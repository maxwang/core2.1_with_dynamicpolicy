using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomPermission.Extensions
{
    public class PermissionAuthorizeAttribute : AuthorizeAttribute
    {
        public PermissionAuthorizeAttribute(string permissionSet, string permissionValue)
        {
            if (string.IsNullOrEmpty(permissionSet) || string.IsNullOrEmpty(permissionValue))
            {
                throw new ArgumentNullException("Permission Set and Permission Value are required.");
            }
            var resourceName = string.Format("{0}====={1}", permissionSet, permissionValue);
            Policy = resourceName;
        }

    }
}
