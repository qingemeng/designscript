﻿#pragma checksum "..\..\..\CustomTextBox.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BA36D6CDA1AF9EC2689CCD62B45936E2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace DesignScriptStudio.Graph.Ui {
    
    
    /// <summary>
    /// CustomTextBox
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class CustomTextBox : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\CustomTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TextBoxGrid;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\CustomTextBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InternalTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DesignScriptStudio.Graph.Ui;component/customtextbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CustomTextBox.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TextBoxGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 13 "..\..\..\CustomTextBox.xaml"
            this.TextBoxGrid.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.OnTextBoxGridMouseWheel);
            
            #line default
            #line hidden
            return;
            case 2:
            this.InternalTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 171 "..\..\..\CustomTextBox.xaml"
            this.InternalTextBox.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnPreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 172 "..\..\..\CustomTextBox.xaml"
            this.InternalTextBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.OnPreviewKeyDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

