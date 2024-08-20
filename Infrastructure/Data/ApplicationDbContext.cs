using System.Reflection;
using Application.Common.Interfaces;
using Domain.Models.UserRoles;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<UserRole> UserRoles => Set<UserRole>();
    public DbSet<IdentityUser> IdentityUsers => Set<IdentityUser>();
    public DbSet<IdentityUserClaim<string>> IdentityUserClaims => Set<IdentityUserClaim<string>>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }
}