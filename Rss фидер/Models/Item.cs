namespace Rss_фидер.Models
{
    public class Item
    {
        public string? Title { get; set; }
        public string? PubDate { get; set; }
        public string? Link { get; set; }
        public string? Description { get; set; }
        public string? HtmlTitle { get; set; }
        public string ChannelUrl { get; set; }
        public int ChannelId { get; set; }
    }
}
