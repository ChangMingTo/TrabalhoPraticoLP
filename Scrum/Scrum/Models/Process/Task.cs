using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum.Models
{
    public class Task
    {
        public Task(string text)
        {
            TaskDescription = text;
        }
        public string TaskDescription { get; set; }
        public Priority Prioridade { get; set; }
        public State Progress { get; set; }
        public Developer DeveloperWorkingOn { get; set; }
    }
}
