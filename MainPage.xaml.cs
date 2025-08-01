namespace CollectionViewIssues
{
  public partial class MainPage : ContentPage
  {
    public MainPage(MainViewModel viewModel)
    {
      InitializeComponent();
      BindingContext = viewModel;
    }

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      await Shell.Current.GoToAsync("DetailPage");
    }
  }
}
