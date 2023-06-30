using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * The recipient of a payment.
 */
public class PaymentParameters : CommonBase {
	internal PaymentParameters(object _dummy, long ptr) : base(ptr) { }
	~PaymentParameters() {
		if (ptr != 0) { bindings.PaymentParameters_free(ptr); }
	}

	/**
	 * The node id of the payee.
	 */
	public byte[] get_payee_pubkey() {
		byte[] ret = bindings.PaymentParameters_get_payee_pubkey(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The node id of the payee.
	 */
	public void set_payee_pubkey(byte[] val) {
		bindings.PaymentParameters_set_payee_pubkey(this.ptr, InternalUtils.check_arr_len(val, 33));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Features supported by the payee.
	 * 
	 * May be set from the payee's invoice or via [`for_keysend`]. May be `None` if the invoice
	 * does not contain any features.
	 * 
	 * [`for_keysend`]: Self::for_keysend
	 * 
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public InvoiceFeatures get_features() {
		long ret = bindings.PaymentParameters_get_features(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InvoiceFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.InvoiceFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Features supported by the payee.
	 * 
	 * May be set from the payee's invoice or via [`for_keysend`]. May be `None` if the invoice
	 * does not contain any features.
	 * 
	 * [`for_keysend`]: Self::for_keysend
	 * 
	 * Note that val (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public void set_features(org.ldk.structs.InvoiceFeatures val) {
		bindings.PaymentParameters_set_features(this.ptr, val == null ? 0 : val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		if (this != null) { this.ptrs_to.AddLast(val); };
	}

	/**
	 * Hints for routing to the payee, containing channels connecting the payee to public nodes.
	 */
	public RouteHint[] get_route_hints() {
		long[] ret = bindings.PaymentParameters_get_route_hints(this.ptr);
		GC.KeepAlive(this);
		int ret_conv_11_len = ret.Length;
		RouteHint[] ret_conv_11_arr = new RouteHint[ret_conv_11_len];
		for (int l = 0; l < ret_conv_11_len; l++) {
			long ret_conv_11 = ret[l];
			org.ldk.structs.RouteHint ret_conv_11_hu_conv = null; if (ret_conv_11 < 0 || ret_conv_11 > 4096) { ret_conv_11_hu_conv = new org.ldk.structs.RouteHint(null, ret_conv_11); }
			if (ret_conv_11_hu_conv != null) { ret_conv_11_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_11_arr[l] = ret_conv_11_hu_conv;
		}
		return ret_conv_11_arr;
	}

	/**
	 * Hints for routing to the payee, containing channels connecting the payee to public nodes.
	 */
	public void set_route_hints(RouteHint[] val) {
		bindings.PaymentParameters_set_route_hints(this.ptr, val != null ? InternalUtils.mapArray(val, val_conv_11 => val_conv_11 == null ? 0 : val_conv_11.ptr) : null);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
		foreach (RouteHint val_conv_11 in val) { if (this != null) { this.ptrs_to.AddLast(val_conv_11); }; };
	}

	/**
	 * Expiration of a payment to the payee, in seconds relative to the UNIX epoch.
	 */
	public Option_u64Z get_expiry_time() {
		long ret = bindings.PaymentParameters_get_expiry_time(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_u64Z ret_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Expiration of a payment to the payee, in seconds relative to the UNIX epoch.
	 */
	public void set_expiry_time(org.ldk.structs.Option_u64Z val) {
		bindings.PaymentParameters_set_expiry_time(this.ptr, val.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum total CLTV delta we accept for the route.
	 * Defaults to [`DEFAULT_MAX_TOTAL_CLTV_EXPIRY_DELTA`].
	 */
	public int get_max_total_cltv_expiry_delta() {
		int ret = bindings.PaymentParameters_get_max_total_cltv_expiry_delta(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum total CLTV delta we accept for the route.
	 * Defaults to [`DEFAULT_MAX_TOTAL_CLTV_EXPIRY_DELTA`].
	 */
	public void set_max_total_cltv_expiry_delta(int val) {
		bindings.PaymentParameters_set_max_total_cltv_expiry_delta(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The maximum number of paths that may be used by (MPP) payments.
	 * Defaults to [`DEFAULT_MAX_PATH_COUNT`].
	 */
	public byte get_max_path_count() {
		byte ret = bindings.PaymentParameters_get_max_path_count(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The maximum number of paths that may be used by (MPP) payments.
	 * Defaults to [`DEFAULT_MAX_PATH_COUNT`].
	 */
	public void set_max_path_count(byte val) {
		bindings.PaymentParameters_set_max_path_count(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Selects the maximum share of a channel's total capacity which will be sent over a channel,
	 * as a power of 1/2. A higher value prefers to send the payment using more MPP parts whereas
	 * a lower value prefers to send larger MPP parts, potentially saturating channels and
	 * increasing failure probability for those paths.
	 * 
	 * Note that this restriction will be relaxed during pathfinding after paths which meet this
	 * restriction have been found. While paths which meet this criteria will be searched for, it
	 * is ultimately up to the scorer to select them over other paths.
	 * 
	 * A value of 0 will allow payments up to and including a channel's total announced usable
	 * capacity, a value of one will only use up to half its capacity, two 1/4, etc.
	 * 
	 * Default value: 2
	 */
	public byte get_max_channel_saturation_power_of_half() {
		byte ret = bindings.PaymentParameters_get_max_channel_saturation_power_of_half(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Selects the maximum share of a channel's total capacity which will be sent over a channel,
	 * as a power of 1/2. A higher value prefers to send the payment using more MPP parts whereas
	 * a lower value prefers to send larger MPP parts, potentially saturating channels and
	 * increasing failure probability for those paths.
	 * 
	 * Note that this restriction will be relaxed during pathfinding after paths which meet this
	 * restriction have been found. While paths which meet this criteria will be searched for, it
	 * is ultimately up to the scorer to select them over other paths.
	 * 
	 * A value of 0 will allow payments up to and including a channel's total announced usable
	 * capacity, a value of one will only use up to half its capacity, two 1/4, etc.
	 * 
	 * Default value: 2
	 */
	public void set_max_channel_saturation_power_of_half(byte val) {
		bindings.PaymentParameters_set_max_channel_saturation_power_of_half(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * A list of SCIDs which this payment was previously attempted over and which caused the
	 * payment to fail. Future attempts for the same payment shouldn't be relayed through any of
	 * these SCIDs.
	 * 
	 * Returns a copy of the field.
	 */
	public long[] get_previously_failed_channels() {
		long[] ret = bindings.PaymentParameters_get_previously_failed_channels(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * A list of SCIDs which this payment was previously attempted over and which caused the
	 * payment to fail. Future attempts for the same payment shouldn't be relayed through any of
	 * these SCIDs.
	 */
	public void set_previously_failed_channels(long[] val) {
		bindings.PaymentParameters_set_previously_failed_channels(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new PaymentParameters given each field
	 */
	public static PaymentParameters of(byte[] payee_pubkey_arg, org.ldk.structs.InvoiceFeatures features_arg, RouteHint[] route_hints_arg, org.ldk.structs.Option_u64Z expiry_time_arg, int max_total_cltv_expiry_delta_arg, byte max_path_count_arg, byte max_channel_saturation_power_of_half_arg, long[] previously_failed_channels_arg) {
		long ret = bindings.PaymentParameters_new(InternalUtils.check_arr_len(payee_pubkey_arg, 33), features_arg == null ? 0 : features_arg.ptr, route_hints_arg != null ? InternalUtils.mapArray(route_hints_arg, route_hints_arg_conv_11 => route_hints_arg_conv_11 == null ? 0 : route_hints_arg_conv_11.ptr) : null, expiry_time_arg.ptr, max_total_cltv_expiry_delta_arg, max_path_count_arg, max_channel_saturation_power_of_half_arg, previously_failed_channels_arg);
		GC.KeepAlive(payee_pubkey_arg);
		GC.KeepAlive(features_arg);
		GC.KeepAlive(route_hints_arg);
		GC.KeepAlive(expiry_time_arg);
		GC.KeepAlive(max_total_cltv_expiry_delta_arg);
		GC.KeepAlive(max_path_count_arg);
		GC.KeepAlive(max_channel_saturation_power_of_half_arg);
		GC.KeepAlive(previously_failed_channels_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(features_arg); };
		foreach (RouteHint route_hints_arg_conv_11 in route_hints_arg) { if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(route_hints_arg_conv_11); }; };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.PaymentParameters_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the PaymentParameters
	 */
	public PaymentParameters clone() {
		long ret = bindings.PaymentParameters_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two PaymentParameterss contain equal inner contents.
	 */
	public long hash() {
		long ret = bindings.PaymentParameters_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two PaymentParameterss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.PaymentParameters b) {
		bool ret = bindings.PaymentParameters_eq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is PaymentParameters)) return false;
		return this.eq((PaymentParameters)o);
	}
	/**
	 * Serialize the PaymentParameters object into a byte array which can be read by PaymentParameters_read
	 */
	public byte[] write() {
		byte[] ret = bindings.PaymentParameters_write(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Read a PaymentParameters from a byte array, created by PaymentParameters_write
	 */
	public static Result_PaymentParametersDecodeErrorZ read(byte[] ser) {
		long ret = bindings.PaymentParameters_read(ser);
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PaymentParametersDecodeErrorZ ret_hu_conv = Result_PaymentParametersDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a payee with the node id of the given `pubkey`.
	 */
	public static PaymentParameters from_node_id(byte[] payee_pubkey) {
		long ret = bindings.PaymentParameters_from_node_id(InternalUtils.check_arr_len(payee_pubkey, 33));
		GC.KeepAlive(payee_pubkey);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Creates a payee with the node id of the given `pubkey` to use for keysend payments.
	 */
	public static PaymentParameters for_keysend(byte[] payee_pubkey) {
		long ret = bindings.PaymentParameters_for_keysend(InternalUtils.check_arr_len(payee_pubkey, 33));
		GC.KeepAlive(payee_pubkey);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentParameters ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.PaymentParameters(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

}
} } }
