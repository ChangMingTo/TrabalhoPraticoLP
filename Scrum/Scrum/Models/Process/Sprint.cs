using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum.Models
{
    public class Sprint
    {
        public Sprint(Date start)
        {
            StartDate = start;
        }
        public Task TaskSprint { get; set; }
        public Date StartDate { get; set; }
        public Date FinishDate { get; set; }
        //time counting
    }
}
