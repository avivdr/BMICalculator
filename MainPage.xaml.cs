namespace BMICalculator;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		//MainLblBorder.BackgroundColor = Color.FromHsv(150, 100, 100);
	}

	public void btn_Clicked(object sender, EventArgs e)
	{
		double value = Weight.Value / Math.Pow(HeightSlider.Value / 100, 2);
		string clrStr = "#802B13";
		if (value < 18.5)
			clrStr = "#00AFBF";
		else if (value < 25)
			clrStr = "#40BF00";
		else if (value < 30)
			clrStr = "#FFAC26";
		else if (value < 40)
			clrStr = "#BF401D";
		MainLblBorder.BackgroundColor = Color.FromArgb(clrStr);
        Main_Lbl.Text = $"BMI: {value:F1}";
	}

    public void Gender_Changed(object sender, CheckedChangedEventArgs e)
    {
		string st = "Male";
		if (Gender.IsChecked)
			st = "Female";

		GenderLbl.Text = $"Gender: {st}";
    }
}

