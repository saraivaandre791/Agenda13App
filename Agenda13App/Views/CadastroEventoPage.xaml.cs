using Agenda13App.Models;

namespace Agenda13App.Views
{
    public partial class CadastroEventoPage : ContentPage
    {
        private Evento evento;

        public CadastroEventoPage()
        {
            InitializeComponent();
            evento = new Evento
            {
                DataInicio = DateTime.Today,
                DataFim = DateTime.Today.AddDays(1)
            };
            BindingContext = evento;
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ResumoEventoPage(evento));
        }
    }
}
