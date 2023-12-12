using IntroduccionMaui.Pages;

namespace IntroduccionMaui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(GestionPlatosPage), typeof(GestionPlatosPage));
        }
    }
}
