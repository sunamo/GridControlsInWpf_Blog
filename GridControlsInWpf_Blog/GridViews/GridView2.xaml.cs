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
            listViewColumnHelper.CheckBox_Click(sender, e, Checkboxes.IsChecked);
        }

        private void miDescending_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miAscending_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miAddToPlaylist_Click(object sender, RoutedEventArgs e)
        {
            var item = sender as ListViewItem;
            var context = item.DataContext as Author;

            MessageBox.Show("Added to playlist " + context.Name);
        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void menuItem_CopyUsername_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)e.Source;
            ContextMenu contextMenu = menuItem.Parent as ContextMenu; //.CommandParameter as ContextMenu;
            ListViewItem item = (ListViewItem)contextMenu.PlacementTarget;
            var context = item.DataContext as Author;

            MessageBox.Show("Added to playlist " + context.Name);
        }
    }

}
