using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamrin8
{
        public class HealthParameter<T>
        { 
            public string Name { get; set; }
            public T Current;
            public T Standard;
            public double x { get; set; }
            public double SteressFactor() =>
               (Convert.ToDouble(Current) / Convert.ToDouble(Standard)) * x;

  

        }
    
}
