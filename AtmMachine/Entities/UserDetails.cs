using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AtmMachine.Entities
{
    public class UserDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }

        [ForeignKey("ProfileId")]
        public Guid ProfileId { get; set; }

        public int PinCode { get; set; } 
    }
}
