using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasemetoo
{
    class Program
    {
        int[] GetIntArray(int num)
        {
            List<int> listOfInts = new List<int>();
            while(num > 0)
            {
            listOfInts.Add(num % 10);
            num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
    }
        static int Words(string t)
        {
            string[] words = t.Split(' ');
            int wordsCount = 0;
            foreach (string st in words)
            {
                wordsCount++;
            }
            return wordsCount;

        }
        static int Spaces(string t)
        {
            char[] texts = t.ToCharArray();
            int spacesCount = 0;
            foreach (char i in texts)
            {
                if (i==' ')
                {
                    spacesCount++;
                }
            }
            return spacesCount;
        }
        static void Main(string[] args)
        {
            //ül 1 Määrake antud tekstireal sõnade arv. Iga sõna on üksteisest eraldatud tühikuga. Loendage tekstis olevate sõnade ja tühikute arv. 
            string text = "Ma meeldin kassid";
            Console.WriteLine(text);
            Console.WriteLine("sõnade arv:{0} tühikute arv:{1}", Words(text),Spaces(text));
            

            /*ül 2 Määratud on ühemõõtmeline täisarvude massiiv. Vormi sellest kaks massiivi,
            mis on sorteeritud kasvavas järjekorras ja sisaldavad paaris- ja paarituid numbreid. Vihje: paarisarv jagub ilma jäägita 2 -ga.*/
            int[] arvud = new int[] {2,3,4,5,6,7,8,9,0,10,11,23,12,56};
            int[] paarisarv = new int[] { };
            int[] paarituarv = new int[] { };
            
            foreach (int i in arvud)
            {
                if (i%2==0)
                {
                    paarisarv.Append(i);
                }
                else
                {
                    paarituarv.Append(i);
                }

            }
            Array.Sort(paarituarv);
            Array.Sort(paarisarv);
            Console.WriteLine("Paarisa arvud:");
            for (int i = 0; i < paarisarv.Length; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Paartu arvud:");
            for (int i = 0; i < paarituarv.Length; i++)
            {
                Console.WriteLine(i);
            }
            int[] arvud23=new int[]{100,1221,66666,12345,54321,29022}
            int[] a=GetIntArray(arvud23[0]);
            int[] b=GetIntArray(arvud23[1]);
            int[] n=GetIntArray(arvud23[2]);
            int[] c=GetIntArray(arvud23[3]);
            int[] d=GetIntArray(arvud23[4]);
            int[] e=GetIntArray(arvud23[5]);
            
            Console.ReadLine();
            
        }
    }
}
