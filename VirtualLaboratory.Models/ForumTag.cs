using System.ComponentModel.DataAnnotations;

namespace VirtualLaboratory.Models
{
    public class ForumTag
    {

        public string Id { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(100, MinimumLength = 10, ErrorMessage ="полето трябва да е между 10 и 100 символа ")]
        public string Name { get; set; }
    }
}