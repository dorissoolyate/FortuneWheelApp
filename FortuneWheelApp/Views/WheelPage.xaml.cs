namespace Views;

using System;
using Microsoft.Maui.Controls;


public partial class WheelPage : ContentPage
{
    private Random _random;
    private string[] _descriptions = {
        "A new adventure awaits!", "Good luck is on your side!", "The future is bright!", "Today is your lucky day!", "You are on the right path!", "Good luck is on your side!"
    };

    public WheelPage()
    {
        InitializeComponent();
        _random = new Random();
    }

    private async void OnSpinClicked(object sender, EventArgs e)
    {
        // ���� ������ (������������ �����������)
        var spinAnimation = new Animation(v => WheelImage.Rotation = v, 0, 360);
        spinAnimation.Commit(this, "SpinAnimation", 16, 1000, Easing.Linear);

        // ����� 1 ������� ���������� ��������
        await Task.Delay(1000);
        int randomIndex = _random.Next(_descriptions.Length);
        await Navigation.PushAsync(new DescriptionPage(_descriptions[randomIndex]));
    }

    // ���������� ��� ������ "��������"
    private void OnDescriptionClicked(object sender, EventArgs e)
    {
        // ��������, ������� �� ������ �������� � ���������
        DisplayAlert("Hint", "Snip the wheel :)", "OK");
    }
}
