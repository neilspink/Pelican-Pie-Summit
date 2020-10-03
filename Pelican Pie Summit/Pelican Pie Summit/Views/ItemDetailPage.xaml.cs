using System.ComponentModel;
using Xamarin.Forms;
using Pelican_Pie_Summit.ViewModels;

namespace Pelican_Pie_Summit.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}