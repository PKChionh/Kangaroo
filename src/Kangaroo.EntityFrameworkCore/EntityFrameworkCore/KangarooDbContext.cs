using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Kangaroo.Authorization.Roles;
using Kangaroo.Authorization.Users;
using Kangaroo.MultiTenancy;

namespace Kangaroo.EntityFrameworkCore
{
    public class KangarooDbContext : AbpZeroDbContext<Tenant, Role, User, KangarooDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public KangarooDbContext(DbContextOptions<KangarooDbContext> options)
            : base(options)
        {
        }
    }
}
