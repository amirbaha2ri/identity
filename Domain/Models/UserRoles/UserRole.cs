using Domain.Models.Common;

namespace Domain.Models.UserRoles;

public class UserRole : BaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}