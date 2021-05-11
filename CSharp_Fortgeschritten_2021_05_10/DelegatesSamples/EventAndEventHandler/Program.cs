using System;
using System.Threading.Tasks;

namespace EventAndEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic processBusinessLogic = new ProcessBusinessLogic();

            processBusinessLogic.ProcessCompleted += ProcessBusinessLogic_ProcessCompleted;
            processBusinessLogic.ProcessInWorking += ProcessBusinessLogic_ProcessInWorking;
            processBusinessLogic.StartProcess();
            //Task myTask = Task.Run(processBusinessLogic.StartProcess);

            ProcessBusinessLogic2 processBusinessLogic2 = new ProcessBusinessLogic2();
            processBusinessLogic2.ProcessCompleted += ProcessBusinessLogic2_ProcessCompleted;
            processBusinessLogic2.ProcessCompletedNew += ProcessBusinessLogic2_ProcessCompletedNew;

            processBusinessLogic2.StartProcess();
        }

        private static void ProcessBusinessLogic2_ProcessCompletedNew(object sender, EventArgs e)
        {
            MyEventArg myEventArg = (MyEventArg)e;

            Console.WriteLine($"Bin fertig {myEventArg.Uhrzeit.ToString()}");
        }

        private static void ProcessBusinessLogic2_ProcessCompleted(object sender, EventArgs e)
        {
            
        }

        private static void ProcessBusinessLogic_ProcessInWorking(int processBarValue)
        {
            
        }

        private static void ProcessBusinessLogic_ProcessCompleted()
        {
           
        }
    }
}
