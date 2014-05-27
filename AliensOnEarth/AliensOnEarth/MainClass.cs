using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliensOnEarth
{

    public class MainClass
    {

        static public int Count;
        static public Alien[] Al;


        public struct Alien
        {
            public string Code;
            public string Name;
            public string BloodColor;
            public int NoOfAntennas;
            public int NoOfLegs;
            public string HomePlanet;

            /* Stores Code value into a Code field */
            public string AlienCode
            {
                get
                {
                    return Code;
                }
                set
                {
                    if (value != null)
                        Code = value;
                }
            }

            /* Stores Name value into a Name field */
            public string AlienName
            {
                get
                {
                    return Name;
                }
                set
                {
                    if (value != null)
                        Name = value;
                }
            }

            /* Stores BloodColor value into a BloodColor field */
            public string AlienBloodColor
            {
                get
                {
                    return BloodColor;
                }
                set
                {
                    if (value != null)
                        BloodColor = value;
                }
            }

            /* Stores NoOfAntennas value into a NoOfAntennas field */
            public int AlienNoOfAntennas
            {
                get
                {
                    return NoOfAntennas;
                }
                set
                {
                    if (value >= 0)
                        NoOfAntennas = value;
                }
            }

            /* Stores NoOfLegs value into a NoOfLegs field */
            public int AlienNoOfLegs
            {
                get
                {
                    return NoOfLegs;
                }
                set
                {
                    if (value >= 0)
                        NoOfLegs = value;
                }
            }

            /* Stores HomePlanet value into a HomePlanet field */
            public string AlienHomePlanet
            {
                get
                {
                    return HomePlanet;
                }
                set
                {
                    if (value != null)
                        HomePlanet = value;
                }
            }


            /* Method to output the entered details */
            public void DisplayAlienDetails()
            {
                Console.Write(" {0,2} {1,5} {2,8} {3,10} {4,12} {5,12} ", Code, Name, BloodColor, NoOfAntennas, NoOfLegs, HomePlanet);

            }
        }



        static void Main(string[] args)
        {

            NoOfAliens NOA = new NoOfAliens();
            AlienInput AI = new AlienInput();
            AlienReview AR = new AlienReview();

            Console.Title = "AliensDatabase";
            Console.WriteLine("*****************");
            Console.WriteLine("Welcome Aliens !!");
            Console.WriteLine("*****************");
            Console.WriteLine();

            /* NoOfAliensToBeEntered() method is of class NoOfAliens is called to get the count on number of Alien's details to be entered at a time. */
            NOA.NoOfAliensToBeEntered();
            Console.WriteLine();
            Console.WriteLine("Please fill out the following details.");


            /* AliensInput() method of  class AlienInput is called to input the details entered by the user into the array of structure. */
            AI.AliensInput();



            /* AlienReviewandExport() method of class AlienReview is called to give an option to the user to review the data entered before exporting
            and allowing user to select the required file format to export the entered data into. */
            AR.AlienReviewandExport();

        }

    }

}

   

    
    


