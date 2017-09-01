using System.ComponentModel.DataAnnotations;
using SodingApp.Models;

namespace SodingApp.Controllers.Resources
{
    public class ApplicationViewModel
    {
        public ApplicationViewModel()
        {
        }

        public ApplicationViewModel(Application application)
        {
            this.Id = application.Id;
            this.Name = application.Name;
            this.Description = application.Description;
            this.TeamName = application.Team != null ? application.Team.Name : string.Empty;
            this.TeamId = application.TeamId;
            this.Slug = application.Name;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public string Slug { get; set; }
        public string TeamName { get; set; }
        public string Description { get; set; }

        [Display(Name = "Managed by team")]
        [Required(ErrorMessage = "Team is required")]
        public int TeamId { get; set; }
    }
}