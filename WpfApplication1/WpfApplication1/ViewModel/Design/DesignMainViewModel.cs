using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1.ViewModel.Design
{
    public class DesignMainViewModel : IMainViewModel
    {

        public static IPerson fakePerson = new Person()
        {
            Name = "Raymond Domenech",
            Age = 62,
            Books = new IBook[0]
        };

        public static IPerson fakePerson2 = new Person()
        {
            Name = "Victor Hugo", 
            Age = 45, 
            Books = new IBook[0]
        };

        public IPerson SelectedPerson
        {
            get
            {
                return fakePerson;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IList<IPerson> AvailablePersons
        {
            get {return new []{fakePerson, fakePerson2}; }
        }

        public int SelectedTabIndex
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public ISummaryTabViewModel SummaryTabViewModel
        {
            get { return new DesignSummaryTabViewModel(); }
        }

        public IBooksReadTabViewModel BooksReadTabViewModel
        {
            get { return new DesignBooksReadTabViewModel(); }
        }
    }
}
