using CodeDocument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeDocumentation
{
    public static  class Utility
    {


        private  static int _choice;

        private static int _choicer;

        //print color message
        public static void PrintColorMessage(ConsoleColor color, string message)
        {

            Console.ForegroundColor = color;

            //tell user its not a number
            Console.WriteLine(message);

            //reset text color
            Console.ResetColor();
        }



        public static void ShowMenu()
        {
           
            PrintColorMessage(ConsoleColor.Yellow, " ------------------------------------");
            PrintColorMessage(ConsoleColor.Yellow, "| InHouse Code Documentation Menu    |");
            PrintColorMessage(ConsoleColor.Yellow, "|                                    |");
            PrintColorMessage(ConsoleColor.Yellow, "| 1. Write to File & Read to Console |");
            PrintColorMessage(ConsoleColor.Yellow, "| 2. Write to JSON & Read to Console |");
            PrintColorMessage(ConsoleColor.Yellow, "| 3. Write to Pdf & Read to Console  |");
            PrintColorMessage(ConsoleColor.Yellow, "| 4. Exit                            |");
            PrintColorMessage(ConsoleColor.Yellow, "|                                    |");
            PrintColorMessage(ConsoleColor.Yellow, "|                                    |");
            PrintColorMessage(ConsoleColor.Yellow, "|                                    |");
            PrintColorMessage(ConsoleColor.Yellow, " -------------------------------------");
        }


        public static void ChooseAction()
        {
            
            ShowMenu();


            attempt:  PrintColorMessage(ConsoleColor.Cyan, "\nPlease enter an option:");
            


            try
            {

                _choice = int.Parse(Console.ReadLine());


                switch (_choice)
                {
                    case 1:

                        Console.Clear();

                        InHouseCodeToFile.CreateAndReadFile();

                        goto nextattempt;
                        

                        break;

                    case 2:

                        Console.Clear();

                        InHouseCodeToJson.GetDocs();

                        goto nextattempt;

                        break;

                    case 3:
                        Console.Clear();

                        PrintColorMessage(ConsoleColor.Yellow, "Successfully created a PDF file...");

                        Console.WriteLine();

                        Thread.Sleep(1000);

                        InHouseCodeToPdf.CreateAndReadPDF();

                        goto nextattempt;

                        break;

                    case 4:

                        Environment.Exit(0);

                        break;

                    default:

                        PrintColorMessage(ConsoleColor.Red, "Invalid entry, please try again!!!");

                        goto attempt;


                        break;


                }

            }
            catch
            {
                PrintColorMessage(ConsoleColor.Red, "Invalid entry, please try again!!!");

                goto attempt;

            }

            PrintColorMessage(ConsoleColor.Cyan, "\nDo you wish to continue");

            nextattempt:  PrintColorMessage(ConsoleColor.Cyan, "\n press 1 to exit or 2 to continue");

            try
            {
                _choicer = int.Parse(Console.ReadLine());

                switch (_choicer)
                {
                    case 1:

                        Environment.Exit(0);

                        break;

                    case 2:
                        Console.Clear();

                        ShowMenu();

                        goto attempt;


                        break;
                   

                    default:

                        PrintColorMessage(ConsoleColor.Red, "please enter a valid option");

                        goto nextattempt;


                        break;


                }

            }
            catch
            {
                PrintColorMessage(ConsoleColor.Red, "please enter a valid option");

                goto nextattempt;
            }

        }
    }
}
