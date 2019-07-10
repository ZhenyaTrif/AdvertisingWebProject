using System.ComponentModel.DataAnnotations;

namespace Common.Entity
{
    public class AdvertisingModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Text { get; set; }

        public string ImagePath { get; set; }

        [Required]
        public int AdvertisingCategoryId { get; set; }
    }
}
