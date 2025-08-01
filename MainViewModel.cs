using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using System.Collections.ObjectModel;

namespace CollectionViewIssues
{
  public partial class MainViewModel : ObservableObject
  {
    [ObservableProperty]
    ObservableCollection<string> _items;

    private int skip = 0;
    private int take = 50;

    public MainViewModel()
    {
      Items = new ObservableCollection<string>();
      for (int i = 0; i < take; i++)
      {
        Items.Add($"https://picsum.photos/id/{i}/200/300");
      }
      skip = Items.Count;
    }

    [RelayCommand]
    async Task AddRange()
    {
      await Task.Delay(1000); // Simulate a delay
      for (int i = skip; i < skip + take; i++)
      {
        Items.Add($"https://picsum.photos/id/{i}/200/300");
      }

      skip = Items.Count;
    }
  }
}
