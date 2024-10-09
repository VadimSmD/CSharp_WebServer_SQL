using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_12.Models
{
    public class SupplyM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int PharmacyId { get; set; }
        public string Suppliments { get; set; }

    }

}
