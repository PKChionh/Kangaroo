using System.Threading.Tasks;
using Kangaroo.Configuration.Dto;

namespace Kangaroo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
