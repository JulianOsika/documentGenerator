using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;

namespace Kwerendy
{
    internal class RodoPageTemplate : WordPageTemplate
    {
        private readonly Xceed.Document.NET.Font basicFont = new Xceed.Document.NET.Font("TimesNewRoman");

        private readonly string information = "Z uwagi na obowiązujące przepisy o ochronie danych osobowych, " +
            "zamieszczamy poniżej informację o zasadach przetwarzania Państwa danych osobowych " +
            "przekazanych na WNIOSKU o wydanie dokumentacji oraz o przetwarzaniu wynikającym z " +
            "naszych działań związanych z kompletowaniem i przekazaniem Państwu dokumentów z Archiwum. " +
            "Uprzejmie prosimy o zapoznanie się z informacją. Przetwarzanie danych Państwa dane " +
            "osobowe, podane we WNIOSKU o wydanie zaświadczenia, w postaci: imienia, nazwiska, " +
            "nazwiska panieńskiego- jeżeli ma zastosowanie, daty urodzenia, imienia ojca i matki, " +
            "danych spółdzielni (byłego pracodawcy) i okresu zatrudnienia, danych adresowych, numeru " +
            "telefonu są przetwarzane przez Związek Lustracyjny Spółdzielni z siedzibą w Warszawie " +
            "przy ul. Żurawiej 47. Przetwarzanie jest niezbędne do realizacji Państwa uprawnienia " +
            "do otrzymania zaświadczenia lub kopii dokumentów kadrowo-płacowych z Archiwum.Jeżeli " +
            "kontaktują się Państwo z Archiwum za pomocą poczty elektronicznej, to Państwa adres " +
            "e-mail może być wykorzystywany do komunikacji związanej z przygotowaniem dokumentów o " +
            "które Państwo wnioskowali. Przy zapłacie przelewem, dane rachunku bankowego będą " +
            "przetwarzane w celu prowadzenia rozliczeń i archiwalnym. Pracownicy Archiwum mogą " +
            "zwrócić się do Państwa o podanie innych, dodatkowych informacji i danych osobowych " +
            "jeżeli skompletowanie dokumentacji na podstawie WNIOSKU o wydanie zaświadczenia okaże " +
            "się niemożliwe. Jeżeli upoważniają Państwo inne osoby do odbioru dokumentacji lub " +
            "innych działań, będziemy kontrolować i przechowywać upoważnienia. Odbiorcami Państwa " +
            "danych osobowych mogą być organy publiczne (które mogą otrzymywać dane w ramach " +
            "konkretnego postępowania) oraz upoważnione przez administratora (czyli Związek " +
            "Lustracyjny Spółdzielni) osoby i podmioty świadczące usługi na jego rzecz. Jeżeli " +
            "skorzystali Państwo z możliwości upoważnienia innej osoby do odbioru dokumentacji " +
            "lub prowadzeniu korespondencji w Państwa imieniu, odbiorcami danych będą również te " +
            "osoby. Związek Lustracyjny Spółdzielni wdrożył odpowiednie środki techniczne i " +
            "organizacyjne aby przetwarzanie danych odbywało się zgodnie z RODO* i innymi przepisami " +
            "z zakresu ochrony danych osobowych. Po wydaniu dokumentacji, WNIOSEK i Państwa dane " +
            "osobowe będą przechowywane, przez okres wskazany dla danego rodzaju sprawy w " +
            "obowiązującym jednolitym rzeczowym wykazie akt dla archiwów państwowych, który wynosi " +
            "20 lat od daty wydania dokumentu. Dane osobowe przetwarzane w celu prowadzenia " +
            "rozliczeń i dokumentacji księgowej będą przechowywane przez okres wynikający z " +
            "przepisów podatkowych oraz ustawy o rachunkowości. Jeżeli zajdzie konieczność " +
            "rozpatrzenia reklamacji, to niezbędne dane będą przechowywane do zakończenia tego " +
            "postępowania. WNIOSEK o wydanie zaświadczenia przechowujemy przez okres przewidziany " +
            "dla przechowywania akt. Prawa i dalsze informacje Mają Państwo prawo żądania dostępu " +
            "do treści swoich danych oraz prawo do sprostowania nieprawidłowych danych (nie dotyczy " +
            "danych w dokumentacji archiwalnej). Mają również Państwo prawo do usunięcia lub " +
            "ograniczenia przetwarzania swoich danych oraz prawo wniesienia sprzeciwu wobec " +
            "przetwarzania, te prawa przysługują w określonych przypadkach wskazanych w Art.17, " +
            "Art.18 i Art.21 RODO. Przysługuje Państwu również prawo do wniesienia skargi do organu " +
            "nadzorczego - Prezesa Urzędu Ochrony Danych Osobowych. Podanie danych jest niezbędne do " +
            "wydania zaświadczenia lub kopii dokumentów archiwalnych, jeżeli Państwo ich nie podadzą " +
            "pracownicy Archiwum nie będą mogli skompletować dokumentów oraz nie będą w stanie " +
            "dokonać weryfikacji czy po dokumenty zgłosiła się właściwa, uprawniona osoba, a bez " +
            "takiej pewności nie możemy wydać zaświadczenia lub kopii dokumentów. Dane kontaktowe: " +
            "Związek Lustracyjny Spółdzielni ul. Żurawia 47, 00-680 Warszawa, www.zlsp.org.pl " +
            "Kontakt do inspektora ochrony danych, e-mail: iod@zlsp.org.pl";

        private readonly string RODO = "*RODO - Rozporządzenie Parlamentu Europejskiego i Rady " +
            "Unii Europejskiej 2016/679 z dnia 27 kwietnia 2016 r. w sprawie ochrony osób fizycznych " +
            "w związku z przetwarzaniem danych osobowych i w sprawie swobodnego przepływu takich " +
            "danych oraz uchylenia dyrektywy 95/46/WE.";

        protected override void AddHeader(Document document)
        {
            Formatting basicFormatting = new Formatting();
            basicFormatting.Size = 12;
            basicFormatting.FontFamily = basicFont;

            Paragraph h1 = document.InsertParagraph();
            h1.Append("INFORMACJA O PRZETWARZANIU DANYCH OSOBOWYCH", basicFormatting)
                .Alignment = Alignment.center;

        }

        protected override void AddBody(Document document, Entry entry)
        {
            Formatting basicFormatting = new Formatting();
            basicFormatting.Size = 12;
            basicFormatting.FontFamily = basicFont;

            Paragraph p1 = document.InsertParagraph();
            p1.Append(information, basicFormatting).Alignment = Alignment.both;
            p1.LineSpacing = 11;
            p1.SpacingAfter(9);

            Paragraph p2 = document.InsertParagraph();
            p2.Append(RODO, basicFormatting).FontSize(8). Alignment = Alignment.both;
            
            

        }

    }
}
