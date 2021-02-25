namespace Multitenant.TenancyContext
{
    public interface ITenantAccessor<T> where T : Tenant
    {
        T Tenant { get; }
    }
}