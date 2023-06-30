using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A funding_signed message to be sent or received from a peer
 */
public class FundingSigned : CommonBase {
	internal FundingSigned(object _dummy, long ptr) : base(ptr) { }
	~FundingSigned() {
		if (ptr != 0) { bindings.FundingSigned_free(ptr); }
	}

	/**
	 * The channel ID
	 */
	public byte[] get_channel_id() {
		byte[] ret = bindings.FundingSigned_get_channel_id(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The channel ID
	 */
	public void set_channel_id(byte[] val) {
		bindings.FundingSigned_set_channel_id(this.ptr, InternalUtils.check_arr_len(val, 32));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The signature of the channel acceptor (fundee) on the initial commitment transaction
	 */
	public byte[] get_signature() {
		byte[] ret = bindings.FundingSigned_get_signature(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The signature of the channel acceptor (fundee) on the initial commitment transaction
	 */
	public void set_signature(byte[] val) {
		bindings.FundingSigned_set_signature(this.ptr, InternalUtils.check_arr_len(val, 64));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new FundingSigned given each field
	 */
	public static FundingSigned of(byte[] channel_id_arg, byte[] signature_arg) {
		long ret = bindings.FundingSigned_new(InternalUtils.check_arr_len(channel_id_arg, 32), InternalUtils.check_arr_len(signature_arg, 64));
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(signature_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.FundingSigned ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.FundingSigned(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.FundingSigned_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the FundingSigned
	 */
	public FundingSigned clone() {
		long ret = bindings.FundingSigned_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.FundingSigned ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.FundingSigned(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two FundingSigneds contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.FundingSigned b) {
		bool ret = bindings.FundingSigned_eq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is FundingSigned)) return false;
		return this.eq((FundingSigned)o);
	}
	/**
	 * Serialize the FundingSigned object into a byte array which can be read by FundingSigned_read
	 */
	public byte[] write() {
		byte[] ret = bindings.FundingSigned_write(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Read a FundingSigned from a byte array, created by FundingSigned_write
	 */
	public static Result_FundingSignedDecodeErrorZ read(byte[] ser) {
		long ret = bindings.FundingSigned_read(ser);
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FundingSignedDecodeErrorZ ret_hu_conv = Result_FundingSignedDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
