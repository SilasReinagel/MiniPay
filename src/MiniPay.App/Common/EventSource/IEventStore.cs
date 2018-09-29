using System.Collections.Generic;

namespace MiniPay
{
    public interface IEventStore
    {
        void Commit(IEnumerable<Event> events);
        IEnumerable<Event> GetEvents<T>(string entityId);
        IEnumerable<EventStream> GetEvents<T>();
    }
}
