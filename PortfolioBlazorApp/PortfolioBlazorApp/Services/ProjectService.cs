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
                Id = "console-table",
                ImageSrc = "/images/console-table.png",
                Title = "Handball Players - Console Table",
                Tags = ["C#", "Console", "Dependency injections", "Services", "Extension Methods", "Enums"]

            },
            new ProjectListItem
            {
                Id = "quickiequiz",
                ImageSrc = "/images/quickiequiz.png",
                Title = "Quickie Quiz - Fullstack project",
                Tags = ["jQuery", "Javascript", "MVC", "SqlServer", "API", "Azure"]
            },
             new ProjectListItem
            {
                Id = "bookbuddy",
                ImageSrc = "/images/bookbuddy.png",
                Title = "BookBuddy - Optimizely/OpenAI project",
                Tags = ["CMS", "Optimizely", "Open AI", "Blazor", "Scheduled jobs", "SqlServer", "Identity", "SASS"]
            }

        ];
    }

    //public List<ProjectModel> GetProjectModels()
    //{
    //    return
    //    [
    //        new()
    //        {
    //            Id = "silicon",
    //            ImageSrc = "/images/silicon.png",
    //            Title = "Silicon - .NET MVC Project",
    //            Includes = ["ASP.NET MVC", "Web Api", "Dependency injections", "Figma", "Services", "SqlServer", "Identity", "Javascript", "SASS", "Factories", "Repositories", "Generics"],
    //            Description = "This is a project description bla bla bla blal This is a project description bla bla bla blal This is a project description bla bla bla blal This is a project description bla bla bla blal",
    //        },

           
    //    ];
       
    //}

    //public ProjectModel GetById(string id)
    //{
    //    var project = GetProjectModels().FirstOrDefault(x => x.Id == id);
    //    return project ?? null!;
    //}
}
