//Created By Engin Yenice
//enginyenice2626@gmail.com

using Entities.Dtos;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserForLoginValidator : AbstractValidator<UserForLoginDto>
    {
        public UserForLoginValidator()
        {
            RuleFor(p => p.Email).EmailAddress();
            RuleFor(p => p.Password).MinimumLength(8);
            RuleFor(p => p.Password).NotNull();
            RuleFor(p => p.Password).NotEmpty();
        }
    }
}