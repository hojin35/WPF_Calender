using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WPF_Calender.Models;
using WPF_Calender.Services;

namespace WPF_Calender.ViewModels
{
    internal partial class CalenderViewModel : ObservableRecipient
    {
        IDialogService dialogService;
        public CalenderViewModel(IDialogService dialogService)
        {
            this.dialogService = dialogService;

            SelectionChangedCommand = new RelayCommand<object>(OnSelectionChanged);
            Years = Enumerable.Range(2000, 30).ToList();
            Months = Enumerable.Range(1, 12).ToList();

            selectedYear = DateTime.Now.Year;
            selectedMonth = DateTime.Now.Month;
            UpdateCalender();
        }

        [ObservableProperty]
        private bool isDataLoading;

        [ObservableProperty]
        private ObservableCollection<DayItem> items = new ObservableCollection<DayItem>();

        [ObservableProperty]
        private List<int> years;

        [ObservableProperty]
        private List<int> months;

        [ObservableProperty]
        private int selectedYear;

        [ObservableProperty]
        private int selectedMonth;

        public RelayCommand<object> SelectionChangedCommand { get; }

        partial void OnSelectedYearChanged(int value)
        {
            UpdateCalender();
        }
        partial void OnSelectedMonthChanged(int value)
        {
            UpdateCalender();
        }

        private void UpdateCalender()
        {
            Items.Clear();
            DateTime dateTime = new DateTime(SelectedYear, SelectedMonth, 1);
            for (int i = 0; i < (int)dateTime.DayOfWeek; i++)
            {
                Items.Add(new DayItem(0.ToString(),new List<string>() { "빈칸" }));
            }

            int dayInMonth = DateTime.DaysInMonth(SelectedYear, SelectedMonth);
            for (int i = 1; i <= dayInMonth; i++)
            {
                Items.Add(new DayItem(i.ToString(), new List<string>() { "존재칸"}));
            }
        }

        private async void OnSelectionChanged(object parameter)
        {
            IsDataLoading = true;
            //dialogService.ShowDialog("선택 변경됨");
            await Task.Delay(2000);
            IsDataLoading = false;
        }
    }
    
}
