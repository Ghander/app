using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Some information provided on receipt of payment depends on whether the payment received is a
 * spontaneous payment or a \"conventional\" lightning payment that's paying an invoice.
 */
public class PaymentPurpose : CommonBase {
	protected PaymentPurpose(object _dummy, long ptr) : base(ptr) { }
	~PaymentPurpose() {
		if (ptr != 0) { bindings.PaymentPurpose_free(ptr); }
	}

	internal static PaymentPurpose constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKPaymentPurpose_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new PaymentPurpose_InvoicePayment(ptr);
			case 1: return new PaymentPurpose_SpontaneousPayment(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A PaymentPurpose of type InvoicePayment */
	public class PaymentPurpose_InvoicePayment : PaymentPurpose {
		/**
		 * The preimage to the payment_hash, if the payment hash (and secret) were fetched via
		 * [`ChannelManager::create_inbound_payment`]. If provided, this can be handed directly to
		 * [`ChannelManager::claim_funds`].
		 * 
		 * [`ChannelManager::create_inbound_payment`]: crate::ln::channelmanager::ChannelManager::create_inbound_payment
		 * [`ChannelManager::claim_funds`]: crate::ln::channelmanager::ChannelManager::claim_funds
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		public byte[] payment_preimage;
		/**
		 * The \"payment secret\". This authenticates the sender to the recipient, preventing a
		 * number of deanonymization attacks during the routing process.
		 * It is provided here for your reference, however its accuracy is enforced directly by
		 * [`ChannelManager`] using the values you previously provided to
		 * [`ChannelManager::create_inbound_payment`] or
		 * [`ChannelManager::create_inbound_payment_for_hash`].
		 * 
		 * [`ChannelManager`]: crate::ln::channelmanager::ChannelManager
		 * [`ChannelManager::create_inbound_payment`]: crate::ln::channelmanager::ChannelManager::create_inbound_payment
		 * [`ChannelManager::create_inbound_payment_for_hash`]: crate::ln::channelmanager::ChannelManager::create_inbound_payment_for_hash
		 */
		public byte[] payment_secret;
		internal PaymentPurpose_InvoicePayment(long ptr) : base(null, ptr) {
			this.payment_preimage = bindings.LDKPaymentPurpose_InvoicePayment_get_payment_preimage(ptr);
			this.payment_secret = bindings.LDKPaymentPurpose_InvoicePayment_get_payment_secret(ptr);
		}
	}
	/** A PaymentPurpose of type SpontaneousPayment */
	public class PaymentPurpose_SpontaneousPayment : PaymentPurpose {
		public byte[] spontaneous_payment;
		internal PaymentPurpose_SpontaneousPayment(long ptr) : base(null, ptr) {
			this.spontaneous_payment = bindings.LDKPaymentPurpose_SpontaneousPayment_get_spontaneous_payment(ptr);
		}
	}
	internal long clone_ptr() {
		long ret = bindings.PaymentPurpose_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the PaymentPurpose
	 */
	public PaymentPurpose clone() {
		long ret = bindings.PaymentPurpose_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentPurpose ret_hu_conv = org.ldk.structs.PaymentPurpose.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new InvoicePayment-variant PaymentPurpose
	 */
	public static PaymentPurpose invoice_payment(byte[] payment_preimage, byte[] payment_secret) {
		long ret = bindings.PaymentPurpose_invoice_payment(InternalUtils.check_arr_len(payment_preimage, 32), InternalUtils.check_arr_len(payment_secret, 32));
		GC.KeepAlive(payment_preimage);
		GC.KeepAlive(payment_secret);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentPurpose ret_hu_conv = org.ldk.structs.PaymentPurpose.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SpontaneousPayment-variant PaymentPurpose
	 */
	public static PaymentPurpose spontaneous_payment(byte[] a) {
		long ret = bindings.PaymentPurpose_spontaneous_payment(InternalUtils.check_arr_len(a, 32));
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.PaymentPurpose ret_hu_conv = org.ldk.structs.PaymentPurpose.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the PaymentPurpose object into a byte array which can be read by PaymentPurpose_read
	 */
	public byte[] write() {
		byte[] ret = bindings.PaymentPurpose_write(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Read a PaymentPurpose from a byte array, created by PaymentPurpose_write
	 */
	public static Result_PaymentPurposeDecodeErrorZ read(byte[] ser) {
		long ret = bindings.PaymentPurpose_read(ser);
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_PaymentPurposeDecodeErrorZ ret_hu_conv = Result_PaymentPurposeDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
