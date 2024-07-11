using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole 
                {
                Id= "79b38cac-6d0d-4eb8-bcb9-8ccff0d30dfc",
                Name="Employee",
                NormalizedName="EMPLOYEE"
                },
                new IdentityRole {
                    Id = "26e8fd60-aa62-4a31-820b-1dc183fa42f3",
                    Name = "Supervior",
                    NormalizedName = "SUPERVISOR"
                },
                new IdentityRole {
                    Id = "d3e226c4-0929-47fb-8169-ff3ecc9db83d",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }                );

            var hasher = new PasswordHasher<IdentityUser>();
            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3cc21aa9-357b-459d-9287-4d0faf140034",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                NormalizedUserName= "ADMIN@LOCALHOST.COM",
                UserName = "admin@localhost.com",
                PasswordHash =hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true
            });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "d3e226c4-0929-47fb-8169-ff3ecc9db83d",
                    UserId = "3cc21aa9-357b-459d-9287-4d0faf140034"
                }
                
                );
        }

        public DbSet <LeaveType> LeaveTypes { get; set; }
    }
}
