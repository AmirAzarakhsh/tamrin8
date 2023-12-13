using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tamrin8;

List<Animal> animals = new List<Animal>()
{
        new Cow___Sheep.Cow()
        {   
                  IsMale = true, Weight = 250 , BirthDate=new DateTime(2020,10,05),
                  Environments=new List<tamrin8.Environment>()
                   {
                     new tamrin8.Environment()
                     {
                     TDS= new HealthParameter<int>(){Name = "TDS" , Current = 700 , Standard=4900 , x=0.2 },
                     Temperature=new HealthParameter<double>(){Name = "Temperature" , Current = 26.5 , Standard=30.5, x = 0.4 },
                     Density= new HealthParameter<int>(){Name = "Density" , Current = 1000 , Standard=5000 , x=0.1},
                     Decibel= new HealthParameter<double>(){Name = "Decibel" , Current = 1000 , Standard=5000, x=0.1 },
                     Oxygen= new HealthParameter<int>(){Name = "TDS" , Current = 1000 , Standard=5000, x=0.1},
                     AQI= new HealthParameter<int>(){Name = "TDS" , Current = 1000 , Standard=5000, x=0.1 },
                    

                     }
                   }
        },


        
};
foreach (Animal animal in animals)
{
    Console.WriteLine(animal);
    Console.WriteLine("omr baghi mande (day)" + animal.Life());
}