using AtmMachine.Entities;
using AtmMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtmMachine.DAL
{
    public class AtmMachineRepository : IAtmMachineRepository
    {
        private AtmContext _context;

        public AtmMachineRepository(AtmContext context)
        {
            _context = context;
        }

        public UserDetails GetUser(int pinCode)
        {
            var user = _context.UserDetails
                               .Where(u => u.PinCode == pinCode)
                               .FirstOrDefault<UserDetails>();

            return user;
        }
        
        public ProfileDetails GetUerProfile(Guid profileId)
        {
            var userProfile = _context.ProfileDetails
                                    .Where(p => p.ProfileId == profileId)
                                    .FirstOrDefault<ProfileDetails>();
            return userProfile;
        }

        public ProfileDetails UpdateProfile(ProfileDetails newProfile)
        {
            _context.Update(newProfile);
            _context.SaveChanges();

            return newProfile;
        }

        public List<GiftCardDetails> GetAllGiftCards()
        {
            var cards = _context.GiftCardDetails;
                                
            return cards.ToList();
        }
    }
}
