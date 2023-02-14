using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstASPNETWebApp.Models
{
    public class FanMailModel
    {
        [Required] //// validation
        public string From { get; set; }
        public string Subject { get; set; }
        [Required]
        [MaxLength(25)]
        public string Message { get; set; }
    }
}