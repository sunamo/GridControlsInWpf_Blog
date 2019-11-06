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

namespace GridControlsInWpf_Blog.DataGrids
{
    /// <summary>
    /// Interaction logic for DataGrid1.xaml
    /// </summary>
    public partial class DataGrid1 : UserControl
    {
        public DataGrid1()
        {
            InitializeComponent();

            dg.ItemsSource = Source.ItemsSource();
            ((INotifyCollectionChanged)dg.Items).CollectionChanged += GridView1_CollectionChanged;
        }

        public event Action CollectionChanged;

        private void GridView1_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            CollectionChanged();
        }
    }
}
