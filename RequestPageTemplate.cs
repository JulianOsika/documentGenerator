using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;

namespace Kwerendy
{
    internal class RequestPageTemplate : WordPageTemplate
    {
        private readonly Xceed.Document.NET.Font basicFont = new Xceed.Document.NET.Font("TimesNewRoman");
        private readonly int basicLineSpacing = 18;
        private readonly int basicSpacingAfter = 15;

        protected override void AddHeader(Document document)
        {
            Formatting basicFormatting = new Formatting();
            basicFormatting.Size = 12;
            basicFormatting.FontFamily = basicFont;

            Paragraph h1 = document.InsertParagraph();
            h1.Append("WNIOSEK O WYDANIE DOKUMENTACJI Z ARCHIWUM",basicFormatting).Alignment = Alignment.center;
            h1.SpacingAfter(basicSpacingAfter);
        }

        protected override void AddBody(Document document, Entry entry)
        {
            Formatting basicFormatting = new Formatting();
            basicFormatting.Size = 12;
            basicFormatting.FontFamily = basicFont;
            basicFormatting.Spacing = 1;


            Paragraph p1 = document.InsertParagraph();
            p1.Append($"Znak sprawy: ", basicFormatting);
            p1.Append($"{entry.Sign}", basicFormatting);
            p1.FontSize(14).Alignment = Alignment.right;

            Paragraph p2 = document.InsertParagraph();
            p2.Append("Wszystkie podpunkty we wniosku są wymagane", basicFormatting).Bold().SpacingAfter(10);

            Paragraph p3 = document.InsertParagraph();
            p3.Append("Imię: \n", basicFormatting);
            p3.Append("Obecne", basicFormatting).Bold();
            p3.Append(" nazwisko: \n", basicFormatting);
            p3.Append("Wszystkie poprzednie nazwiska: \n", basicFormatting);
            p3.Append("Data urodzenia: \n", basicFormatting);
            p3.Append("Imiona rodziców: \n", basicFormatting);
            p3.Append("Obecny", basicFormatting).Bold();
            p3.Append(" adres zamieszkania (korespondencyjny) \n ... \n...", basicFormatting);
            p3.LineSpacing = basicLineSpacing;
            p3.SpacingAfter(basicSpacingAfter);

            Paragraph p4 = document.InsertParagraph();
            p4.Append("Informacje o zatrudnieniu\n", basicFormatting).Bold();
            p4.Append("Pełna nazwa zakładu i miejscowość głównej siedziby" +
                "\n..." +
                "\n...\n", basicFormatting);
            p4.Append("Okres zatrudnienia:\n", basicFormatting);
            p4.LineSpacing = basicLineSpacing;
            p3.SpacingAfter(basicSpacingAfter);

            
            Paragraph p5 = document.InsertParagraph();
            p5.Append("Rodzaj poszukiwanej dokumentacji:\n", basicFormatting).Bold();
            p5.Append("[   ] Świadectwo pracy\n", basicFormatting);
            p5.Append("[   ] Dokumentacja płacowa (karty zarobkowe, listy płac, itp...)\n", basicFormatting);
            p5.Append("[   ] Inna - podać jaka: ...", basicFormatting);
            p5.LineSpacing = basicLineSpacing;
            p5.SpacingAfter(basicSpacingAfter);

            Paragraph p6 = document.InsertParagraph();
            p6.Append("Odbiór dokumentów\n", basicFormatting).Bold();
            p6.Append("[   ] Odbiór osobisty\n", basicFormatting);
            p6.Append("[   ] Wysyłka pocztowa\n", basicFormatting);
            p6.Append("[   ] Odbiór osobisty przez osobę upoważnioną (odrębne upoważnienie)\n", basicFormatting);
            p6.Append("[   ] Wysyłka pocztowa na osobę upoważnioną (odrębne upoważnienie)", basicFormatting);
            p6.LineSpacing = basicLineSpacing;
            p6.SpacingAfter(basicSpacingAfter);

            Paragraph p7 = document.InsertParagraph();
            p7.Append("Oświadczam, że zapoznałem się z regulaminem oraz informacją o przetwarzaniu " +
                "danych osobowych.", basicFormatting);
            p7.LineSpacing = basicLineSpacing;
            p7.SpacingAfter(40);

            var signatureTab = document.AddTable(2, 3);
            signatureTab.Rows[0].Cells[0].Paragraphs[0].Append(".................", basicFormatting);
            signatureTab.Rows[0].Cells[2].Paragraphs[0].Append(".................", basicFormatting);
            signatureTab.Rows[1].Cells[0].Paragraphs[0].Append("Miejscowość i data", basicFormatting).FontSize(10);
            signatureTab.Rows[1].Cells[2].Paragraphs[0].Append("Odręczny podpis", basicFormatting).FontSize(10);

            foreach ( var paragraph in signatureTab.Paragraphs)
            {
                paragraph.Alignment = Alignment.center;
            }

            ClearBorder(signatureTab);
            document.InsertTable(signatureTab);
        }

    }
}
