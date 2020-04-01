using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Kangaroo.Configuration;

namespace Kangaroo.Web.Host.Startup
{
    [DependsOn(
       typeof(KangarooWebCoreModule))]
    public class KangarooWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public KangarooWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(KangarooWebHostModule).GetAssembly());
        }
    }
}
