using System.Collections.Generic;
using Kangaroo.Roles.Dto;

namespace Kangaroo.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
