using System.ComponentModel.DataAnnotations;

namespace Common.Entity
{
    public class AdvertisingCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
