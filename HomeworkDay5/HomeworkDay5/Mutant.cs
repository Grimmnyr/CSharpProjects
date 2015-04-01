using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkDay5
{
    abstract class Mutant : IDisplayable
    {
        public string CodeName { get; set; }
        public int Level { get; set; }

        public abstract void DangerQuotient();

        public virtual void DisplayInfo()
        {

            Console.WriteLine("{0} \n {1}", CodeName, Level); 
        }

    }
}
