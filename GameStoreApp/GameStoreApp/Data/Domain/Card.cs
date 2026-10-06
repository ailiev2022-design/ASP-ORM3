using System.ComponentModel.DataAnnotations;

namespace GameStoreApp.Data.Domain
{
    public class Card
    {
        public int Id { get; set; }

        [Required]
        public string Number { get; set; } = null!;

        public string Cvc { get; set; } = null!;

        public string Type { get; set; } = null!;

        [Required]
        public int UserdId { get; set; }
        public virtual User User { get; set; } = null!;

        public virtual IEnumerable<Purchase> Purchase { get; set; } = new List<Purchase>();
    }
}
