using System.ComponentModel.DataAnnotations;

namespace Lesson6_asp_hw.Validations.DataAnnotations
{
    public class UserValidation
    {
        [MinLength(3, ErrorMessage = "Ad 3 herfden az ola bilmez...")]
        [MaxLength(10, ErrorMessage = "Ad 10 herfden cox ola bilmez...")]

        public string? Name { get; set; }

        [MinLength(3, ErrorMessage = "Soyad 3 herfden az ola bilmez...")]
        [MaxLength(10, ErrorMessage = "Soyad 10 herfden cox ola bilmez...")]
        public string? Surname { get; set; }

        [RegularExpression("^(1[89]|[2-5][0-9]|6[0-5])$", ErrorMessage = "Yas 18-65 araliginda ola biler...")]
        public string? Age { get; set; }

        [EmailAddress(ErrorMessage = "Duzgun email daxil edin...")]
        public string? Email { get; set; }

        [MinLength(6, ErrorMessage = "Parol 6 herfden az ola bilmez...")]
        [MaxLength(10, ErrorMessage = "Parol 10 herfden cox ola bilmez...")]

        public string? Password { get; set; }
        [Phone(ErrorMessage = "Duzgun nomre daxil edin...")]
        public string? Phone { get; set; }

    }
}
