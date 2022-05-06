using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FAQs.Models
{
    public class Topic
    {
        // primary key must be user friendly in a URL
        public string TopicId { get; set; }
        public string TName { get; set; }


    }
}
