using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliensOnEarth
{

    public interface AlienOutPutInterface
    {
        void AliensOutPut();
    }

    class AlienOutPut : MainClass, AlienOutPutInterface
    {

        public void AliensOutPut()
        {
            Console.WriteLine("Entered details are as follows :");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Code  Name  BloodColor  NoOfAntennas  NoOfLegs  HomePlanet");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();

            for (int i = 0; i < Count; i++)
            {
                Al[i].DisplayAlienDetails();
                Console.WriteLine();
            }
            //Console.ReadLine();
        }
    }
}
