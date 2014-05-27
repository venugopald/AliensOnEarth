using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliensOnEarth
{
    class NoOfAliens : MainClass
    {
        public void NoOfAliensToBeEntered()
        {
            AlienValidatorInterface AVI = new AlienValidator();
            bool success = false;
            string line;
            try
            {
                while (!success)
                {

                    Console.Write("Number of Alien details to be entered : ");

                    line = Console.ReadLine();
                    if (AVI.IsIntValid(line))
                    {
                        Count = int.Parse(line);

                        Al = new Alien[Count];
                        success = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter integer value only");
                        Console.WriteLine();
                        success = false;

                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                line = null;


            }

        }
    }
}
