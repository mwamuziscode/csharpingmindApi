using System;
using System.Text.Json.Serialization;

namespace csharpingmindApi.Models
{
    public class BlogPost
    {
        public long Id { get; set; }

        [JsonRequired]
        public string Title { get; set; } = string.Empty;

        [JsonRequired]
        public string Images { get; set; } = string.Empty;

        public DateTime UpdatedOn { get; set; }

        [JsonRequired]
        public string Content { get; set; } = string.Empty;

        public DateTime CreatedOn { get; set; }

        [JsonRequired]
        public int Status { get; set; }

        [JsonRequired]
        public int AuthorId { get; set; }

        [JsonIgnore]
        public virtual User? Author { get; set; }
    }
}
