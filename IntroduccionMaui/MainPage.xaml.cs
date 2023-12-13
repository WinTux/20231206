using IntroduccionMaui.ConexionDatos;
using IntroduccionMaui.Maodels;
using IntroduccionMaui.Pages;
using System.Diagnostics;

namespace IntroduccionMaui
{
    public partial class MainPage : ContentPage
    {
        private readonly IRestConexionDatos conexionDatos;

        public MainPage(IRestConexionDatos restConexionDatos)
        {
            InitializeComponent();
            this.conexionDatos = restConexionDatos;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            coleccionPlatosView.ItemsSource = await conexionDatos.GetPlatosAsync();
        }

        //Evento add
        async void OnAddPlatoClic(object sender, EventArgs e) {
            Debug.WriteLine("[EVENTO] Botón AddPlato clickeado");
            var param = new Dictionary<string, object> {
                {nameof(Plato), new Plato()}
            };
            await Shell.Current.GoToAsync(nameof(GestionPlatosPage), param);
        }
        // Evento clic sobre plato
        async void OnPlatoCambiadoClic(object sender, SelectionChangedEventArgs e)
        {
            Debug.WriteLine("[EVENTO] Botón PlatoCambiado clickeado");
            var param = new Dictionary<string, object> {
                {nameof(Plato), e.CurrentSelection.FirstOrDefault() as Plato}
            };
            await Shell.Current.GoToAsync(nameof(GestionPlatosPage), param);
        }
    }

}
