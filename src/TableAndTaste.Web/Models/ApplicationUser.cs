using Microsoft.AspNetCore.Identity;

namespace TableAndTaste.Web.Models;

public class ApplicationUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;
}
