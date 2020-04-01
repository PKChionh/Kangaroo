using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Kangaroo.Configuration;
using Kangaroo.Web;

namespace Kangaroo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class KangarooDbContextFactory : IDesignTimeDbContextFactory<KangarooDbContext>
    {
        public KangarooDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<KangarooDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            KangarooDbContextConfigurer.Configure(builder, configuration.GetConnectionString(KangarooConsts.ConnectionStringName));

            return new KangarooDbContext(builder.Options);
        }
    }
}
