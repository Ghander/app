using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A ChannelMonitor handles chain events (blocks connected and disconnected) and generates
 * on-chain transactions to ensure no loss of funds occurs.
 * 
 * You MUST ensure that no ChannelMonitors for a given channel anywhere contain out-of-date
 * information and are actively monitoring the chain.
 * 
 * Pending Events or updated HTLCs which have not yet been read out by
 * get_and_clear_pending_monitor_events or get_and_clear_pending_events are serialized to disk and
 * reloaded at deserialize-time. Thus, you must ensure that, when handling events, all events
 * gotten are fully handled before re-serializing the new state.
 * 
 * Note that the deserializer is only implemented for (BlockHash, ChannelMonitor), which
 * tells you the last block hash which was block_connect()ed. You MUST rescan any blocks along
 * the \"reorg path\" (ie disconnecting blocks until you find a common ancestor from both the
 * returned block hash and the the current chain and then reconnecting blocks to get to the
 * best chain) upon deserializing the object!
 */
public class ChannelMonitor : CommonBase {
	internal ChannelMonitor(object _dummy, long ptr) : base(ptr) { }
	~ChannelMonitor() {
		if (ptr != 0) { bindings.ChannelMonitor_free(ptr); }
	}

	internal long clone_ptr() {
		long ret = bindings.ChannelMonitor_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChannelMonitor
	 */
	public ChannelMonitor clone() {
		long ret = bindings.ChannelMonitor_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelMonitor ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelMonitor(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the ChannelMonitor object into a byte array which can be read by ChannelMonitor_read
	 */
	public byte[] write() {
		byte[] ret = bindings.ChannelMonitor_write(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Updates a ChannelMonitor on the basis of some new information provided by the Channel
	 * itself.
	 * 
	 * panics if the given update is not the next update by update_id.
	 */
	public Result_NoneNoneZ update_monitor(org.ldk.structs.ChannelMonitorUpdate updates, org.ldk.structs.BroadcasterInterface broadcaster, org.ldk.structs.FeeEstimator fee_estimator, org.ldk.structs.Logger logger) {
		long ret = bindings.ChannelMonitor_update_monitor(this.ptr, updates == null ? 0 : updates.ptr, broadcaster == null ? 0 : broadcaster.ptr, fee_estimator == null ? 0 : fee_estimator.ptr, logger == null ? 0 : logger.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(updates);
		GC.KeepAlive(broadcaster);
		GC.KeepAlive(fee_estimator);
		GC.KeepAlive(logger);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneNoneZ ret_hu_conv = Result_NoneNoneZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(updates); };
		if (this != null) { this.ptrs_to.AddLast(broadcaster); };
		if (this != null) { this.ptrs_to.AddLast(fee_estimator); };
		if (this != null) { this.ptrs_to.AddLast(logger); };
		return ret_hu_conv;
	}

	/**
	 * Gets the update_id from the latest ChannelMonitorUpdate which was applied to this
	 * ChannelMonitor.
	 */
	public long get_latest_update_id() {
		long ret = bindings.ChannelMonitor_get_latest_update_id(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Gets the funding transaction outpoint of the channel this ChannelMonitor is monitoring for.
	 */
	public TwoTuple_OutPointScriptZ get_funding_txo() {
		long ret = bindings.ChannelMonitor_get_funding_txo(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		TwoTuple_OutPointScriptZ ret_hu_conv = new TwoTuple_OutPointScriptZ(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Gets a list of txids, with their output scripts (in the order they appear in the
	 * transaction), which we must learn about spends of via block_connected().
	 */
	public TwoTuple_TxidCVec_C2Tuple_u32ScriptZZZ[] get_outputs_to_watch() {
		long[] ret = bindings.ChannelMonitor_get_outputs_to_watch(this.ptr);
		GC.KeepAlive(this);
		int ret_conv_40_len = ret.Length;
		TwoTuple_TxidCVec_C2Tuple_u32ScriptZZZ[] ret_conv_40_arr = new TwoTuple_TxidCVec_C2Tuple_u32ScriptZZZ[ret_conv_40_len];
		for (int o = 0; o < ret_conv_40_len; o++) {
			long ret_conv_40 = ret[o];
			TwoTuple_TxidCVec_C2Tuple_u32ScriptZZZ ret_conv_40_hu_conv = new TwoTuple_TxidCVec_C2Tuple_u32ScriptZZZ(null, ret_conv_40);
			if (ret_conv_40_hu_conv != null) { ret_conv_40_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_40_arr[o] = ret_conv_40_hu_conv;
		}
		return ret_conv_40_arr;
	}

	/**
	 * Loads the funding txo and outputs to watch into the given `chain::Filter` by repeatedly
	 * calling `chain::Filter::register_output` and `chain::Filter::register_tx` until all outputs
	 * have been registered.
	 */
	public void load_outputs_to_watch(org.ldk.structs.Filter filter) {
		bindings.ChannelMonitor_load_outputs_to_watch(this.ptr, filter == null ? 0 : filter.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(filter);
		if (this != null) { this.ptrs_to.AddLast(filter); };
	}

	/**
	 * Get the list of HTLCs who's status has been updated on chain. This should be called by
	 * ChannelManager via [`chain::Watch::release_pending_monitor_events`].
	 */
	public MonitorEvent[] get_and_clear_pending_monitor_events() {
		long[] ret = bindings.ChannelMonitor_get_and_clear_pending_monitor_events(this.ptr);
		GC.KeepAlive(this);
		int ret_conv_14_len = ret.Length;
		MonitorEvent[] ret_conv_14_arr = new MonitorEvent[ret_conv_14_len];
		for (int o = 0; o < ret_conv_14_len; o++) {
			long ret_conv_14 = ret[o];
			org.ldk.structs.MonitorEvent ret_conv_14_hu_conv = org.ldk.structs.MonitorEvent.constr_from_ptr(ret_conv_14);
			if (ret_conv_14_hu_conv != null) { ret_conv_14_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_14_arr[o] = ret_conv_14_hu_conv;
		}
		return ret_conv_14_arr;
	}

	/**
	 * Gets the list of pending events which were generated by previous actions, clearing the list
	 * in the process.
	 * 
	 * This is called by the [`EventsProvider::process_pending_events`] implementation for
	 * [`ChainMonitor`].
	 * 
	 * [`EventsProvider::process_pending_events`]: crate::util::events::EventsProvider::process_pending_events
	 * [`ChainMonitor`]: crate::chain::chainmonitor::ChainMonitor
	 */
	public Event[] get_and_clear_pending_events() {
		long[] ret = bindings.ChannelMonitor_get_and_clear_pending_events(this.ptr);
		GC.KeepAlive(this);
		int ret_conv_7_len = ret.Length;
		Event[] ret_conv_7_arr = new Event[ret_conv_7_len];
		for (int h = 0; h < ret_conv_7_len; h++) {
			long ret_conv_7 = ret[h];
			org.ldk.structs.Event ret_conv_7_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret_conv_7);
			if (ret_conv_7_hu_conv != null) { ret_conv_7_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_7_arr[h] = ret_conv_7_hu_conv;
		}
		return ret_conv_7_arr;
	}

	/**
	 * Gets the `node_id` of the counterparty for this channel.
	 * 
	 * Will be `None` for channels constructed on LDK versions prior to 0.0.110 and always `Some`
	 * otherwise.
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public byte[] get_counterparty_node_id() {
		byte[] ret = bindings.ChannelMonitor_get_counterparty_node_id(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Used by ChannelManager deserialization to broadcast the latest holder state if its copy of
	 * the Channel was out-of-date.
	 * 
	 * You may also use this to broadcast the latest local commitment transaction, either because
	 * a monitor update failed with [`ChannelMonitorUpdateStatus::PermanentFailure`] or because we've
	 * fallen behind (i.e. we've received proof that our counterparty side knows a revocation
	 * secret we gave them that they shouldn't know).
	 * 
	 * Broadcasting these transactions in the second case is UNSAFE, as they allow counterparty
	 * side to punish you. Nevertheless you may want to broadcast them if counterparty doesn't
	 * close channel with their commitment transaction after a substantial amount of time. Best
	 * may be to contact the other node operator out-of-band to coordinate other options available
	 * to you. In any-case, the choice is up to you.
	 * 
	 * [`ChannelMonitorUpdateStatus::PermanentFailure`]: super::ChannelMonitorUpdateStatus::PermanentFailure
	 */
	public byte[][] get_latest_holder_commitment_txn(org.ldk.structs.Logger logger) {
		byte[][] ret = bindings.ChannelMonitor_get_latest_holder_commitment_txn(this.ptr, logger == null ? 0 : logger.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(logger);
		if (this != null) { this.ptrs_to.AddLast(logger); };
		return ret;
	}

	/**
	 * Processes transactions in a newly connected block, which may result in any of the following:
	 * - update the monitor's state against resolved HTLCs
	 * - punish the counterparty in the case of seeing a revoked commitment transaction
	 * - force close the channel and claim/timeout incoming/outgoing HTLCs if near expiration
	 * - detect settled outputs for later spending
	 * - schedule and bump any in-flight claims
	 * 
	 * Returns any new outputs to watch from `txdata`; after called, these are also included in
	 * [`get_outputs_to_watch`].
	 * 
	 * [`get_outputs_to_watch`]: #method.get_outputs_to_watch
	 */
	public TwoTuple_TxidCVec_C2Tuple_u32TxOutZZZ[] block_connected(byte[] header, TwoTuple_usizeTransactionZ[] txdata, int height, org.ldk.structs.BroadcasterInterface broadcaster, org.ldk.structs.FeeEstimator fee_estimator, org.ldk.structs.Logger logger) {
		long[] ret = bindings.ChannelMonitor_block_connected(this.ptr, InternalUtils.check_arr_len(header, 80), txdata != null ? InternalUtils.mapArray(txdata, txdata_conv_28 => txdata_conv_28 != null ? txdata_conv_28.ptr : 0) : null, height, broadcaster == null ? 0 : broadcaster.ptr, fee_estimator == null ? 0 : fee_estimator.ptr, logger == null ? 0 : logger.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(header);
		GC.KeepAlive(txdata);
		GC.KeepAlive(height);
		GC.KeepAlive(broadcaster);
		GC.KeepAlive(fee_estimator);
		GC.KeepAlive(logger);
		int ret_conv_39_len = ret.Length;
		TwoTuple_TxidCVec_C2Tuple_u32TxOutZZZ[] ret_conv_39_arr = new TwoTuple_TxidCVec_C2Tuple_u32TxOutZZZ[ret_conv_39_len];
		for (int n = 0; n < ret_conv_39_len; n++) {
			long ret_conv_39 = ret[n];
			TwoTuple_TxidCVec_C2Tuple_u32TxOutZZZ ret_conv_39_hu_conv = new TwoTuple_TxidCVec_C2Tuple_u32TxOutZZZ(null, ret_conv_39);
			if (ret_conv_39_hu_conv != null) { ret_conv_39_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_39_arr[n] = ret_conv_39_hu_conv;
		}
		if (this != null) { this.ptrs_to.AddLast(broadcaster); };
		if (this != null) { this.ptrs_to.AddLast(fee_estimator); };
		if (this != null) { this.ptrs_to.AddLast(logger); };
		return ret_conv_39_arr;
	}

	/**
	 * Determines if the disconnected block contained any transactions of interest and updates
	 * appropriately.
	 */
	public void block_disconnected(byte[] header, int height, org.ldk.structs.BroadcasterInterface broadcaster, org.ldk.structs.FeeEstimator fee_estimator, org.ldk.structs.Logger logger) {
		bindings.ChannelMonitor_block_disconnected(this.ptr, InternalUtils.check_arr_len(header, 80), height, broadcaster == null ? 0 : broadcaster.ptr, fee_estimator == null ? 0 : fee_estimator.ptr, logger == null ? 0 : logger.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(header);
		GC.KeepAlive(height);
		GC.KeepAlive(broadcaster);
		GC.KeepAlive(fee_estimator);
		GC.KeepAlive(logger);
		if (this != null) { this.ptrs_to.AddLast(broadcaster); };
		if (this != null) { this.ptrs_to.AddLast(fee_estimator); };
		if (this != null) { this.ptrs_to.AddLast(logger); };
	}

	/**
	 * Processes transactions confirmed in a block with the given header and height, returning new
	 * outputs to watch. See [`block_connected`] for details.
	 * 
	 * Used instead of [`block_connected`] by clients that are notified of transactions rather than
	 * blocks. See [`chain::Confirm`] for calling expectations.
	 * 
	 * [`block_connected`]: Self::block_connected
	 */
	public TwoTuple_TxidCVec_C2Tuple_u32TxOutZZZ[] transactions_confirmed(byte[] header, TwoTuple_usizeTransactionZ[] txdata, int height, org.ldk.structs.BroadcasterInterface broadcaster, org.ldk.structs.FeeEstimator fee_estimator, org.ldk.structs.Logger logger) {
		long[] ret = bindings.ChannelMonitor_transactions_confirmed(this.ptr, InternalUtils.check_arr_len(header, 80), txdata != null ? InternalUtils.mapArray(txdata, txdata_conv_28 => txdata_conv_28 != null ? txdata_conv_28.ptr : 0) : null, height, broadcaster == null ? 0 : broadcaster.ptr, fee_estimator == null ? 0 : fee_estimator.ptr, logger == null ? 0 : logger.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(header);
		GC.KeepAlive(txdata);
		GC.KeepAlive(height);
		GC.KeepAlive(broadcaster);
		GC.KeepAlive(fee_estimator);
		GC.KeepAlive(logger);
		int ret_conv_39_len = ret.Length;
		TwoTuple_TxidCVec_C2Tuple_u32TxOutZZZ[] ret_conv_39_arr = new TwoTuple_TxidCVec_C2Tuple_u32TxOutZZZ[ret_conv_39_len];
		for (int n = 0; n < ret_conv_39_len; n++) {
			long ret_conv_39 = ret[n];
			TwoTuple_TxidCVec_C2Tuple_u32TxOutZZZ ret_conv_39_hu_conv = new TwoTuple_TxidCVec_C2Tuple_u32TxOutZZZ(null, ret_conv_39);
			if (ret_conv_39_hu_conv != null) { ret_conv_39_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_39_arr[n] = ret_conv_39_hu_conv;
		}
		if (this != null) { this.ptrs_to.AddLast(broadcaster); };
		if (this != null) { this.ptrs_to.AddLast(fee_estimator); };
		if (this != null) { this.ptrs_to.AddLast(logger); };
		return ret_conv_39_arr;
	}

	/**
	 * Processes a transaction that was reorganized out of the chain.
	 * 
	 * Used instead of [`block_disconnected`] by clients that are notified of transactions rather
	 * than blocks. See [`chain::Confirm`] for calling expectations.
	 * 
	 * [`block_disconnected`]: Self::block_disconnected
	 */
	public void transaction_unconfirmed(byte[] txid, org.ldk.structs.BroadcasterInterface broadcaster, org.ldk.structs.FeeEstimator fee_estimator, org.ldk.structs.Logger logger) {
		bindings.ChannelMonitor_transaction_unconfirmed(this.ptr, InternalUtils.check_arr_len(txid, 32), broadcaster == null ? 0 : broadcaster.ptr, fee_estimator == null ? 0 : fee_estimator.ptr, logger == null ? 0 : logger.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(txid);
		GC.KeepAlive(broadcaster);
		GC.KeepAlive(fee_estimator);
		GC.KeepAlive(logger);
		if (this != null) { this.ptrs_to.AddLast(broadcaster); };
		if (this != null) { this.ptrs_to.AddLast(fee_estimator); };
		if (this != null) { this.ptrs_to.AddLast(logger); };
	}

	/**
	 * Updates the monitor with the current best chain tip, returning new outputs to watch. See
	 * [`block_connected`] for details.
	 * 
	 * Used instead of [`block_connected`] by clients that are notified of transactions rather than
	 * blocks. See [`chain::Confirm`] for calling expectations.
	 * 
	 * [`block_connected`]: Self::block_connected
	 */
	public TwoTuple_TxidCVec_C2Tuple_u32TxOutZZZ[] best_block_updated(byte[] header, int height, org.ldk.structs.BroadcasterInterface broadcaster, org.ldk.structs.FeeEstimator fee_estimator, org.ldk.structs.Logger logger) {
		long[] ret = bindings.ChannelMonitor_best_block_updated(this.ptr, InternalUtils.check_arr_len(header, 80), height, broadcaster == null ? 0 : broadcaster.ptr, fee_estimator == null ? 0 : fee_estimator.ptr, logger == null ? 0 : logger.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(header);
		GC.KeepAlive(height);
		GC.KeepAlive(broadcaster);
		GC.KeepAlive(fee_estimator);
		GC.KeepAlive(logger);
		int ret_conv_39_len = ret.Length;
		TwoTuple_TxidCVec_C2Tuple_u32TxOutZZZ[] ret_conv_39_arr = new TwoTuple_TxidCVec_C2Tuple_u32TxOutZZZ[ret_conv_39_len];
		for (int n = 0; n < ret_conv_39_len; n++) {
			long ret_conv_39 = ret[n];
			TwoTuple_TxidCVec_C2Tuple_u32TxOutZZZ ret_conv_39_hu_conv = new TwoTuple_TxidCVec_C2Tuple_u32TxOutZZZ(null, ret_conv_39);
			if (ret_conv_39_hu_conv != null) { ret_conv_39_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_39_arr[n] = ret_conv_39_hu_conv;
		}
		if (this != null) { this.ptrs_to.AddLast(broadcaster); };
		if (this != null) { this.ptrs_to.AddLast(fee_estimator); };
		if (this != null) { this.ptrs_to.AddLast(logger); };
		return ret_conv_39_arr;
	}

	/**
	 * Returns the set of txids that should be monitored for re-organization out of the chain.
	 */
	public TwoTuple_TxidBlockHashZ[] get_relevant_txids() {
		long[] ret = bindings.ChannelMonitor_get_relevant_txids(this.ptr);
		GC.KeepAlive(this);
		int ret_conv_25_len = ret.Length;
		TwoTuple_TxidBlockHashZ[] ret_conv_25_arr = new TwoTuple_TxidBlockHashZ[ret_conv_25_len];
		for (int z = 0; z < ret_conv_25_len; z++) {
			long ret_conv_25 = ret[z];
			TwoTuple_TxidBlockHashZ ret_conv_25_hu_conv = new TwoTuple_TxidBlockHashZ(null, ret_conv_25);
			if (ret_conv_25_hu_conv != null) { ret_conv_25_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_25_arr[z] = ret_conv_25_hu_conv;
		}
		return ret_conv_25_arr;
	}

	/**
	 * Gets the latest best block which was connected either via the [`chain::Listen`] or
	 * [`chain::Confirm`] interfaces.
	 */
	public BestBlock current_best_block() {
		long ret = bindings.ChannelMonitor_current_best_block(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BestBlock ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.BestBlock(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Gets the balances in this channel which are either claimable by us if we were to
	 * force-close the channel now or which are claimable on-chain (possibly awaiting
	 * confirmation).
	 * 
	 * Any balances in the channel which are available on-chain (excluding on-chain fees) are
	 * included here until an [`Event::SpendableOutputs`] event has been generated for the
	 * balance, or until our counterparty has claimed the balance and accrued several
	 * confirmations on the claim transaction.
	 * 
	 * Note that for `ChannelMonitors` which track a channel which went on-chain with versions of
	 * LDK prior to 0.0.111, balances may not be fully captured if our counterparty broadcasted
	 * a revoked state.
	 * 
	 * See [`Balance`] for additional details on the types of claimable balances which
	 * may be returned here and their meanings.
	 */
	public Balance[] get_claimable_balances() {
		long[] ret = bindings.ChannelMonitor_get_claimable_balances(this.ptr);
		GC.KeepAlive(this);
		int ret_conv_9_len = ret.Length;
		Balance[] ret_conv_9_arr = new Balance[ret_conv_9_len];
		for (int j = 0; j < ret_conv_9_len; j++) {
			long ret_conv_9 = ret[j];
			org.ldk.structs.Balance ret_conv_9_hu_conv = org.ldk.structs.Balance.constr_from_ptr(ret_conv_9);
			if (ret_conv_9_hu_conv != null) { ret_conv_9_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_9_arr[j] = ret_conv_9_hu_conv;
		}
		return ret_conv_9_arr;
	}

}
} } }
