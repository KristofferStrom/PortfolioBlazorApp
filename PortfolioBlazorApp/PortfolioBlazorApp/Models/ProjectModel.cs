namespace PortfolioBlazorApp.Models;

public class ProjectModel
{
    public string Id { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string ImageSrc { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string[] Includes { get; set; } = null!;

    public List<ProjectDetailsSection>? DetailsSections { get; set; }
}
