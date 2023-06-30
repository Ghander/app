using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A funding_created message to be sent or received from a peer
 */
public class FundingCreated : CommonBase {
	internal FundingCreated(object _dummy, long ptr) : base(ptr) { }
	~FundingCreated() {
		if (ptr != 0) { bindings.FundingCreated_free(ptr); }
	}

	/**
	 * A temporary channel ID, until the funding is established
	 */
	public byte[] get_temporary_channel_id() {
		byte[] ret = bindings.FundingCreated_get_temporary_channel_id(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * A temporary channel ID, until the funding is established
	 */
	public void set_temporary_channel_id(byte[] val) {
		bindings.FundingCreated_set_temporary_channel_id(this.ptr, InternalUtils.check_arr_len(val, 32));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The funding transaction ID
	 */
	public byte[] get_funding_txid() {
		byte[] ret = bindings.FundingCreated_get_funding_txid(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The funding transaction ID
	 */
	public void set_funding_txid(byte[] val) {
		bindings.FundingCreated_set_funding_txid(this.ptr, InternalUtils.check_arr_len(val, 32));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The specific output index funding this channel
	 */
	public short get_funding_output_index() {
		short ret = bindings.FundingCreated_get_funding_output_index(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The specific output index funding this channel
	 */
	public void set_funding_output_index(short val) {
		bindings.FundingCreated_set_funding_output_index(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The signature of the channel initiator (funder) on the initial commitment transaction
	 */
	public byte[] get_signature() {
		byte[] ret = bindings.FundingCreated_get_signature(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The signature of the channel initiator (funder) on the initial commitment transaction
	 */
	public void set_signature(byte[] val) {
		bindings.FundingCreated_set_signature(this.ptr, InternalUtils.check_arr_len(val, 64));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new FundingCreated given each field
	 */
	public static FundingCreated of(byte[] temporary_channel_id_arg, byte[] funding_txid_arg, short funding_output_index_arg, byte[] signature_arg) {
		long ret = bindings.FundingCreated_new(InternalUtils.check_arr_len(temporary_channel_id_arg, 32), InternalUtils.check_arr_len(funding_txid_arg, 32), funding_output_index_arg, InternalUtils.check_arr_len(signature_arg, 64));
		GC.KeepAlive(temporary_channel_id_arg);
		GC.KeepAlive(funding_txid_arg);
		GC.KeepAlive(funding_output_index_arg);
		GC.KeepAlive(signature_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.FundingCreated ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.FundingCreated(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.FundingCreated_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the FundingCreated
	 */
	public FundingCreated clone() {
		long ret = bindings.FundingCreated_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.FundingCreated ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.FundingCreated(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two FundingCreateds contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.FundingCreated b) {
		bool ret = bindings.FundingCreated_eq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is FundingCreated)) return false;
		return this.eq((FundingCreated)o);
	}
	/**
	 * Serialize the FundingCreated object into a byte array which can be read by FundingCreated_read
	 */
	public byte[] write() {
		byte[] ret = bindings.FundingCreated_write(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Read a FundingCreated from a byte array, created by FundingCreated_write
	 */
	public static Result_FundingCreatedDecodeErrorZ read(byte[] ser) {
		long ret = bindings.FundingCreated_read(ser);
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FundingCreatedDecodeErrorZ ret_hu_conv = Result_FundingCreatedDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
