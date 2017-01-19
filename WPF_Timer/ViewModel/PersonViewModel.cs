using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using WPF_Timer.For_MVVM;

namespace WPF_Timer.ViewModel
{
    class PersonViewModel : DependencyObject
    {


        //public string FilterText
        //{
        //    get { return (string)GetValue(FilterTextProperty); }
        //    set { SetValue(FilterTextProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for FilterText.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty FilterTextProperty =
        //    DependencyProperty.Register("FilterText", typeof(string), typeof(PersonViewModel), new PropertyMetadata(""));






        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Items.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(PersonViewModel), new PropertyMetadata(null));


        public PersonViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(Person.GetPersons());
        }



    }
}
