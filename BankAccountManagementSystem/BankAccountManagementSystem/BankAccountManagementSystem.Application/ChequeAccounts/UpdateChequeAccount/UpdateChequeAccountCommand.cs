using BankAccountManagementSystem.Application.Common.Interfaces;
using BankAccountManagementSystem.Domain;
using Intent.RoslynWeaver.Attributes;
using MediatR;

[assembly: DefaultIntentManaged(Mode.Fully)]
[assembly: IntentTemplate("Intent.Application.MediatR.CommandModels", Version = "1.0")]

namespace BankAccountManagementSystem.Application.ChequeAccounts.UpdateChequeAccount
{
    public class UpdateChequeAccountCommand : IRequest, ICommand
    {
        public UpdateChequeAccountCommand(long id,
            ChequeAccountType type,
            string currencyIsoCode,
            decimal balance,
            long accountHolderId)
        {
            Id = id;
            Type = type;
            CurrencyIsoCode = currencyIsoCode;
            Balance = balance;
            AccountHolderId = accountHolderId;
        }

        public long Id { get; set; }
        public ChequeAccountType Type { get; set; }
        public string CurrencyIsoCode { get; set; }
        public decimal Balance { get; set; }
        public long AccountHolderId { get; set; }
    }
}