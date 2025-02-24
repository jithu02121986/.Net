using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Demo_App.Model
{
    public class HashTableDemo
    {
        public void _HashTableEx_CaseStudy_1()
        {
            Hashtable hst = new Hashtable();
            hst.Add("Eid", 350499);
            hst.Add("Name", "Jitendra");
            hst.Add("Company", "RRD");

            Console.WriteLine("Iterating The HAsh Table");

            foreach (Object key in hst.Keys)
            {
                Console.WriteLine(key + ":" + hst[key]);
            }
            Console.ReadKey();
        }

        public void _HashTableEx_CaseStudy_2()
        {
            Hashtable hst = new Hashtable();
            hst.Add("Eid", 350499);
            hst.Add("Name", "Jitendra");
            hst.Add("Company", "RRD");

            Console.WriteLine("Iteratining Hashtable by using dictonary entry :: ");

            foreach (DictionaryEntry de in hst)
            {
                Console.WriteLine($"key : {de.Key} , value : {de.Value}");
            }
            Console.ReadKey();
        }

        public void _HasHashTableEx_CaseStudy_3()
        {
            Hashtable hst = new Hashtable 
            { 
                {"Eid",46608 },
                {"name","Medha" },
                {"company","TechMAhindra" }
            };

            Console.WriteLine("Hash table operations ::");

            Console.WriteLine($"Hashtable count :: {hst.Count}");

           // hst.Clear();

           // Console.WriteLine($"Hashtable count after clearing  :: {hst.Count}");

            Hashtable clonehst = (Hashtable)hst.Clone();

            Console.WriteLine($"Cloned Hashtable count  :: {clonehst.Count}");

            foreach (DictionaryEntry de in clonehst)
            {
                Console.WriteLine($"key : {de.Key} , value : {de.Value}");
            }

            Console.ReadKey();
        }

        public void _HasHashTableEx_CaseStudy_4()
        {
            Hashtable hst = new Hashtable();
            hst.Add("Eid", 350499);
            hst.Add("Name", "Jitendra");
            hst.Add("Company", "RRD");

            Console.WriteLine("Copying the Hashtable to Array List");

            DictionaryEntry[] di = new DictionaryEntry[hst.Count];

            hst.CopyTo(di, 0);
            Console.WriteLine("Hash Table copy array elements  ::");

            foreach(DictionaryEntry de in di)
            {
                Console.WriteLine($"key :: {de.Key},Value :: {de.Value} ");
            }
            Console.ReadKey();


        }


    }
}
