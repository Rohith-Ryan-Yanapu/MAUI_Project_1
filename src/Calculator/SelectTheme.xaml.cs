namespace Calculator;

public partial class SelectTheme : ContentPage, IModalPage
{
	public SelectTheme()
	{
		InitializeComponent();
    }

    void OnPickerSelectionChanged(object sender, EventArgs e)
    {
        Picker picker = sender as Picker;
        Theme theme = (Theme)picker.SelectedItem;

        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();

            switch(theme)
            {
                case Theme.Dark:
                    mergedDictionaries.Add(new DarkTheme());
                    break;
                
                default:
                    mergedDictionaries.Add(new DarkTheme());
                    break;
            }
        }
    }

    public async Task Dismiss()
    {
        await Navigation.PopModalAsync();
    }
}