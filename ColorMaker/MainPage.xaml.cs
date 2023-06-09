﻿namespace ColorMaker;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        var red = SliderRed.Value;
        var green = SliderGreen.Value;
        var blue = SliderBlue.Value;

        var color = Color.FromRgb(red, green, blue);

        SetColor(color);
    }

    private void SetColor(Color color)
    {
        BtnGenerate.BackgroundColor = color;
        Container.BackgroundColor = color;
        LabelHex.BackgroundColor = color;

        LabelHex.Text = $"HEX Value : {color.ToHex()}";
    }

    private void BtnCopy_Clicked(object sender, EventArgs e)
    {
        Clipboard.Default.SetTextAsync(LabelHex.BackgroundColor.ToHex());
    }
    
    private void BtnGenerate_Clicked(object sender, EventArgs e)
    {
        var rand = new Random();

        var red = rand.NextDouble();
        SliderRed.Value = red;

        var green = rand.NextDouble();
        SliderGreen.Value = green;

        var blue = rand.NextDouble();
        SliderBlue.Value = blue;

        var color = Color.FromRgb(red, green, blue);

        SetColor(color);
    }
}

