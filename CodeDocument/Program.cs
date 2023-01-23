using CodeDocumentation;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.Serialization.Json;
using System.Text;

namespace CodeDocument
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.PrintColorMessage(ConsoleColor.Yellow, "************ Welcome to the In-House Code Documentation Tool********\n\n");


            InHouseCode.GetDocs();
        }


      

    }
}