namespace BMICalculator;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	public void btn_Clicked(object sender, EventArgs e)
	{
		Main_Lbl.Text = (Weight.Value / Math.Pow(HeightSlider.Value / 100, 2)).ToString();
	}
}

