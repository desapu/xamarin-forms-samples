using CollectionViewDemos.ViewModels;
using Xamarin.Forms;

namespace CollectionViewDemos.Views
{
    public partial class MultipleDataTemplateSizePage : ContentPage
    {
        public MultipleDataTemplateSizePage()
        {
            InitializeComponent();
            BindingContext = new AnimalsViewModel();
        }
    }
}
