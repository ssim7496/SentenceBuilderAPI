using System.ComponentModel.DataAnnotations;

namespace SentenceBuilderAPI.Models
{
    public class Sentence
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; } = String.Empty;
    }
}
