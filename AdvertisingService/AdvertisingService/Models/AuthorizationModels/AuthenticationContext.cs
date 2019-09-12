using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AdvertisingService.Models
{
    public class AuthenticationContext : IdentityDbContext
    {
        public AuthenticationContext(DbContextOptions<AuthenticationContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole[]
                {
                    new IdentityRole { Id="1", Name="Admin", NormalizedName="ADMIN"},
                    new IdentityRole { Id="2", Name="User", NormalizedName="USER"}
                });

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser[]
                {
                    new ApplicationUser{ UserName="admin", NormalizedUserName="ADMIN",
                        Email ="admin@admin.com", NormalizedEmail="ADMIN@ADMIN.COM",
                        PasswordHash ="AQAAAAEAACcQAAAAENLC13AVzOAC/y2EXdKna8vf2Je5j+yPwM7HczOyZTIkZwxo7/4QIdciwGtVvHeK+A==",
                        FullName = "Admin"},
                    new ApplicationUser{ UserName="user", NormalizedUserName="USER",
                        PasswordHash="AQAAAAEAACcQAAAAEJEtLnTWRvn3wp9QQaA1GFJoA7adXXN6DQlDiwiGYezZSgifA1kelWmVwfNPzQlXqg=="}
                });
        }
    }
}
