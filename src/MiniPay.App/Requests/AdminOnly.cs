using System.Linq;
using MiniPay;
using MiniPay.App.User;

namespace MiniPay.App.Requests
{
    public sealed class AdminOnly : IRequest
    {
        private readonly IRequest _request;
        
        public AdminOnly(IRequest request)
        {
            _request = request;
        }

        public Response GetResponse(RequestParams requestParams)
        {
            if (!requestParams.Actor.Roles.Contains(UserRoles.Admin))
                return Response.Errored(ResponseStatus.Unauthorized, "Requires Admin permission");
            return _request.GetResponse(requestParams);
        }
    }
}
