
namespace MiniPay
{
    public interface IMonitoredComponent
    {
        string Name { get; }
        HealthStatus GetStatus();
    }
}
