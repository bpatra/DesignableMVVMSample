using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1.ViewModel
{
    public interface IBook
    {
        string Title { get; }

        string SelectedGenre { get; set; }

        List<string> AllAvailableGenres { get; }
    }
}
