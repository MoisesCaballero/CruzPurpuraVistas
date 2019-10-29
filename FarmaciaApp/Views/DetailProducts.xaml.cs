
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FarmaciaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailProducts : ContentPage
    {
        public DetailProducts(Product product)
        {
            InitializeComponent();
            LoadData(product);
        }

        private void LoadData(Product contact)
        {
            Datos.BindingContext = contact;
        }
    }
}