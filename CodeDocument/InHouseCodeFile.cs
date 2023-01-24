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

namespace CodeDocument
{
    internal class InHouseCodeFile {


        public static string GetDocs()
        {
            // Get all types in the assembly
            var types = Assembly.GetExecutingAssembly().GetTypes();

            // Create a string to store the documentation
            string documentation = "";

            // Loop through each type
            foreach (var type in types)
            {
                // Check if the type is a class
                if (type.IsClass)
                {
                    // Get the DocumentAttribute for the class, if it exists
                    var typeAttribute = (DocumentAttribute)type.GetCustomAttribute(typeof(DocumentAttribute));

                    // If the class has the DocumentAttribute, add its documentation to the string
                    if (typeAttribute != null)
                    {
                        documentation += "Class: " + type.Name + "\n";

                        documentation += "Description: " + typeAttribute.Description + "\n";

                        documentation += "Input: " + typeAttribute.Input + "\n";

                        documentation += "Output: " + typeAttribute.Output + "\n\n";
                    }

                    // Get the constructors of the class
                    var constructors = type.GetConstructors();

                    // Loop through each constructor
                    foreach (var constructor in constructors)
                    {
                        // Get the DocumentAttribute for the constructor, if it exists
                        var constructorAttribute = (DocumentAttribute)constructor.GetCustomAttribute(typeof(DocumentAttribute));

                        // If the constructor has the DocumentAttribute, add its documentation to the string
                        if (constructorAttribute != null)
                        {
                            documentation += "Constructor: " + constructor.Name + "\n";

                            documentation += "Description: " + constructorAttribute.Description + "\n";

                            documentation += "Input: " + constructorAttribute.Input + "\n";

                            documentation += "Output: " + constructorAttribute.Output + "\n\n";
                        }
                    }

                    // Get the properties of the class
                    var properties = type.GetProperties();

                    // Loop through each property
                    foreach (var property in properties)
                    {
                        // Get the DocumentAttribute for the property, if it exists
                        var propertyAttribute = (DocumentAttribute)property.GetCustomAttribute(typeof(DocumentAttribute));

                        // If the property has the DocumentAttribute, add its documentation to the string
                        if (propertyAttribute != null)
                        {
                            documentation += "Property: " + property.Name + "\n";

                            documentation += "Description: " + propertyAttribute.Description + "\n";

                            documentation += "Input: " + propertyAttribute.Input + "\n";

                            documentation += "Output: " + propertyAttribute.Output + "\n\n";
                        }
                    }
                }
                // Check if the type is an Enum
                else if (type.IsEnum)
                {
                    var typeattribute = (DocumentAttribute)type.GetCustomAttribute(typeof(DocumentAttribute));

                    if (typeattribute != null)
                    {
                        documentation += "Enum: " + type.Name + "\n";

                        documentation += "Description: " + typeattribute.Description + "\n\n\n";
                    }
                }
            
            
                // Check if the type is an Interface
                else if (type.IsInterface)
                {
                    documentation += "Interface: " + type.Name + "\n\n";
                }
            }


            // Create a StreamWriter to write the documentation to a file
            using (StreamWriter writer = new StreamWriter("documentationTwo.txt"))
            {
                writer.Write(documentation);
            }

            // Now read data from file.
            
            using (StreamReader sr = File.OpenText("documentationTwo.txt"))
            {
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }



            return documentation;
            


            Console.ReadLine();

           



        }



        public static void RunJSONfile()
        {
            string document = GetDocs();
            SaveAsJsonFormat(document, "documentation.json");
        }



      


        public static void SaveAsJsonFormat<T>(T objGraph, string fileName)
        {

            var options = new JsonSerializerOptions
            {
                //PropertyNamingPolicy = null,
                //IncludeFields = true,
                //WriteIndented = true,



                PropertyNameCaseInsensitive = true,
                //PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNamingPolicy = null, //Pascal casing
                IncludeFields = true,
                WriteIndented = true,
                NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString
            };

            File.WriteAllText(fileName, System.Text.Json.JsonSerializer.Serialize(objGraph, options));



        }




    }
}
