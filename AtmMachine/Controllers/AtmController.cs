using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtmMachine.DAL;
using AtmMachine.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace AtmMachine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtmController : ControllerBase
    {
        private readonly IAtmMachineRepository _atmMachineRepository;

        public AtmController(IAtmMachineRepository atmMachineRepository)
        {
            _atmMachineRepository = atmMachineRepository;
        }
        
        [HttpPost("{UserLogin}")]
        public ActionResult UserLogin([FromBody] JObject input)
        {

            int pinCode = (int) input.GetValue("pinCode");

            var user = _atmMachineRepository.GetUser(pinCode);

            if(user == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(user);
            }
        }

        [HttpGet("{GiftCards}")]
        public ActionResult GiftCards()
        {
            var giftCards = _atmMachineRepository.GetAllGiftCards();

            return Ok(giftCards);
        }

        [HttpPut("{Profile}/{profileId}")]
        public ActionResult UpdateProfile(Guid profileId, [FromBody] ProfileDto newProfile)
        {
            var userProfile = _atmMachineRepository.GetUerProfile(profileId);
            if(userProfile == null)
            {
                return NotFound();
            }

            userProfile.Name = newProfile.Name;
            userProfile.Address = newProfile.Address;
            userProfile.PhoneNumber = newProfile.PhoneNumber;

            return Ok(_atmMachineRepository.UpdateProfile(userProfile));
        }
    }
}