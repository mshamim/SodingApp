using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SodingApp.Models
{
    public class UserTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }

        
        
        public DateTime DateCreated { get; set; }

        
        
        public DateTime DateUpdated { get; set; }
    }
}