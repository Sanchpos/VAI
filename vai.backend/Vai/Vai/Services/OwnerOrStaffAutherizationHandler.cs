using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vai.Data.Models;
using Vai.Data.Models.Authorization;

namespace Vai.Services
{

    public class OwnerOrStaffAutherizationHandler : AuthorizationHandler<OperationAuthorizationRequirement, Person>
    {
        private readonly UserManager<User> _userManager;

        public OwnerOrStaffAutherizationHandler(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorizationRequirement requirement, Person resource)
        {
            var currentUser = await _userManager.GetUserAsync(context.User);
            if (currentUser == null) return;
            if (currentUser.Id == resource.UserId)
            {
                context.Succeed(requirement);
            }
            var isStaff = await _userManager.IsInRoleAsync(currentUser, "staff");
            if (isStaff)
            {
                context.Succeed(requirement);
            }
        }
    }

    public static class Operations
    {
        public static OperationAuthorizationRequirement Create =
            new OperationAuthorizationRequirement { Name = nameof(Create) };
        public static OperationAuthorizationRequirement Read =
            new OperationAuthorizationRequirement { Name = nameof(Read) };
        public static OperationAuthorizationRequirement Update =
            new OperationAuthorizationRequirement { Name = nameof(Update) };
        public static OperationAuthorizationRequirement Delete =
            new OperationAuthorizationRequirement { Name = nameof(Delete) };
    }
}
