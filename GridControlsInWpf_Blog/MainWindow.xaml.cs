namespace GridControlsInWpf_Blog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Type type = typeof(MainWindow);
        ComboBoxHelper<GridControls> gc = null;

/// <summary>
/// SetContent
/// </summary>
UserControl last = new UserControl();

/// <summary>
/// SetContent
/// </summary>
GridView1 gridView1 = null;

/// <summary>
/// SetContent
/// </summary>
GridView2 gridView2 = null;

/// <summary>
/// SetContent
/// </summary>
DataGrid1 dataGrid1 = null;

        public MainWindow()
        {
            InitializeComponent();

            gc = new ComboBoxHelper<GridControls>(cb);
            gc.AddValuesOfEnumAsItems<GridControls>();
            cb.SelectionChanged += Cb_SelectionChanged;

            Source.SortReceiptsByDateBorn();

            SetContent(GridControls.GridView2);
        }

        private void Author_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }

        private void Cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SetContent(gc.SelectedT);
        }

        private void SetContent(GridControls gridControl)
        {


            grid.Children.Remove(last);
            UserControl c = null;

            switch (gridControl)
            {
                case GridControls.GridView1:
                    if (gridView1 == null)
                    {
                        gridView1 = new GridView1();
                        gridView1.CollectionChanged += GridView1_CollectionChanged;
                    }
                    c = gridView1;
                    break;
                case GridControls.GridView2:

                    if (gridView2 == null)
                    {
                        gridView2 = new GridView2();
                        gridView2.CollectionChanged += GridView1_CollectionChanged;

                    }
                    c = gridView2;
                    break;
                case GridControls.DataGrid:

                    if (dataGrid1 == null)
                    {
                        dataGrid1 = new DataGrid1();
                        dataGrid1.CollectionChanged += GridView1_CollectionChanged;
                    }
                    c = dataGrid1;
                    break;
                default:
                    ThrowEx.NotImplementedCase( gridControl);
                    break;
            }

            last = c;

            Grid.SetRow(c, 1);
            grid.Children.Add(c);
        }






        private void GridView1_CollectionChanged()
        {
            Title = string.Join(",", Source.list.Select(a => a.IsChecked));
        }

        private void btnListChecked_Click(object sender, RoutedEventArgs e)
        {
            GridView1_CollectionChanged();
        }

        private void btnIndexesChecked_Click(object sender, RoutedEventArgs e)
        {
            Title = string.Join(",", Source.list.Where(r => r.IsChecked).Select(a => a.Id));
        }
    }
}
