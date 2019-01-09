using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace BlueApronSample.Controls
{
    public class ExtendedListView : ListView
    {
        // ItemAppearing Property and field to allow binding of a custom command in our control
        // directly from our xaml code
       

        public static readonly BindableProperty TappedCommandProperty =
            BindableProperty.Create(nameof(TappedCommand), typeof(ICommand), typeof(ExtendedListView), default(ICommand));

        public ICommand TappedCommand
        {
            get { return (ICommand)GetValue(TappedCommandProperty); }
            set { SetValue(TappedCommandProperty, value); }
        }


        public ExtendedListView() : this(ListViewCachingStrategy.RecycleElement)
        {
        }

        public ExtendedListView(ListViewCachingStrategy cachingStrategy) : base(cachingStrategy)
        {
            this.ItemTapped += OnItemTapped;
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (TappedCommand != null)
            {
                TappedCommand?.Execute(e.Item);
            }
        }
    }
}

