using SodingApp.Models;

namespace SodingApp.Controllers.Resources
{
    public class UserTaskManageViewModel : UserTaskViewModel
    {
        public UserTaskManageViewModel()
            : base()
        {
        }
        public UserTaskManageViewModel(UserTask userTask)
            : base(userTask)
        {
        }

        public UserTask ToDalEntity()
        {
            return ToDalEntity(new UserTask());
        }

        public UserTask ToDalEntity(UserTask userTask)
        {
            userTask.Id = this.Id;
            userTask.Name = this.Name;
            userTask.Description = this.Description;
            userTask.DateCreated = this.DateCreated;
            userTask.DateUpdated = this.DateUpdated;
            return userTask;
        }
    }
}