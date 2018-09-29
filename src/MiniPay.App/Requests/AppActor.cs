using System.Collections.Generic;
using MiniPay.App.User;

namespace MiniPay.App.Requests
{
    public sealed class AppActor
    {
        public string Id { get; }
        public IEnumerable<UserRoles> Roles { get; }

        public AppActor(string id, HashSet<UserRoles> roles)
        {
            Id = id;
            Roles = roles;
        }
    }
}
