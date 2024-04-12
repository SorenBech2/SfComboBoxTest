using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace SfComboBoxTest
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        public int bookingListIndex = -1;
        [ObservableProperty]
        public ObservableCollection<string>? bookingAlternativeList = ["1",  "2", "3", "4", "5"];

        public MainViewModel() 
        {
        }
    }
}
