﻿using BTCPayApp.Core.Wallet;
using NBitcoin;
using org.ldk.structs;

namespace BTCPayApp.Core.LDK;

/// <summary>
/// Enables LDK to broadcast transactions through BTCPayServer.
/// </summary>
public class LDKBroadcaster : BroadcasterInterfaceInterface
{
    private readonly Network _network;
    private readonly IEnumerable<IBroadcastGateKeeper> _broadcastGateKeepers;
    private readonly OnChainWalletManager _onChainWalletManager;

    public LDKBroadcaster(
        Network network,
        IEnumerable<IBroadcastGateKeeper> broadcastGateKeepers, OnChainWalletManager onChainWalletManager)
    {
        _network = network;
        _broadcastGateKeepers = broadcastGateKeepers;
        _onChainWalletManager = onChainWalletManager;
    }

    public void broadcast_transactions(byte[][] txs)
    {
        List<Task> tasks = new();
        foreach (var tx in txs)
        {
            var loadedTx = Transaction.Load(tx, _network);
            if(_broadcastGateKeepers.Any(gk => gk.DontBroadcast(loadedTx)))
                continue;
            tasks.Add(Broadcast(loadedTx));
        }
        Task.WhenAll(tasks).GetAwaiter().GetResult();
    }

    public async Task Broadcast(Transaction transaction, CancellationToken cancellationToken = default)
    {
        await _onChainWalletManager.BroadcastTransaction(transaction, cancellationToken);
    }
}

