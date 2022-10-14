using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddedEvents
{
    public class Airplane
    {
        public int currentAlt;
        public int code;
        public Engine engine;

        public event EventHandler OnFlyUP;
        public Airplane(int Code)
        {
            currentAlt = 0;
            this.OnFlyUP += onFlyUP;
            this.code = Code;
            engine = new Engine();
        }

        public string TakeOff()
        {
            if (!engine.isStarted)
            {
                return "Engine not started";
            }
            else
            {
                FlyUp();
                return "Plane has taken off";
            }
        }

        public void startEngine()
        {
            this.engine.Start();
        }
        public void onFlyUP(object sender, EventArgs e)
        {
            currentAlt += 1000;
        }
        public void FlyUp()
        {
            OnFlyUP.Invoke(this, EventArgs.Empty);
        }
    }
}
