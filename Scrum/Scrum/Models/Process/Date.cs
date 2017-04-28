using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrum.Models
{
    public class Date
    {
        public Date(int dd,int mm,int aa)
        {
            Dia = dd;
            Mes = mm;
            Ano = aa;
        }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
    }
}
