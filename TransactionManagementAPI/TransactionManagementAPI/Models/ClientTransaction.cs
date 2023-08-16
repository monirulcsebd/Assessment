using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TransactionManagementAPI.Models
{
    public class ClientTransaction
    {
        [Key]
        public long TransactionId { get; set; } = 0;
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Account Number")]
        public long AccountNo { get; set; }
        public decimal transactionAmount { get; set; }
        public decimal InitialAccountBalance { get; set; }
        public string TransactionDescription { get; set; } = null!;
        [Required(ErrorMessage = "This field is required.")]
        public string TransactionType { get; set; }=null!;//T=transfer and C=cash
        [Required(ErrorMessage = "This field is required.")]
        public string DebitOrCredit { get; set; } = null!; //Debit=D and Credit=C

        public DateTime TransactionDate { get; set; }= DateTime.Now;

    }
}
