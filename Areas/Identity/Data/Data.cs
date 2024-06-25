using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Quiz_Application.Areas.Identity.Data;
using Quiz_Application.Models;

namespace Quiz_Application;

public class Data : IdentityDbContext<Quiz_ApplicationUser>
{
    public Data(DbContextOptions<Data> options)
        : base(options)
    {
    }
    public DbSet<Question> Question { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
