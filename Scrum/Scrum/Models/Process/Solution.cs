using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum.Models
{
    public class Solution
    {
        public List<Project> Projects { get; set; }
        public Sprint Time { get; set; }
        public State Progress {get;set;}
    }
}
