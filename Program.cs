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
            //insere no local definido e empurra os outros
            listadeitem.Insert(2,"Joice Mara<------");
            foreach (string obj in listadeitem) {
                Console.WriteLine(obj);
            }
            //verssão simplificada
            List<string> listadeitem2 = new List<string> {"Isabela","Renato","Julia" };
            
            foreach (string obj in listadeitem2)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("quantidade de itens = "+listadeitem.Count);

            //função lambda que retorna primeiro nome com a letra especificada
            Console.WriteLine("escreva a letra inicial do nome ");
            char letra = 'a';
            letra = char.Parse(Console.ReadLine());
            string retorno = listadeitem.Find(x => x[0] == letra);
            Console.WriteLine("nome é "+retorno);

        }
    }
}
