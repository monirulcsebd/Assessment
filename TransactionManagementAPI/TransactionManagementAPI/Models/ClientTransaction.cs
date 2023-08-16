using System.ComponentModel.DataAnnotations;

namespace TransactionManagementAPI.Models
{
    public class ClientTransaction
    {
        [Key]
        public long TransactionId { get; set; } = 0;
        [Required]
        public long AccountNo { get; set; }
        public decimal transactionAmount { get; set; }
        public decimal InitialAccountBalance { get; set; }
        public string TransactionDescription { get; set; } = null!;
        [Required]
        public string TransactionType { get; set; }=null!;//T=transfer and C=cash
        [Required]
        public string DebitOrCredit { get; set; } = null!; //Debit=D and Credit=C

        public DateTime TransactionDate { get; set; }= DateTime.Now;

    }
}
