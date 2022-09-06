﻿using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace General.WinUIClassLibraryApp
{
    public sealed partial class WinUIReportViewerUserControl : UserControl
    {
        public WinUIReportViewerUserControl()
        {
            this.InitializeComponent();
        }

        void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            var menuItem = sender as MenuFlyoutItem;
            if (menuItem != null)
            {
                var selectedTheme = menuItem?.Text;
                if (!string.IsNullOrWhiteSpace(selectedTheme))
                {
                    this.themeChangeDropDown.Content = selectedTheme;                    
                }
            }
        }
    }
}
