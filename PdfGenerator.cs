using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using MigraDoc.DocumentObjectModel.Tables;

namespace Kwerendy
{
    public static class PdfGenerator
    {
        public static void CreatePdf(string folderPath, Entry entry)
        {
            string pdfFilePath = folderPath + $"\\kw_{entry.Sign}.pdf";
            Document doc = new Document();
            Section section = doc.AddSection();

            Style style = doc.Styles["Normal"];
            style.Font.Name = "Times New Roman";
            style.Font.Size = 12;
            style.ParagraphFormat.Alignment = ParagraphAlignment.Justify;


            // NAGŁÓWEK
            Paragraph p1 = section.AddParagraph();
            p1.AddText($"{Properties.Settings.Default.CompanyName}");
            p1.Format.Font.Size = 15;
            p1.Format.Font.Bold = true;
            p1.Format.Alignment = ParagraphAlignment.Left;

            Paragraph p2 = section.AddParagraph();
            p2.AddText(
                $"{Properties.Settings.Default.AddressLine1}, " +
                $"{Properties.Settings.Default.AddressLine2}, " +
                $"tel. {Properties.Settings.Default.CompanyPhoneNumber},\n" +
                $"email: {Properties.Settings.Default.CompanyEmailAddress}"
                + "\n" + $"Konto: {Properties.Settings.Default.CompanyBankAccount}");
            p2.Format.Font.Bold = true;
            p2.Format.Alignment = ParagraphAlignment.Left;


            // TABELA - ZNAK I DATA
            Table tab = section.AddTable();
            tab.Borders.Width = 0;

            tab.AddColumn(Unit.FromCentimeter(8));
            tab.AddColumn(Unit.FromCentimeter(8));

            Row row00 = tab.AddRow();
            Paragraph tabPar1 = row00.Cells[0].AddParagraph($"ZNAK SPRAWY: ");
            tabPar1.AddFormattedText($"{entry.Sign}", TextFormat.Bold);
            Paragraph tabPar2 = row00.Cells[1].AddParagraph($"{DateTime.Today.ToShortDateString()}");
            tabPar2.Format.Alignment = ParagraphAlignment.Right;



            // ODSTĘP
            Paragraph parBlank1 = section.AddParagraph();
            parBlank1.Format.SpaceAfter = 10;



            // TABELA - ADRESAT
            Table table = section.AddTable();
            table.Borders.Width = 0;

            table.AddColumn(Unit.FromCentimeter(8));
            table.AddColumn(Unit.FromCentimeter(8));

            Row row0 = table.AddRow();
            row0.Cells[1].AddParagraph("Sz. P.");
            var nameParagraph = row0.Cells[1].AddParagraph();
            nameParagraph.AddText(
                $"{entry.Name}\n" +
                $"{entry.AdressL1}\n" +
                $"{entry.AdressL2}");
            nameParagraph.Format.Alignment = ParagraphAlignment.Left;

            table.AddRow();
            table.AddRow();


            // SPACE
            Paragraph parBlank3 = section.AddParagraph();
            parBlank3.Format.SpaceAfter = 15;

            Paragraph p3 = section.AddParagraph();
            p3.AddText(
                $"Informujemy, że w naszych zasobach archiwalnych przechowujemy dokumentację:" + 
                "\n" + $"{entry.Workplace}");
            p3.Format.Alignment = ParagraphAlignment.Center;
            p3.Format.SpaceAfter = 34;


            Paragraph p4 = section.AddParagraph();
            p4.AddText("Poniżej przedstawiamy krok po kroku jak wygląda procedura wydania dokumentacji z " +
                "naszego archiwum:");
            p4.Format.FirstLineIndent = 20;

            Paragraph p5 = section.AddParagraph();
            p5.AddText("1. Osoba upoważniona do otrzymania dokumentacji musi przesłać wypełniony oraz ");
            p5.AddFormattedText("odręcznie", TextFormat.Bold);
            p5.AddText(" podpisany wniosek drogą pocztową lub mailową w postaci czytelnego skanu lub zdjęcia. " +
                "Jeśli wniosek na naszym formularzu został już przesłany należy przejść do punktu drugiego.");


            Paragraph p6 = section.AddParagraph();
            p6.AddText(
                "2. Aby wniosek został przyjęty należy opłacić pierwszą z dwóch opłat za kwerendę " +
                "(tj. poszukiwanie dokumentacji) w wysokości ");
            p6.AddFormattedText($"{Properties.Settings.Default.EntryFee} zł", TextFormat.Bold);
            p6.AddText($" w przeciągu 60 dni kalendarzowych od dnia {DateTime.Today.Date.ToShortDateString()}. ");
            p6.AddFormattedText($"! Uwaga !", TextFormat.Bold);
            p6.AddText(" – przy dokonywaniu wpłat ");
            p6.AddFormattedText($"konieczne", TextFormat.Bold);
            p6.AddText(" jest podanie znaku sprawy w tytule przelewu: ");
            p6.AddFormattedText($"{entry.Sign}.", TextFormat.Bold);


            Paragraph p7 = section.AddParagraph();
            p7.AddText(
                $"3. Aktualnie przybliżony czas realizacji kwerendy wynosi około " +
                $"{Properties.Settings.Default.LeadTime} od nmomentu wpłynięcia opłaty na nasze konto.");


            Paragraph p8 = section.AddParagraph();
            p8.AddText($"Po przeprowadzeniu kwerendy poinformujemy o wysokości ");
            p8.AddFormattedText("drugiej", TextFormat.Bold);
            p8.AddText(
                " opłaty. Wysokośćdrugiej opłaty jest zależna od wyniku poszukiwań oraz ilości i postaci " +
                "dokumentacji.");


            Paragraph p9 = section.AddParagraph();
            p9.AddText("5. Po uiszczeniu drugiej opłaty wysyłamy dokumenty listem poleconym w przeciągu " +
                "maksymalnie 5 dni roboczych od momentu wpłynięcia opłaty na nasze konto.");
            p9.Format.SpaceAfter = 10;

            Paragraph p10 = section.AddParagraph();
            p10.AddText("Brak wpłaty w wyznaczonym terminie jest uznawany za rezygnację.");
            p10.Format.Alignment = ParagraphAlignment.Center;


            // SIGNATURE
            MigraDoc.DocumentObjectModel.Shapes.Image image = section.AddImage(MyTools.signatureFilePath);
            image.Width = 100;
            image.Left = 300;

            // Footer
            Paragraph fp1 = section.Footers.Primary.AddParagraph("Regulamin dostępny na stronie www.zlsp.org.pl");
            fp1.Format.Font.Size = 8;

            Paragraph fp2 = section.Footers.Primary.AddParagraph(
                "Opłata naliczana jest na podstawie Rozporządzenia " +
                "Ministra Kultury z dnia 10 lutego 2005 r. i Regulaminu ZLSP");
            fp2.Format.Font.Size = 8;

            //Renderowanie
            PdfDocumentRenderer renderer = new PdfDocumentRenderer();
            renderer.Document = doc;
            renderer.RenderDocument();
            renderer.Save(pdfFilePath);
        }
    }
}
