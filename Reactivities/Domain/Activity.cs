namespace Domain
{
	public class Activity
	{
		public Activity()
		{
		}

		public Guid Id { get; set; }
		public string? Title { get; set; }
		public DateOnly? Date { get; set; }
		public string? Description { get; set; }
		public string? Categoriy { get; set; }
		public string? City { get; set; }
		public string? Venue { get; set; }



	}

}