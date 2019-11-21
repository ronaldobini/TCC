using FluentValidation;
using TCC.Classes;


namespace TCC.Validators
{
    public class CadastroClienteValidator : AbstractValidator<Usuario>
    {
        public CadastroClienteValidator()
        {
            RuleFor(x => x.Login).NotEmpty().NotNull().WithMessage("Informar 'Login' valido");
            RuleFor(x => x.Senha).NotEmpty().NotNull().WithMessage("Informar 'Senha' valida");
            RuleFor(x => x.Numero).NotEmpty().NotNull().GreaterThan(0).WithMessage("Informar um numero residencial valido");
            RuleFor(x => x.Tel1).NotNull().NotEmpty().WithMessage("Informar um numero de telefone valido");
            RuleFor(x => x.Email).NotEmpty().NotNull().WithMessage("Informar um email valido");
            RuleFor(x => x.Endereco).NotEmpty().NotNull().WithMessage("Informe um endereço valido");
            RuleFor(x => x.Cep).NotEmpty().NotNull().WithMessage("Informe um cep valido");





        }
    }
}