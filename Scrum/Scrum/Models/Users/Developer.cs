using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum.Models
{
    public class Developer
    {
        public Developer(string name)
        {
            Name = name;
        }
        public Product ProductInWork { get; set; }
        public string Name { get; set; }
        public ScrumTeam WorkingTeam { get; set; }
        public List<Task> Tasks { get; set; }
        public Task TaskInWork { get; set; }
        //ProjectInWork
    }
}
