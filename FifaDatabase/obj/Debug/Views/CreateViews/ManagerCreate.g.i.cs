﻿#pragma checksum "..\..\..\..\Views\CreateViews\ManagerCreate.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6B1CC0359340F5FB7B7C08DD348630E3B06B242A43619B8AB131649A8ADB1274"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FifaDatabase.Views.CreateViews;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace FifaDatabase.Views.CreateViews {
    
    
    /// <summary>
    /// ManagerCreate
    /// </summary>
    public partial class ManagerCreate : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Views\CreateViews\ManagerCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameSearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Views\CreateViews\ManagerCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border TextBoxBorder;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Views\CreateViews\ManagerCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AgeText_Copy4;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Views\CreateViews\ManagerCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Nationality_Copy4;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Views\CreateViews\ManagerCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Nationality;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Views\CreateViews\ManagerCreate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border TextBoxBorder_Copy;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FifaDatabase;component/views/createviews/managercreate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\CreateViews\ManagerCreate.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.NameSearchTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TextBoxBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.AgeText_Copy4 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            
            #line 17 "..\..\..\..\Views\CreateViews\ManagerCreate.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Nationality_Copy4 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.Nationality = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.TextBoxBorder_Copy = ((System.Windows.Controls.Border)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

