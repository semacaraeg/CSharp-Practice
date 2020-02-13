﻿using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.IdentityPolicy
{
    public class AllowUserPolicy : IAuthorizationRequirement
    {
        public string[] AllowUsers { get; set; }

        public AllowUserPolicy(params string[] users)
        {
            AllowUsers = users;
        }
    }

    public class AllowUsersHandler : AuthorizationHandler<AllowUserPolicy>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AllowUserPolicy requirement)
        {
            if (requirement.AllowUsers.Any(user => user.Equals(context.User.Identity.Name, StringComparison.OrdinalIgnoreCase)))
            {
                context.Succeed(requirement);
            }
            else
            {
                context.Fail();
            }
            return Task.CompletedTask;
        }
    }
}
