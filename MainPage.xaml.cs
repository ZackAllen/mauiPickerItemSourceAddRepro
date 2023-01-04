namespace PickerItemSourceAddRepro;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.Loaded += (s, e) =>
        {
            MyPicker.Items.Add("A");
            MyPicker.Items.Add("B");
            MyPicker.Items.Add("C");

            // Workaround:
            //MyPicker.ItemsSource = MyPicker.GetItemsAsArray();
        };
    }
}