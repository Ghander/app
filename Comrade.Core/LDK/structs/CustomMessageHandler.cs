using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * Handler for BOLT1-compliant messages.
 */
public class CustomMessageHandler : CommonBase {
	internal readonly bindings.LDKCustomMessageHandler bindings_instance;
	internal CustomMessageHandler(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	private CustomMessageHandler(bindings.LDKCustomMessageHandler arg, bindings.LDKCustomMessageReader CustomMessageReader) : base(bindings.LDKCustomMessageHandler_new(arg, CustomMessageReader)) {
		this.ptrs_to.AddLast(arg);
		this.ptrs_to.AddLast(CustomMessageReader);
		this.bindings_instance = arg;
	}
	~CustomMessageHandler() {
		if (ptr != 0) { bindings.CustomMessageHandler_free(ptr); }
	}

	public interface CustomMessageHandlerInterface {
		/**
		 * Called with the message type that was received and the buffer to be read.
		 * Can return a `MessageHandlingError` if the message could not be handled.
		 */
		Result_NoneLightningErrorZ handle_custom_message(Type _msg, byte[] _sender_node_id);
		/**
		 * Gets the list of pending messages which were generated by the custom message
		 * handler, clearing the list in the process. The first tuple element must
		 * correspond to the intended recipients node ids. If no connection to one of the
		 * specified node does not exist, the message is simply not sent to it.
		 */
		TwoTuple_PublicKeyTypeZ[] get_and_clear_pending_msg();
	}
	private class LDKCustomMessageHandlerHolder { internal CustomMessageHandler held; }
	private class LDKCustomMessageHandlerImpl : bindings.LDKCustomMessageHandler {
		internal LDKCustomMessageHandlerImpl(CustomMessageHandlerInterface arg, LDKCustomMessageHandlerHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private CustomMessageHandlerInterface arg;
		private LDKCustomMessageHandlerHolder impl_holder;
		public long handle_custom_message(long _msg, byte[] _sender_node_id) {
			Type ret_hu_conv = new Type(null, _msg);
			if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
			Result_NoneLightningErrorZ ret = arg.handle_custom_message(ret_hu_conv, _sender_node_id);
				GC.KeepAlive(arg);
			long result = ret == null ? 0 : ret.clone_ptr();
			return result;
		}
		public long[] get_and_clear_pending_msg() {
			TwoTuple_PublicKeyTypeZ[] ret = arg.get_and_clear_pending_msg();
				GC.KeepAlive(arg);
			long[] result = ret != null ? InternalUtils.mapArray(ret, ret_conv_25 => ret_conv_25 == null ? 0 : ret_conv_25.clone_ptr()) : null;
			return result;
		}
	}
	public static CustomMessageHandler new_impl(CustomMessageHandlerInterface arg, CustomMessageReader.CustomMessageReaderInterface CustomMessageReader_impl) {
		LDKCustomMessageHandlerHolder impl_holder = new LDKCustomMessageHandlerHolder();
		impl_holder.held = new CustomMessageHandler(new LDKCustomMessageHandlerImpl(arg, impl_holder), CustomMessageReader.new_impl(CustomMessageReader_impl).bindings_instance);
		return impl_holder.held;
	}

	/**
	 * Gets the underlying CustomMessageReader.
	 */
	public CustomMessageReader get_custom_message_reader() {
		CustomMessageReader res = new CustomMessageReader(null, bindings.LDKCustomMessageHandler_get_CustomMessageReader(this.ptr));
		this.ptrs_to.AddLast(res);
		return res;
	}

	/**
	 * Called with the message type that was received and the buffer to be read.
	 * Can return a `MessageHandlingError` if the message could not be handled.
	 */
	public Result_NoneLightningErrorZ handle_custom_message(org.ldk.structs.Type msg, byte[] sender_node_id) {
		long ret = bindings.CustomMessageHandler_handle_custom_message(this.ptr, msg == null ? 0 : msg.ptr, InternalUtils.check_arr_len(sender_node_id, 33));
		GC.KeepAlive(this);
		GC.KeepAlive(msg);
		GC.KeepAlive(sender_node_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneLightningErrorZ ret_hu_conv = Result_NoneLightningErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(msg); };
		return ret_hu_conv;
	}

	/**
	 * Gets the list of pending messages which were generated by the custom message
	 * handler, clearing the list in the process. The first tuple element must
	 * correspond to the intended recipients node ids. If no connection to one of the
	 * specified node does not exist, the message is simply not sent to it.
	 */
	public TwoTuple_PublicKeyTypeZ[] get_and_clear_pending_msg() {
		long[] ret = bindings.CustomMessageHandler_get_and_clear_pending_msg(this.ptr);
		GC.KeepAlive(this);
		int ret_conv_25_len = ret.Length;
		TwoTuple_PublicKeyTypeZ[] ret_conv_25_arr = new TwoTuple_PublicKeyTypeZ[ret_conv_25_len];
		for (int z = 0; z < ret_conv_25_len; z++) {
			long ret_conv_25 = ret[z];
			TwoTuple_PublicKeyTypeZ ret_conv_25_hu_conv = new TwoTuple_PublicKeyTypeZ(null, ret_conv_25);
			if (ret_conv_25_hu_conv != null) { ret_conv_25_hu_conv.ptrs_to.AddLast(this); };
			ret_conv_25_arr[z] = ret_conv_25_hu_conv;
		}
		return ret_conv_25_arr;
	}

}
} } }
