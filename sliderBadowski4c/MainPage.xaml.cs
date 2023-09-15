namespace sliderBadowski4c;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private void podajEmail(object sender, EventArgs e)
    {
        string Email = email.Text;
        if(Email == null)
        {
            wynik.Text = "Wprowadź email";
            return;
        }
        if (!Email.Contains("@"))
        {
            wynik.Text = "Błędny email";
            return;
        }
        string Haslo = haslo.Text;
        string HasloPow = hasloPow.Text;
        if(Haslo == null || HasloPow == null)
        {
            if(Haslo == null && HasloPow == null)
            {
                wynik.Text = "Podaj hasło";
                return;
            }
            wynik.Text = "Podaj hasło";
            return;
        }
        if (Haslo == HasloPow)
        {
            wynik.Text = $"Witaj {Email}";
        }
        else
        {
            wynik.Text = "Hasła nie są identyczne";
            return;
        }
    }

    private void pokaz(object sender, ValueChangedEventArgs e)
    {
		int medium = Convert.ToInt32(suwakTu.Value);
		wynikSuwak.Text = Convert.ToString(medium);
    }
}

