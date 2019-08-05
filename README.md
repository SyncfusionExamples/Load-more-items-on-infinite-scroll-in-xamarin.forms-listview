# Load more items in ListView on infinite scroll

The SfListView allows adding more items infinite times either manually or automatically.

```
public class LoadMoreViewModel:INotifyPropertyChanged
{
  public ObservableCollection<Product> Products { get; set; }
  public Command<object> LoadMoreItemsCommand { get; set; }

  public LoadMoreViewModel()
  {
     Products = new ObservableCollection<Product>();
     AddProducts(0, 10);
     LoadMoreItemsCommand = new Command<object>(LoadMoreItems);
  }
  private async void LoadMoreItems(object obj)
  {
     var listview = obj as Syncfusion.ListView.XForms.SfListView;
     listview.IsBusy = true;
     await Task.Delay(2500);
     AddProducts(11, 21);
     listview.IsBusy = false;
  }
  private void AddProducts(int value, int count)
  {
     Random rand= new Random();
     for (int i = value; i < count; i++)
     {
        var name = Names[rand.Next(1,22)];
        var p = new Product()
        {
           Name = name,
           Weight = Weights[i],
           Price = Prices[i],
           Image = ImageSource.FromResource("LoadMoreUG.LoadMore." + name.Replace(" ", string.Empty) + ".jpg")
        };
        Products.Add(p);
     }
  }
}
```

To know more about load more in ListView, please refer our documentation [here](https://help.syncfusion.com/xamarin/sflistview/loadmore#how-to)

