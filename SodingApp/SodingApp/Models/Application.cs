using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SodingApp.Models
{
    public class Application
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual Team Team { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? Deleted { get; set; }

        [ForeignKey("Team")]
        public int TeamId { get; set; }
    }
}