using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliensOnEarth
{
    class AlienInput : MainClass
    {

        public void AliensInput()
        {
            AlienValidatorInterface AVI = new AlienValidator();

            bool success = false;
            string line = null;


            for (int i = 0; i < Count; i++)  //Loop to insert Alien details into arrays of structure
            {
                Console.WriteLine();

                Console.WriteLine("Alien No. {0}", i+1);
                Console.WriteLine("---------------------");

                while (!success) //Loop to insert Alien's Code into an arrays of structure
                {
                    Console.Write("Alien Code: ");
                    line = Console.ReadLine();


                    if (AVI.IsLetterOrDigitValid(line)) //Checking the condition whether the entered value is digit or alphabet at AlienValidator class
                    {
                        Al[i].AlienCode = line;
                        line = null;
                        success = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter either digits or alphabets only");
                        success = false;
                    }
                }
                success = false;


                while (!success) //Loop to insert Alien's Name into an array of structure
                {
                    Console.Write("Alien Name: ");
                    line = Console.ReadLine();
                    if (AVI.IsStringValid(line)) //Checking the condition whether the entered values are alphabets or not at AlienValidator class
                    {
                        Al[i].AlienName = line;
                        line = null;
                        success = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter alphabets value only");
                        success = false;
                    }
                }
                success = false;


                while (!success) //Loop to insert Alien's Blood Colour into an array of structure
                {
                    Console.Write("Alien BloodColor: ");
                    line = Console.ReadLine();
                    if (AVI.IsStringValid(line)) //Checking the condition whether the entered values are alphabets or not at AlienValidator class
                    {
                        Al[i].AlienBloodColor = line;
                        line = null;
                        success = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter alphabets only");
                        success = false;
                        line = null;
                    }
                }
                success = false;

                //Loop to insert Alien's No of antennas Code into an array of structure
                while (!success)
                {
                    Console.Write("Alien NoOfAntennas: ");
                    line = Console.ReadLine();
                    if (AVI.IsIntValid(line)) //Checking the condition whether the entered values are digits or not at AlienValidator class
                    {
                        Al[i].AlienNoOfAntennas = int.Parse(line);
                        line = null;
                        success = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter digits only");
                        success = false;
                        line = null;
                    }
                }
                success = false;

                //Loop to insert Alien's No of legs into an array of structure
                while (!success)
                {
                    Console.Write("Alien NoOfLegs: ");
                    line = Console.ReadLine();
                    if (AVI.IsIntValid(line)) //Checking the condition whether the entered values are digits or not at AlienValidator class
                    {
                        Al[i].AlienNoOfLegs = int.Parse(line);
                        line = null;
                        success = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter digits only");
                        line = null;
                        success = false;
                    }
                }
                success = false;


                while (!success) //Loop to insert Alien's home planet into an array of structure
                {
                    Console.Write("Alien HomePlanet: ");

                    line = Console.ReadLine();
                    if (AVI.IsStringValid(line)) //Checking the condition whether the entered values are alphabets or not at AlienValidator class
                    {
                        Al[i].AlienHomePlanet = line;
                        line = null;
                        success = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter alphabets only");
                        success = false;
                        line = null;
                    }
                }
                success = false;
            }

            Console.WriteLine();
            Console.WriteLine("Thanks for entering the details.");
            Console.WriteLine();


        }
    }
}
