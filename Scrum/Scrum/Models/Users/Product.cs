using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum.Models
{
    public class Product
    {
        public Product(string a)
        {
            Nome = a;
        }
        public string Nome { get; set;}
        public ProductOwner Owner { get; set; }
        public Solution Solutions { get; set; }
        public Sprint EleapsedTime { get; set; }
        public State Progress { get; set; }
        public ScrumTeam DeveloperTeam { get; set; }
        public ScrumMaster Master { get; set; }
    }
}
