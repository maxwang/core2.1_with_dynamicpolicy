using CustomPermission.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomPermission.Extensions
{
    public class AuthorizationPolicyProvider: DefaultAuthorizationPolicyProvider
    {
        private readonly AuthorizationOptions _options;
        private static object _myLock = new object();

        public AuthorizationPolicyProvider(IOptions<AuthorizationOptions> options) : base(options)
        {
            _options = options.Value;
        }

        public override async Task<AuthorizationPolicy> GetPolicyAsync(string policyName)
        {
            
            var policy = await base.GetPolicyAsync(policyName);

            if (policy == null)
            {
                string[] resourceValues = policyName.Split(new string[] { "=====" }, StringSplitOptions.RemoveEmptyEntries);

                if (resourceValues.Length > 1)
                {
                    policy = new AuthorizationPolicyBuilder()
                    .AddRequirements(new HasPermissionRequirement(resourceValues[0], resourceValues[1]))
                    .Build();

                    _options.AddPolicy(policyName, policy);
                }

                // Add policy to the AuthorizationOptions, so we don't have to re-create it each time
                
            }

            return policy;
        }

    }
}
