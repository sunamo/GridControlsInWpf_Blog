using System;
using System.Collections.Generic;
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

namespace GridControlsInWpf_Blog
{
    /// <summary>
    /// Interaction logic for GridViewUC.xaml
    /// </summary>
    public partial class GridViewUC : UserControl
    {
        public GridViewUC()
        {
            InitializeComponent();
        }

        private void CreateDynamicGridView()
        {
            // Create a GridView  
            GridView grdView = new GridView();
            grdView.AllowsColumnReorder = true;
            grdView.ColumnHeaderToolTip = "Authors";
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
            GridViewColumn mvpColumn = new GridViewColumn();
            mvpColumn.DisplayMemberBinding = new Binding("Mvp");
            mvpColumn.Header = "Mvp";
            mvpColumn.Width = 50;
            grdView.Columns.Add(mvpColumn);
            ListView1.View = grdView;
        }
    }
}
