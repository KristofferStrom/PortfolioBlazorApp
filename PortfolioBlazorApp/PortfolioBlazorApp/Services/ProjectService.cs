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
                Id = "Silicon",
                ImageSrc = "/images/silicon.png",
                Title = "Silicon - .NET MVC Project",
                Tags = ["ASP.NET MVC", "Web Api", "Dependency injections", "Figma", "Services", "SqlServer", "Identity", "Javascript", "SASS", "Factories", "Repositories", "Generics"]
            },
            new ProjectListItem
            {
                Id = "Silicon2",
                ImageSrc = "/images/laptop.jpg",
                Title = "Project 2",
                Tags = ["ASP.NET MVC", "Web Api", "Dependency injections", "Figma", "Services", "SqlServer", "Identity", "Javascript", "SASS", "Factories", "Repositories", "Generics"]

            },
            new ProjectListItem
            {
                Id = "Silicon3",
                ImageSrc = "/images/laptop.jpg",
                Title = "Project 3",
                Tags = ["ASP.NET MVC", "Web Api", "Dependency injections", "Figma", "Services", "SqlServer", "Identity", "Javascript", "SASS", "Factories", "Repositories", "Generics"]

            },
            new ProjectListItem
            {
                Id = "Silicon4",
                ImageSrc = "/images/laptop.jpg",
                Title = "Project 3",
                Tags = ["ASP.NET MVC", "Web Api", "Dependency injections", "Figma", "Services", "SqlServer", "Identity", "Javascript", "SASS", "Factories", "Repositories", "Generics"]

            }
        ];
    }

    public List<ProjectModel> GetProjectModels()
    {
        return
        [
            new()
            {
                Id = "Silicon",
                ImageSrc = "/images/silicon.png",
                Title = "Silicon - .NET MVC Project",
                Includes = ["ASP.NET MVC", "Web Api", "Dependency injections", "Figma", "Services", "SqlServer", "Identity", "Javascript", "SASS", "Factories", "Repositories", "Generics"],
                Description = "This is a project description bla bla bla blal This is a project description bla bla bla blal This is a project description bla bla bla blal This is a project description bla bla bla blal",
            },

           
        ];
       
    }

    public ProjectModel GetById(string id)
    {
        var project = GetProjectModels().FirstOrDefault(x => x.Id == id);
        return project ?? null!;
    }
}
