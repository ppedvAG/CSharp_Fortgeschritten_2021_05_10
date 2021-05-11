using System;

namespace DelegateWithCallback
{
    class Program
    {
        public delegate void Del(string message);

        static void Main(string[] args)
        {
            Del handler = new Del(DelegateMthod);
            MethodWithCallback(12, 33, handler);


            Action<string> action = DelegateMthod;
            MethodWithCallback(44, 33, action);

            Func<int, int, int> myFunc = CallbackMethode;

            MethodWithCallback(12, 14, myFunc);
        }

        public static int CallbackMethode(int a, int b)
        {
            return a + b;
        }

        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            //Ganz viel Logik berechnet wird und das kann dauern

            //Callback wird ganz unten aufgerufen
            callback("This Number is " + (param1 + param2).ToString());
        }

        public static void MethodWithCallback(int param1, int param2, Func<int, int, int> callback) //Action wäre bei Callback besser
        {
            //Logik die etwas dauern kann. 

            int result = callback(param1, param2);
        }

        public static void MethodWithCallback(int param1, int param2, Action<string> callback)
        {
            //Logik die etwas dauern kann. 

            callback("The Number is: " + (param1 + param2).ToString());
        }


        //Wird aufgerufen, wenn ich mit irgendwas fertig bin -> Erfolgsmeldung.
        public static void DelegateMthod(string message)
        {
            Console.WriteLine(message);
        }
    }
}
