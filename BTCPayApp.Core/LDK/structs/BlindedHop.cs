using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Used to construct the blinded hops portion of a blinded path. These hops cannot be identified
 * by outside observers and thus can be used to hide the identity of the recipient.
 */
public class BlindedHop : CommonBase {
	internal BlindedHop(object _dummy, long ptr) : base(ptr) { }
	~BlindedHop() {
		if (ptr != 0) { bindings.BlindedHop_free(ptr); }
	}

	internal long clone_ptr() {
		long ret = bindings.BlindedHop_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the BlindedHop
	 */
	public BlindedHop clone() {
		long ret = bindings.BlindedHop_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.BlindedHop ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.BlindedHop(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the BlindedHop object into a byte array which can be read by BlindedHop_read
	 */
	public byte[] write() {
		byte[] ret = bindings.BlindedHop_write(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Read a BlindedHop from a byte array, created by BlindedHop_write
	 */
	public static Result_BlindedHopDecodeErrorZ read(byte[] ser) {
		long ret = bindings.BlindedHop_read(ser);
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_BlindedHopDecodeErrorZ ret_hu_conv = Result_BlindedHopDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
