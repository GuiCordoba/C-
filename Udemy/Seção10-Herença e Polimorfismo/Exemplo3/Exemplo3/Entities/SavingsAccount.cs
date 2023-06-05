

namespace Exemplo3.Entities
{
    sealed class SavingsAccount : Account // com o 'sealed' não é mais possivel criar derivações da classe SavingsAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) // com o sealed, não sera mais possivel sobescrever o método Withdraw
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
