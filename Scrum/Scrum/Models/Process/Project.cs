using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum.Models
{
    public class Project
    {
        public Project()
        {
            
        }
        public Sprint EleapsedTime { get; set; }
        public State Progress { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
