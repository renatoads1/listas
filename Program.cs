using System;
using System.Collections.Generic;


namespace listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listadeitem = new List<string>();
            listadeitem.Add("renato");
            listadeitem.Add("isabela");
            listadeitem.Add("julia");
            foreach (string obj in listadeitem) {
                Console.WriteLine(obj);
            }
            //verssão simplificada
            List<string> listadeitem2 = new List<string> {"Isabela","Renato","Julia" };
            
            foreach (string obj in listadeitem2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("fim");
        }
    }
}
