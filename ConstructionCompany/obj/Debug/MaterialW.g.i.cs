﻿#pragma checksum "..\..\MaterialW.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "42BE4F7E84F8DCFA0EA480DC48155704DE5A650B1428527D7C361A3B77A406F7"
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
    /// MaterialW
    /// </summary>
    public partial class MaterialW : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\MaterialW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddMaterial;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MaterialW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditMaterial;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\MaterialW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteMaterial;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\MaterialW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid MaterialDG;
        
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
            System.Uri resourceLocater = new System.Uri("/ConstructionCompany;component/materialw.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MaterialW.xaml"
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
            this.AddMaterial = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\MaterialW.xaml"
            this.AddMaterial.Click += new System.Windows.RoutedEventHandler(this.AddMaterial_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EditMaterial = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\MaterialW.xaml"
            this.EditMaterial.Click += new System.Windows.RoutedEventHandler(this.EditMaterial_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DeleteMaterial = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\MaterialW.xaml"
            this.DeleteMaterial.Click += new System.Windows.RoutedEventHandler(this.DeleteMaterial_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MaterialDG = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

