using IntroduccionMaui.ConexionDatos;

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

    }

}
