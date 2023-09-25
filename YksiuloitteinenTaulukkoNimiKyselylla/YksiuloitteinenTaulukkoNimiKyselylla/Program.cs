using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YksiuloitteinenTaulukkoNimiKyselylla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean jatka = true;
            int i = 0;
            string nimi;
            string[] nimet = new string[100];
            while (jatka) 
            {
                Console.Write("Anna etunimi: (X = lopettaa): ");
                nimet[i] = Console.ReadLine();
                if (nimet[i].ToUpper() == "X") jatka = false;
                i++;//i = i + 1;
            }
            for (int j = 0; j < nimet.Length; j++)
            {
                //nimi = nimet[j];
                if (nimet[j] != null) 
                { 
                    if (nimet[j].Length > 0) Console.WriteLine(nimet[j]);
                }
            }
            Console.WriteLine("Paina enter sulkeaksesi ohjelman!");
            Console.ReadLine();
        }

    }
}
