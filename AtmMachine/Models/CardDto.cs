using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtmMachine.Models
{
    public class CardDto
    {
        public Guid GiftCardId { get; set; }

        public String CardNumber { get; set; }

        public int Amount { get; set; }
    }
}
