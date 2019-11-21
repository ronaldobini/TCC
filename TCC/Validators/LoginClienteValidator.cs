using FluentValidation;
using TCC.Classes;

namespace TCC.Validators
{
    public class LoginClienteValidator : AbstractValidator<Usuario>
    {
        public LoginClienteValidator()
        {
            RuleFor(x => x.Login).NotEqual("").WithMessage("Preencher login valido.");
            RuleFor(x => x.Senha).NotEmpty().WithMessage("Preencher senha valida.");

        }
    }
}