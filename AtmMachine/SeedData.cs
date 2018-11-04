using AtmMachine.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtmMachine
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDetails>().HasData(
                new UserDetails
                {
                    UserId = new Guid("cfc64e1f-65b7-448a-a280-ea09f2a6693f"),
                    ProfileId = new Guid("fa86431a-4029-4942-afab-daf566d2818e"),
                    PinCode = 4060
                }
            );

            modelBuilder.Entity<ProfileDetails>().HasData(
                new ProfileDetails
                {
                    ProfileId = new Guid("fa86431a-4029-4942-afab-daf566d2818e"),
                    Name = "Alireza Shoaei",
                    Address = "Olav M.Troviks Vei 48, H0108",
                    PhoneNumber = "48686475"
                }
            );

            modelBuilder.Entity<GiftCardDetails>().HasData(
                new GiftCardDetails
                {
                    GiftCardId = new Guid("e652001d-8d64-4118-ac58-62b90a93c4da"),
                    CardNumber = "6104337968574416",
                    Amount = 50
                },
                new GiftCardDetails
                {
                    GiftCardId = new Guid("52ca9ed2-a192-4d5f-bebf-4b9d5c879436"),
                    CardNumber = "6104337968575519",
                    Amount = 150
                },
                new GiftCardDetails
                {
                    GiftCardId = new Guid("ca13a3d2-4fd9-4d8a-8789-6ef8c9f8bfb4"),
                    CardNumber = "6104337968576728",
                    Amount = 250
                },
                new GiftCardDetails
                {
                    GiftCardId = new Guid("fc64e1f4-65b7-448a-a280-ea09f2a6693f"),
                    CardNumber = "6104570268579001",
                    Amount = 500
                }
            );
        }
    }
}
