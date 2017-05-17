using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scrum.Models;

namespace Scrum.Controllers
{
    public class DevelopersController
    {
        private List<Developer> developers;
        public DevelopersController()
        {
            developers = new List<Developer>();
        }
        public bool AddDeveloper(Developer add)
        {
            if (developers.Contains(add)==true)
            {
                return false;
            }
            else
            {
                developers.Add(add);
                return true;
            }
        }
    }
}
