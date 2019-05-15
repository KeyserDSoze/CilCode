using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ILTest
{
    class Program
    {
        //https://en.wikipedia.org/wiki/List_of_CIL_instructions
        static void Main(string[] args)
        {
            MethodInfo methodInfo = typeof(Program).GetMethods(BindingFlags.Static | BindingFlags.Public).FirstOrDefault();
            foreach (ILInstruction instruction in ILInstructionLoader.GetInstructions(methodInfo))
            {
                Console.WriteLine(instruction);
            }
        }
        public static bool Salve()
        {
            string s = string.Empty;
            string al = string.Empty;
            for (int i = 0; i < 10; i++)
                s += i.ToString();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 10; i++)
                stringBuilder.Append(i.ToString());
            return true;
        }
        public static bool ReturnedToTheHills(int x)
        {
            int zero;
            string hello;
            hello = "Asddod" + x.ToString();
            //for (int i = 0; i < hello.Length; i++)
            //    Console.WriteLine(i);
            int cold = 0;
            List<string> salsicce = new List<string>();
            salsicce.Add("dddd");
            salsicce.Add("ddddddd");
            List<string> stringozze = new List<string>() { "ddd", "sss" };
            foreach (string o in stringozze)
            {
                Console.WriteLine(o);
            }
            do
            {
                Console.WriteLine(cold.ToString());
                cold++;
            } while (cold <= 7);
            zero = 5000;
            double xx = 45D;
            return hello == null;
        }
    }
}

