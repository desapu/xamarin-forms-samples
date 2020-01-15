using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace CarouselViewDemos.ViewModels
{
    public class MonkeysOnCollectionViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MonkeysRowViewModel> Rows { get; private set; }

        public MonkeysOnCollectionViewModel()
        {
            Rows = new ObservableCollection<MonkeysRowViewModel>();
            BuildMonkeys();
        }

        private void BuildMonkeys()
        {
            for (var i = 0; i < 16; i += 2) {
                Rows.Add(new MonkeysRowViewModel(i, 2));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

