using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

public class Result_NonePaymentErrorZ : CommonBase {
	Result_NonePaymentErrorZ(object _dummy, long ptr) : base(ptr) { }
	~Result_NonePaymentErrorZ() {
		if (ptr != 0) { bindings.CResult_NonePaymentErrorZ_free(ptr); }
	}

	internal static Result_NonePaymentErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_NonePaymentErrorZ_is_ok(ptr)) {
			return new Result_NonePaymentErrorZ_OK(null, ptr);
		} else {
			return new Result_NonePaymentErrorZ_Err(null, ptr);
		}
	}
	public class Result_NonePaymentErrorZ_OK : Result_NonePaymentErrorZ {
		internal Result_NonePaymentErrorZ_OK(object _dummy, long ptr) : base(_dummy, ptr) {
		}
	}

	public class Result_NonePaymentErrorZ_Err : Result_NonePaymentErrorZ {
		public readonly PaymentError err;
		internal Result_NonePaymentErrorZ_Err(object _dummy, long ptr) : base(_dummy, ptr) {
			long err = bindings.CResult_NonePaymentErrorZ_get_err(ptr);
			org.ldk.structs.PaymentError err_hu_conv = org.ldk.structs.PaymentError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.AddLast(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_NonePaymentErrorZ in the success state.
	 */
	public static Result_NonePaymentErrorZ ok() {
		long ret = bindings.CResult_NonePaymentErrorZ_ok();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NonePaymentErrorZ ret_hu_conv = Result_NonePaymentErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_NonePaymentErrorZ in the error state.
	 */
	public static Result_NonePaymentErrorZ err(org.ldk.structs.PaymentError e) {
		long ret = bindings.CResult_NonePaymentErrorZ_err(e.ptr);
		GC.KeepAlive(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NonePaymentErrorZ ret_hu_conv = Result_NonePaymentErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public bool is_ok() {
		bool ret = bindings.CResult_NonePaymentErrorZ_is_ok(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	internal long clone_ptr() {
		long ret = bindings.CResult_NonePaymentErrorZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new CResult_NonePaymentErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_NonePaymentErrorZ clone() {
		long ret = bindings.CResult_NonePaymentErrorZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NonePaymentErrorZ ret_hu_conv = Result_NonePaymentErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
