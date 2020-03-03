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
    /// Interaction logic for GridView1.xaml
    /// </summary>
    public partial class GridView1 : UserControl
    {
        public GridView1()
        {
            InitializeComponent();

            CreateDynamicGridView();
            ListView1.ItemsSource = Source.ItemsSource();

            ((INotifyCollectionChanged)ListView1.Items).CollectionChanged += GridView1_CollectionChanged;
        }

        public event Action CollectionChanged;

        private void GridView1_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            CollectionChanged();
        }

        private void CreateDynamicGridView()
        {
            // Create a GridView  
            GridView grdView = new GridView();
            grdView.AllowsColumnReorder = true;
            grdView.ColumnHeaderToolTip = "Authors";

            GridViewColumn mvpColumn = new GridViewColumn();
            mvpColumn.DisplayMemberBinding = new Binding("Mvp");
            mvpColumn.Header = "Mvp";
            mvpColumn.Width = 50;
            grdView.Columns.Add(mvpColumn);

            GridViewColumn nameColumn = new GridViewColumn();
            nameColumn.DisplayMemberBinding = new Binding("Name");
            nameColumn.Header = "Author Name";
            nameColumn.Width = 120;
            grdView.Columns.Add(nameColumn);
            GridViewColumn ageColumn = new GridViewColumn();
            ageColumn.DisplayMemberBinding = new Binding("Age");
            ageColumn.Header = "Age";
            ageColumn.Width = 30;
            grdView.Columns.Add(ageColumn);
            GridViewColumn bookColumn = new GridViewColumn();
            bookColumn.DisplayMemberBinding = new Binding("Book");
            bookColumn.Header = "Book";
            bookColumn.Width = 250;
            grdView.Columns.Add(bookColumn);
            
            ListView1.View = grdView;
        }
    }
}