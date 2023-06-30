using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A simple implementation of [`Sign`] that just keeps the private keys in memory.
 * 
 * This implementation performs no policy checks and is insufficient by itself as
 * a secure external signer.
 */
public class InMemorySigner : CommonBase {
	internal InMemorySigner(object _dummy, long ptr) : base(ptr) { }
	~InMemorySigner() {
		if (ptr != 0) { bindings.InMemorySigner_free(ptr); }
	}

	/**
	 * Holder secret key in the 2-of-2 multisig script of a channel. This key also backs the
	 * holder's anchor output in a commitment transaction, if one is present.
	 */
	public byte[] get_funding_key() {
		byte[] ret = bindings.InMemorySigner_get_funding_key(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Holder secret key in the 2-of-2 multisig script of a channel. This key also backs the
	 * holder's anchor output in a commitment transaction, if one is present.
	 */
	public void set_funding_key(byte[] val) {
		bindings.InMemorySigner_set_funding_key(this.ptr, InternalUtils.check_arr_len(val, 32));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Holder secret key for blinded revocation pubkey.
	 */
	public byte[] get_revocation_base_key() {
		byte[] ret = bindings.InMemorySigner_get_revocation_base_key(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Holder secret key for blinded revocation pubkey.
	 */
	public void set_revocation_base_key(byte[] val) {
		bindings.InMemorySigner_set_revocation_base_key(this.ptr, InternalUtils.check_arr_len(val, 32));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Holder secret key used for our balance in counterparty-broadcasted commitment transactions.
	 */
	public byte[] get_payment_key() {
		byte[] ret = bindings.InMemorySigner_get_payment_key(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Holder secret key used for our balance in counterparty-broadcasted commitment transactions.
	 */
	public void set_payment_key(byte[] val) {
		bindings.InMemorySigner_set_payment_key(this.ptr, InternalUtils.check_arr_len(val, 32));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Holder secret key used in an HTLC transaction.
	 */
	public byte[] get_delayed_payment_base_key() {
		byte[] ret = bindings.InMemorySigner_get_delayed_payment_base_key(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Holder secret key used in an HTLC transaction.
	 */
	public void set_delayed_payment_base_key(byte[] val) {
		bindings.InMemorySigner_set_delayed_payment_base_key(this.ptr, InternalUtils.check_arr_len(val, 32));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Holder HTLC secret key used in commitment transaction HTLC outputs.
	 */
	public byte[] get_htlc_base_key() {
		byte[] ret = bindings.InMemorySigner_get_htlc_base_key(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Holder HTLC secret key used in commitment transaction HTLC outputs.
	 */
	public void set_htlc_base_key(byte[] val) {
		bindings.InMemorySigner_set_htlc_base_key(this.ptr, InternalUtils.check_arr_len(val, 32));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Commitment seed.
	 */
	public byte[] get_commitment_seed() {
		byte[] ret = bindings.InMemorySigner_get_commitment_seed(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Commitment seed.
	 */
	public void set_commitment_seed(byte[] val) {
		bindings.InMemorySigner_set_commitment_seed(this.ptr, InternalUtils.check_arr_len(val, 32));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	internal long clone_ptr() {
		long ret = bindings.InMemorySigner_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the InMemorySigner
	 */
	public InMemorySigner clone() {
		long ret = bindings.InMemorySigner_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InMemorySigner ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.InMemorySigner(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new [`InMemorySigner`].
	 */
	public static InMemorySigner of(byte[] node_secret, byte[] funding_key, byte[] revocation_base_key, byte[] payment_key, byte[] delayed_payment_base_key, byte[] htlc_base_key, byte[] commitment_seed, long channel_value_satoshis, byte[] channel_keys_id) {
		long ret = bindings.InMemorySigner_new(InternalUtils.check_arr_len(node_secret, 32), InternalUtils.check_arr_len(funding_key, 32), InternalUtils.check_arr_len(revocation_base_key, 32), InternalUtils.check_arr_len(payment_key, 32), InternalUtils.check_arr_len(delayed_payment_base_key, 32), InternalUtils.check_arr_len(htlc_base_key, 32), InternalUtils.check_arr_len(commitment_seed, 32), channel_value_satoshis, InternalUtils.check_arr_len(channel_keys_id, 32));
		GC.KeepAlive(node_secret);
		GC.KeepAlive(funding_key);
		GC.KeepAlive(revocation_base_key);
		GC.KeepAlive(payment_key);
		GC.KeepAlive(delayed_payment_base_key);
		GC.KeepAlive(htlc_base_key);
		GC.KeepAlive(commitment_seed);
		GC.KeepAlive(channel_value_satoshis);
		GC.KeepAlive(channel_keys_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InMemorySigner ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.InMemorySigner(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Returns the counterparty's pubkeys.
	 * 
	 * Will panic if [`BaseSign::provide_channel_parameters`] has not been called before.
	 */
	public ChannelPublicKeys counterparty_pubkeys() {
		long ret = bindings.InMemorySigner_counterparty_pubkeys(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelPublicKeys ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelPublicKeys(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Returns the `contest_delay` value specified by our counterparty and applied on holder-broadcastable
	 * transactions, i.e., the amount of time that we have to wait to recover our funds if we
	 * broadcast a transaction.
	 * 
	 * Will panic if [`BaseSign::provide_channel_parameters`] has not been called before.
	 */
	public short counterparty_selected_contest_delay() {
		short ret = bindings.InMemorySigner_counterparty_selected_contest_delay(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Returns the `contest_delay` value specified by us and applied on transactions broadcastable
	 * by our counterparty, i.e., the amount of time that they have to wait to recover their funds
	 * if they broadcast a transaction.
	 * 
	 * Will panic if [`BaseSign::provide_channel_parameters`] has not been called before.
	 */
	public short holder_selected_contest_delay() {
		short ret = bindings.InMemorySigner_holder_selected_contest_delay(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Returns whether the holder is the initiator.
	 * 
	 * Will panic if [`BaseSign::provide_channel_parameters`] has not been called before.
	 */
	public bool is_outbound() {
		bool ret = bindings.InMemorySigner_is_outbound(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Funding outpoint
	 * 
	 * Will panic if [`BaseSign::provide_channel_parameters`] has not been called before.
	 */
	public OutPoint funding_outpoint() {
		long ret = bindings.InMemorySigner_funding_outpoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.OutPoint ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.OutPoint(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Returns a [`ChannelTransactionParameters`] for this channel, to be used when verifying or
	 * building transactions.
	 * 
	 * Will panic if [`BaseSign::provide_channel_parameters`] has not been called before.
	 */
	public ChannelTransactionParameters get_channel_parameters() {
		long ret = bindings.InMemorySigner_get_channel_parameters(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelTransactionParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelTransactionParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Returns whether anchors should be used.
	 * 
	 * Will panic if [`BaseSign::provide_channel_parameters`] has not been called before.
	 */
	public bool opt_anchors() {
		bool ret = bindings.InMemorySigner_opt_anchors(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Sign the single input of `spend_tx` at index `input_idx`, which spends the output described
	 * by `descriptor`, returning the witness stack for the input.
	 * 
	 * Returns an error if the input at `input_idx` does not exist, has a non-empty `script_sig`,
	 * is not spending the outpoint described by [`descriptor.outpoint`],
	 * or if an output descriptor `script_pubkey` does not match the one we can spend.
	 * 
	 * [`descriptor.outpoint`]: StaticPaymentOutputDescriptor::outpoint
	 */
	public Result_CVec_CVec_u8ZZNoneZ sign_counterparty_payment_input(byte[] spend_tx, long input_idx, org.ldk.structs.StaticPaymentOutputDescriptor descriptor) {
		long ret = bindings.InMemorySigner_sign_counterparty_payment_input(this.ptr, spend_tx, input_idx, descriptor == null ? 0 : descriptor.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(spend_tx);
		GC.KeepAlive(input_idx);
		GC.KeepAlive(descriptor);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_CVec_u8ZZNoneZ ret_hu_conv = Result_CVec_CVec_u8ZZNoneZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(descriptor); };
		return ret_hu_conv;
	}

	/**
	 * Sign the single input of `spend_tx` at index `input_idx` which spends the output
	 * described by `descriptor`, returning the witness stack for the input.
	 * 
	 * Returns an error if the input at `input_idx` does not exist, has a non-empty `script_sig`,
	 * is not spending the outpoint described by [`descriptor.outpoint`], does not have a
	 * sequence set to [`descriptor.to_self_delay`], or if an output descriptor
	 * `script_pubkey` does not match the one we can spend.
	 * 
	 * [`descriptor.outpoint`]: DelayedPaymentOutputDescriptor::outpoint
	 * [`descriptor.to_self_delay`]: DelayedPaymentOutputDescriptor::to_self_delay
	 */
	public Result_CVec_CVec_u8ZZNoneZ sign_dynamic_p2wsh_input(byte[] spend_tx, long input_idx, org.ldk.structs.DelayedPaymentOutputDescriptor descriptor) {
		long ret = bindings.InMemorySigner_sign_dynamic_p2wsh_input(this.ptr, spend_tx, input_idx, descriptor == null ? 0 : descriptor.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(spend_tx);
		GC.KeepAlive(input_idx);
		GC.KeepAlive(descriptor);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_CVec_u8ZZNoneZ ret_hu_conv = Result_CVec_CVec_u8ZZNoneZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(descriptor); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new BaseSign which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned BaseSign must be freed before this_arg is
	 */
	public BaseSign as_BaseSign() {
		long ret = bindings.InMemorySigner_as_BaseSign(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		BaseSign ret_hu_conv = new BaseSign(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new Sign which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned Sign must be freed before this_arg is
	 */
	public Sign as_Sign() {
		long ret = bindings.InMemorySigner_as_Sign(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Sign ret_hu_conv = new Sign(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the InMemorySigner object into a byte array which can be read by InMemorySigner_read
	 */
	public byte[] write() {
		byte[] ret = bindings.InMemorySigner_write(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Read a InMemorySigner from a byte array, created by InMemorySigner_write
	 */
	public static Result_InMemorySignerDecodeErrorZ read(byte[] ser, byte[] arg) {
		long ret = bindings.InMemorySigner_read(ser, InternalUtils.check_arr_len(arg, 32));
		GC.KeepAlive(ser);
		GC.KeepAlive(arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InMemorySignerDecodeErrorZ ret_hu_conv = Result_InMemorySignerDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
