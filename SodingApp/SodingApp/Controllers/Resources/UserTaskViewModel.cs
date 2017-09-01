using SodingApp.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace SodingApp.Controllers.Resources
{
    public class UserTaskViewModel
    {
        public UserTaskViewModel()
        {
            this.DateCreated=DateTime.Now;
            this.DateUpdated = DateTime.Now;
        }

        public UserTaskViewModel(UserTask userTask)
        {
            this.Id = userTask.Id;
            
            this.Name = userTask.Name;
            
            this.Description = userTask.Description;

            this.DateCreated = userTask.DateCreated;
            
            this.DateUpdated = userTask.DateUpdated;

        }

        
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime DateUpdated { get; set; }

    }
}