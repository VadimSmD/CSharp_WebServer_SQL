using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_12.Models
{
    public class PharmacyM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int PharmacistId { get; set; }
        public int SupplyId { get; set; }
        public string Address { get; set; }
        public double Doxod { get; set; }
    }
}
