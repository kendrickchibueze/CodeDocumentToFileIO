using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeDocument
{
    //internal class WalkThrough { }
    

//        using System;
//using System.IO;
//using System.Reflection;
//using iTextSharp.text;
//using iTextSharp.text.pdf;

//public class PdfWriter
//    {
//        public void WritePdf(string fileName)
//        {
//            var assembly = Assembly.GetExecutingAssembly();

//            string assemblyName = assembly.FullName;
//            Type[] types = assembly.GetTypes();

//            using (FileStream fs = new FileStream(fileName, FileMode.Create))
//            {
//                using (Document doc = new Document(PageSize.A4, 25, 25, 30, 30))
//                {
//                    using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
//                    {
//                        doc.Open();

//                        doc.Add(new Paragraph("Assembly name: " + assemblyName));
//                        doc.Add(Chunk.NEWLINE);

//                        foreach (Type type in types)
//                        {
//                            doc.Add(new Paragraph("Type: " + type.Name));
//                            doc.Add(Chunk.NEWLINE);

//                            // Display Constructor
//                            ConstructorInfo[] constructors = type.GetConstructors();
//                            if (constructors.Length > 0)
//                            {
//                                doc.Add(new Paragraph("Constructors: "));
//                                doc.Add(Chunk.NEWLINE);
//                                foreach (ConstructorInfo constructor in constructors)
//                                {
//                                    doc.Add(new Paragraph("  " + constructor.ToString()));
//                                    doc.Add(Chunk.NEWLINE);
//                                }
//                            }

//                            // Display Properties
//                            PropertyInfo[] properties = type.GetProperties();
//                            if (properties.Length > 0)
//                            {
//                                doc.Add(new Paragraph("Properties: "));
//                                doc.Add(Chunk.NEWLINE);
//                                foreach (PropertyInfo property in properties)
//                                {
//                                    doc.Add(new Paragraph("  " + property.ToString()));
//                                    doc.Add(Chunk.NEWLINE);
//                                }
//                            }

//                            // Display Methods
//                            MethodInfo[] methods = type.GetMethods();
//                            if (methods.Length > 0)
//                            {
//                                doc.Add(new Paragraph("Methods: "));
//                                doc.Add(Chunk.NEWLINE);
//                                foreach (MethodInfo method in methods)
//                                {
//                                    doc.Add(new Paragraph("  " + method.ToString()));
//                                    doc.Add(Chunk.NEWLINE);
//                                }
//                            }
//                        }

//                        doc.Close();
//                    }
//                }
//            }
//        }
//    }


}
//}
