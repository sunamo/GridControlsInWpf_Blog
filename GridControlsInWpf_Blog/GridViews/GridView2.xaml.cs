using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GridControlsInWpf_Blog.GridViews
{
    /// <summary>
    /// Interaction logic for GridView2.xaml
    /// </summary>
    public partial class GridView2 : UserControl
    {
        public GridView2()
        {
            InitializeComponent();
            var list = Source.ItemsSource();
            lstViewXamlColumns.ItemsSource = list;
            ((INotifyCollectionChanged)list).CollectionChanged += GridView1_CollectionChanged;
        }

        public event Action CollectionChanged;

        private void GridView1_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            CollectionChanged();
        }
    }

}
