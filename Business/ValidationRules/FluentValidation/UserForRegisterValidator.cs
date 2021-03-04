//Created By Engin Yenice
//enginyenice2626@gmail.com

using Entities.Dtos;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserForRegisterValidator : AbstractValidator<UserForRegisterDto>
    {
        public UserForRegisterValidator()
        {
            RuleFor(p => p.Email).EmailAddress();
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.FirstName).NotNull();
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.LastName).NotNull();
            RuleFor(p => p.Password).MinimumLength(8);
            RuleFor(p => p.Password).NotNull();
            RuleFor(p => p.Password).NotEmpty();
        }
    }
}