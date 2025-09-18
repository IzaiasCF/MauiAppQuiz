namespace MauiAppQuiz
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void BTNiniciar_Clicked(object sender, EventArgs e)
        {
            try 
            {
                
            }
            catch (Exception ex) 
            {
                await DisplayAlert("Aviso!", ex.Message, "Ok");
            }
        }
    }

}
