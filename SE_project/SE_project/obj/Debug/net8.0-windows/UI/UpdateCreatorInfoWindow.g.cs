﻿#pragma checksum "..\..\..\..\UI\UpdateCreatorInfoWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21322AA62150EB349F7015D10A0458BBD2387489"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SE_project.UI;
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


namespace SE_project.UI {
    
    
    /// <summary>
    /// UpdateCreatorInfoWindow
    /// </summary>
    public partial class UpdateCreatorInfoWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\UI\UpdateCreatorInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SocialMediaLinkTextBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\UI\UpdateCreatorInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Run DescriptionTextField;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\UI\UpdateCreatorInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChoosePhotoButton;
        
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
            System.Uri resourceLocater = new System.Uri("/SE_project;component/ui/updatecreatorinfowindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\UpdateCreatorInfoWindow.xaml"
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
            this.SocialMediaLinkTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            
            #line 11 "..\..\..\..\UI\UpdateCreatorInfoWindow.xaml"
            ((System.Windows.Controls.RichTextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RichTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DescriptionTextField = ((System.Windows.Documents.Run)(target));
            return;
            case 4:
            this.ChoosePhotoButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\UI\UpdateCreatorInfoWindow.xaml"
            this.ChoosePhotoButton.Click += new System.Windows.RoutedEventHandler(this.ChoosePhotoButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 23 "..\..\..\..\UI\UpdateCreatorInfoWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SubmitUpdateButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 24 "..\..\..\..\UI\UpdateCreatorInfoWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

