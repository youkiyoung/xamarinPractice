using EditorTutorial.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace EditorTutorial.Views
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