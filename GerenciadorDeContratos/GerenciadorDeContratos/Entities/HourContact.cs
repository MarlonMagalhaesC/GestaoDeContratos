using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POONelio.Entities
{
    public class HourContract
    {
        public DateTime data { get; set; }
        public double valuePerHour { get; set; }
        public int hours { get; set; }

        public HourContract(DateTime data, double valuePerHour, int hours)
        {
            this.data = data;
            this.valuePerHour = valuePerHour;
            this.hours = hours;
        }


        public double totalValue()
        {
            return valuePerHour * hours;
        }

    }

}
