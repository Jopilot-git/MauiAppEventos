
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using MauiAppEventos.Models;
using MauiAppEventos.Views;

namespace MauiAppEventos
{
    public partial class MainPage : ContentPage
    {
             
        public MainPage()
        {
             InitializeComponent();


            // Validação do DatePicker com data minima e máxima do Inicio

            dtpck_Inicio.MinimumDate = DateTime.Now;
            dtpck_Inicio.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 2, DateTime.Now.Day);

            // Validação do DatePicker do término

            dtpck_Termino.MinimumDate = dtpck_Inicio.Date.AddDays(1);
            dtpck_Termino.MaximumDate = dtpck_Inicio.Date.AddMonths(3);



        }

       
        // O botão vai levar até a tela Eventos da pasta Views com o navigation

                
        private async void Button_Cadastro(object sender, EventArgs e)
        {

            // Qd clicar o botão, vai mandar os dados das ENTRY da MainPage.xaml para Eventos.xaml.cs na pasta MODELS
            // Criar em EventoSelecionado.cs as variáveis para guardar os *.Text das ENTRY

                EventoSelecionado Selecionado = new EventoSelecionado
                {
                   Nome = Name.Text,
                   Local = Local_Evento.Text,
                   participantes = Convert.ToInt32(N_Participantes.Text),
                   custo = Convert.ToInt32(Custo_Participante.Text),
                   datainicio = dtpck_Inicio.Date,
                   datatermino = dtpck_Termino.Date


                };

           await Navigation.PushAsync(new Eventos(Selecionado));
            
              

            }
            
           

        private void dtpck_Inicio_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker elemento = sender as DatePicker;

            DateTime data_selecionada_Inicio = elemento.Date;

            dtpck_Termino.MinimumDate = data_selecionada_Inicio.AddDays(1);
            dtpck_Termino.MaximumDate = data_selecionada_Inicio.AddMonths(3);
        }

        private void dtpck_Termino_DateSelected(object sender, DateChangedEventArgs e)
        {

        }

        
    }

}
