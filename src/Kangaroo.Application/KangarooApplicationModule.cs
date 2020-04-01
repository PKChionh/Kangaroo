using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Kangaroo.Authorization;

namespace Kangaroo
{
    [DependsOn(
        typeof(KangarooCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class KangarooApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<KangarooAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(KangarooApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
