﻿#pragma checksum "..\..\..\..\UI\ArtistMainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9E16ACEF621CE3986A34AD1A022B2B226A8F2220"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using wpfui;


namespace wpfui {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\..\UI\ArtistMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StatisticsButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\UI\ArtistMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PFPButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\UI\ArtistMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewAlbumButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\UI\ArtistMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox SongsListBox;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\UI\ArtistMainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox AlbumListBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SE_project;component/ui/artistmainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\ArtistMainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.StatisticsButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\UI\ArtistMainWindow.xaml"
            this.StatisticsButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_Statistics);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PFPButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\UI\ArtistMainWindow.xaml"
            this.PFPButton.Click += new System.Windows.RoutedEventHandler(this.PFPButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NewAlbumButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\UI\ArtistMainWindow.xaml"
            this.NewAlbumButton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_NewAlbum);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SongsListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.AlbumListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
