using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using inner.masterApi.Authorization.Roles;
using inner.masterApi.Authorization.Users;
using inner.masterApi.MultiTenancy;

namespace inner.masterApi.EntityFrameworkCore
{
    public class masterApiDbContext : AbpZeroDbContext<Tenant, Role, User, masterApiDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public masterApiDbContext(DbContextOptions<masterApiDbContext> options)
            : base(options)
        {
        }
    }
}
