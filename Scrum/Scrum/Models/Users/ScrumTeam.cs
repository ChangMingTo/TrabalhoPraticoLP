using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum.Models
{
    public class ScrumTeam
    {
        public ScrumTeam(List<Developer> developers, ScrumMaster master)
        {
            Developers = developers;
            Master = master;
        }
        public List<Developer> Developers { get; set; }
        public ScrumMaster Master { get; set; }
        public Product ProductInWork{get;set;}
    }
}
