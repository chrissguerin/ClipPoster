using ClipPoster.Configurations.API;

namespace ClipPoster.Configurations
{
	public class ContentPoster
	{
		public required string DataFolderName { get; set; }
		public TiktokAPI? TiktokAPI { get; set; }
		public InstagramAPI? InstagramAPI { get; set; }
		public TwitterAPI? TwitterAPI { get; set; }
		public YoutubeAPI? YoutubeAPI { get; set; }
	}
}
