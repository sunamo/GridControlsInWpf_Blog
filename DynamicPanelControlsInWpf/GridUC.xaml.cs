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

namespace DynamicPanelControlsInWpf
{
    /// <summary>
    /// Interaction logic for GridUC.xaml
    /// </summary>
    public partial class GridUC : UserControl
    {
        public GridUC()
        {
            InitializeComponent();

            Loaded += GridUC_Loaded;
        }

        private void GridUC_Loaded(object sender, RoutedEventArgs e)
        {
            Grid g = new Grid();

            g.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(0, GridUnitType.Auto) });
            g.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(0, GridUnitType.Auto) });

            g.Children.Add(new TextBox());

            Content = g;
        }
    }
}
