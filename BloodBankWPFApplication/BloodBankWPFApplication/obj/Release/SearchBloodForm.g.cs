﻿#pragma checksum "..\..\SearchBloodForm.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FD32ADADB3AD72BC4719A1B22589F70E3ABA422727B735C2FE138D8A1E689D49"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BloodBankWPFApplication;
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


namespace BloodBankWPFApplication {
    
    
    /// <summary>
    /// SearchBloodForm
    /// </summary>
    public partial class SearchBloodForm : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 100 "..\..\SearchBloodForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHome;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\SearchBloodForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRegister;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\SearchBloodForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearchBlood;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\SearchBloodForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBloodStock;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\SearchBloodForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRequestBlood;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\SearchBloodForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSearchBG;
        
        #line default
        #line hidden
        
        
        #line 153 "..\..\SearchBloodForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearchBloodGroup;
        
        #line default
        #line hidden
        
        
        #line 164 "..\..\SearchBloodForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridDonorList;
        
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
            System.Uri resourceLocater = new System.Uri("/BloodBankWPFApplication;component/searchbloodform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SearchBloodForm.xaml"
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
            
            #line 8 "..\..\SearchBloodForm.xaml"
            ((BloodBankWPFApplication.SearchBloodForm)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnHome = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\SearchBloodForm.xaml"
            this.btnHome.Click += new System.Windows.RoutedEventHandler(this.btnHome_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnRegister = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\SearchBloodForm.xaml"
            this.btnRegister.Click += new System.Windows.RoutedEventHandler(this.btnRegister_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSearchBlood = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.btnBloodStock = ((System.Windows.Controls.Button)(target));
            
            #line 117 "..\..\SearchBloodForm.xaml"
            this.btnBloodStock.Click += new System.Windows.RoutedEventHandler(this.btnBloodStock_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnRequestBlood = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\SearchBloodForm.xaml"
            this.btnRequestBlood.Click += new System.Windows.RoutedEventHandler(this.btnRequestBlood_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cmbSearchBG = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.btnSearchBloodGroup = ((System.Windows.Controls.Button)(target));
            
            #line 153 "..\..\SearchBloodForm.xaml"
            this.btnSearchBloodGroup.Click += new System.Windows.RoutedEventHandler(this.btnSearchBloodGroup_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dataGridDonorList = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

