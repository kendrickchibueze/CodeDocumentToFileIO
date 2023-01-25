using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using AttributeLibrary;
using CodeDocumentation;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Document = iTextSharp.text.Document;


namespace CodeDocument
{
    internal class InHouseCodeToPdf
    {
        public static void CreateAndReadPDF()
        {

            Console.Clear();

            Utility.PrintColorMessage(ConsoleColor.Cyan, "************ Welcome to the In-House Code Documentation Tool(PDF)********\n\n");


            string documentation = InHouse.GetDocs();

            //create a pdf file and write to it

            using (FileStream fs = new FileStream("Besters.pdf", FileMode.Create))
            {
                using (Document doc = new Document())
                {
                    using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
                    {
                        doc.Open();

                        doc.Add(new Paragraph(documentation));

                        doc.Close();

                       
                    }
                }
                
            }

           


            //read from pdf to the console

            using (PdfReader reader = new PdfReader("Besters.pdf"))
            {
                StringBuilder text = new StringBuilder();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
                Console.WriteLine(text.ToString());
            }


        }

    }
}












       



 
