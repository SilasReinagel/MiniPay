using MiniPay;

namespace MiniPay.App.Requests
{
    public interface IRequest
    {
        Response GetResponse(RequestParams requestParams);
    }
}
