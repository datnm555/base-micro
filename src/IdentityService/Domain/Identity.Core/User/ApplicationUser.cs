using Microsoft.AspNetCore.Identity;

namespace Identity.Core.User;

public class ApplicationUser : IdentityUser
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}