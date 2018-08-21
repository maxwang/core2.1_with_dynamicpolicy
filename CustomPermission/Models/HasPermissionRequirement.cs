using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomPermission.Models
{
    public class HasPermissionRequirement: IAuthorizationRequirement
    {
        public string PermissionSet { get; }
        public string Permission { get; }

        public HasPermissionRequirement(string permissionSet, string permission)
        {
            PermissionSet = permissionSet ?? throw new ArgumentNullException(nameof(permissionSet));
            Permission = permission ?? throw new ArgumentNullException(nameof(permission));
        }
    }
}
