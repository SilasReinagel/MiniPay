﻿using MiniPay;

namespace MiniPay.App.User
{
    public static class UsersExtensions
    {
        public static Response IfExists(this Users users, string userId)
        {
            return users.Exists(userId)
               ? Response.Success()
               : Response.Errored(ResponseStatus.UnknownEntity, $"Unknown User { userId }");
        }
    }
}
