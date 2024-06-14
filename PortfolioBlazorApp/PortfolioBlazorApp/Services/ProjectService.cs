using PortfolioBlazorApp.Models;

namespace PortfolioBlazorApp.Services;

public class ProjectService
{
    public List<ProjectListItem> GetProjects()
    {
        return
        [
            new ProjectListItem
            {
                ImageSrc = "/images/silicon.png",
                Title = "Silicon - .NET MVC Project",
                Tags = ["ASP.NET MVC", "Web Api", "Dependency injections", "Figma", "Services", "SqlServer", "Identity", "Javascript", "SASS", "Factories", "Repositories", "Generics"]
            },
            new ProjectListItem
            {
                ImageSrc = "/images/laptop.jpg",
                Title = "Project 2",
                Tags = ["ASP.NET MVC", "Web Api", "Dependency injections", "Figma", "Services", "SqlServer", "Identity", "Javascript", "SASS", "Factories", "Repositories", "Generics"]

            },
            new ProjectListItem
            {
                ImageSrc = "/images/laptop.jpg",
                Title = "Project 3",
                Tags = ["ASP.NET MVC", "Web Api", "Dependency injections", "Figma", "Services", "SqlServer", "Identity", "Javascript", "SASS", "Factories", "Repositories", "Generics"]

            },
            new ProjectListItem
            {
                ImageSrc = "/images/laptop.jpg",
                Title = "Project 3",
                Tags = ["ASP.NET MVC", "Web Api", "Dependency injections", "Figma", "Services", "SqlServer", "Identity", "Javascript", "SASS", "Factories", "Repositories", "Generics"]

            }
        ];
    }
}
