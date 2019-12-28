using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppListViewBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            myListStack.ItemsSource = myListGrid.ItemsSource = myListGridChanging.ItemsSource = GetItems();
        }


        public double myWidth
        {
            get { return (double)GetValue(myWidthProperty); }
            set { SetValue(myWidthProperty, value); }
        }
        public static readonly BindableProperty myWidthProperty = BindableProperty.Create("myWidth", typeof(double), typeof(ContentPage), default(double));

        List<string> items = new List<string>();

        IEnumerable<string> GetItems()
        {
            for (int i=0; i<50; i++)
            {
                items.Add("item: " + i);
            }

            return items;
        }

        private void ContentPage_SizeChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(Width + " " + Height);
            myWidth = Width - 100;
        }
    }
}
