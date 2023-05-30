using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * A trait to describe an object which can receive routing messages.
 * 
 * # Implementor DoS Warnings
 * 
 * For `gossip_queries` messages there are potential DoS vectors when handling
 * inbound queries. Implementors using an on-disk network graph should be aware of
 * repeated disk I/O for queries accessing different parts of the network graph.
 */
public class RoutingMessageHandler : CommonBase {
	internal readonly bindings.LDKRoutingMessageHandler bindings_instance;
	internal RoutingMessageHandler(object _dummy, long ptr) : base(ptr) { bindings_instance = null; }
	private RoutingMessageHandler(bindings.LDKRoutingMessageHandler arg, bindings.LDKMessageSendEventsProvider MessageSendEventsProvider) : base(bindings.LDKRoutingMessageHandler_new(arg, MessageSendEventsProvider)) {
		this.ptrs_to.AddLast(arg);
		this.ptrs_to.AddLast(MessageSendEventsProvider);
		this.bindings_instance = arg;
	}
	~RoutingMessageHandler() {
		if (ptr != 0) { bindings.RoutingMessageHandler_free(ptr); }
	}

	public interface RoutingMessageHandlerInterface {
		/**
		 * Handle an incoming node_announcement message, returning true if it should be forwarded on,
		 * false or returning an Err otherwise.
		 */
		Result_boolLightningErrorZ handle_node_announcement(NodeAnnouncement _msg);
		/**
		 * Handle a channel_announcement message, returning true if it should be forwarded on, false
		 * or returning an Err otherwise.
		 */
		Result_boolLightningErrorZ handle_channel_announcement(ChannelAnnouncement _msg);
		/**
		 * Handle an incoming channel_update message, returning true if it should be forwarded on,
		 * false or returning an Err otherwise.
		 */
		Result_boolLightningErrorZ handle_channel_update(ChannelUpdate _msg);
		/**
		 * Gets channel announcements and updates required to dump our routing table to a remote node,
		 * starting at the short_channel_id indicated by starting_point and including announcements
		 * for a single channel.
		 */
		Option_C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZZ get_next_channel_announcement(long _starting_point);
		/**
		 * Gets a node announcement required to dump our routing table to a remote node, starting at
		 * the node *after* the provided pubkey and including up to one announcement immediately
		 * higher (as defined by <PublicKey as Ord>::cmp) than starting_point.
		 * If None is provided for starting_point, we start at the first node.
		 * 
		 * Note that starting_point (or a relevant inner pointer) may be NULL or all-0s to represent None
		 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		NodeAnnouncement get_next_node_announcement(byte[] _starting_point);
		/**
		 * Called when a connection is established with a peer. This can be used to
		 * perform routing table synchronization using a strategy defined by the
		 * implementor.
		 * 
		 * May return an `Err(())` if the features the peer supports are not sufficient to communicate
		 * with us. Implementors should be somewhat conservative about doing so, however, as other
		 * message handlers may still wish to communicate with this peer.
		 */
		Result_NoneNoneZ peer_connected(byte[] _their_node_id, Init _init);
		/**
		 * Handles the reply of a query we initiated to learn about channels
		 * for a given range of blocks. We can expect to receive one or more
		 * replies to a single query.
		 */
		Result_NoneLightningErrorZ handle_reply_channel_range(byte[] _their_node_id, ReplyChannelRange _msg);
		/**
		 * Handles the reply of a query we initiated asking for routing gossip
		 * messages for a list of channels. We should receive this message when
		 * a node has completed its best effort to send us the pertaining routing
		 * gossip messages.
		 */
		Result_NoneLightningErrorZ handle_reply_short_channel_ids_end(byte[] _their_node_id, ReplyShortChannelIdsEnd _msg);
		/**
		 * Handles when a peer asks us to send a list of short_channel_ids
		 * for the requested range of blocks.
		 */
		Result_NoneLightningErrorZ handle_query_channel_range(byte[] _their_node_id, QueryChannelRange _msg);
		/**
		 * Handles when a peer asks us to send routing gossip messages for a
		 * list of short_channel_ids.
		 */
		Result_NoneLightningErrorZ handle_query_short_channel_ids(byte[] _their_node_id, QueryShortChannelIds _msg);
		/**
		 * Gets the node feature flags which this handler itself supports. All available handlers are
		 * queried similarly and their feature flags are OR'd together to form the [`NodeFeatures`]
		 * which are broadcasted in our [`NodeAnnouncement`] message.
		 */
		NodeFeatures provided_node_features();
		/**
		 * Gets the init feature flags which should be sent to the given peer. All available handlers
		 * are queried similarly and their feature flags are OR'd together to form the [`InitFeatures`]
		 * which are sent in our [`Init`] message.
		 * 
		 * Note that this method is called before [`Self::peer_connected`].
		 */
		InitFeatures provided_init_features(byte[] _their_node_id);
	}
	private class LDKRoutingMessageHandlerHolder { internal RoutingMessageHandler held; }
	private class LDKRoutingMessageHandlerImpl : bindings.LDKRoutingMessageHandler {
		internal LDKRoutingMessageHandlerImpl(RoutingMessageHandlerInterface arg, LDKRoutingMessageHandlerHolder impl_holder) { this.arg = arg; this.impl_holder = impl_holder; }
		private RoutingMessageHandlerInterface arg;
		private LDKRoutingMessageHandlerHolder impl_holder;
		public long handle_node_announcement(long _msg) {
			org.ldk.structs.NodeAnnouncement _msg_hu_conv = null; if (_msg < 0 || _msg > 4096) { _msg_hu_conv = new org.ldk.structs.NodeAnnouncement(null, _msg); }
			Result_boolLightningErrorZ ret = arg.handle_node_announcement(_msg_hu_conv);
				GC.KeepAlive(arg);
			long result = ret == null ? 0 : ret.clone_ptr();
			return result;
		}
		public long handle_channel_announcement(long _msg) {
			org.ldk.structs.ChannelAnnouncement _msg_hu_conv = null; if (_msg < 0 || _msg > 4096) { _msg_hu_conv = new org.ldk.structs.ChannelAnnouncement(null, _msg); }
			Result_boolLightningErrorZ ret = arg.handle_channel_announcement(_msg_hu_conv);
				GC.KeepAlive(arg);
			long result = ret == null ? 0 : ret.clone_ptr();
			return result;
		}
		public long handle_channel_update(long _msg) {
			org.ldk.structs.ChannelUpdate _msg_hu_conv = null; if (_msg < 0 || _msg > 4096) { _msg_hu_conv = new org.ldk.structs.ChannelUpdate(null, _msg); }
			Result_boolLightningErrorZ ret = arg.handle_channel_update(_msg_hu_conv);
				GC.KeepAlive(arg);
			long result = ret == null ? 0 : ret.clone_ptr();
			return result;
		}
		public long get_next_channel_announcement(long _starting_point) {
			Option_C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZZ ret = arg.get_next_channel_announcement(_starting_point);
				GC.KeepAlive(arg);
			long result = ret == null ? 0 : ret.clone_ptr();
			return result;
		}
		public long get_next_node_announcement(byte[] _starting_point) {
			NodeAnnouncement ret = arg.get_next_node_announcement(_starting_point);
				GC.KeepAlive(arg);
			long result = ret == null ? 0 : ret.clone_ptr();
			return result;
		}
		public long peer_connected(byte[] _their_node_id, long _init) {
			org.ldk.structs.Init _init_hu_conv = null; if (_init < 0 || _init > 4096) { _init_hu_conv = new org.ldk.structs.Init(null, _init); }
			Result_NoneNoneZ ret = arg.peer_connected(_their_node_id, _init_hu_conv);
				GC.KeepAlive(arg);
			long result = ret == null ? 0 : ret.clone_ptr();
			return result;
		}
		public long handle_reply_channel_range(byte[] _their_node_id, long _msg) {
			org.ldk.structs.ReplyChannelRange _msg_hu_conv = null; if (_msg < 0 || _msg > 4096) { _msg_hu_conv = new org.ldk.structs.ReplyChannelRange(null, _msg); }
			if (_msg_hu_conv != null) { _msg_hu_conv.ptrs_to.AddLast(this); };
			Result_NoneLightningErrorZ ret = arg.handle_reply_channel_range(_their_node_id, _msg_hu_conv);
				GC.KeepAlive(arg);
			long result = ret == null ? 0 : ret.clone_ptr();
			return result;
		}
		public long handle_reply_short_channel_ids_end(byte[] _their_node_id, long _msg) {
			org.ldk.structs.ReplyShortChannelIdsEnd _msg_hu_conv = null; if (_msg < 0 || _msg > 4096) { _msg_hu_conv = new org.ldk.structs.ReplyShortChannelIdsEnd(null, _msg); }
			if (_msg_hu_conv != null) { _msg_hu_conv.ptrs_to.AddLast(this); };
			Result_NoneLightningErrorZ ret = arg.handle_reply_short_channel_ids_end(_their_node_id, _msg_hu_conv);
				GC.KeepAlive(arg);
			long result = ret == null ? 0 : ret.clone_ptr();
			return result;
		}
		public long handle_query_channel_range(byte[] _their_node_id, long _msg) {
			org.ldk.structs.QueryChannelRange _msg_hu_conv = null; if (_msg < 0 || _msg > 4096) { _msg_hu_conv = new org.ldk.structs.QueryChannelRange(null, _msg); }
			if (_msg_hu_conv != null) { _msg_hu_conv.ptrs_to.AddLast(this); };
			Result_NoneLightningErrorZ ret = arg.handle_query_channel_range(_their_node_id, _msg_hu_conv);
				GC.KeepAlive(arg);
			long result = ret == null ? 0 : ret.clone_ptr();
			return result;
		}
		public long handle_query_short_channel_ids(byte[] _their_node_id, long _msg) {
			org.ldk.structs.QueryShortChannelIds _msg_hu_conv = null; if (_msg < 0 || _msg > 4096) { _msg_hu_conv = new org.ldk.structs.QueryShortChannelIds(null, _msg); }
			if (_msg_hu_conv != null) { _msg_hu_conv.ptrs_to.AddLast(this); };
			Result_NoneLightningErrorZ ret = arg.handle_query_short_channel_ids(_their_node_id, _msg_hu_conv);
				GC.KeepAlive(arg);
			long result = ret == null ? 0 : ret.clone_ptr();
			return result;
		}
		public long provided_node_features() {
			NodeFeatures ret = arg.provided_node_features();
				GC.KeepAlive(arg);
			long result = ret == null ? 0 : ret.clone_ptr();
			return result;
		}
		public long provided_init_features(byte[] _their_node_id) {
			InitFeatures ret = arg.provided_init_features(_their_node_id);
				GC.KeepAlive(arg);
			long result = ret == null ? 0 : ret.clone_ptr();
			return result;
		}
	}
	public static RoutingMessageHandler new_impl(RoutingMessageHandlerInterface arg, MessageSendEventsProvider.MessageSendEventsProviderInterface MessageSendEventsProvider_impl) {
		LDKRoutingMessageHandlerHolder impl_holder = new LDKRoutingMessageHandlerHolder();
		impl_holder.held = new RoutingMessageHandler(new LDKRoutingMessageHandlerImpl(arg, impl_holder), MessageSendEventsProvider.new_impl(MessageSendEventsProvider_impl).bindings_instance);
		return impl_holder.held;
	}

