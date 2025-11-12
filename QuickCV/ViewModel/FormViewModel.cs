using QuestPDF.Fluent;
using QuickCV.Model;
using QuickCV.View;
using System;
using System.IO;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Navigation;

namespace QuickCV.ViewModel
{
    internal class FormViewModel : ViewModelBase
    {
        public FormViewModel()
        {
            GenerateCommand = new RelayCommand(_createPDF);
        }
        public string Name { get; set;  }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Uri DocumentUri
        {
            get
            {
                return _documentUri;
            }
            private set
            {
                _documentUri = value;
                OnPropertyChanged(nameof(DocumentUri));
            } 
        } 
        
        public ICommand GenerateCommand { get; private set; }

        private void _createPDF()
        {
            Form form = new Form()
            {

                Age = this.Age,
                Name = this.Name,
                LastName = this.LastName
            };

            InvoiceDocument document = new InvoiceDocument(form);
            try
            {
                document.GeneratePdf("cv.pdf");
                Uri path = new Uri(System.IO.Path.GetFullPath("cv.pdf"));
                DocumentUri = new Uri(path.AbsoluteUri + $"?t={DateTime.Now.Ticks}");

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private Uri _documentUri = null;
        

    }
}
