using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinal
{
    public class Movement
    {
        public string date { get; set; }
        public string amount { get; set; }

        public Movement(string pDate, string pAmount)
        {
            this.date = pDate;
            this.amount = pAmount;

        }
    }
}