	/**
	 * Gets the underlying MessageSendEventsProvider.
	 */
	public MessageSendEventsProvider get_message_send_events_provider() {
		MessageSendEventsProvider res = new MessageSendEventsProvider(null, bindings.LDKRoutingMessageHandler_get_MessageSendEventsProvider(this.ptr));
		this.ptrs_to.AddLast(res);
		return res;
	}

	/**
	 * Handle an incoming node_announcement message, returning true if it should be forwarded on,
	 * false or returning an Err otherwise.
	 */
	public Result_boolLightningErrorZ handle_node_announcement(org.ldk.structs.NodeAnnouncement msg) {
		long ret = bindings.RoutingMessageHandler_handle_node_announcement(this.ptr, msg == null ? 0 : msg.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(msg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_boolLightningErrorZ ret_hu_conv = Result_boolLightningErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(msg); };
		return ret_hu_conv;
	}

	/**
	 * Handle a channel_announcement message, returning true if it should be forwarded on, false
	 * or returning an Err otherwise.
	 */
	public Result_boolLightningErrorZ handle_channel_announcement(org.ldk.structs.ChannelAnnouncement msg) {
		long ret = bindings.RoutingMessageHandler_handle_channel_announcement(this.ptr, msg == null ? 0 : msg.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(msg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_boolLightningErrorZ ret_hu_conv = Result_boolLightningErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(msg); };
		return ret_hu_conv;
	}

	/**
	 * Handle an incoming channel_update message, returning true if it should be forwarded on,
	 * false or returning an Err otherwise.
	 */
	public Result_boolLightningErrorZ handle_channel_update(org.ldk.structs.ChannelUpdate msg) {
		long ret = bindings.RoutingMessageHandler_handle_channel_update(this.ptr, msg == null ? 0 : msg.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(msg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_boolLightningErrorZ ret_hu_conv = Result_boolLightningErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(msg); };
		return ret_hu_conv;
	}

	/**
	 * Gets channel announcements and updates required to dump our routing table to a remote node,
	 * starting at the short_channel_id indicated by starting_point and including announcements
	 * for a single channel.
	 */
	public Option_C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZZ get_next_channel_announcement(long starting_point) {
		long ret = bindings.RoutingMessageHandler_get_next_channel_announcement(this.ptr, starting_point);
		GC.KeepAlive(this);
		GC.KeepAlive(starting_point);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZZ ret_hu_conv = org.ldk.structs.Option_C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Gets a node announcement required to dump our routing table to a remote node, starting at
	 * the node *after* the provided pubkey and including up to one announcement immediately
	 * higher (as defined by <PublicKey as Ord>::cmp) than starting_point.
	 * If None is provided for starting_point, we start at the first node.
	 * 
	 * Note that starting_point (or a relevant inner pointer) may be NULL or all-0s to represent None
	 * Note that the return value (or a relevant inner pointer) may be NULL or all-0s to represent None
	 */
	public NodeAnnouncement get_next_node_announcement(byte[] starting_point) {
		long ret = bindings.RoutingMessageHandler_get_next_node_announcement(this.ptr, InternalUtils.check_arr_len(starting_point, 33));
		GC.KeepAlive(this);
		GC.KeepAlive(starting_point);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeAnnouncement ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeAnnouncement(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Called when a connection is established with a peer. This can be used to
	 * perform routing table synchronization using a strategy defined by the
	 * implementor.
	 * 
	 * May return an `Err(())` if the features the peer supports are not sufficient to communicate
	 * with us. Implementors should be somewhat conservative about doing so, however, as other
	 * message handlers may still wish to communicate with this peer.
	 */
	public Result_NoneNoneZ peer_connected(byte[] their_node_id, org.ldk.structs.Init init) {
		long ret = bindings.RoutingMessageHandler_peer_connected(this.ptr, InternalUtils.check_arr_len(their_node_id, 33), init == null ? 0 : init.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(their_node_id);
		GC.KeepAlive(init);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneNoneZ ret_hu_conv = Result_NoneNoneZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(init); };
		return ret_hu_conv;
	}

	/**
	 * Handles the reply of a query we initiated to learn about channels
	 * for a given range of blocks. We can expect to receive one or more
	 * replies to a single query.
	 */
	public Result_NoneLightningErrorZ handle_reply_channel_range(byte[] their_node_id, org.ldk.structs.ReplyChannelRange msg) {
		long ret = bindings.RoutingMessageHandler_handle_reply_channel_range(this.ptr, InternalUtils.check_arr_len(their_node_id, 33), msg == null ? 0 : msg.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(their_node_id);
		GC.KeepAlive(msg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneLightningErrorZ ret_hu_conv = Result_NoneLightningErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(msg); };
		return ret_hu_conv;
	}

	/**
	 * Handles the reply of a query we initiated asking for routing gossip
	 * messages for a list of channels. We should receive this message when
	 * a node has completed its best effort to send us the pertaining routing
	 * gossip messages.
	 */
	public Result_NoneLightningErrorZ handle_reply_short_channel_ids_end(byte[] their_node_id, org.ldk.structs.ReplyShortChannelIdsEnd msg) {
		long ret = bindings.RoutingMessageHandler_handle_reply_short_channel_ids_end(this.ptr, InternalUtils.check_arr_len(their_node_id, 33), msg == null ? 0 : msg.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(their_node_id);
		GC.KeepAlive(msg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneLightningErrorZ ret_hu_conv = Result_NoneLightningErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(msg); };
		return ret_hu_conv;
	}

	/**
	 * Handles when a peer asks us to send a list of short_channel_ids
	 * for the requested range of blocks.
	 */
	public Result_NoneLightningErrorZ handle_query_channel_range(byte[] their_node_id, org.ldk.structs.QueryChannelRange msg) {
		long ret = bindings.RoutingMessageHandler_handle_query_channel_range(this.ptr, InternalUtils.check_arr_len(their_node_id, 33), msg == null ? 0 : msg.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(their_node_id);
		GC.KeepAlive(msg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneLightningErrorZ ret_hu_conv = Result_NoneLightningErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(msg); };
		return ret_hu_conv;
	}

	/**
	 * Handles when a peer asks us to send routing gossip messages for a
	 * list of short_channel_ids.
	 */
	public Result_NoneLightningErrorZ handle_query_short_channel_ids(byte[] their_node_id, org.ldk.structs.QueryShortChannelIds msg) {
		long ret = bindings.RoutingMessageHandler_handle_query_short_channel_ids(this.ptr, InternalUtils.check_arr_len(their_node_id, 33), msg == null ? 0 : msg.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(their_node_id);
		GC.KeepAlive(msg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_NoneLightningErrorZ ret_hu_conv = Result_NoneLightningErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.AddLast(msg); };
		return ret_hu_conv;
	}

	/**
	 * Gets the node feature flags which this handler itself supports. All available handlers are
	 * queried similarly and their feature flags are OR'd together to form the [`NodeFeatures`]
	 * which are broadcasted in our [`NodeAnnouncement`] message.
	 */
	public NodeFeatures provided_node_features() {
		long ret = bindings.RoutingMessageHandler_provided_node_features(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.NodeFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.NodeFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Gets the init feature flags which should be sent to the given peer. All available handlers
	 * are queried similarly and their feature flags are OR'd together to form the [`InitFeatures`]
	 * which are sent in our [`Init`] message.
	 * 
	 * Note that this method is called before [`Self::peer_connected`].
	 */
	public InitFeatures provided_init_features(byte[] their_node_id) {
		long ret = bindings.RoutingMessageHandler_provided_init_features(this.ptr, InternalUtils.check_arr_len(their_node_id, 33));
		GC.KeepAlive(this);
		GC.KeepAlive(their_node_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InitFeatures ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.InitFeatures(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
