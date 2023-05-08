

namespace Exercicio_3.Entities
{
    internal class Client
    {
        public string NameClient { get; set; }
        public string Email { get; set; }
        public DateOnly DateOfBirth { get; set; }

        public Client()
        {

        }

        public Client(string nameClient, string email, DateOnly dateOfBirth)
        {
            NameClient = nameClient;
            Email = email;
            DateOfBirth = dateOfBirth;
        }
    }
}
