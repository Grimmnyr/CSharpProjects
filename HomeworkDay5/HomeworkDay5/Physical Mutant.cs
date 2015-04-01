using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkDay5
{
    class Physical_Mutant : Mutant, IDisplayable
    {

        public int IQ { get; set; }
        public int Strength { get; set; }


        public override void DangerQuotient()
        {
            int sum = Level * IQ * Strength;
            Console.WriteLine("Danger Quotient: " + sum);
        }


        public override void DisplayInfo()
        {
            Console.WriteLine("CodeName: {0} \n Level: {1} \n IQ: {2} \n Strength:{3} \n ", CodeName, Level, IQ, Strength );
        }


    }
}
