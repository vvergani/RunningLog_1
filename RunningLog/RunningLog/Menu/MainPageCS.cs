
using RunningLog.Interfaces;
using RunningLog.Resources;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RunningLog.Menu
{
    public class MainPageCS : MasterDetailPage
    {
        MasterPageCS masterPage;

        public MainPageCS()
        {
            Title = AppResources.menu_Title;

            Style = (Style)Application.Current.Resources["ContentPageMenuStyle"];
            
            masterPage = new MasterPageCS();
     
            Master = masterPage;
            this.MasterBehavior = MasterBehavior.Popover;
        
            //Detail = new NavigationPage(new Pages.CustomersPage());
            Detail = new NavigationPage(new Pages.HomePage());

            masterPage.ListView.ItemSelected += OnItemSelected;

            App.EnableBackButton = true;
            //if (Device.OS == TargetPlatform.Windows)
            //{
            //    Master.Icon = "swap.png";
            //}
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {                
                List<RunningLog.Menu.MasterPageItem> MenuItems;

                MenuItems = (List<RunningLog.Menu.MasterPageItem>)((ListView)sender).ItemsSource;

                foreach (MasterPageItem masterPageItem in MenuItems)
                {
                    masterPageItem.Selected = false;
                }

                if (item.Command == "TBD")
                {
                    DependencyService.Get<IToast>().DisplayToast(AppResources.text_UnderConstruction);
                }
                else
                {
                    
                    Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                    masterPage.ListView.SelectedItem = null;
                    IsPresented = false;
                    item.Selected = true;
                }                         
            }            
        }

        void NavigateTo(RunningLog.Menu.MasterPageItem menu)
        {
            if (menu.TargetType != null)
            {
                Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);
                Detail = SetNavigationDetailPage(Detail, displayPage);
                IsPresented = false;
            }
        }

        private Page SetNavigationDetailPage(Page Detail, Page displayPage)
        {
            Detail = new NavigationPage(displayPage);
            Detail.Style = (Style)Application.Current.Resources["NavigationPageStyle"];

            App.Navigation = Detail.Navigation;
            this.MasterBehavior = Xamarin.Forms.MasterBehavior.Popover;
            return Detail;
        }
    }
}
