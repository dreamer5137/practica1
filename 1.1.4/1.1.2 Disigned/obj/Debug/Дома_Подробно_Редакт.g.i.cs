﻿#pragma checksum "..\..\Дома_Подробно_Редакт.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "75A8011913D83AA6464002C5AC2A52E04AAF1E1B5077FE6F919AFED555EE843B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using _1;


namespace _1 {
    
    
    /// <summary>
    /// Дома_Подробно_Редакт
    /// </summary>
    public partial class Дома_Подробно_Редакт : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\Дома_Подробно_Редакт.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNum;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Дома_Подробно_Редакт.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtStreet;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Дома_Подробно_Редакт.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbComplex;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Дома_Подробно_Редакт.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBuildCost;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Дома_Подробно_Редакт.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button save;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Дома_Подробно_Редакт.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCost;
        
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
            System.Uri resourceLocater = new System.Uri("/1;component/%d0%94%d0%be%d0%bc%d0%b0_%d0%9f%d0%be%d0%b4%d1%80%d0%be%d0%b1%d0%bd%" +
                    "d0%be_%d0%a0%d0%b5%d0%b4%d0%b0%d0%ba%d1%82.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Дома_Подробно_Редакт.xaml"
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
            this.txtNum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtStreet = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cmbComplex = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.txtBuildCost = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.save = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\Дома_Подробно_Редакт.xaml"
            this.save.Click += new System.Windows.RoutedEventHandler(this.save_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtCost = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

