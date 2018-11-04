using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtmMachine.Models
{
    public class UserDto
    {
        public Guid UserId { get; set; }

        public Guid ProfileId { get; set; }
    }
}
