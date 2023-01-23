using AttributeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CodeDocumentation
{
    internal class InHouseCode
    {


        public static void GetDocs()
        {
            var assembly = Assembly.GetExecutingAssembly();

            Utility.PrintColorMessage(ConsoleColor.Cyan, "Assembly name: " + assembly.FullName);

            Console.WriteLine();

            Type[] types = assembly.GetTypes();



            //foreach (Type type in types)
            //{
            //    DisplayType(type);

            //    DisplayConstructor(type);

            //    DisplayProperties(type);

            //    DisplayMethods(type);

            //    Console.WriteLine();

            //}

            // Create a dictionary to store the documentation information
               var docs = new Dictionary<string, object>();







            //}


            //    public static void GetDocs()
            //{
            //    // Get the assembly of the calling code
            //    var assembly = Assembly.GetCallingAssembly();

            //    // Get all the types in the assembly
            //    var types = assembly.GetTypes();

            //    // Create a dictionary to store the documentation information
            //    var docs = new Dictionary<string, object>();

            //    // Iterate through each type
            //    foreach (var type in types)
            //    {
            //        // Create a dictionary to store the documentation for the current type
            //        var typeDocs = new Dictionary<string, object>();

            //        // Get the methods and add their documentation to the dictionary
            //        var methods = type.GetMethods();
            //        var methodDocs = new List<Dictionary<string, string>>();
            //        foreach (var method in methods)
            //        {
            //            var documentAttribute = (DocumentAttribute)method.GetCustomAttribute(typeof(DocumentAttribute));
            //            if (documentAttribute != null)
            //            {
            //                var methodDoc = new Dictionary<string, string>();
            //                methodDoc.Add("Name", method.Name);
            //                methodDoc.Add("Description", documentAttribute.Description);
            //                if (!string.IsNullOrEmpty(documentAttribute.Input))
            //                {
            //                    methodDoc.Add("Input", documentAttribute.Input);
            //                }
            //                if (!string.IsNullOrEmpty(documentAttribute.Output))
            //                {
            //                    methodDoc.Add("Output", documentAttribute.Output);
            //                }
            //                methodDocs.Add(methodDoc);
            //            }
            //        }
            //        typeDocs.Add("Methods", methodDocs);

            //        // Get the properties and add their documentation to the dictionary
            //        var properties = type.GetProperties();
            //        var propertyDocs = new List<Dictionary<string, string>>();
            //        foreach (var property in properties)
            //        {
            //            var documentattribute = (DocumentAttribute)property.GetCustomAttribute(typeof(DocumentAttribute));
            //            if (documentattribute != null)
            //            {
            //                var propertyDoc = new Dictionary<string, string>();
            //                propertyDoc.Add("Name", property.Name);
            //                propertyDoc.Add("Description", documentattribute.Description);
            //                propertyDocs.Add(propertyDoc);
            //            }
            //        }
            //        typeDocs.Add("Properties", propertyDocs);

            //        // Get the constructors and add their documentation to the dictionary
            //        var constructors = type.GetConstructors();
            //        var constructorDocs = new List<Dictionary<string, string>>();
            //        foreach (var constructor in constructors)
            //        {
            //            var documentattribute = (DocumentAttribute)constructor.GetCustomAttribute(typeof(DocumentAttribute));
            //            if (documentattribute != null)
            //            {
            //                var constructorDoc = new Dictionary<string, string>();
            //                constructorDoc.Add("Name", constructor.Name);
            //                constructorDoc.Add("Description", documentattribute.Description);
            //                if (!string.IsNullOrEmpty(documentattribute.Input))
            //                {
            //                    constructorDoc.Add("Input", documentattribute.Input);
            //                }
            //                if (!string.IsNullOrEmpty(documentattribute.Output))
            //                {
            //                    constructorDoc.Add("Output", documentattribute.Output);
            //                }
            //                constructorDocs.Add(constructorDoc);
            //            }
            //        }
            //        typeDocs.Add("Constructors", constructorDocs);

            //        // Get the type documentation and add it to the dictionary
            //        var documentattributeType = (DocumentAttribute)type.GetCustomAttribute(typeof(DocumentAttribute));
            //        if (documentattributeType != null)
            //        {
            //            typeDocs.Add("Name", type.Name);
            //            typeDocs.Add("Description", documentattributeType.Description);
            //            typeDocs.Add("Type", type.IsClass ? "Class" : (type.IsEnum ? "Enum" : "Interface"));
            //        }
            //        docs.Add(type.Name, typeDocs);
            //    }

            //    // Write the documentation to a file
            //    using (StreamWriter file = new StreamWriter("docs.txt"))
            //    {
            //        foreach (var doc in docs)
            //        {
            //            file.WriteLine(doc.Key + ":");
            //            if (doc.Value is Dictionary<string, object>)
            //            {
            //                var typeDoc = (Dictionary<string, object>)doc.Value;
            //                foreach (var item in typeDoc)
            //                {
            //                    if (item.Value is List<Dictionary<string, string>>)
            //                    {
            //                        file.WriteLine("\t" + item.Key + ":");
            //                        foreach (var subitem in (List<Dictionary<string, string>>)item.Value)
            //                        {
            //                            file.WriteLine("\t\t" + subitem["Name"]);
            //                            file.WriteLine("\t\t\tDescription: " + subitem["Description"]);
            //                            if (subitem.ContainsKey("Input"))
            //                            {
            //                                file.WriteLine("\t\t\tInput: " + subitem["Input"]);
            //                            }
            //                            if (subitem.ContainsKey("Output"))
            //                            {
            //                                file.WriteLine("\t\t\tOutput: " + subitem["Output"]);
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }








            static void DisplayMethods(Type type)
            {
                var methods = type.GetMethods();

                foreach (var method in methods)
                {
                    var documentattribute = (DocumentAttribute)method.GetCustomAttribute(typeof(DocumentAttribute));

                    if (documentattribute != null)
                    {
                        Utility.PrintColorMessage(ConsoleColor.Yellow, "\t Method: " + method.Name);

                        Utility.PrintColorMessage(ConsoleColor.Yellow, "\t Description: " + documentattribute.Description);

                        if (!string.IsNullOrEmpty(documentattribute.Input))
                        {
                            Utility.PrintColorMessage(ConsoleColor.Yellow, "\t Input: " + documentattribute.Input);
                        }

                        if (!string.IsNullOrEmpty(documentattribute.Output))
                        {
                            Utility.PrintColorMessage(ConsoleColor.Yellow, "\t Output: " + documentattribute.Output + "\n");
                        }
                    }
                }
            }





            // Display properties

            static void DisplayProperties(Type type)
            {

                var properties = type.GetProperties();

                foreach (var property in properties)
                {
                    //Gets custom attribute  to property variable. The returned attribute is then being assigned to the documentattribute variable.
                    var documentattribute = (DocumentAttribute)property.GetCustomAttribute(typeof(DocumentAttribute));

                    if (documentattribute != null)
                    {
                        Utility.PrintColorMessage(ConsoleColor.Yellow, "\t Property: " + property.Name);

                        Utility.PrintColorMessage(ConsoleColor.Cyan, "\t Description: " + documentattribute.Description + "\n");
                    }


                }
            }


            //// Display constructors
            static void DisplayConstructor(Type type)
            {

                var constructors = type.GetConstructors();

                foreach (var constructor in constructors)
                {
                    var documentattribute = (DocumentAttribute)constructor.GetCustomAttribute(typeof(DocumentAttribute));

                    if (documentattribute != null)
                    {
                        Utility.PrintColorMessage(ConsoleColor.Cyan, "\t Constructor: " + constructor.Name);

                        Utility.PrintColorMessage(ConsoleColor.Cyan, "\t Description: " + documentattribute.Description);

                        if (!string.IsNullOrEmpty(documentattribute.Input))
                        {
                            Utility.PrintColorMessage(ConsoleColor.Yellow, "\t Input: " + documentattribute.Input);
                        }

                        if (!string.IsNullOrEmpty(documentattribute.Output))
                        {
                            Utility.PrintColorMessage(ConsoleColor.Yellow, "\t Output: " + documentattribute.Output + "\n");
                        }
                    }

                }
            }

            static void DisplayType(Type type)
            {
                var documentAttribute = (DocumentAttribute)type.GetCustomAttribute(typeof(DocumentAttribute));

                if (documentAttribute != null && type.IsClass)
                {
                    Utility.PrintColorMessage(ConsoleColor.Yellow, "Class: " + type.Name);

                    Utility.PrintColorMessage(ConsoleColor.Yellow, "Description: " + documentAttribute.Description);

                    Console.WriteLine();

                }
                else if (documentAttribute != null && type.IsEnum)
                {
                    Utility.PrintColorMessage(ConsoleColor.Cyan, "Enum: " + type.Name);

                    Utility.PrintColorMessage(ConsoleColor.Cyan, "Description: " + documentAttribute.Description + "\n");

                    Console.WriteLine();
                }
                else if (documentAttribute != null && type.IsInterface)
                {
                    Utility.PrintColorMessage(ConsoleColor.Cyan, "Interface: " + type.Name);

                    Utility.PrintColorMessage(ConsoleColor.Cyan, "Description: " + documentAttribute.Description + "\n");
                }
            }
        }


        //    // Write the documentation to a file
        //    using (StreamWriter file = new StreamWriter("docs.txt"))
        //    {
        //        foreach (var doc in docs)
        //        {
        //            file.WriteLine(doc.Key + ":");
        //            if (doc.Value is Dictionary<string, object>)
        //            {
        //                var typeDoc = (Dictionary<string, object>)doc.Value;
        //                foreach (var item in typeDoc)
        //                {
        //                    if (item.Value is List<Dictionary<string, string>>)
        //                    {
        //                        file.WriteLine("\t" + item.Key + ":");
        //                        foreach (var subitem in (List<Dictionary<string, string>>)item.Value)
        //                        {
        //                            file.WriteLine("\t\t" + subitem["Name"]);
        //                            file.WriteLine("\t\t\tDescription: " + subitem["Description"]);
        //                            if (subitem.ContainsKey("Input"))
        //                            {
        //                                file.WriteLine("\t\t\tInput: " + subitem["Input"]);
        //                            }
        //                            if (subitem.ContainsKey("Output"))
        //                            {
        //                                file.WriteLine("\t\t\tOutput: " + subitem["Output"]);
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }






    }
}

    

