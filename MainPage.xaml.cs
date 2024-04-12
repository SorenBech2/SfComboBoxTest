namespace SfComboBoxTest
{
    public partial class MainPage : ContentPage
    {
        readonly MainViewModel _viewModel;
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            _viewModel = viewModel;
        }

        private void BookingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Do nothing
        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            _viewModel.BookingListIndex = -1;
        }
    }
}
