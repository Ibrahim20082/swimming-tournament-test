using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please enter your email adress")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email adress")]
        public string Email { get; set; }

        [RegularExpression("^\\+?\\d{4,25}$", ErrorMessage = "Please enter a valid phone number")]
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }


        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}
