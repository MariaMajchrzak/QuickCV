using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickCV.Model
{
    internal class InvoiceDocument : IDocument
    {
        public InvoiceDocument(Form data)
        {
            _data = data;
        }
        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                //page.PageColor(Color.FromRGB(255, 0, 0));
                page.Content().Text(
                    "name: " + _data.Name + "\n" +
                    "last name " + _data.LastName + "\n"+
                    "age: " + _data.Age
                    );
            });
        }

        public DocumentMetadata GetMetadata()
        {
            return DocumentMetadata.Default;
        }

        public DocumentSettings GetSettings()
        {
            return DocumentSettings.Default;
        }

        private Form _data;
    }
}
