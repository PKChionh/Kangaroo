using Abp.Authorization;
using Kangaroo.Authorization.Roles;
using Kangaroo.Authorization.Users;

namespace Kangaroo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
