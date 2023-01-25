using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using AttributeLibrary;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Document = iTextSharp.text.Document;
//using Document = System.Reflection.Metadata.Document;

namespace CodeDocument
{
    internal class InHouseCodeToPdf
    {


        public static class PDFGenerator
        {
            public static string _documentation;

            public static void GetDocs()
            {
                var types = Assembly.GetExecutingAssembly().GetTypes();

                _documentation = "";

                foreach (var type in types)
                {
                    if (type.IsClass)
                    {
                        var typeAttribute = (DocumentAttribute)type.GetCustomAttribute(typeof(DocumentAttribute));

                        if (typeAttribute != null)
                        {
                            _documentation += "Class: " + type.Name + "\n";

                            _documentation += "Description: " + typeAttribute.Description + "\n";

                            _documentation += "Input: " + typeAttribute.Input + "\n";

                            _documentation += "Output: " + typeAttribute.Output + "\n\n";
                        }

                        var constructors = type.GetConstructors();

                        foreach (var constructor in constructors)
                        {
                            var constructorAttribute = (DocumentAttribute)constructor.GetCustomAttribute(typeof(DocumentAttribute));

                            if (constructorAttribute != null)
                            {
                                _documentation += "Constructor: " + constructor.Name + "\n";

                                _documentation += "Description: " + constructorAttribute.Description + "\n";

                                _documentation += "Input: " + constructorAttribute.Input + "\n";

                                _documentation += "Output: " + constructorAttribute.Output + "\n\n";
                            }
                        }

                        var properties = type.GetProperties();

                        foreach (var property in properties)
                        {
                            var propertyAttribute = (DocumentAttribute)property.GetCustomAttribute(typeof(DocumentAttribute));

                            if (propertyAttribute != null)
                            {
                                _documentation += "Property: " + property.Name + "\n";

                                _documentation += "Description: " + propertyAttribute.Description + "\n";

                                _documentation += "Input: " + propertyAttribute.Input + "\n";

                                _documentation += "Output: " + propertyAttribute.Output + "\n\n";
                            }
                        }
                    }
                    else if (type.IsEnum)
                    {
                        var typeattribute = (DocumentAttribute)type.GetCustomAttribute(typeof(DocumentAttribute));

                        if (typeattribute != null)
                        {
                            _documentation += "Enum: " + type.Name + "\n";

                            _documentation += "Description: " + typeattribute.Description + "\n\n\n";
                        }
                    }
                    else if (type.IsInterface)
                    {
                        _documentation += "Interface: " + type.Name + "\n\n";
                    }
                }





                //write output to a pdf file

                try
                {
                    // Check if the documentation variable is not empty or null
                    if (string.IsNullOrEmpty(_documentation))
                    {
                        throw new Exception("The documentation variable is empty or null");
                    }

                    // Set the path and file name for the PDF
                    var pdfFile = "documentation.pdf";

                  

                    // Create a new file stream to write the PDF
                    using (var stream = new FileStream(pdfFile, FileMode.Create))
                    {
                        // Create a new PDF document
                        using (var doc = new Document())
                        {
                            // Set the page size and margins
                            doc.SetPageSize(PageSize.A4);

                            doc.SetMargins(36, 36, 36, 36);

                            // Create a new PDF writer for the document
                            var writer = PdfWriter.GetInstance(doc, stream);

                            // Open the document for writing
                            doc.Open();

                            // Check if the document is open before adding any content
                            if (doc.IsOpen())
                            {
                                // Create a new paragraph with the documentation string
                                var para = new Paragraph(_documentation);

                                // Add the paragraph to the document
                                doc.Add(para);
                            }
                            else
                            {
                                throw new Exception("The document is not open, cannot add content to it.");
                            }

                            // Close the document
                            doc.Close();
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
    }
}












       



 
