using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Kangaroo.EntityFrameworkCore
{
    public static class KangarooDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<KangarooDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<KangarooDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
