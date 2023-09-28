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
