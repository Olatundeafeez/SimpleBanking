using System.ComponentModel.DataAnnotations;

namespace SimpleBanking.Controllers.Model
{
    public class Account
    {
        [Key]
        public Guid Id  { get; set; }
        [Required, Length(10,10)]
        public string AccountName { get; set; }
        public string Email{ get; set; }
        public string AccountNumber { get; set; }
        public double AccountBalance { get; set; } = 0;

    }
}
