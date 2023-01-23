using CodeDocumentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CodeDocument
{
    internal class More
    {
        //        using System;
        //using System.IO;

        //// Document Attribute
        //[attributeUsage(attributeTargets.All)]
        //    public class DocumentAttribute : Attribute
        //    {
        //        public string Description { get; set; }
        //        public string Input { get; set; }
        //        public string Output { get; set; }

        //        public DocumentAttribute(string description)
        //        {
        //            Description = description;
        //        }
        //    }

        //    // Example class with documented methods
        //    public class ExampleClass
        //    {
        //        [Document("This method does something", Input = "input", Output = "output")]
        //        public void ExampleMethod(int input)
        //        {
        //            // method implementation
        //        }
        //    }

        //    // GetDocs method
        //    public static void GetDocs()
        //    {
        //        var assembly = typeof(ExampleClass).Assembly;
        //        var types = assembly.GetTypes();
        //        var docs = new List<Dictionary<string, string>>();

        //        foreach (var type in types)
        //        {
        //            var methods = type.GetMethods();
        //            foreach (var method in methods)
        //            {
        //                var attributes = method.GetCustomAttributes(typeof(DocumentAttribute), false);
        //                if (attributes.Length > 0)
        //                {
        //                    var attribute = (DocumentAttribute)attributes[0];
        //                    var doc = new Dictionary<string, string>
        //                {
        //                    {"Type", type.Name},
        //                    {"Method", method.Name},
        //                    {"Description", attribute.Description},
        //                    {"Input", attribute.Input},
        //                    {"Output", attribute.Output}
        //                };
        //                    docs.Add(doc);
        //                }
        //            }
        //        }

        //        // Output to file
        //        var json = JsonConvert.SerializeObject(docs);
        ////        File.WriteAllText("docs.json", json);
        ////    }




        //        using System;
        //using System.IO;
        //using System.Web.Script.Serialization;

        //// Document Attribute
        //[AttributeUsage(attributeTargets.All)]
        //    public class DocumentAttribute : Attribute
        //    {
        //        public string Description { get; set; }
        //        public string Input { get; set; }
        //        public string Output { get; set; }

        //        public DocumentAttribute(string description)
        //        {
        //            Description = description;
        //        }
        //    }

        //    // Example class with documented methods
        //    public class ExampleClass
        //    {
        //        [Document("This method does something", Input = "input", Output = "output")]
        //        public void ExampleMethod(int input)
        //        {
        //            // method implementation
        //        }
        //    }

        //    // GetDocs method
        //    public static void GetDocs()
        //    {
        //        var assembly = typeof(ExampleClass).Assembly;
        //        var types = assembly.GetTypes();
        //        var docs = new List<Dictionary<string, string>>();

        //        foreach (var type in types)
        //        {
        //            var methods = type.GetMethods();
        //            foreach (var method in methods)
        //            {
        //                var attributes = method.GetCustomAttributes(typeof(DocumentAttribute), false);
        //                if (attributes.Length > 0)
        //                {
        //                    var attribute = (DocumentAttribute)attributes[0];
        //                    var doc = new Dictionary<string, string>
        //                {
        //                    {"Type", type.Name},
        //                    {"Method", method.Name},
        //                    {"Description", attribute.Description},
        //                    {"Input", attribute.Input},
        //                    {"Output", attribute.Output}
        //                };
        //                    docs.Add(doc);
        //                }
        //            }
        //        }

        //        // Output to file
        //        var serializer = new JavaScriptSerializer();
        //        var json = serializer.Serialize(docs);
        //        File.WriteAllText("docs.json", json);
        //    }




        //------------------------------------------checck out-----------------------------


        //To File
        //public static void GetDocs()
        //{
        //    var assembly = Assembly.GetExecutingAssembly();

        //    Utility.PrintColorMessage(ConsoleColor.Cyan, "Assembly name: " + assembly.FullName);

        //    Console.WriteLine();

        //    Type[] types = assembly.GetTypes();

        //    // Use StreamWriter to write the output to a text file
        //    using (StreamWriter writer = new StreamWriter("output.txt"))
        //    {
        //        foreach (Type type in types)
        //        {
        //            DisplayType(type);
        //            DisplayConstructor(type);
        //            DisplayProperties(type);
        //            DisplayMethods(type);

        //            // Write the output to the text file
        //            writer.WriteLine(type.ToString());
        //            writer.WriteLine(constructor.ToString());
        //            writer.WriteLine(property.ToString());
        //            writer.WriteLine(method.ToString());

        //            Console.WriteLine();
        //        }
        //    }
        //}


        //Back To Console
        //using (StreamReader reader = new StreamReader("output.txt"))
        //{
        //    string line;
        //    while ((line = reader.ReadLine()) != null)
        //    {
        //        Console.WriteLine(line);
        //    }
        //}


        //TO JSON 
        // using System;
        //using System.IO;
        //using System.Reflection;
        //using Newtonsoft.Json;

        //public static void GetDocs()
        //    {
        //        var assembly = Assembly.GetExecutingAssembly();
        //        Utility.PrintColorMessage(ConsoleColor.Cyan, "Assembly name: " + assembly.FullName);
        //        Console.WriteLine();

        //        Type[] types = assembly.GetTypes();

        //        foreach (Type type in types)
        //        {
        //            DisplayType(type);
        //            DisplayConstructor(type);
        //            DisplayProperties(type);
        //            DisplayMethods(type);
        //            Console.WriteLine();
        //        }

        //        // Serialize the output to a JSON file
        //        string json = JsonConvert.SerializeObject(types);
        //        File.WriteAllText("output.json", json);
        //    }




        //public static void GetDocs()
        //{
        //    var assembly = Assembly.GetExecutingAssembly();

        //    Utility.PrintColorMessage(ConsoleColor.Cyan, "Assembly name: " + assembly.FullName);

        //    Console.WriteLine();

        //    Type[] types = assembly.GetTypes();

        //    var jsonDocs = new List<TypeInformation>();

        //    foreach (Type type in types)
        //    {
        //        var typeInformation = new TypeInformation
        //        {
        //            Type = type,
        //            Constructors = type.GetConstructors(),
        //            Properties = type.GetProperties(),
        //            Methods = type.GetMethods()
        //        };

        //        jsonDocs.Add(typeInformation);
        //    }

        //    string jsonString = JsonSerializer.Serialize(jsonDocs);

        //    File.WriteAllText("docs.json", jsonString);
        //}


        //You will need to create a class TypeInformation and that will have properties for Type, Constructors, Properties, and Methods.
        //You also need to import using System.IO;to use the File class




    }
}
