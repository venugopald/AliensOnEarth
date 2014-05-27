using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliensOnEarth
{
    class AlienReview 
    {
        public void AlienReviewandExport()
        {
            bool success = false;
            char ReviewChk;
            AlienOutPutInterface AOI = new AlienOutPut();
            AlienExportInterface AEI = new AlienExport();

            try
            {
                //Loop to review the entered details and export it based on the user entry
 
                while (!success)
                {

                    Console.WriteLine(" Would you like to review it before exporting ? (Y/N)");
                    ReviewChk = Convert.ToChar(Console.ReadLine());

                    if (ReviewChk == 'Y' || ReviewChk == 'y')
                    {
                        /* AliensOutPut() method is of class AlienOutPut, it outputs the data either on to the screen or into a file based on user selection */
                        AOI.AliensOutPut();

                        /* ExportAlienDetails() method is of class AlienExport, it exports the data into a file based on user selection */
                        AEI.ExportAlienDetails();

                        success = true;

                    }
                    else if (ReviewChk == 'N' || ReviewChk == 'n')
                    {
                        /* ExportAlienDetails() method is of class AlienExport, it exports the data into a file based on user selection */
                        AEI.ExportAlienDetails();

                        success = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid input (Y/N) !!");
                        success = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
