using FluentValidation;
using Lesson6_asp_hw.Models;
using System.Text.RegularExpressions;

namespace Lesson6_asp_hw.Validations.FluentValidations
{
    public class UserValidator : AbstractValidator<UserForFluent>
    {
        public UserValidator()
        {
           
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Email format is incorrect.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters long.")
                .Matches("[a-z]").WithMessage("Password must contain at least 1 lowercase letter.")
                .Matches("[0-9]").WithMessage("Password must contain at least 1 digit.");


        }
    }
}
