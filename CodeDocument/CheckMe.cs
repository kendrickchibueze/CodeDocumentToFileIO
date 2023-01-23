using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDocument
{
    internal class CheckMe
    {

        //to file
        //public static void GetDocs()
        //{
        //    var assembly = Assembly.GetExecutingAssembly();

        //    Utility.PrintColorMessage(ConsoleColor.Cyan, "Assembly name: " + assembly.FullName);

        //    Console.WriteLine();

        //    Type[] types = assembly.GetTypes();

        //    StringBuilder sb = new StringBuilder();
        //    foreach (Type type in types)
        //    {
        //        DisplayType(type);

        //        DisplayConstructor(type);

        //        DisplayProperties(type);

        //        DisplayMethods(type);

        //        sb.AppendLine(type.ToString());
        //        Console.WriteLine();
        //    }
        //    File.WriteAllText("output.txt", sb.ToString());
        //}


        //to Json 1
        //        using System.Web.Script.Serialization;

        //public static void GetDocs()
        //    {
        //        var assembly = Assembly.GetExecutingAssembly();

        //        Utility.PrintColorMessage(ConsoleColor.Cyan, "Assembly name: " + assembly.FullName);

        //        Console.WriteLine();

        //        Type[] types = assembly.GetTypes();

        //        StringBuilder sb = new StringBuilder();
        //        foreach (Type type in types)
        //        {
        //            DisplayType(type);

        //            DisplayConstructor(type);

        //            DisplayProperties(type);

        //            DisplayMethods(type);

        //            sb.AppendLine(type.ToString());
        //            Console.WriteLine();
        //        }
        //        var json = new JavaScriptSerializer().Serialize(types);
        //        File.WriteAllText("output.json", json);
        //    }



        //        using System.Runtime.Serialization.Json;
        //using System.IO;

        //...

        //To JSON

        //public static void GetDocs()
        //    {
        //        var assembly = Assembly.GetExecutingAssembly();

        //        Utility.PrintColorMessage(ConsoleColor.Cyan, "Assembly name: " + assembly.FullName);

        //        Console.WriteLine();

        //        Type[] types = assembly.GetTypes();

        //        StringBuilder sb = new StringBuilder();
        //        foreach (Type type in types)
        //        {
        //            DisplayType(type);

        //            DisplayConstructor(type);

        //            DisplayProperties(type);

        //            DisplayMethods(type);

        //            sb.AppendLine(type.ToString());
        //            Console.WriteLine();
        //        }
        //        using (var stream = new MemoryStream())
        //        {
        //            var serializer = new DataContractJsonSerializer(typeof(Type[]));
        //            serializer.WriteObject(stream, types);
        //            stream.Position = 0;
        //            using (var sr = new StreamReader(stream))
        //            {
        //                File.WriteAllText("output.json", sr.ReadToEnd());
        //            }
        //        }
        //    }


        //pdf
        //        using System;
        //using System.Reflection;
        //using iTextSharp.text;
        //using iTextSharp.text.pdf;

        //namespace PDFGenerator
        //    {
        //        public static class PDFGenerator
        //        {
        //            public static void GetDocs()
        //            {
        //                var assembly = Assembly.GetExecutingAssembly();

        //                Utility.PrintColorMessage(ConsoleColor.Cyan, "Assembly name: " + assembly.FullName);

        //                Console.WriteLine();

        //                Type[] types = assembly.GetTypes();

        //                StringBuilder sb = new StringBuilder();
        //                foreach (Type type in types)
        //                {
        //                    DisplayType(type);

        //                    DisplayConstructor(type);

        //                    DisplayProperties(type);

        //                    DisplayMethods(type);

        //                    sb.AppendLine(type.ToString());
        //                    Console.WriteLine();
        //                }
        //                // create a new PDF document
        //                using (var document = new Document())
        //                {
        //                    // create a new file stream to save the PDF document
        //                    using (var writer = PdfWriter.GetInstance(document, new FileStream("output.pdf", FileMode.Create)))
        //                    {
        //                        // open the document
        //                        document.Open();
        //                        // create a new paragraph with the text
        //                        var paragraph = new Paragraph(sb.ToString());
        //                        // add the paragraph to the document
        //                        document.Add(paragraph);
        //                        // close the document
        //                        document.Close();
        //                    }
        //                }
        //            }

    }
}
