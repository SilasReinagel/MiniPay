using System.Collections.Generic;
using System.Linq;

namespace MiniPay.App.User
{
    public sealed class RemoveRoles
    {
        public string UserId { get; }
        public HashSet<UserRoles> Roles { get; }

        public RemoveRoles(string userId, params UserRoles[] roles)
        {
            UserId = userId;
            Roles = new HashSet<UserRoles>(roles);
        }
    }
}
