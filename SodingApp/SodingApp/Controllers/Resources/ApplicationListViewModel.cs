using SodingApp.Models;
using System.Collections.Generic;

namespace SodingApp.Controllers.Resources
{
    public class ApplicationListViewModel
    {
        public ApplicationListViewModel()
        {
            this.Applications = new List<ApplicationViewModel>();
        }

        public ApplicationListViewModel(IEnumerable<Application> applications)
        {
            this.Applications = new List<ApplicationViewModel>();

            foreach (var application in applications)
            {
                this.Applications.Add(new ApplicationViewModel(application));
            }
        }

        public List<ApplicationViewModel> Applications { get; set; }
    }
}