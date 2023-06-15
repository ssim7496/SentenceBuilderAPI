using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SentenceBuilderAPI.Models
{
    public class Word
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; } = String.Empty;

        public int WordTypeID { get; set; }
    }
}
