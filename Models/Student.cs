using TesteIndra.Interfaces;

namespace TesteIndra.Models
{
    public class Student : Ilogin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; } = "student";
        public CreditCard CreditCard { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
