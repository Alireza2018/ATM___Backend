using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AtmMachine.Entities
{
    public class GiftCardDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid GiftCardId { get; set; }

        public String CardNumber { get; set; }

        public int Amount { get; set; }
    }
}
