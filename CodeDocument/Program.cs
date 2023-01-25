using CodeDocumentation;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.Serialization.Json;
using System.Text;
using static CodeDocument.InHouseCodeToPdf;

namespace CodeDocument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.PrintColorMessage(ConsoleColor.Cyan, "************ Welcome to the In-House Code Documentation Tool********\n\n");


            Utility.ChooseAction();



        }


      

    }
}