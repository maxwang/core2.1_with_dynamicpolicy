using CustomPermission.Models;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomPermission.Extensions
{
    public class PermissionAuthorizationHandler : AttributeAuthorizationHandler<HasPermissionRequirement, PermissionAuthorizeAttribute>
    {
        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        //public override Task HandleAsync(AuthorizationHandlerContext context)
        //{
        //    return base.HandleAsync(context);
        //}

        //public override string ToString()
        //{
        //    return base.ToString();
        //}

        //protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, HasPermissionRequirement requirement, IEnumerable<HasPermissionRequirement> attributes)
        //{
        //    await Task.FromResult(1);
        //    context.Succeed(requirement);
        //}

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, HasPermissionRequirement requirement, IEnumerable<PermissionAuthorizeAttribute> attributes)
        {
            await Task.FromResult(1);
            context.Succeed(requirement);
            //throw new NotImplementedException();
        }
    }
}
