using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int ApplicationID { get; set; }
        public string FirstName { get; set; }
        // validation in the controller (check if valid) then validation summary on html page
        [Required(ErrorMessage ="Hey, you fool! You need to enter a last name")]
        public string LastName { get; set; }
        public byte Age { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        public bool CreeperStalker { get; set; }

        // Build Foreign Key Relationship
        public int MajorId { get; set; }
        public Major Major { get; set; }
    }
}
