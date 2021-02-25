using System.Threading.Tasks;

namespace Multitenant.TenancyContext.Data
{
    public interface ITenantStore<T> where T : Tenant
    {
        Task<T> GetTenantAsync(string identifier);
    }
}