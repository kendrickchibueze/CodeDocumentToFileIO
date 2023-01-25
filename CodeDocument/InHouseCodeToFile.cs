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
    public class InHouseCodeToFile {


        public static void GetDocs()
        {
            
            var types = Assembly.GetExecutingAssembly().GetTypes();

            
            string documentation = "";

            
            foreach (var type in types)
            {
                
                if (type.IsClass)
                {
                    
                    var typeAttribute = (DocumentAttribute)type.GetCustomAttribute(typeof(DocumentAttribute));

                    // If the class has the DocumentAttribute, add its documentation to the string

                    if (typeAttribute != null)
                    {
                        documentation += "Class: " + type.Name + "\n";

                        documentation += "Description: " + typeAttribute.Description + "\n";

                        documentation += "Input: " + typeAttribute.Input + "\n";

                        documentation += "Output: " + typeAttribute.Output + "\n\n";
                    }

                    
                    var constructors = type.GetConstructors();

                  
                    foreach (var constructor in constructors)
                    {
                        
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

                    
                    var properties = type.GetProperties();

                    
                    foreach (var property in properties)
                    {
                       
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


            //Create a StreamWriter to write the documentation to a file

            using (StreamWriter writer = new StreamWriter("documentationTwo.txt"))
            {
                writer.Write(documentation);
            }

            // Now read data from file to console

            using (StreamReader sr = File.OpenText("documentationTwo.txt"))
            {
                string input = null;

                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }




        }











    }
}
