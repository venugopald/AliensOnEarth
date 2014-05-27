using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AliensOnEarth
{

    public interface AlienExportInterface
    {
        void ExportAlienDetails();

    }


    class AlienExport : AlienExportInterface
    {
        public void ExportAlienDetails()
        {
            AlienValidatorInterface AVI = new AlienValidator();
            AlienOutPutInterface AOI = new AlienOutPut();
            char ExportChk;
            int ExportSelection;
            string line;

            bool success = false;
            Console.WriteLine();
            Console.Write("Would you like to export the details ? (Y/N) :");

            ExportChk = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            try
            {

                while (!success)
                {
                    if (ExportChk == 'Y' || ExportChk == 'y')
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please specify the file format to be used to export (1 OR 2) ");
                        Console.WriteLine("1.   PLAIN TEXT");
                        Console.WriteLine("2.   PDF");
                        Console.WriteLine();
                        line = Console.ReadLine();

                        if (AVI.IsIntValid(line))
                        {
                            ExportSelection = int.Parse(line);
                        }
                        else
                        {
                            ExportSelection = 0;
                        }

                        switch (ExportSelection)
                        {
                            case 0: Console.WriteLine("Please enter digits only");
                                success = false;
                                break;

                            case 1: Console.WriteLine("Please check the selected format file at Path: C:\\AlienPLAINTXTOutPut.txt");

                                using (StreamWriter writer = new StreamWriter("C:\\AlienPLAINTXTOutPut.txt"))
                                {
                                    Console.SetOut(writer);
                                    AOI.AliensOutPut();


                                    success = true;
                                    writer.Flush();

                                    Console.ReadLine();

                                }

                                break;

                            case 2: Console.WriteLine("Please check the selected format file at Path: C:\\AlienPDFOutPut.pdf");

                                using (StreamWriter writer = new StreamWriter("C:\\AlienPDFOutPut.pdf"))
                                {
                                    Console.SetOut(writer);

                                    AOI.AliensOutPut();


                                    success = true;
                                    writer.Flush();
                                    Console.ReadLine();

                                }
                                break;

                            default: Console.WriteLine("Please enter valid input (1 0r 2)");
                                success = false;

                                break;

                        }

                        //success = true;
                    }
                    else if (ExportChk == 'N' || ExportChk == 'n')
                    {
                        Console.WriteLine("Thank you for using the application, Take care !! ");
                        success = true;
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid input (Y/N) !!");
                        success = false;

                    }
                    //success = fa;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}