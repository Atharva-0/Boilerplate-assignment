using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseApp.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var hasher = new PasswordHasher<IdentityUser>();
            builder.HasData(
                 new IdentityUser
                 {
                     Id = "ebc94afe - 1fb4 - 4666 - 91df - 6ea1a5256d7b",
                     UserName = "admin@gmail.com",
                     NormalizedUserName = "ADMIN@GMAIL.COM",
                     Email = "admin@gmail.com",
                     PasswordHash = hasher.HashPassword(null, "Atharva@123")
                 });
        }
    }
}
