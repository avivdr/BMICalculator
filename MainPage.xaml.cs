namespace BMICalculator;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	public void btn_Clicked(object sender, EventArgs e)
	{
		double value = Weight.Value / Math.Pow(HeightSlider.Value / 100, 2);
		float hue = 5;
		if()
		MainLblBorder.BackgroundColor = Color.FromHsv(hue, 100, 100);
        Main_Lbl.Text = $"BMI: {value:F2}";
	}

    public void Gender_Changed(object sender, CheckedChangedEventArgs e)
    {
		string st = "Male";
		if (Gender.IsChecked)
			st = "Female";

		GenderLbl.Text = $"Gender: {st}";
    }
}

