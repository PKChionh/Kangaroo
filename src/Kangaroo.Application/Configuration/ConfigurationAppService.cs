using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Kangaroo.Configuration.Dto;

namespace Kangaroo.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : KangarooAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
