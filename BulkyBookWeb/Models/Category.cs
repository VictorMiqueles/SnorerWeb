using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        //[Required]
        //public string UserName { get; set; }
        [DisplayName("Posted By")]
        //[Range(1, 100, ErrorMessage = "Must only be in the range of 1 and 100!")]
        public string DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
