using SodingApp.Models;
using System.Collections.Generic;

namespace SodingApp.Controllers.Resources
{
    public class UserTaskListViewModel
    {
        public UserTaskListViewModel()
        {
            this.UserTasks = new List<UserTaskViewModel>();
        }

        public UserTaskListViewModel(IEnumerable<UserTask> userTasks)
        {
            this.UserTasks = new List<UserTaskViewModel>();

            foreach (var userTask in userTasks)
            {
                userTask.Description= GetDescriptionWithInShape(userTask.Description);

                this.UserTasks.Add(new UserTaskViewModel(userTask));
            }
        }

        private static string GetDescriptionWithInShape(string description)
        {
            return description.Length > 10 ? description.Substring(0, 10) : description;

        }

        public List<UserTaskViewModel> UserTasks { get; set; }
    }
}