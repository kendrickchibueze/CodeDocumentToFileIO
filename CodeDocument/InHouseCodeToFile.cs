using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AttributeLibrary;
using System.Text.Json.Serialization;
using System.Text.Json;
using CodeDocumentation;
using static CodeDocument.InHouseCodeToJson;

namespace CodeDocument
{
    public  class InHouseCodeToFile {


        public static void CreateAndReadFile()
        {

            Utility.PrintColorMessage(ConsoleColor.Cyan, "************ Welcome to the In-House Code Documentation Tool(FILE)********\n\n");


            string documentation = InHouse.GetDocs();


            //Create a StreamWriter to write the documentation to a file

            using (StreamWriter writer = new StreamWriter("document.txt"))
            {
                writer.Write(documentation);
            }

            // Now read data from file to console

            using (StreamReader sr = File.OpenText("document.txt"))
            {
                string input = null;

                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }
        }

          

            


    }











   // }
}
