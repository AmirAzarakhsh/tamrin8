using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin8
{
   
        abstract class Animal
        {
            static Animal()
            {
                TotalNumber = 0;
            }
            public Animal()
            {
                TotalNumber++;
                Number = TotalNumber;
            }
            public static int TotalNumber { get; private set; }
            public int Number { get; private set; }
            public double Weight { get; set; }
            public bool IsMale { get; set; }
            public DateTime BirthDate { get; set; }
            public abstract int Life();
            public List<Environment> Environments { get; set; }

            public abstract float KillPriority();
            public abstract int CostPerDay();
            public abstract double TotalStress();


        }
    
}
////amirhossein azarakhsh