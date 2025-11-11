namespace Agenda13App.Views
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Models.Evento evento)
        {
            InitializeComponent(); // só funciona se o x:Class bater
            BindingContext = evento;
        }
    }
}
