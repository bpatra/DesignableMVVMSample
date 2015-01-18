using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace WpfApplication1.ViewModel
{
    public interface IBooksWrittenTabViewModel
    {
        ObservableCollection<IBook> BooksWritten { get; }

         List<string> AllAvailableGenres { get; }

        IBook SelectedBook { get; set; }
    }
}
