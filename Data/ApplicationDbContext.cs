using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TodoApi.Enums;
using TodoApi.Models;

namespace TodoApi.Data;

public class ApplicationDbContext : DbContext
{

    public DbSet<Page> Pages => Set<Page>();
    public DbSet<User> Users => Set<User>();

    public DbSet<TodoItem> TodoItems { get; set; } = null!;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
     : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}