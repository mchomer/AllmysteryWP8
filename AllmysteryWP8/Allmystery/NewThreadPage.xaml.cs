using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using AllmysteryWP8.ViewModel;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using AllmysteryWP8.ViewModel.Extensions;

namespace AllmysteryWP8
{
    public partial class NewThreadPage : PhoneApplicationPage
    {
        private string category = "";
        SingleThreadViewModel singlethreadviewmodel;
        ProgressBar progressbar;
        public NewThreadPage()
        {
            InitializeComponent();
            this.singlethreadviewmodel = new SingleThreadViewModel();
            this.progressbar = new ProgressBar();
            this.DataContext = App.ViewModel;
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            NavigationContext.QueryString.TryGetValue("category", out this.category);
        }
        private void PhoneApplicationPage_OrientationChanged(object sender, OrientationChangedEventArgs e)
        {
            if (this.Orientation == PageOrientation.PortraitUp || this.Orientation == PageOrientation.PortraitDown)
            {
                
                //this.tbonewpost.Height = 612;
                //this.tbonewpost.Width = 480;
            }
            else if (this.Orientation == PageOrientation.LandscapeLeft || this.Orientation == PageOrientation.LandscapeRight)
            {
                //this.tbonewpost.Height = 400;
                //this.tbonewpost.Width = 644;
            }
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            if (Application.Current.Resources["lngTitle"].ToString() != this.tbotitle.Text)
            {
                this.openprogressbar();
                this.IsHitTestVisible = false;
                this.ApplicationBar.IsMenuEnabled = false;
                this.singlethreadviewmodel.newthreadCreated = this.newthreadcreated;
                this.singlethreadviewmodel.createNewThread(this.category, this.tbotitle.Text, this.tbonewpost.Text);
            }
            else
            {
                MessageBox.Show(Application.Current.Resources["lngThreadTitleFail"].ToString(), Application.Current.Resources["lngThreadTitleFailTitle"].ToString(), MessageBoxButton.OK);
            }
        }

        private void newthreadcreated(string result)
        {
            Deployment.Current.Dispatcher.BeginInvoke(delegate
            {
                if (result != "false")
                {
                    if (App.ViewModel.settingsViewModel.autoFavourite)
                    {
                        BookmarksViewModel bookmarksviewmodel = new BookmarksViewModel();
                        bookmarksviewmodel.bookmarkAdded = this.bookmarkadded;
                        bookmarksviewmodel.addBookmark(result);
                    }
                    this.IsHitTestVisible = true;
                    this.ApplicationBar.IsMenuEnabled = true;
                    this.closeprogressbar();
                    this.tbonewpost.Text = "";
                    this.tbotitle.Text = Application.Current.Resources["lngTitle"].ToString();
                    NavigationService.Navigate(new Uri("/SingleThreadPage.xaml?threadid=" + result + "&title=" + this.tbotitle.Text, UriKind.Relative));
                }
                else
                {
                    this.closeprogressbar();
                    MessageBox.Show(Application.Current.Resources["lngFailCreateNewThread"].ToString(), Application.Current.Resources["lngFailCreateNewThreadTitle"].ToString(), MessageBoxButton.OK);
                }
            });
        }
        private void closeprogressbar(bool result = false)
        {
            this.progressbar.IsIndeterminate = false;
            this.progressbar.Visibility = System.Windows.Visibility.Collapsed;
            this.ContentPanel.Children.Remove(this.progressbar);
            this.IsEnabled = true;
            this.tbotitle.IsEnabled = true;
            this.IsHitTestVisible = true;
            this.tbonewpost.IsEnabled = true;
            this.ApplicationBar.Enable();
        }

        private void openprogressbar()
        {
            if (this.progressbar.IsIndeterminate != true)
            {
                this.progressbar.IsIndeterminate = true;
                this.IsHitTestVisible = false;
                this.tbonewpost.IsEnabled = false;
                this.tbotitle.IsEnabled = false;
                this.ApplicationBar.Disable();
                this.progressbar.Visibility = System.Windows.Visibility.Visible;
                try
                {
                    this.ContentPanel.Children.Add(this.progressbar);
                }
                catch
                {

                }
            }
        }

        private void bookmarkadded(bool result = false)
        {
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            this.Focus();
        }

        
    }
}