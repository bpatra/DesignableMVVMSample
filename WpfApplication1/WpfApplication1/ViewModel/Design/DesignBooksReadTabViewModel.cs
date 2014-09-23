using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace WpfApplication1.ViewModel.Design
{
    internal class DesignBooksReadTabViewModel
        : IBooksReadTabViewModel
    {
        public ObservableCollection<string> BooksRead
        {
            get { return new ObservableCollection<string>(new[] {"1984 Georges Orwell", "Animal Farm"}); }
        }
    }
}
