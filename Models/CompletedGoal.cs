using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoalTrackingWebApp.Models
{
    public class CompletedGoal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string GoalTitle { get; set; }
        public string GoalText { get; set; }
        public DateTime GoalDate { get; set; } 
        public CompletedGoal()
        {

        }
    }
}
