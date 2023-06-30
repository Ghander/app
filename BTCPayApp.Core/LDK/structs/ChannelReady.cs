using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * A channel_ready message to be sent or received from a peer
 */
public class ChannelReady : CommonBase {
	internal ChannelReady(object _dummy, long ptr) : base(ptr) { }
	~ChannelReady() {
		if (ptr != 0) { bindings.ChannelReady_free(ptr); }
	}

	/**
	 * The channel ID
	 */
	public byte[] get_channel_id() {
		byte[] ret = bindings.ChannelReady_get_channel_id(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The channel ID
	 */
	public void set_channel_id(byte[] val) {
		bindings.ChannelReady_set_channel_id(this.ptr, InternalUtils.check_arr_len(val, 32));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The per-commitment point of the second commitment transaction
	 */
	public byte[] get_next_per_commitment_point() {
		byte[] ret = bindings.ChannelReady_get_next_per_commitment_point(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The per-commitment point of the second commitment transaction
	 */
	public void set_next_per_commitment_point(byte[] val) {
		bindings.ChannelReady_set_next_per_commitment_point(this.ptr, InternalUtils.check_arr_len(val, 33));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * If set, provides a short_channel_id alias for this channel. The sender will accept payments
	 * to be forwarded over this SCID and forward them to this messages' recipient.
	 */
	public Option_u64Z get_short_channel_id_alias() {
		long ret = bindings.ChannelReady_get_short_channel_id_alias(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * If set, provides a short_channel_id alias for this channel. The sender will accept payments
	 * to be forwarded over this SCID and forward them to this messages' recipient.
	 */
	public void set_short_channel_id_alias(org.ldk.structs.Option_u64Z val) {
		bindings.ChannelReady_set_short_channel_id_alias(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new ChannelReady given each field
	 */
	public static ChannelReady of(byte[] channel_id_arg, byte[] next_per_commitment_point_arg, org.ldk.structs.Option_u64Z short_channel_id_alias_arg) {
		long ret = bindings.ChannelReady_new(InternalUtils.check_arr_len(channel_id_arg, 32), InternalUtils.check_arr_len(next_per_commitment_point_arg, 33), short_channel_id_alias_arg.ptr);
		GC.KeepAlive(channel_id_arg);
		GC.KeepAlive(next_per_commitment_point_arg);
		GC.KeepAlive(short_channel_id_alias_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelReady ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelReady(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.ChannelReady_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChannelReady
	 */
	public ChannelReady clone() {
		long ret = bindings.ChannelReady_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelReady ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelReady(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two ChannelReadys contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.ChannelReady b) {
		bool ret = bindings.ChannelReady_eq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is ChannelReady)) return false;
		return this.eq((ChannelReady)o);
	}
	/**
	 * Serialize the ChannelReady object into a byte array which can be read by ChannelReady_read
	 */
	public byte[] write() {
		byte[] ret = bindings.ChannelReady_write(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Read a ChannelReady from a byte array, created by ChannelReady_write
	 */
	public static Result_ChannelReadyDecodeErrorZ read(byte[] ser) {
		long ret = bindings.ChannelReady_read(ser);
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelReadyDecodeErrorZ ret_hu_conv = Result_ChannelReadyDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
