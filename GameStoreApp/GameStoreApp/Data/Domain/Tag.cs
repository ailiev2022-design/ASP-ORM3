using System.ComponentModel.DataAnnotations;

namespace GameStoreApp.Data.Domain
{
    public class Tag
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public virtual IEnumerable<GameTag> GameTag { get; set; } = new List<GameTag>();


    }
}
