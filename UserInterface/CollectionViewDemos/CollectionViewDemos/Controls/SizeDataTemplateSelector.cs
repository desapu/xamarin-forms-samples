using CollectionViewDemos.Models;
using Xamarin.Forms;

namespace CollectionViewDemos.Controls
{
    public class SizeDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate SizeSmall { get; set; }
        public DataTemplate SizeMedium { get; set; }
        public DataTemplate SizeLarge { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            DataTemplate template = SizeSmall;
            var location = ((Animal)item).Location;

            if (location.Contains("Asia")) {
                template = SizeLarge;
            } else if (location.Contains("America"))
            {
                template = SizeMedium;
            }

            return template;
        }
    }
}
