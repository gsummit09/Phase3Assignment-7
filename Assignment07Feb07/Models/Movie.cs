using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment07Feb07.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string? MName { get; set; }
        [StringLength(50)]
        public string? StarCast { get; set; }
        [StringLength(50)]
        public string? Director { get; set; }
        [StringLength(50)]
        public string? Producer { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
