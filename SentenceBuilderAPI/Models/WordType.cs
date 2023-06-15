using System.ComponentModel.DataAnnotations;

namespace SentenceBuilderAPI.Models
{
    public class WordType
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; } = String.Empty;
    }
}
