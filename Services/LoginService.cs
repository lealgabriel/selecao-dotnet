using TesteIndra.Interfaces;

namespace TesteIndra.Models
{
    public class LoginService : Ilogin
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
