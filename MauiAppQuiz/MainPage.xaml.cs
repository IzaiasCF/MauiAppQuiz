using MauiAppQuiz.Paginas;

namespace MauiAppQuiz
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            SecureStorage.Default.RemoveAll();
        }

        private async void BTNiniciar_Clicked(object sender, EventArgs e)
        {
            try 
            {
                string pergunta = await DisplayPromptAsync("Pergunta", "Qual é seu nome?", "Ok", "Cancelar");

                await SecureStorage.Default.SetAsync("nome", pergunta);

                await Navigation.PushAsync(new Questao1());
            }
            catch (Exception ex) 
            {
                await DisplayAlert("Aviso!", ex.Message, "Ok");
            }
        }
    }

}
