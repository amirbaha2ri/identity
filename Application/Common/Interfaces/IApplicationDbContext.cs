using Domain.Models.UserRoles;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<UserRole> UserRoles { get; }
    DbSet<IdentityUser> IdentityUsers { get; }
    DbSet<IdentityUserClaim<string>> IdentityUserClaims { get; }
}