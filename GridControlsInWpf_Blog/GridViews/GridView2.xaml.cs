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
        ListViewColumnHelper<Author> listViewColumnHelper = null;

        public GridView2()
        {
            InitializeComponent();

            listViewColumnHelper = new ListViewColumnHelper<Author>(lstViewXamlColumns);


            var list = Source.ItemsSource();
            Source.SortReceiptsByDateBorn();
            lstViewXamlColumns.ItemsSource = list;
            ((INotifyCollectionChanged)list).CollectionChanged += GridView1_CollectionChanged;
        }

        public event Action CollectionChanged;
        
        int ByDateTimeDesc(Author x, Author y)
        {
            return SunamoComparer.DT.Instance.Desc(x.DateBorn, y.DateBorn);
        }

        private void GridView1_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            CollectionChanged();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            listViewColumnHelper.CheckBox_Click(sender, e);
        }
    }

}
