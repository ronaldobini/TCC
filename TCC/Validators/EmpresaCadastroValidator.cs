using FluentValidation;
using TCC.Classes;

namespace TCC.Validators
{
    public class EmpresaCadastroValidator : AbstractValidator<Empresa>
    {
        public EmpresaCadastroValidator()
        {
            RuleFor(x => x.DescEmpresa).NotEmpty().NotNull().WithMessage("Informar uma descrição de empresa valida");
            RuleFor(x => x.QtdFuncionarios).NotEmpty().NotNull().GreaterThan(0).WithMessage("Informar numeros de funcionarios valido");
            RuleFor(x => x.RazaoSocial).NotEmpty().NotNull().WithMessage("Informar uma razão social valida");
            RuleFor(x => x.Numero).NotEmpty().NotNull().GreaterThan(0).WithMessage("Informar um numero residencial valido");
            RuleFor(x => x.Tel1).NotNull().NotEmpty().WithMessage("Informar um numero de telefone valido");
            RuleFor(x => x.Endereco).NotEmpty().NotNull().WithMessage("Informe um endereço valido");
            RuleFor(x => x.Cep).NotEmpty().NotNull().WithMessage("Informe um cep valido");
        }
    }
}