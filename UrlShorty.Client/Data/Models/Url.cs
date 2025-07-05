namespace UrlShorty.Client.Data.Models
{
	public class Url
	{
		// Unique identifier for the URL entity
		public Guid Id { get; set; }

		// The original, long URL to be shortened
		public string? OriginalUrl { get; set; }

		// The generated short code or token
		public string? ShortenedUrl { get; set; }

		// Date and time when the short URL was created
		public DateTime? CreatedOn { get; set; }

		// Date and time when the short URL was updated
		public DateTime? UpdatedOn { get; set; }

		// User or owner information, when authentication is used
		public string? UserId { get; set; }

		// Expiration date for the short URL
		public DateTime? ExpirationDate { get; set; }

		// Number of times the short URL has been accessed
		public int ClickCount { get; set; } = 0;

		public Url()
		{
			// Initialize CreatedOn and UpdatedOn to the current date and time
			CreatedOn = DateTime.UtcNow;
			UpdatedOn = DateTime.UtcNow;
			Id = Guid.NewGuid();
		}
	}
}
