using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAQs.Models
{
    public class Category
    {
        // primary key must be user friendly in a URL
        public string? CategoryId { get; set; }
        public string? CName { get; set; }

    }
}
