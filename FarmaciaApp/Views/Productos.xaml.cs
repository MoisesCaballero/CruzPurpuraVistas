using product.Domain;
using Xamarin.Forms;
using FarmaciaApp.Services;
using Xamarin.Forms.Xaml;

namespace FarmaciaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Productos : ContentPage
    {
        

        public Productos()
        {

            InitializeComponent();

            lssContact.ItemsSource = ProductoService.GetProducts();

        }
        private void Contact_selected(object sender, SelectedItemChangedEventArgs e)
        {
            var contactselected = (Product)e.SelectedItem;
            Navigation.PushAsync(new DetailProducts(contactselected));
        }

    }
}