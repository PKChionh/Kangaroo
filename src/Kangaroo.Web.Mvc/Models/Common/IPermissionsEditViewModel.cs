using System.Collections.Generic;
using Kangaroo.Roles.Dto;

namespace Kangaroo.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}