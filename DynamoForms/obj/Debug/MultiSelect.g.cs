﻿#pragma checksum "..\..\MultiSelect.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CADF913BA3859A9904ACED85DBE3B7A989DD70417BDC9E2E012395F4B2835FDA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DynamoForms;
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


namespace DynamoForms {
    
    
    /// <summary>
    /// MultiSelect
    /// </summary>
    public partial class MultiSelect : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\MultiSelect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_1;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\MultiSelect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MultiSelect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Ok;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MultiSelect.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/DynamoForms;component/multiselect.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MultiSelect.xaml"
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
            this.tb_1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.lstBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.btn_Ok = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\MultiSelect.xaml"
            this.btn_Ok.Click += new System.Windows.RoutedEventHandler(this.btn_Ok_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btn_Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\MultiSelect.xaml"
            this.btn_Cancel.Click += new System.Windows.RoutedEventHandler(this.btn_Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

