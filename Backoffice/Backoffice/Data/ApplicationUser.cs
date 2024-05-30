using Microsoft.AspNetCore.Identity;

namespace Backoffice.Data;

//Dessa är admins
public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public int? RoleId { get; set; }
    public RoleEntity? Role { get; set; }
}
