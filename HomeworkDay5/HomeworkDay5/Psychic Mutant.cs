using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkDay5
{
    class Psychic_Mutant : Mutant, IDisplayable
    {
        public int IQ { get; set; }
        public int UsageCount { get; set; }




        public override void DisplayInfo()
        {
            Console.WriteLine("CodeName: {0} \n Level: {1} \n IQ: {2} \n Usage:{3}", CodeName, Level, IQ, UsageCount);
        }

        public override void DangerQuotient()
        {
            int sum = Level * IQ * UsageCount;
            Console.WriteLine("Danger Quotient: " + sum);
        }
    }
}
