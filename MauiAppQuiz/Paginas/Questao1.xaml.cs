namespace MauiAppQuiz.Paginas;

public partial class Questao1 : ContentPage
{
	public Questao1()
	{
		InitializeComponent();
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        string nome = await SecureStorage.Default.GetAsync("nome");

        LBLTexte.Text = nome;
    }
}