using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace Kwerendy
{
    public abstract class WordPageTemplate
    {
        public void FillPage(Document document, Entry entry)
        {
            document.AddHeaders();
            document.AddFooters();

            Header header = document.Headers.Odd;
            AddHeader(document);

            AddBody(document, entry);

        }

        protected abstract void AddHeader(Document document);
        protected abstract void AddBody(Document document, Entry entry);

        protected void ClearBorder(Xceed.Document.NET.Table tab)
        {
            var myBorder = new Border(Xceed.Document.NET.BorderStyle.Tcbs_none, 0, 0, System.Drawing.Color.White);
            foreach (var row in tab.Rows)
            {
                foreach (var cell in row.Cells)
                {
                    cell.SetBorder(TableCellBorderType.Left, myBorder);
                    cell.SetBorder(TableCellBorderType.Right, myBorder);
                    cell.SetBorder(TableCellBorderType.Top, myBorder);
                    cell.SetBorder(TableCellBorderType.Bottom, myBorder);
                }
            }
        }


    }
}
