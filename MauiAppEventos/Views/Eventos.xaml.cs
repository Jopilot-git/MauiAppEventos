using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using MauiAppEventos.Models;

namespace MauiAppEventos.Views;

public partial class Eventos : ContentPage
{

	
	public Eventos(EventoSelecionado evento)
	{
		InitializeComponent();
		BindingContext = evento;

	}

	private async void Button_Voltar(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());


	}
}