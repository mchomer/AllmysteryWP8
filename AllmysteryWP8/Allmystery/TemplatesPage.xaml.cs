﻿/* ***************************************************************************************************************************************************
 * Copyright (c) 2012 Michel Krämer
 * 
 * Hiermit wird unentgeltlich, jeder Person, die eine Kopie der Software und der zugehörigen Dokumentationen (die "Software") erhält, 
 * die Erlaubnis erteilt, uneingeschränkt zu benutzen, inklusive und ohne Ausnahme, dem Recht, sie zu verwenden, kopieren, ändern, fusionieren, 
 * verlegen, verbreiten, unterlizenzieren und/oder zu verkaufen, und Personen, die diese Software erhalten, diese Rechte zu geben, unter den 
 * folgenden Bedingungen:
 * 
 * Der obige Urheberrechtsvermerk und dieser Erlaubnisvermerk sind in allen Kopien oder Teilkopien der Software beizulegen.
 * 
 * DIE SOFTWARE WIRD OHNE JEDE AUSDRÜCKLICHE ODER IMPLIZIERTE GARANTIE BEREITGESTELLT, EINSCHLIESSLICH DER GARANTIE ZUR BENUTZUNG FÜR DEN 
 * VORGESEHENEN ODER EINEM BESTIMMTEN ZWECK SOWIE JEGLICHER RECHTSVERLETZUNG, JEDOCH NICHT DARAUF BESCHRÄNKT. 
 * IN KEINEM FALL SIND DIE AUTOREN ODER COPYRIGHTINHABER FÜR JEGLICHEN SCHADEN ODER SONSTIGE ANSPRÜCHE HAFTBAR ZU MACHEN, 
 * OB INFOLGE DER ERFÜLLUNG EINES VERTRAGES, EINES DELIKTES ODER ANDERS IM ZUSAMMENHANG MIT DER SOFTWARE ODER SONSTIGER VERWENDUNG DER SOFTWARE 
 * ENTSTANDEN.
 * 
 * ***************************************************************************************************************************************************
 * Copyright (c) 2012 Michel Krämer
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
 * to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
 * and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
 * DEALINGS IN THE SOFTWARE.
 * 
 *****************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using AllmysteryWP8.ViewModel.DataTypes;
using AllmysteryWP8.ViewModel;
using AllmysteryWP8.ViewModel.Extensions;
namespace AllmysteryWP8
{
    public partial class TemplatesPage : PhoneApplicationPage
    {
        public TemplatesPage()
        {
            InitializeComponent();
            this.DataContext = App.ViewModel;
            this.lbotemplates.ItemsSource = App.ViewModel.templateViewModel.Templates;
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            this.lbotemplates.ItemsSource = App.ViewModel.templateViewModel.Templates;
            this.templatepopup.IsOpen = false;
            this.IsHitTestVisible = true;
            this.ApplicationBar.Enable();
        }

        private void lbotemplates_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.templatepopup.IsOpen = true;
            this.IsHitTestVisible = false;
            this.ApplicationBar.Disable();
        }

        private void butuseit_Click(object sender, RoutedEventArgs e)
        {
            this.templatepopup.IsOpen = false;
            this.IsHitTestVisible = true;
            this.ApplicationBar.Enable();
            if (this.lbotemplates.SelectedIndex != -1)
            {
                Template template = App.ViewModel.templateViewModel.Templates[this.lbotemplates.SelectedIndex];
                NavigationService.Navigate(new Uri("/SingleThreadPage.xaml?threadid=" + template.threadID + "&title=" + template.threadTitle + "&index=" + this.lbotemplates.SelectedIndex.ToString(), UriKind.Relative));
            }
        }

        private void butremoveit_Click(object sender, RoutedEventArgs e)
        {
            App.ViewModel.templateViewModel.removeTemplate(App.ViewModel.templateViewModel.Templates[this.lbotemplates.SelectedIndex]);
            
            this.lbotemplates.ItemsSource = App.ViewModel.templateViewModel.Templates;
            this.templatepopup.IsOpen = false;
            this.IsHitTestVisible = true;
            this.ApplicationBar.Enable();
        }

        private void butback2_Click(object sender, RoutedEventArgs e)
        {
            this.templatepopup.IsOpen = false;
            this.IsHitTestVisible = true;
            this.ApplicationBar.Enable();
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            App.ViewModel.templateViewModel.removeAllTemplates();
            this.lbotemplates.ItemsSource = App.ViewModel.templateViewModel.Templates;
        }


        private void ApplicationTitle_Tap_1(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MyConversationsPage.xaml", UriKind.Relative));
        }
    }
}