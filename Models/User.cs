using TodoApi.Enums;
using Microsoft.AspNetCore.Identity;

namespace TodoApi.Models;

public class User
{
    public long UserId { get; set; }
    public required string Username { get; set; }

    public required string Phone { get; set; }

    public required string Password { get; set; }
    public Role Role { get; set; }
}