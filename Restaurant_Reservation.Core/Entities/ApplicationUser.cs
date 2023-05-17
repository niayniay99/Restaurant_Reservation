using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Reservation.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
        public DateTime JoinedDate { get; set; }

        [NotMapped]
        public string Role { get; set; }
        public bool isSubscriber { get; set; }

    }
}
