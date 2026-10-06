using System.ComponentModel.DataAnnotations;

namespace GameStoreApp.Data.Domain
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Ussrname { get; set; } = null!;
        [Required]
        [MaxLength(30)]
        public string FullName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public int Age { get; set; }

        public virtual IEnumerable<Card> Card { get; set; } = new List<Card>();
    }
}
