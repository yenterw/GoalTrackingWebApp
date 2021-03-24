using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoalTrackingWebApp.Models
{
    public class Goal
    {
        public int Id { get; set; }
        public string GoalTitle { get; set; }
        public string GoalText { get; set; }

        public Goal()
        {

        }
    }
}
