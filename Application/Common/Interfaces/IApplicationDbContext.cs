using Domain.Models.UserRoles;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<UserRole> UserRoles { get; }
}