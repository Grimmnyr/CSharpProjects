using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkDay5
{
    class Elemental_Mutant : Mutant, IDisplayable
    {
        public int Region { get; set; }



        public override void DisplayInfo()
        {
            Console.WriteLine("CodeName:{0} \n Level:{1} \n Region:{2}", CodeName, Level, Region);
        }

        public override void DangerQuotient()
        {
            int sum = Level * Region;
            Console.WriteLine("Danger Quotient: " + sum);
        }
    }
}
