using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin8
{
    class Cow___Sheep
    {
        public class Cow : Animal
        {
            public override int CostPerDay()
            {
                throw new NotImplementedException();
            }

           
            static Cow() { MaxLife = 9125; }
            public static int MaxLife { get; }
            public override float KillPriority()
            {
                return 2;

            }
            public override int Life()
            {
                int Age = (int)(DateTime.Now - BirthDate).TotalDays;

                return MaxLife - Age;
            }

            public override string ToString() =>
                $"C{(IsMale ? 'M' : 'F')}{BirthDate.Year}{BirthDate.Month}{BirthDate.Day}No{Number}";

            public override double TotalStress()
            {
                double TotalStress = 0;
                foreach (var environment in Environments)
                {
                    TotalStress += environment.TDS.SteressFactor() + environment.Temperature.SteressFactor() +
                    environment.Density.SteressFactor() + environment.Decibel.SteressFactor() +
                    environment.AQI.SteressFactor() + environment.Oxygen.SteressFactor();
                }
                return TotalStress;
            }
        }

      
    }
}
