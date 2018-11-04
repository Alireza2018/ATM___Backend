using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtmMachine.Entities;

namespace AtmMachine.DAL
{
    public interface IAtmMachineRepository
    {
        UserDetails GetUser(int pinCode);
        ProfileDetails GetUerProfile(Guid profileId);
        ProfileDetails UpdateProfile(ProfileDetails newProfile);
        List<GiftCardDetails> GetAllGiftCards();
    }
}
