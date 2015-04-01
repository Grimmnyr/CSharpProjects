using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkDay5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDisplayable> Mutants = new List<IDisplayable>();

            Elemental_Mutant a1 = new Elemental_Mutant();
            a1.CodeName = "Gambit";
            a1.Level = 200;
            a1.Region = 42;


            Psychic_Mutant a2 = new Psychic_Mutant();
            a2.CodeName = "Phoenix";
            a2.Level = 250;
            a2.IQ = 170;
            a2.UsageCount = 12;

            Physical_Mutant a3 = new Physical_Mutant();
            a3.CodeName = "DeadPool";
            a3.Level = 150;
            a3.IQ = 130;
            a3.Strength = 400;

            Mutants.Add(a1);
            Mutants.Add(a2);
            Mutants.Add(a3);

            foreach (var item in Mutants)
            {
                item.DisplayInfo();
                item.DangerQuotient();
            }
            Console.ReadLine();
        }
    }
}
