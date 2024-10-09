using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_12.Models
{
    public class PharmacistM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int PharmacyId { get; set; }
        public string Name { get; set; }
        public double Oklad { get; set; }
    }
}
