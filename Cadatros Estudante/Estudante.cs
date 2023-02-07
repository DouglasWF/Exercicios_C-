using System.Globalization;

namespace Course
{
    internal class Calculator
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Calculator (string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
