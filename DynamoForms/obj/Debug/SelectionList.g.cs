﻿#pragma checksum "..\..\SelectionList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E80E3BEEF90D4009D033216F043D0A976F5BFF0B0D6412BD5DC9E2A59D942D59"
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
    /// SelectionList
    /// </summary>
    public partial class SelectionList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\SelectionList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tb_1;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\SelectionList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstUnselected;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\SelectionList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelect;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\SelectionList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSelectAll;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\SelectionList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeselect;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\SelectionList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeselectAll;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\SelectionList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstSelected;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\SelectionList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_MoveUp;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\SelectionList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_MoveDown;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\SelectionList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Ok;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\SelectionList.xaml"
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
            System.Uri resourceLocater = new System.Uri("/DynamoForms;component/selectionlist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SelectionList.xaml"
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
            this.lstUnselected = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.btnSelect = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\SelectionList.xaml"
            this.btnSelect.Click += new System.Windows.RoutedEventHandler(this.btnSelect_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSelectAll = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\SelectionList.xaml"
            this.btnSelectAll.Click += new System.Windows.RoutedEventHandler(this.btnSelectAll_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnDeselect = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\SelectionList.xaml"
            this.btnDeselect.Click += new System.Windows.RoutedEventHandler(this.btnDeselect_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnDeselectAll = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\SelectionList.xaml"
            this.btnDeselectAll.Click += new System.Windows.RoutedEventHandler(this.btnDeselectAll_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lstSelected = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.btn_MoveUp = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\SelectionList.xaml"
            this.btn_MoveUp.Click += new System.Windows.RoutedEventHandler(this.btn_MoveUp_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btn_MoveDown = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\SelectionList.xaml"
            this.btn_MoveDown.Click += new System.Windows.RoutedEventHandler(this.btn_MoveDown_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btn_Ok = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\SelectionList.xaml"
            this.btn_Ok.Click += new System.Windows.RoutedEventHandler(this.btn_Ok_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btn_Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\SelectionList.xaml"
            this.btn_Cancel.Click += new System.Windows.RoutedEventHandler(this.btn_Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

