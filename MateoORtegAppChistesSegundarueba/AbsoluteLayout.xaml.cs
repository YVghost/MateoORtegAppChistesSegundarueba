using System.Net.Http.Json;

namespace MateoORtegAppChistesSegundarueba;

public partial class AbsoluteLayout : ContentPage
{
	public AbsoluteLayout()
	{
		InitializeComponent();
	}

    private async void OnOtroChisteClicked(object sender, EventArgs e)
    {
        try
        {
            using var client = new HttpClient();
            var joke = await client.GetFromJsonAsync<Joke>("https://official-joke-api.appspot.com/random_joke");
            if (joke != null)
            {
                JokeLabel.Text = $"{joke.setup}\n{joke.punchline}";
            }
            else
            {
                JokeLabel.Text = "No se pudo obtener un chiste.";
            }
        }
        catch
        {
            JokeLabel.Text = "Error al obtener el chiste.";
        }
    }

    public class Joke
    {
        public string setup { get; set; }
        public string punchline { get; set; }
    }
}