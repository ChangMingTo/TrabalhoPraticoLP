using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum.Models
{
    public class DailyMettings
    {
        public DailyMettings(Date data)
        {
            Data = data;
        }
        public Date Data { get; set; }
        public ScrumTeam Team { get; set; }
        public string Goals { get; set; }
    }
}
