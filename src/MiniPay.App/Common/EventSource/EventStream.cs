using System.Collections.Generic;

namespace MiniPay
{
    public struct EventStream
    {
        public string Id { get; set; }
        public IEnumerable<Event> Events { get; set; }        
    }
}
