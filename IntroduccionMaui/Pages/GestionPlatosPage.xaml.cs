using IntroduccionMaui.ConexionDatos;
using IntroduccionMaui.Maodels;
using System.Diagnostics;

namespace IntroduccionMaui.Pages;
[QueryProperty(nameof(plato), "Plato")]
public partial class GestionPlatosPage : ContentPage
{
    private readonly IRestConexionDatos restConexionDatos;
	private Plato _plato;
	private bool _esNuevo;//para controlar si el plato es nuevo

	public Plato plato {
		get => _plato;
		set {
			_esNuevo = esNuevo(value);
			_plato = value;
			OnPropertyChanged();//Obligatorio al actualizar un plato existente.
		}
	}
    public GestionPlatosPage(IRestConexionDatos restConexionDatos)
	{
		InitializeComponent();
		this.restConexionDatos = restConexionDatos;
		BindingContext = this;//para vincular los datos de C# con la vista xaml
	}

	bool esNuevo(Plato plato)
	{
		if(plato.Id == 0) 
			return true; 
		return false;
	}
	async void OnCancelarClic(object sender, EventArgs e) {
		await Shell.Current.GoToAsync("..");//retorna un nivel atras
	}

	async void OnGuardarClic(object sender, EventArgs e) {
		if (_esNuevo)
		{
			Debug.WriteLine("[REGISTRO] Agregando nuevo plato.");
			await restConexionDatos.AddPlatoAsync(plato);
		}
		else
		{
            Debug.WriteLine("[REGISTRO] Editando un plato.");
            await restConexionDatos.UpdatePlatoAsync(plato);
        }
		await Shell.Current.GoToAsync("..");
	}
	async void OnEliminarClic(object sender, EventArgs e) {
		await restConexionDatos.DeletePlato(plato.Id);
        await Shell.Current.GoToAsync("..");
    }
}