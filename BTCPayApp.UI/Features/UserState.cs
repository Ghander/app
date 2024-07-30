﻿using BTCPayApp.CommonServer.Models;
using BTCPayApp.Core.Auth;
using BTCPayServer.Client.Models;
using Fluxor;

namespace BTCPayApp.UI.Features;

[FeatureState]
public record UserState
{
    public RemoteData<AppUserInfo>? Info;

    public record FetchInfo(
        TaskCompletionSource<AppUserInfo?> TaskCompletionSource,
        CancellationToken CancellationToken = default);

    public record FetchedInfo(AppUserInfo? Info, string? Error);
    public record UpdateUser(UpdateApplicationUserRequest Request);
    public record UpdatedUser(ApplicationUserData? UserData, string? Error);

    protected class FetchInfoReducer : Reducer<UserState, FetchInfo>
    {
        public override UserState Reduce(UserState state, FetchInfo action)
        {
            return state with
            {
                Info = (state.Info ?? new RemoteData<AppUserInfo>()) with
                {
                    Loading = true
                }
            };
        }
    }

    protected class FetchedInfoReducer : Reducer<UserState, FetchedInfo>
    {
        public override UserState Reduce(UserState state, FetchedInfo action)
        {
            return state with
            {
                Info = (state.Info ?? new RemoteData<AppUserInfo>()) with
                {
                    Data = action.Info,
                    Error = action.Error,
                    Loading = false
                }
            };
        }
    }

    protected class UpdateUserReducer : Reducer<UserState, UpdateUser>
    {
        public override UserState Reduce(UserState state, UpdateUser action)
        {
            return state with
            {
                Info = (state.Info ?? new RemoteData<AppUserInfo>()) with
                {
                    Sending = true
                }
            };
        }
    }

    protected class UpdatedUserReducer : Reducer<UserState, UpdatedUser>
    {
        public override UserState Reduce(UserState state, UpdatedUser action)
        {
            var newState = state with
            {
                Info = state.Info! with
                {
                    Error = action.Error,
                    Sending = false
                }
            };
            if (action.UserData != null && newState.Info.Data != null)
            {
                newState.Info.Data.Name = action.UserData.Name;
                newState.Info.Data.Email = action.UserData.Email;
                newState.Info.Data.ImageUrl = action.UserData.ImageUrl;
            }
            return newState;
        }
    }

    public class UserEffects(IAccountManager accountManager)
    {
        [EffectMethod]
        public async Task FetchInfoEffect(FetchInfo action, IDispatcher dispatcher)
        {
            try
            {
                var info = await accountManager.GetClient().GetUserInfo(action.CancellationToken);
                action.TaskCompletionSource.SetResult(info);
                dispatcher.Dispatch(new FetchedInfo(info, null));
            }
            catch (Exception e)
            {
                var error = e.InnerException?.Message ?? e.Message;
                action.TaskCompletionSource.SetResult(null);
                dispatcher.Dispatch(new FetchedInfo(null, error));
            }
        }

        [EffectMethod]
        public async Task UpdateUserEffect(UpdateUser action, IDispatcher dispatcher)
        {
            try
            {
                var userData = await accountManager.GetClient().UpdateCurrentUser(action.Request);
                dispatcher.Dispatch(new UpdatedUser(userData, null));
            }
            catch (Exception e)
            {
                var error = e.InnerException?.Message ?? e.Message;
                dispatcher.Dispatch(new UpdatedUser(null, error));
            }
        }
    }
}



