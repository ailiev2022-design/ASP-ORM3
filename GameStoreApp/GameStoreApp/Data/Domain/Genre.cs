using System.ComponentModel.DataAnnotations;

namespace GameStoreApp.Data.Domain
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; } = null!;

        public virtual IEnumerable<Game> Games { get; set; } = new List<Game>();



    }
}
