using Logistic.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Logistic.Views
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