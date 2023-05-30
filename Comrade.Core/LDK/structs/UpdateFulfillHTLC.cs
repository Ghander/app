using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An update_fulfill_htlc message to be sent or received from a peer
 */
public class UpdateFulfillHTLC : CommonBase {
	internal UpdateFulfillHTLC(object _dummy, long ptr) : base(ptr) { }
	~UpdateFulfillHTLC() {
		if (ptr != 0) { bindings.UpdateFulfillHTLC_free(ptr); }
	}

	/**
	 * The channel ID
	 */
	public byte[] get_channel_id() {
		byte[] ret = bindings.UpdateFulfillHTLC_get_channel_id(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The channel ID
	 */
	public void set_channel_id(byte[] val) {
		bindings.UpdateFulfillHTLC_set_channel_id(this.ptr, InternalUtils.check_arr_len(val, 32));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The HTLC ID
	 */
	public long get_htlc_id() {
		long ret = bindings.UpdateFulfillHTLC_get_htlc_id(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The HTLC ID
	 */
	public void set_htlc_id(long val) {
		bindings.UpdateFulfillHTLC_set_htlc_id(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The pre-image of the payment hash, allowing HTLC redemption
	 */
	public byte[] get_payment_preimage() {
		byte[] ret = bindings.UpdateFulfillHTLC_get_payment_preimage(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The pre-image of the payment hash, allowing HTLC redemption
	 */
	public void set_payment_preimage(byte[] val) {
		bindings.UpdateFulfillHTLC_set_payment_preimage(this.ptr, InternalUtils.check_arr_len(val, 32));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new UpdateFulfillHTLC given each field
	 */
	public static UpdateFulfillHTLC of(byte[] channel_id_arg, long htlc_id_arg, byte[] payment_preimage_arg) {
		long ret = bindings.UpdateFulfillHTLC_new(InternalUtils.check_arr_len(channel_id_arg, 32), htlc_id_arg, InternalUtils.check_arr_len(payment_preimage_arg, 32));
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(htlc_id_arg);
		GC.KeepAlive(payment_preimage_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UpdateFulfillHTLC ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UpdateFulfillHTLC(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.UpdateFulfillHTLC_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the UpdateFulfillHTLC
	 */
	public UpdateFulfillHTLC clone() {
		long ret = bindings.UpdateFulfillHTLC_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.UpdateFulfillHTLC ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.UpdateFulfillHTLC(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two UpdateFulfillHTLCs contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.UpdateFulfillHTLC b) {
		bool ret = bindings.UpdateFulfillHTLC_eq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is UpdateFulfillHTLC)) return false;
		return this.eq((UpdateFulfillHTLC)o);
	}
	/**
	 * Serialize the UpdateFulfillHTLC object into a byte array which can be read by UpdateFulfillHTLC_read
	 */
	public byte[] write() {
		byte[] ret = bindings.UpdateFulfillHTLC_write(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Read a UpdateFulfillHTLC from a byte array, created by UpdateFulfillHTLC_write
	 */
	public static Result_UpdateFulfillHTLCDecodeErrorZ read(byte[] ser) {
		long ret = bindings.UpdateFulfillHTLC_read(ser);
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_UpdateFulfillHTLCDecodeErrorZ ret_hu_conv = Result_UpdateFulfillHTLCDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
