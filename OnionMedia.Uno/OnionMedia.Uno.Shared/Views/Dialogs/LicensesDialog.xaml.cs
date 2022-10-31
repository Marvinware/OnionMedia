﻿/*
 * Copyright (C) 2022 Jaden Phil Nebel (Onionware)
 *
 * This file is part of OnionMedia.
 * OnionMedia is free software: you can redistribute it and/or modify it under the terms of the GNU Affero General Public License as published by the Free Software Foundation, version 3.

 * OnionMedia is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Affero General Public License for more details.

 * You should have received a copy of the GNU Affero General Public License along with OnionMedia. If not, see <https://www.gnu.org/licenses/>.
 */

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using OnionMedia.Uno.Views.Dialogs.LicenseDialogPages;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace OnionMedia.Uno.Views.Dialogs
{
    public sealed partial class LicensesDialog : ContentDialog
    {
        public LicensesDialog()
        {
            InitializeComponent();
            licenseNavFrame.Navigate(typeof(LicensesListPage));
        }

        private void licenseNavFrame_Navigated(object sender, NavigationEventArgs e)
            => backButton.Visibility = e.SourcePageType == typeof(LicensesInfoPage) ? Visibility.Visible : Visibility.Collapsed;

        private void backButton_Click(object sender, RoutedEventArgs e)
            => licenseNavFrame.GoBack();
    }
}
