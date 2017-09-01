using SodingApp.Models;

namespace SodingApp.Controllers.Resources
{
    public class ApplicationManageViewModel : ApplicationViewModel
    {
        public ApplicationManageViewModel()
            : base()
        {
        }
        public ApplicationManageViewModel(Application application)
            : base(application)
        {
        }

        public Application ToDalEntity()
        {
            return ToDalEntity(new Application());
        }

        public Application ToDalEntity(Application application)
        {
            application.Id = this.Id;
            application.Name = this.Name;
            application.Description = this.Description;
            application.TeamId = this.TeamId;
            return application;
        }
    }
}