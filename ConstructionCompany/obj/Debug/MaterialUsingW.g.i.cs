﻿#pragma checksum "..\..\MaterialUsingW.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D1BD17286AE272883E0CC0809BAB0586EDBB3C0220BFC50057509EF1E806235A"
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
using ConstructionCompany.Models;
using ConstructionCompany.ViewModels;
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
    /// MaterialUsingW
    /// </summary>
    public partial class MaterialUsingW : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 40 "..\..\MaterialUsingW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid BrigadesInOrderDG;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MaterialUsingW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid MaterialsInOrderBrigadeDG;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\MaterialUsingW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddMaterial;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MaterialUsingW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_ExpertClass;
        
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
            System.Uri resourceLocater = new System.Uri("/ConstructionCompany;component/materialusingw.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MaterialUsingW.xaml"
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
            this.BrigadesInOrderDG = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.MaterialsInOrderBrigadeDG = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.AddMaterial = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\MaterialUsingW.xaml"
            this.AddMaterial.Click += new System.Windows.RoutedEventHandler(this.AddMaterial_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.button_ExpertClass = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\MaterialUsingW.xaml"
            this.button_ExpertClass.Click += new System.Windows.RoutedEventHandler(this.button_ExpertClass_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

