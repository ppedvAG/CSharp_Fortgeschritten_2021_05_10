﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndEventHandler
{
    public class ProcessBusinessLogic2
    {
        public event EventHandler ProcessCompleted;

        public event EventHandler ProcessCompletedNew;

        public void StartProcess()
        {
            Console.WriteLine("Process start");
            //Ganz viel Logic


            MyEventArg myEventArg = new MyEventArg();
            myEventArg.Uhrzeit = DateTime.Now;



            OnProcessCompleted(EventArgs.Empty);

            OnProcessCompletedNew(myEventArg); //Beispiel 2
        }

        protected virtual void OnProcessCompleted(EventArgs e)
        {
            ProcessCompleted?.Invoke(this, e);

        }

        protected virtual void OnProcessCompletedNew(MyEventArg e)
        {
            ProcessCompletedNew?.Invoke(this, e);
        }
    }


    public class MyEventArg : EventArgs
    {
        public DateTime Uhrzeit { get; set; }
    }
}
