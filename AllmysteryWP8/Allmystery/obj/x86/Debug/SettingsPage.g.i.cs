﻿#pragma checksum "C:\Users\Michel Krämer\Documents\Visual Studio 2012\Projects\Allmystery WP8\Allmystery\SettingsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "53CD2AE46761B6517577FFE4AAF46BC0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18010
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace AllmysteryWP8 {
    
    
    public partial class SettingsPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock tblusername;
        
        internal System.Windows.Controls.TextBox tbousername;
        
        internal System.Windows.Controls.TextBlock tblpassword;
        
        internal System.Windows.Controls.PasswordBox tbopassword;
        
        internal System.Windows.Controls.CheckBox cbopushmessages;
        
        internal System.Windows.Controls.CheckBox cbopushthreads;
        
        internal System.Windows.Controls.CheckBox cbopushsystem;
        
        internal System.Windows.Controls.CheckBox cbomarker;
        
        internal System.Windows.Controls.CheckBox cboautofavourite;
        
        internal System.Windows.Controls.TextBlock textBlock1;
        
        internal System.Windows.Controls.Button button1;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/AllmysteryWP8;component/SettingsPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.tblusername = ((System.Windows.Controls.TextBlock)(this.FindName("tblusername")));
            this.tbousername = ((System.Windows.Controls.TextBox)(this.FindName("tbousername")));
            this.tblpassword = ((System.Windows.Controls.TextBlock)(this.FindName("tblpassword")));
            this.tbopassword = ((System.Windows.Controls.PasswordBox)(this.FindName("tbopassword")));
            this.cbopushmessages = ((System.Windows.Controls.CheckBox)(this.FindName("cbopushmessages")));
            this.cbopushthreads = ((System.Windows.Controls.CheckBox)(this.FindName("cbopushthreads")));
            this.cbopushsystem = ((System.Windows.Controls.CheckBox)(this.FindName("cbopushsystem")));
            this.cbomarker = ((System.Windows.Controls.CheckBox)(this.FindName("cbomarker")));
            this.cboautofavourite = ((System.Windows.Controls.CheckBox)(this.FindName("cboautofavourite")));
            this.textBlock1 = ((System.Windows.Controls.TextBlock)(this.FindName("textBlock1")));
            this.button1 = ((System.Windows.Controls.Button)(this.FindName("button1")));
        }
    }
}

