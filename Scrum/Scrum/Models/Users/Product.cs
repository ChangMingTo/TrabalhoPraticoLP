using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum.Models
{
    public class Product
    {
        public Product(string nome,ProductOwner owner)
        {
            Nome = nome;
            Owner = owner;
        }
        public string Nome { get; set;}
        public ProductOwner Owner { get; set; }
        public Sprint EleapsedTime { get; set; }
        public State Progress { get; set; }
        public ScrumTeam DeveloperTeam { get; set; }
        public List<Project> Projects { get; set; }
    }
}
