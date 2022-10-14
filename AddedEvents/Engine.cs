using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddedEvents
{
    public class Engine
    {
        public bool isStarted;

        public event EventHandler OnStart;
        public Engine()
        { 
            isStarted = false;
            this.OnStart += onStart;
        }

        public void onStart(object sender, EventArgs e)
        { 
            isStarted=true;
        }

        public string Start()
        {
            this.OnStart.Invoke(this, EventArgs.Empty);
            return "Engine has started";
        }
    }
}
