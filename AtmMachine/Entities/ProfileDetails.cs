using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtmMachine.Entities
{
    public class ProfileDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProfileId { get; set; }

        public String Name { get; set; }

        public String Address { get; set; }

        public String PhoneNumber { get; set; }
    }
}
