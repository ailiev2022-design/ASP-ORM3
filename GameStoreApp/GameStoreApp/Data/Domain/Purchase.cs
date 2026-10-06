using System.ComponentModel.DataAnnotations;

namespace GameStoreApp.Data.Domain
{
    public class Purchase
    {
        public int Id { get; set; }

        public string Type { get; set; } = null!;

        public string ProductKey { get; set; } = null!;

        public DateTime Date { get; set; }

        [Required]
        public int CardId { get; set; }
        public virtual Card Card { get; set; } = null!;

        [Required]
        public int GameId { get; set; }
        public virtual Game Game { get; set; } = null!;
    }
}
