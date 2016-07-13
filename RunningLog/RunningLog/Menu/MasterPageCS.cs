
using RunningLog.Resources;
using System.Collections.Generic;
using Xamarin.Forms;


namespace RunningLog.Menu
{
    public class MasterPageCS : ContentPage
    {
        public ListView ListView { get { return listView; } }

        ListView listView;
        

        public MasterPageCS()
        {           
            
            var masterPageItems = new List<MasterPageItem>();

            masterPageItems.Add(new MasterPageItem
            {
                Title = AppResources.menu_HomePage,
                Command = "HomePage",
                IconSource = "ic_home_grey600_24dp.png",
                TargetType = typeof(Pages.HomePage),
                TextColor = Color.FromHex((string) Application.Current.Resources["MasterPageItemTextColorSelected"]),
                BackgroundColor = Color.FromHex((string) Application.Current.Resources["MasterPageItemBackgroundColorSelected"])
            });

            masterPageItems.Add(new MasterPageItem
            {
                Title = AppResources.menu_RunsPage,
                Command = "RunsPage",
                IconSource = "ic_cc_grey600_24dp.png",
                TargetType = typeof(Pages.RunsPage),
                TextColor = Color.FromHex((string)Application.Current.Resources["MasterPageItemTextColor"]),
                BackgroundColor = Color.FromHex((string)Application.Current.Resources["MasterPageItemBackgroundColor"])
            });


            listView = new ListView
            {
                ItemsSource = masterPageItems,
                RowHeight = 50,
                ItemTemplate = new DataTemplate(() =>
                {              
                    Image ImageItem = new Image { };
                    ImageItem.SetBinding(Image.SourceProperty, "IconSource");

                    Label LabelItem = new Label();
                    LabelItem.SetBinding(Label.TextProperty, "Title");
                    LabelItem.SetBinding(Label.TextColorProperty, "TextColor");
                    LabelItem.VerticalOptions = LayoutOptions.CenterAndExpand;

                    StackLayout StackLayoutItem = new StackLayout
                    {
                        Padding = new Thickness(16, 10, 10, 10),
                        Spacing = 10,                        
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        Children = {
                            ImageItem,
                            new StackLayout{Spacing = 8},
                            LabelItem
                        }
                    };

                    StackLayoutItem.SetBinding(StackLayout.BackgroundColorProperty, "BackgroundColor");

                    // Return an assembled ViewCell.
                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Padding = new Thickness(0, 0),
                            Orientation = StackOrientation.Horizontal,
                            Children = 
                                    {
                                        StackLayoutItem                                                                               
                                   }
                        }
                    };

                }),
                VerticalOptions = LayoutOptions.FillAndExpand,                
                SeparatorVisibility = SeparatorVisibility.None
            };

           
            //Padding = new Thickness(0, 40, 0, 0);
            Icon = "iconMenu.png";
            Title = " ";
          
       
            Content = new StackLayout
            {       
                BackgroundColor = Color.White,
                VerticalOptions = LayoutOptions.FillAndExpand,                
                Children = {
                                     
                    listView
                }
            };
        }
    }
}
