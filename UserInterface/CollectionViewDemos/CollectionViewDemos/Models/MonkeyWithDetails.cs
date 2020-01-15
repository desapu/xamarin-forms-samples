using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CollectionViewDemos.Models
{
    public class MonkeyWithDetails : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
        public bool IsFavorite { get; set; }

        private bool showDetails;
        public bool ShowDetails {
            get { return showDetails; }
            set { showDetails = value; OnPropertyChanged(); }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
