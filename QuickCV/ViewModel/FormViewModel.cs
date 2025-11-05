using QuestPDF.Fluent;
using QuickCV.Model;
using System;
using System.Windows;
using System.Windows.Input;

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
                document.GeneratePdfAndShow();

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
