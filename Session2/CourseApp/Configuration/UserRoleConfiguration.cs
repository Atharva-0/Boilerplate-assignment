using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseApp.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {

            //builder.HasNoKey();

            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "eec94afe - 1fb4 - 4666 - 92df - 6ea1a5256d8b",
                    UserId = "ebc94afe - 1fb4 - 4666 - 91df - 6ea1a5256d7b"

                }
                );
        }
    }
}
