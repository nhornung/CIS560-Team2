﻿#pragma checksum "..\..\..\..\Views\CreateViews\PlayerGameStatCreateView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "47A2AF8D9E192584715BDC269125EA35D083A30542A60608ABD669F35A9D3C34"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FifaDatabase.Models.Enums;
using FifaDatabase.Views;
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
    /// PlayerGameStatCreateView
    /// </summary>
    public partial class PlayerGameStatCreateView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\Views\CreateViews\PlayerGameStatCreateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTextBox;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Views\CreateViews\PlayerGameStatCreateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border TextBoxBorder;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Views\CreateViews\PlayerGameStatCreateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider WeightSlider;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Views\CreateViews\PlayerGameStatCreateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WeightText;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Views\CreateViews\PlayerGameStatCreateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PositionBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Views\CreateViews\PlayerGameStatCreateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PositionText;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Views\CreateViews\PlayerGameStatCreateView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PlayerNameText;
        
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
            System.Uri resourceLocater = new System.Uri("/FifaDatabase;component/views/createviews/playergamestatcreateview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\CreateViews\PlayerGameStatCreateView.xaml"
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
            this.NameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TextBoxBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.WeightSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 4:
            this.WeightText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.PositionBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.PositionText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.PlayerNameText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            
            #line 24 "..\..\..\..\Views\CreateViews\PlayerGameStatCreateView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

