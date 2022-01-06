using System;
using System.ComponentModel.DataAnnotations;

namespace TesteIndra.Models
{
    public class CreditCard
    {

        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public int Cvc { get; set; }
        public string Expiration { get; set; }

    }
}
