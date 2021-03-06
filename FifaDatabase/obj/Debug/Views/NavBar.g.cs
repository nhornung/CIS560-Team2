#pragma checksum "..\..\..\Views\NavBar.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AA864DB654A69838907C271EDDFCF1DDE9AA928C884D7744653A91FB1FBF5F64"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FifaDatabase.Models;
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


namespace FifaDatabase.Views {
    
    
    /// <summary>
    /// NavBar
    /// </summary>
    public partial class NavBar : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\Views\NavBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CategoryCombo;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\NavBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox QueryTypeCombo;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\NavBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Hot;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Views\NavBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Traits;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Views\NavBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Views;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Views\NavBar.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Winning;
        
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
            System.Uri resourceLocater = new System.Uri("/FifaDatabase;component/views/navbar.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\NavBar.xaml"
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
            this.CategoryCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.QueryTypeCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            
            #line 49 "..\..\..\Views\NavBar.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Hot = ((System.Windows.Controls.RadioButton)(target));
            
            #line 51 "..\..\..\Views\NavBar.xaml"
            this.Hot.Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Traits = ((System.Windows.Controls.RadioButton)(target));
            
            #line 52 "..\..\..\Views\NavBar.xaml"
            this.Traits.Checked += new System.Windows.RoutedEventHandler(this.Traits_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Views = ((System.Windows.Controls.RadioButton)(target));
            
            #line 55 "..\..\..\Views\NavBar.xaml"
            this.Views.Checked += new System.Windows.RoutedEventHandler(this.Views_Checked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Winning = ((System.Windows.Controls.RadioButton)(target));
            
            #line 56 "..\..\..\Views\NavBar.xaml"
            this.Winning.Checked += new System.Windows.RoutedEventHandler(this.Winning_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

