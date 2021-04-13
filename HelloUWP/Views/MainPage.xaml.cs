using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace HelloUWP.Views
{
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private async void Button_ClickAsync(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var myDIg = new MessageDialog("안녕하세요");
            myDIg.Commands.Add(new UICommand("OK"));
            myDIg.Commands.Add(new UICommand("아니요"));
            myDIg.Commands.Add(new UICommand("탈출"));
            await myDIg.ShowAsync();
        }
        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }
    }
}
