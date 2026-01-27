using Lesson6_asp_hw.Validations.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Lesson6_asp_hw.Models
{
    [ModelMetadataType(typeof(UserValidation))]

    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

    }
}
