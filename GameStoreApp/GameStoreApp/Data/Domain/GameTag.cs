using System.ComponentModel.DataAnnotations;

namespace GameStoreApp.Data.Domain
{
    public class GameTag
    {
        public int Id { get; set; }

        [Required]
        public int GameId { get; set; }
        public virtual Game Game { get; set; } = null!;

        [Required]
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; } = null!;

        public virtual IEnumerable<Game> Games { get; set; } = new List<Game>();
    }
}
