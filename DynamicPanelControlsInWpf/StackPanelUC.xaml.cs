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
