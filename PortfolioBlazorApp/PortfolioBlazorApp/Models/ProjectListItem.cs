namespace PortfolioBlazorApp.Models;

public class ProjectListItem
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string ImageSrc { get; set; } = null!;
    public string Title { get; set; } = null!;
    public List<string>? Tags { get; set; }
}
