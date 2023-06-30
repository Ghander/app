using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * Features used within an invoice.
 */
public class InvoiceFeatures : CommonBase {
	internal InvoiceFeatures(object _dummy, long ptr) : base(ptr) { }
	~InvoiceFeatures() {
		if (ptr != 0) { bindings.InvoiceFeatures_free(ptr); }
	}

	/**
	 * Checks if two InvoiceFeaturess contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.InvoiceFeatures b) {
		bool ret = bindings.InvoiceFeatures_eq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is InvoiceFeatures)) return false;
		return this.eq((InvoiceFeatures)o);
	}
	internal long clone_ptr() {
		long ret = bindings.InvoiceFeatures_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the InvoiceFeatures
	 */
	public InvoiceFeatures clone() {
		long ret = bindings.InvoiceFeatures_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InvoiceFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.InvoiceFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Create a blank Features with no features set
	 */
	public static InvoiceFeatures empty() {
		long ret = bindings.InvoiceFeatures_empty();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InvoiceFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.InvoiceFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Returns true if this `Features` object contains unknown feature flags which are set as
	 * \"required\".
	 */
	public bool requires_unknown_bits() {
		bool ret = bindings.InvoiceFeatures_requires_unknown_bits(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Serialize the InvoiceFeatures object into a byte array which can be read by InvoiceFeatures_read
	 */
	public byte[] write() {
		byte[] ret = bindings.InvoiceFeatures_write(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Read a InvoiceFeatures from a byte array, created by InvoiceFeatures_write
	 */
	public static Result_InvoiceFeaturesDecodeErrorZ read(byte[] ser) {
		long ret = bindings.InvoiceFeatures_read(ser);
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_InvoiceFeaturesDecodeErrorZ ret_hu_conv = Result_InvoiceFeaturesDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Set this feature as optional.
	 */
	public void set_variable_length_onion_optional() {
		bindings.InvoiceFeatures_set_variable_length_onion_optional(this.ptr);
		GC.KeepAlive(this);
	}

	/**
	 * Set this feature as required.
	 */
	public void set_variable_length_onion_required() {
		bindings.InvoiceFeatures_set_variable_length_onion_required(this.ptr);
		GC.KeepAlive(this);
	}

	/**
	 * Checks if this feature is supported.
	 */
	public bool supports_variable_length_onion() {
		bool ret = bindings.InvoiceFeatures_supports_variable_length_onion(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Checks if this feature is required.
	 */
	public bool requires_variable_length_onion() {
		bool ret = bindings.InvoiceFeatures_requires_variable_length_onion(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Set this feature as optional.
	 */
	public void set_payment_secret_optional() {
		bindings.InvoiceFeatures_set_payment_secret_optional(this.ptr);
		GC.KeepAlive(this);
	}

	/**
	 * Set this feature as required.
	 */
	public void set_payment_secret_required() {
		bindings.InvoiceFeatures_set_payment_secret_required(this.ptr);
		GC.KeepAlive(this);
	}

	/**
	 * Checks if this feature is supported.
	 */
	public bool supports_payment_secret() {
		bool ret = bindings.InvoiceFeatures_supports_payment_secret(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Checks if this feature is required.
	 */
	public bool requires_payment_secret() {
		bool ret = bindings.InvoiceFeatures_requires_payment_secret(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Set this feature as optional.
	 */
	public void set_basic_mpp_optional() {
		bindings.InvoiceFeatures_set_basic_mpp_optional(this.ptr);
		GC.KeepAlive(this);
	}

	/**
	 * Set this feature as required.
	 */
	public void set_basic_mpp_required() {
		bindings.InvoiceFeatures_set_basic_mpp_required(this.ptr);
		GC.KeepAlive(this);
	}

	/**
	 * Checks if this feature is supported.
	 */
	public bool supports_basic_mpp() {
		bool ret = bindings.InvoiceFeatures_supports_basic_mpp(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Checks if this feature is required.
	 */
	public bool requires_basic_mpp() {
		bool ret = bindings.InvoiceFeatures_requires_basic_mpp(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

}
} } }
