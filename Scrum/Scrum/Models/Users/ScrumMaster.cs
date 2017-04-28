using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum.Models
{
    public class ScrumMaster
    {
        public ScrumMaster(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public ScrumTeam WorkTeam { get; set; }
    }
}
