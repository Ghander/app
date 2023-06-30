using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Features used within the channel_type field in an OpenChannel message.
 * 
 * A channel is always of some known \"type\", describing the transaction formats used and the exact
 * semantics of our interaction with our peer.
 * 
 * Note that because a channel is a specific type which is proposed by the opener and accepted by
 * the counterparty, only required features are allowed here.
 * 
 * This is serialized differently from other feature types - it is not prefixed by a length, and
 * thus must only appear inside a TLV where its length is known in advance.
 */
public class ChannelTypeFeatures : CommonBase {
	internal ChannelTypeFeatures(object _dummy, long ptr) : base(ptr) { }
	~ChannelTypeFeatures() {
		if (ptr != 0) { bindings.ChannelTypeFeatures_free(ptr); }
	}

	/**
	 * Checks if two ChannelTypeFeaturess contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.ChannelTypeFeatures b) {
		bool ret = bindings.ChannelTypeFeatures_eq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is ChannelTypeFeatures)) return false;
		return this.eq((ChannelTypeFeatures)o);
	}
	internal long clone_ptr() {
		long ret = bindings.ChannelTypeFeatures_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChannelTypeFeatures
	 */
	public ChannelTypeFeatures clone() {
		long ret = bindings.ChannelTypeFeatures_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelTypeFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelTypeFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Create a blank Features with no features set
	 */
	public static ChannelTypeFeatures empty() {
		long ret = bindings.ChannelTypeFeatures_empty();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelTypeFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelTypeFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Returns true if this `Features` object contains unknown feature flags which are set as
	 * \"required\".
	 */
	public bool requires_unknown_bits() {
		bool ret = bindings.ChannelTypeFeatures_requires_unknown_bits(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Serialize the ChannelTypeFeatures object into a byte array which can be read by ChannelTypeFeatures_read
	 */
	public byte[] write() {
		byte[] ret = bindings.ChannelTypeFeatures_write(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Read a ChannelTypeFeatures from a byte array, created by ChannelTypeFeatures_write
	 */
	public static Result_ChannelTypeFeaturesDecodeErrorZ read(byte[] ser) {
		long ret = bindings.ChannelTypeFeatures_read(ser);
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelTypeFeaturesDecodeErrorZ ret_hu_conv = Result_ChannelTypeFeaturesDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Set this feature as optional.
	 */
	public void set_static_remote_key_optional() {
		bindings.ChannelTypeFeatures_set_static_remote_key_optional(this.ptr);
		GC.KeepAlive(this);
	}

	/**
	 * Set this feature as required.
	 */
	public void set_static_remote_key_required() {
		bindings.ChannelTypeFeatures_set_static_remote_key_required(this.ptr);
		GC.KeepAlive(this);
	}

	/**
	 * Checks if this feature is supported.
	 */
	public bool supports_static_remote_key() {
		bool ret = bindings.ChannelTypeFeatures_supports_static_remote_key(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Checks if this feature is required.
	 */
	public bool requires_static_remote_key() {
		bool ret = bindings.ChannelTypeFeatures_requires_static_remote_key(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Set this feature as optional.
	 */
	public void set_scid_privacy_optional() {
		bindings.ChannelTypeFeatures_set_scid_privacy_optional(this.ptr);
		GC.KeepAlive(this);
	}

	/**
	 * Set this feature as required.
	 */
	public void set_scid_privacy_required() {
		bindings.ChannelTypeFeatures_set_scid_privacy_required(this.ptr);
		GC.KeepAlive(this);
	}

	/**
	 * Checks if this feature is supported.
	 */
	public bool supports_scid_privacy() {
		bool ret = bindings.ChannelTypeFeatures_supports_scid_privacy(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Checks if this feature is required.
	 */
	public bool requires_scid_privacy() {
		bool ret = bindings.ChannelTypeFeatures_requires_scid_privacy(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Set this feature as optional.
	 */
	public void set_zero_conf_optional() {
		bindings.ChannelTypeFeatures_set_zero_conf_optional(this.ptr);
		GC.KeepAlive(this);
	}

	/**
	 * Set this feature as required.
	 */
	public void set_zero_conf_required() {
		bindings.ChannelTypeFeatures_set_zero_conf_required(this.ptr);
		GC.KeepAlive(this);
	}

	/**
	 * Checks if this feature is supported.
	 */
	public bool supports_zero_conf() {
		bool ret = bindings.ChannelTypeFeatures_supports_zero_conf(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Checks if this feature is required.
	 */
	public bool requires_zero_conf() {
		bool ret = bindings.ChannelTypeFeatures_requires_zero_conf(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

}
} } }
