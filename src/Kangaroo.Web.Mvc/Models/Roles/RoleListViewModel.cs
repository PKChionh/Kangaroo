using System.Collections.Generic;
using Kangaroo.Roles.Dto;

namespace Kangaroo.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
