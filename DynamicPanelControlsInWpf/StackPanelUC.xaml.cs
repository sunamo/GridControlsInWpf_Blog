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
    /// Interaction logic for StackPanelUC.xaml
    /// </summary>
    public partial class StackPanelUC : UserControl
    {
        public StackPanelUC()
        {
            InitializeComponent();

            StackPanel sp = new StackPanel();

            sp.Children.Add(new TextBox());

            Content = sp;
        }
    }
}