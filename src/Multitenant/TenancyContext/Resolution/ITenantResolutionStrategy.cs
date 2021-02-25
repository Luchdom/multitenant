using System.Threading.Tasks;

namespace Multitenant.TenancyContext.Resolution
{
    public interface ITenantResolutionStrategy
    {
        Task<string> GetTenantIdentifierAsync();
    }
}