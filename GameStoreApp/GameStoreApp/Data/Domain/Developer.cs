using System.ComponentModel.DataAnnotations;

namespace GameStoreApp.Data.Domain
{
    public class Developer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public virtual IEnumerable<Game> Games { get; set; } = new List<Game>();


    }
}
