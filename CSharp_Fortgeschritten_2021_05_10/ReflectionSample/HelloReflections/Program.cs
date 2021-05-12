using System;
using System.Reflection;

namespace HelloReflections
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly geladeneDll = Assembly.LoadFrom("TrumpTaschenrechner.dll");

            Type trumpTaschenrechnerType = geladeneDll.GetType("TrumpTaschenrechner.Taschenrechner");

            object tr = Activator.CreateInstance(trumpTaschenrechnerType);

            MethodInfo addInfo = trumpTaschenrechnerType.GetMethod("Add", new Type[] { typeof(Int32), typeof(Int32), typeof(Int32) });
            
            var result = addInfo.Invoke(tr, new object[] { 33, 22, 11 });
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
