using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Scrum.Models;

namespace Scrum.Controllers
{
    public class MettingController
    {
        private List<DailyMettings> mettings;
        public MettingController()
        {
            mettings = new List<DailyMettings>();  
        }
        public bool SaveMetting(DailyMettings meet)
        {
            mettings.Add(meet);
            return true;
        }

    }
}