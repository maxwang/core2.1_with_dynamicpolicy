using CustomPermission.Data;
using CustomPermission.Models;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomPermission.Extensions
{
    public class PermissionHandler : AuthorizationHandler<HasPermissionRequirement>
    {
        private readonly ApplicationDbContext _db;
        public PermissionHandler(ApplicationDbContext db)
        {
            //here just want to test DI, 
            _db = db;
        }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, HasPermissionRequirement requirement)
        {
            var user = context.User;
            var userId = user.Identity;
            return Task.CompletedTask;
        }
    }
}
