﻿#pragma checksum "..\..\AddMaterialUsing.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3DA0D721E402272F4CB50584E491CA19D6CD4184C17258DDA5F61783DB41BDE0"
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
    /// AddMaterialUsing
    /// </summary>
    public partial class AddMaterialUsing : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\AddMaterialUsing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_addmaterialusing;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\AddMaterialUsing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox_MaterialName;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\AddMaterialUsing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_Count;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\AddMaterialUsing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label countingPrice;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\AddMaterialUsing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_addbrigade;
        
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
            System.Uri resourceLocater = new System.Uri("/ConstructionCompany;component/addmaterialusing.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddMaterialUsing.xaml"
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
            this.button_addmaterialusing = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\AddMaterialUsing.xaml"
            this.button_addmaterialusing.Click += new System.Windows.RoutedEventHandler(this.button_addmaterialusing_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.comboBox_MaterialName = ((System.Windows.Controls.ComboBox)(target));
            
            #line 41 "..\..\AddMaterialUsing.xaml"
            this.comboBox_MaterialName.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBox_MaterialName_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textBox_Count = ((System.Windows.Controls.TextBox)(target));
            
            #line 43 "..\..\AddMaterialUsing.xaml"
            this.textBox_Count.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.countingPrice = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.button_addbrigade = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\AddMaterialUsing.xaml"
            this.button_addbrigade.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

