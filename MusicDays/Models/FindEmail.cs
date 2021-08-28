using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicDays.Models
{
    public class FindEmail
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
