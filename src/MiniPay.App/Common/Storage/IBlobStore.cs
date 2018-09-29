
namespace MiniPay
{
    public interface IBlobStore
    {
        Maybe<byte[]> Get(string id);
        void Put(string id, byte[] bytes);
        void Delete(string id);
    }
}
