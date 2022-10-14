using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AddedEvents
{
    public class Airport
    {
        public List<Airplane> planes { get; set; }

        public Airport()
        {
            planes = new List<Airplane>();
        }

        public void AllTakeOff()
        {
            foreach (Airplane a in planes)
            {
                a.startEngine();
                a.TakeOff();
            }
        }
    }
}
