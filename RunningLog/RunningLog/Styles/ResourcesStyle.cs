using Xamarin.Forms;

namespace RunningLog.Styles
{
    public static class ResourcesStyle
    {
        public static void SetStyles()
        {

            //Sample to set --> ButtonLogin.Style = (Style)Application.Current.Resources["MyButtonStyle"];


            if (Application.Current.Resources == null)
            {
                Application.Current.Resources = new ResourceDictionary();
            }

            //====================================================================================================================
            //  Button
            //====================================================================================================================
            var buttonStyle = new Style(typeof(Button))
            {
                Setters = {                    
                    new Setter {Property = Button.BackgroundColorProperty, Value = Color.FromHex("1C75EA") },
					new Setter {Property = Button.TextColorProperty, Value = Color.FromHex("FFFFFF")}
			    }
            };
            Application.Current.Resources.Add(buttonStyle);
            //--------------------------------------------------------------------------------------------------------------------
            //var buttonLoginStyle = new Style(typeof(Button))
            //{
            //    Setters = {                    
            //        new Setter {Property = Button.BackgroundColorProperty, Value = Color.FromHex("CC0001") },
            //        new Setter {Property = Button.TextColorProperty, Value = Color.FromHex("FFFFFF")}
            //    }
            //};
            //Application.Current.Resources.Add("ButtonLoginStyle", buttonLoginStyle);
            //--------------------------------------------------------------------------------------------------------------------
            var buttonColorStyle = new Style(typeof(Button))
            {
                Setters = {                    
                    new Setter {Property = Button.BackgroundColorProperty, Value = Color.FromHex("BBDEFB") },
					new Setter {Property = Button.TextColorProperty, Value = Color.FromHex("444444")}
                }
            };
            Application.Current.Resources.Add("ButtonColorStyle", buttonColorStyle); // use the "ButtonStyle" key in the app            

            //--------------------------------------------------------------------------------------------------------------------
            var buttonModalStyle = new Style(typeof(Button))
            {
                Setters = {                    
                    new Setter {Property = Button.BackgroundColorProperty, Value = Color.FromHex("FFFFFF") },
					new Setter {Property = Button.TextColorProperty, Value = Color.FromHex("0085CF")},
                    new Setter {Property = Button.VerticalOptionsProperty, Value = LayoutOptions.End},
                    new Setter {Property = Button.HorizontalOptionsProperty, Value = LayoutOptions.End}
                }
            };
            Application.Current.Resources.Add("ButtonModalStyle", buttonModalStyle); // use the "ButtonStyle" key in the app            

            //====================================================================================================================
            //  BoxView
            //====================================================================================================================            
            //var boxViewStyle = new Style(typeof(BoxView))
            //{
            //    Setters = {                    
            //        new Setter {Property = BoxView.BackgroundColorProperty, Value = Color.FromHex("9F60B5")},
            //        new Setter {Property = BoxView.HeightRequestProperty, Value = 35},
            //        new Setter {Property = BoxView.WidthRequestProperty, Value = 35}
            //    }
            //};
            //Application.Current.Resources.Add("BoxViewStyle", boxViewStyle);
            ////--------------------------------------------------------------------------------------------------------------------
            //var boxViewLineeStyle = new Style(typeof(BoxView))
            //{
            //    Setters = {                                        
            //        new Setter {Property = BoxView.BackgroundColorProperty, Value = Color.FromHex("9F60B5")},
            //        new Setter {Property = BoxView.HeightRequestProperty, Value = 1},
            //        new Setter {Property = BoxView.HorizontalOptionsProperty, Value = LayoutOptions.FillAndExpand}                    
            //    }
            //};
            //Application.Current.Resources.Add("BoxViewLineeStyle", boxViewLineeStyle);

            //====================================================================================================================
            //  Image
            //====================================================================================================================          
            //var imageIconStyle = new Style(typeof(Image))
            //{
            //    Setters = {                                                            
            //        new Setter {Property = Image.HeightRequestProperty, Value = 20},
            //        new Setter {Property = Image.WidthRequestProperty, Value = 20}
            //    }
            //};
            //Application.Current.Resources.Add("ImageIconStyle", imageIconStyle);

            //====================================================================================================================
            //  Label
            //====================================================================================================================          
            var labelMenuPrimaryStyle = new Style(typeof(Label))
            {
                Setters = {                                                            
                    //new Setter {Property = Label.FontSizeProperty, Value = 13}  ,            
                    new Setter {Property = Label.TextColorProperty, Value = Color.FromHex("FFFFFF")}                 
                }
            };
            Application.Current.Resources.Add("LabelMenuPrimaryStyle", labelMenuPrimaryStyle);
            //--------------------------------------------------------------------------------------------------------------------
            var labelMenuSecondaryStyle = new Style(typeof(Label))
            {
                Setters = {                                                            
                    //new Setter {Property = Label.FontSizeProperty, Value = 13} ,             
                    new Setter {Property = Label.TextColorProperty, Value = Color.FromHex("E4D3EA")}                 
                }
            };
            Application.Current.Resources.Add("LabelMenuSecondaryStyle", labelMenuSecondaryStyle);
            //--------------------------------------------------------------------------------------------------------------------
            //var labelColorStyle = new Style(typeof(Label))
            //{
            //    Setters = {                                                            
            //        new Setter {Property = Label.FontSizeProperty, Value = 16},                    
            //        new Setter {Property = Label.TextColorProperty, Value = Color.FromHex("9F60B5")}                 
            //    }
            //};
            //Application.Current.Resources.Add("LabelColorStyle", labelColorStyle);
            //--------------------------------------------------------------------------------------------------------------------
            //var labelHeaderStyle = new Style(typeof(Label))
            //{
            //    Setters = {                                                            
            //        new Setter {Property = Label.FontSizeProperty, Value = 18},                    
            //        new Setter {Property = Label.TextColorProperty, Value = Color.FromHex("FFFFFF")}                 
            //    }
            //};
            //Application.Current.Resources.Add("LabelHeaderStyle", labelHeaderStyle);
            //--------------------------------------------------------------------------------------------------------------------
            //var labelItemStyle = new Style(typeof(Label))
            //{
            //    Setters = {                                                            
            //        new Setter {Property = Label.FontSizeProperty, Value = 13},                    
            //        new Setter {Property = Label.TextColorProperty, Value = Color.FromHex("878787")}               
            //    }
            //};
            //Application.Current.Resources.Add("LabelItemStyle", labelItemStyle);
            //--------------------------------------------------------------------------------------------------------------------
            //var labelItemMinStyle = new Style(typeof(Label))
            //{
            //    Setters = {                                                            
            //        new Setter {Property = Label.FontSizeProperty, Value = 9},                    
            //        new Setter {Property = Label.TextColorProperty, Value = Color.FromHex("878787")}               
            //    }
            //};
            //Application.Current.Resources.Add("LabelItemMinStyle", labelItemMinStyle);
            //--------------------------------------------------------------------------------------------------------------------
            //var labelItemHeaderStyle = new Style(typeof(Label))
            //{
            //    Setters = {                                                            
            //        new Setter {Property = Label.FontSizeProperty, Value = 13}
            //    }
            //};
            //Application.Current.Resources.Add("LabelItemHeaderStyle", labelItemHeaderStyle);
            //--------------------------------------------------------------------------------------------------------------------
            //var labelIconStyle = new Style(typeof(Label))
            //{
            //    Setters = {                                                            
            //        new Setter {Property = Label.FontSizeProperty, Value = 20},                    
            //        new Setter {Property = Label.TextColorProperty, Value = Color.FromHex("FFFFFF")}  
            //    }
            //};
            //Application.Current.Resources.Add("LabelIconStyle", labelIconStyle);
            //--------------------------------------------------------------------------------------------------------------------
            //var labelMessageStyle = new Style(typeof(Label))
            //{
            //    Setters = {                                                            
            //        new Setter {Property = Label.FontSizeProperty, Value = 15},                    
            //        new Setter {Property = Label.TextColorProperty, Value = Color.FromHex("757575")},
            //        new Setter {Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.CenterAndExpand},
            //        new Setter {Property = Label.VerticalOptionsProperty, Value = LayoutOptions.StartAndExpand}
            //    }
            //};
            //Application.Current.Resources.Add("LabelMessageStyle", labelMessageStyle);
            //--------------------------------------------------------------------------------------------------------------------
            //var labelMenuStyle = new Style(typeof(Label))
            //{
            //    Setters = {                                                            
            //        new Setter {Property = Label.FontSizeProperty, Value = 20},                    
            //        new Setter {Property = Label.TextColorProperty, Value = Color.FromHex("FFFFFF")}                    
            //    }
            //};
            //Application.Current.Resources.Add("LabelMenuStyle", labelMenuStyle);

            //====================================================================================================================
            //  ContentView
            //====================================================================================================================          
            //var contentViewMenuStyle = new Style(typeof(ContentView))
            //{
            //    Setters = {                                                            
            //        new Setter {Property = ContentView.BackgroundColorProperty, Value = Color.FromHex("9F60B5")},
            //        new Setter {Property = ContentView.PaddingProperty, Value = new Thickness(10, 18, 0, 10)}              
            //    }
            //};
            //Application.Current.Resources.Add("ContentViewMenuStyle", contentViewMenuStyle);

            //====================================================================================================================
            //  ContentPage
            //====================================================================================================================          
            var contentPageMenuStyle = new Style(typeof(ContentPage))
            {
                Setters = {                                                            
                    new Setter {Property = ContentPage.BackgroundColorProperty, Value = Color.FromHex("FFFFFF")},
                    new Setter {Property = ContentPage.IconProperty, Value = "iconMenu.png"}             
                }
            };
            Application.Current.Resources.Add("ContentPageMenuStyle", contentPageMenuStyle);

            //====================================================================================================================
            //  MasterPageItem
            //====================================================================================================================          
            Application.Current.Resources.Add("MasterPageItemBackgroundColor", "FFFFFF");
            Application.Current.Resources.Add("MasterPageItemBackgroundColorSelected", "EDEDED");
            Application.Current.Resources.Add("MasterPageItemTextColor", "333333");
            Application.Current.Resources.Add("MasterPageItemTextColorSelected", "333333");

            //====================================================================================================================
            //  NavigationPage
            //====================================================================================================================          
            var navigationPageStyle = new Style(typeof(NavigationPage))
            {
                Setters = {                                                            
                    new Setter {Property = NavigationPage.BarBackgroundColorProperty, Value = Color.FromHex("1C75EA")},
                    new Setter {Property = NavigationPage.BarTextColorProperty, Value = Color.FromHex("FFFFFF")}             
                }
            };
            Application.Current.Resources.Add("NavigationPageStyle", navigationPageStyle);

            //====================================================================================================================
            //  StackLayout
            //====================================================================================================================          
            var stackLayoutBaseStyle = new Style(typeof(StackLayout))
            {
                Setters = {                                                            
                    new Setter {Property = StackLayout.BackgroundColorProperty, Value = Color.FromHex("FFFFFF")}          
                }
            };
            Application.Current.Resources.Add("StackLayoutBaseStyle", stackLayoutBaseStyle);
            //--------------------------------------------------------------------------------------------------------------------
            var stackLayoutButtonStyle = new Style(typeof(StackLayout))
            {
                Setters = {                                                            
                    new Setter {Property = StackLayout.BackgroundColorProperty, Value = Color.FromHex("1C75EA")}          
                }
            };
            Application.Current.Resources.Add("StackLayoutButtonStyle", stackLayoutButtonStyle);
            //--------------------------------------------------------------------------------------------------------------------
            var stackLayoutColorStyle = new Style(typeof(StackLayout))
            {
                Setters = {                                                            
                    new Setter {Property = StackLayout.BackgroundColorProperty, Value = Color.FromHex("9F60B5")}          
                }
            };
            Application.Current.Resources.Add("StackLayoutColorStyle", stackLayoutColorStyle);
            //--------------------------------------------------------------------------------------------------------------------
            var stackLayoutColorHeaderStyle = new Style(typeof(StackLayout))
            {
                Setters = {                                                            
                    new Setter {Property = StackLayout.BackgroundColorProperty, Value = Color.FromHex("F8F7F6")}          
                }
            };
            Application.Current.Resources.Add("StackLayoutColorHeaderStyle", stackLayoutColorHeaderStyle);
            //--------------------------------------------------------------------------------------------------------------------
            var stackLayoutHeaderStyle = new Style(typeof(StackLayout))
            {
                Setters = {                                                            
                    new Setter {Property = StackLayout.BackgroundColorProperty, Value = Color.FromHex("1C75EA")}          
                }
            };
            Application.Current.Resources.Add("StackLayoutHeaderStyle", stackLayoutHeaderStyle);
            //--------------------------------------------------------------------------------------------------------------------                       
            var listViewTwoLine = new Style(typeof(ListView))
            {
                Setters = {                                                            
                    new Setter {Property = ListView.RowHeightProperty, Value = 72}          
                }
            };
            Application.Current.Resources.Add("ListViewTwoLine", listViewTwoLine);
            //--------------------------------------------------------------------------------------------------------------------                       
            var listViewThreeLine = new Style(typeof(ListView))
            {
                Setters = {                                                            
                    new Setter {Property = ListView.RowHeightProperty, Value = 88}          
                }
            };
            Application.Current.Resources.Add("ListViewThreeLine", listViewThreeLine);                 
            //--------------------------------------------------------------------------------------------------------------------
            var itemBoxViewColor1 = new Style(typeof(BoxView))
            {
                Setters = {                                        
                    new Setter {Property = BoxView.HeightRequestProperty, Value = 40},
                    new Setter {Property = BoxView.WidthRequestProperty, Value = 40},
                    new Setter {Property = BoxView.BackgroundColorProperty,  Value = Color.FromHex("1C75EA")}
                }
            };
            Application.Current.Resources.Add("ItemBoxViewColor1", itemBoxViewColor1);
            //--------------------------------------------------------------------------------------------------------------------                       
            var itemBoxViewLabel = new Style(typeof(Label))
            {
                Setters = {                                        
                    new Setter {Property = Label.FontSizeProperty, Value = 22},
                    new Setter {Property = Label.TextColorProperty,  Value = Color.FromHex("FFFFFF")}                   
                }
            };

            Application.Current.Resources.Add("ItemBoxViewLabel", itemBoxViewLabel);
            //--------------------------------------------------------------------------------------------------------------------
            var itemPrimaryLabel = new Style(typeof(Label))
            {
                Setters = {                                        
                    new Setter {Property = Label.FontSizeProperty, Value = 16},                    
                    new Setter {Property = Label.LineBreakModeProperty, Value = LineBreakMode.TailTruncation}
                    
                }
            };

            Application.Current.Resources.Add("ItemPrimaryLabel", itemPrimaryLabel);
            //--------------------------------------------------------------------------------------------------------------------
            var itemSecondaryLabel = new Style(typeof(Label))
            {
                Setters = {                                        
                    new Setter {Property = Label.FontSizeProperty, Value = 14},
                    new Setter {Property = Label.LineBreakModeProperty, Value = LineBreakMode.TailTruncation},
                    new Setter {Property = Label.TextColorProperty,  Value = Color.FromHex("6D797E")}                    
                }
            };

            Application.Current.Resources.Add("ItemSecondaryLabel", itemSecondaryLabel);
            //--------------------------------------------------------------------------------------------------------------------
            var itemMiniLabel = new Style(typeof(Label))
            {
                Setters = {                                        
                    new Setter {Property = Label.FontSizeProperty, Value = 10},
                    new Setter {Property = Label.LineBreakModeProperty, Value = LineBreakMode.TailTruncation}
                }
            };

            Application.Current.Resources.Add("ItemMiniLabel", itemMiniLabel);
            
            //--------------------------------------------------------------------------------------------------------------------
            var stackLayoutSeparator = new Style(typeof(StackLayout))
            {
                Setters = {                                        
                    new Setter {Property = StackLayout.HeightRequestProperty, Value = 2},
                    new Setter {Property = StackLayout.BackgroundColorProperty,  Value = Color.FromHex("EDEDED")}                    
                }
            };
            Application.Current.Resources.Add("StackLayoutSeparator", stackLayoutSeparator);
            //--------------------------------------------------------------------------------------------------------------------
            var noItemLabel = new Style(typeof(Label))
            {
                Setters = {
                    new Setter {Property = Label.FontSizeProperty, Value = 15},                    
                    new Setter {Property = Label.TextColorProperty, Value = Color.FromHex("757575")},
                    new Setter {Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.CenterAndExpand},
                    new Setter {Property = Label.VerticalOptionsProperty, Value = LayoutOptions.StartAndExpand}
                }
            };
            Application.Current.Resources.Add("NoItemLabel", noItemLabel);
            //--------------------------------------------------------------------------------------------------------------------
            var labelTitle = new Style(typeof(Label))
            {
                Setters = {                                        
                    new Setter {Property = Label.FontSizeProperty, Value = 22},
                    new Setter {Property = Label.TextColorProperty,  Value = Color.FromHex("000000")}                   
                }
            };

            Application.Current.Resources.Add("LabelTitle", labelTitle);
            //--------------------------------------------------------------------------------------------------------------------

        }
    }
}
