using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace Kwerendy
{
    internal class InstructionsPageTemplate : WordPageTemplate
    {
        private readonly Xceed.Document.NET.Font basicFont = new Xceed.Document.NET.Font("TimesNewRoman");

        protected override void AddHeader(Document document)
        {
            Formatting basicFormatting = new Formatting();
            basicFormatting.Size = 12;
            basicFormatting.FontFamily = basicFont;

            //header isnt't needed so i used normal 
            var hp1 = document.InsertParagraph();
                hp1.Append($"{Properties.Settings.Default.CompanyName}", basicFormatting).Bold();

            var hp2 = document.InsertParagraph();
            hp2.Append($"{Properties.Settings.Default.AddressLine1}     " +
                        $"{Properties.Settings.Default.AddressLine2}     " +
                        $"tel. {Properties.Settings.Default.CompanyPhoneNumber}     " +
                        $"email: {Properties.Settings.Default.CompanyEmailAddress}"
                        + "\n" + $"Konto: {Properties.Settings.Default.CompanyBankAccount}",
                        basicFormatting)
                    .Bold()
                    .Alignment = Alignment.left;
        }

        protected override void AddBody(Document document, Entry entry)
        {
            Formatting basicFormatting = new Formatting();
            basicFormatting.Size = 12;
            basicFormatting.FontFamily = basicFont;

            var tab1 = document.AddTable(1, 2);
            tab1.Rows[0].Cells[0].Paragraphs[0].Append("ZNAK SPRAWY: ", basicFormatting);
            tab1.Rows[0].Cells[0].Paragraphs[0].Append($"{entry.Sign}", basicFormatting).Bold();
            tab1.Rows[0].Cells[1].Paragraphs[0].Append(DateTime.Today.ToShortDateString(), basicFormatting).Alignment = Alignment.right;
            ClearBorder(tab1);
            document.InsertTable(tab1);

            document.InsertParagraph().SpacingAfter(10);

            var tab2 = document.AddTable(3, 2);
            tab2.Rows[1].Cells[1].Paragraphs[0].Append(
                "Sz. P." + "\n" + entry.Name + "\n" + entry.AdressL1 + "\n" + entry.AdressL2, basicFormatting);
            ClearBorder(tab2);
            document.InsertTable(tab2);



            //SPACE
            document.InsertParagraph($"")
                .FontSize(12)
                .SpacingAfter(10);



            var p1 = document.InsertParagraph(); 
            p1.Append("Informujemy, że w naszych zasobach archiwalnych przechowujemy dokumentację:", basicFormatting)
            .Alignment = Alignment.center;

            var p2 = document.InsertParagraph();
            p2.Append($"{entry.Workplace}", basicFormatting).Alignment = Alignment.center;
            p2.SpacingAfter(40);

            var p3 = document.InsertParagraph();
            p3.Append(
                $"Poniżej przedstawiamy krok po kroku jak wygląda procedura " +
                $"wydania dokumentacji z naszego archiwum:", basicFormatting).Alignment = Alignment.both;



            var p4 = document.InsertParagraph();
            p4.Append("1. Osoba upoważniona do otrzymania dokumentacji musi przesłać wypełniony oraz", basicFormatting);
            p4.Append(" odręcznie ", basicFormatting).Bold();
            p4.Append(
                "podpisany wniosek drogą pocztową lub mailową w postaci czytelnego skanu lub " +
                "zdjęcia. Jeśli wniosek na naszym formularzu został już przesłany należy przejść do " +
                "punktu drugiego.", basicFormatting).Alignment = Alignment.both;



            var p5 = document.InsertParagraph();
            p5.Append(
                "2. Aby wniosek został przyjęty należy opłacić pierwszą z dwóch " +
                "opłat za kwerendę (tj. poszukiwanie dokumentacji) w wysokości", basicFormatting);
            p5.Append($" {Properties.Settings.Default.EntryFee} zł " , basicFormatting).Bold();
            p5.Append($"w przeciągu 60 dni kalendarzowych od dnia " +
                $"{DateTime.Today.Date.ToShortDateString()}.", basicFormatting);
            p5.Append(" ! Uwaga ! ", basicFormatting).Bold();
            p5.Append("– przy dokonywaniu wpłat konieczne jest podanie znaku sprawy w tytule przelewu:", basicFormatting);
            p5.Append($" {entry.Sign}.", basicFormatting).Bold();
            p5.Alignment = Alignment.both;



            var p6 = document.InsertParagraph();
            p6.Append(
                $"3. Aktualnie przybliżony czas realizacji kwerendy wynosi " +
                $"około {Properties.Settings.Default.LeadTime} od momentu wpłynięcia " +
                $"opłaty na nasze konto.", basicFormatting);



            var p7 = document.InsertParagraph();
            p7.Append("4. Po przeprowadzeniu kwerendy poinformujemy o wysokości ", basicFormatting);
            p7.Append("drugiej", basicFormatting).Bold().UnderlineStyle(UnderlineStyle.singleLine);
            p7.Append(
                " opłaty. Wysokość drugiej opłaty jest zależna od wyniku poszukiwań oraz " +
                "ilości i postaci dokumentacji.", basicFormatting);



            var p8 = document.InsertParagraph();
            p8.Append(
                "5. Po uiszczeniu drugiej opłaty wysyłamy dokumenty listem poleconym w przeciągu " +
                "maksymalnie 5 dni roboczych od momentu wpłynięcia opłaty na nasze konto.", basicFormatting);
            p8.SpacingAfter(10);



            var p9 = document.InsertParagraph();
            p9.Append("Brak wpłaty w wyznaczonym terminie jest uznawany za rezygnację.", basicFormatting)
            .Alignment = Alignment.center;
        }


    }
}
