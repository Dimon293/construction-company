﻿#pragma checksum "..\..\WorkerW.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C962BA82D4FD130D1484A7E03E3F3AFCD4CE3EDE22327D1E58794770967F71CE"
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
    /// WorkerW
    /// </summary>
    public partial class WorkerW : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\WorkerW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddWorker;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\WorkerW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditWorker;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\WorkerW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteWorker;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\WorkerW.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid WorkersDG;
        
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
            System.Uri resourceLocater = new System.Uri("/ConstructionCompany;component/workerw.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WorkerW.xaml"
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
            this.AddWorker = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\WorkerW.xaml"
            this.AddWorker.Click += new System.Windows.RoutedEventHandler(this.AddWorker_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EditWorker = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\WorkerW.xaml"
            this.EditWorker.Click += new System.Windows.RoutedEventHandler(this.EditWorker_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DeleteWorker = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\WorkerW.xaml"
            this.DeleteWorker.Click += new System.Windows.RoutedEventHandler(this.DeleteWorker_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.WorkersDG = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
