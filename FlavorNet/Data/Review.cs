using System.ComponentModel.DataAnnotations;

namespace FlavorNet.Data
{
    public class Review
    {
        /// <summary>
        /// Unique identifier.
        /// </summary>
        public int Id { get; set; }

        [Required]

        [StringLength(100, ErrorMessage = "Reviewer cannot exceed 100 characters.")]
        public string? Reviewer { get; set; }

        [StringLength(4096, ErrorMessage = "Comment cannot exceed 4000 characters.")]
        public string? Comment { get; set; }

        //  public string? Sentiment { get; set; }
        public SentimentEnum? Sentiment { get; set; }

        public string? Summary { get; set; }

    }
}

