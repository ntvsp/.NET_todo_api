using TodoApi.Enums;
using Microsoft.AspNetCore.Identity;

namespace TodoApi.Models;

public class User : IdentityUser
{
    public Role Role { get; set; }
}