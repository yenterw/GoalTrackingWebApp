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
        public DateTime GoalDate { get; set; } //DateTime defaultDate = default(DateTime); var date = defaultDate.ToString().Replace("12:00:00 AM", "");
        public CompletedGoal()
        {

        }
    }
}
