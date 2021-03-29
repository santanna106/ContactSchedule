using AgendaContato.MVCTest.ViewsModel;
using FluentValidation;

namespace AgendaContato.MVCTest.Validation
{
    public class ContactValidation : AbstractValidator<ContactViewModel>
    {
        public ContactValidation()
        {
            RuleFor(contact => contact.Name).NotNull().NotEmpty().WithMessage("Digite o nome do Contato");
            RuleFor(contact => contact.Phone).NotNull().NotEmpty().WithMessage("Digite o telefone do Contato");
        }
    }
}
