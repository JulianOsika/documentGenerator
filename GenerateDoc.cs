using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;


namespace Kwerendy
{
    public static class GenerateDoc
    {
        public static void Generate(string folderPath, List<Entry> registrations)
        {
            InstructionsPageTemplate instructionsPageTemplate = new InstructionsPageTemplate();
            RequestPageTemplate requestPageTemplate = new RequestPageTemplate();
            RodoPageTemplate rodoPageTemplate = new RodoPageTemplate();

            string wordFilePath = folderPath + $"\\kw_{DateTime.Today.ToShortDateString()}";
            var doc = DocX.Create(wordFilePath);
            foreach (Entry entry in registrations)
            {
                instructionsPageTemplate.FillPage(doc, entry);
                doc.InsertParagraph().InsertPageBreakAfterSelf();
                doc.InsertParagraph().InsertPageBreakAfterSelf();

                instructionsPageTemplate.FillPage(doc, entry);
                doc.InsertParagraph().InsertPageBreakAfterSelf();
                doc.InsertParagraph().InsertPageBreakAfterSelf();

                if ( !entry.Description.Contains("@") )
                {
                    requestPageTemplate.FillPage(doc, entry);
                    
                    rodoPageTemplate.FillPage(doc, entry);
                    doc.InsertParagraph().InsertPageBreakAfterSelf();
                }

                PdfGenerator.CreatePdf(folderPath, entry);
            }

            // FOOTER - old version is good, left this code
            doc.DifferentOddAndEvenPages = true;
            doc.AddFooters();
            var footer = doc.Footers.Odd;
            var fPara1 = footer.InsertParagraph("Regulamin dostępny na stronie www.zlsp.org.pl");
            fPara1.Font("TimesNewRoman").FontSize(8).Alignment = Alignment.both;
            var fPara2 = footer.InsertParagraph("Opłata naliczana jest na podstawie Rozporządzenia Ministra Kultury z dnia 10 lutego 2005 r. i Regulaminu ZLSP");
            fPara2.Font("TimesNewRoman").FontSize(8).Alignment = Alignment.both;

            doc.Save();
        }

    }
}
