using Syncfusion.ListView.XForms;
using Syncfusion.ListView.XForms.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoadMoreUG
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //listView.LoadMoreOption = LoadMoreOption.Auto;
            //listView.LoadMoreCommand = viewModel.LoadMoreItemsCommand;
            //listView.LoadMoreTemplate = new DataTemplate(() =>
            //  {
            //      var grid = new Grid();
            //      grid.HeightRequest = 100;
            //      grid.WidthRequest = 100;
            //      var label = new Label
            //      {
            //          Text = "Load More Items...",
            //          FontSize = 20,
            //          BackgroundColor = Color.AliceBlue,
            //          HorizontalTextAlignment = TextAlignment.Center,
            //          VerticalTextAlignment = TextAlignment.Center
            //      };
            //      label.SetBinding(Label.IsVisibleProperty, new Binding("IsBusy", BindingMode.Default, new InverseBoolConverter(), null, null, listView));
            //      var loadMoreIndicator = new LoadMoreIndicator();
            //      loadMoreIndicator.Color = Color.Red;
            //      loadMoreIndicator.VerticalOptions = LayoutOptions.Center;
            //      loadMoreIndicator.SetBinding(LoadMoreIndicator.IsRunningProperty, new Binding("IsBusy", BindingMode.Default, null, null, null, listView));
            //      loadMoreIndicator.SetBinding(LoadMoreIndicator.IsVisibleProperty, new Binding("IsBusy", BindingMode.Default, null, null, null, listView));
            //      loadMoreIndicator.HeightRequest = 100;
            //      loadMoreIndicator.WidthRequest = 100;
            //      grid.Children.Add(label);
            //      grid.Children.Add(loadMoreIndicator);
            //      return grid;
            //  });

        }
    }
}
