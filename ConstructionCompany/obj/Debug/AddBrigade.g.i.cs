﻿#pragma checksum "..\..\AddBrigade.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "21B0F693943738D13F69B856913AD69B0A1CCB1CCD7D7E9171D56A24EFBFC452"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ConstructionCompany;
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


namespace ConstructionCompany {
    
    
    /// <summary>
    /// AddBrigade
    /// </summary>
    public partial class AddBrigade : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\AddBrigade.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_addbrigade;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AddBrigade.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox_BrigadierName;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\AddBrigade.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox_WorkName;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\AddBrigade.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_addbrigadier;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\AddBrigade.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_addwork;
        
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
            System.Uri resourceLocater = new System.Uri("/ConstructionCompany;component/addbrigade.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddBrigade.xaml"
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
            this.button_addbrigade = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\AddBrigade.xaml"
            this.button_addbrigade.Click += new System.Windows.RoutedEventHandler(this.button_addbrigade_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.comboBox_BrigadierName = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.comboBox_WorkName = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.button_addbrigadier = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\AddBrigade.xaml"
            this.button_addbrigadier.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button_addwork = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\AddBrigade.xaml"
            this.button_addwork.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

