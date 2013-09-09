﻿#pragma checksum "..\..\..\ExtendedPreview.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9DA5DFD418EA8820730A3365AFC426B2"
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
    /// ExtendedPreview
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class ExtendedPreview : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\ExtendedPreview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Thumb LeftThumb;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\ExtendedPreview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Thumb RightThumb;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\ExtendedPreview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Thumb LeftBottomThumb;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\ExtendedPreview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Thumb BottomThumb;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\ExtendedPreview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Thumb RightBubbtomThumb;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\ExtendedPreview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel PreviewPanel;
        
        #line default
        #line hidden
        
        
        #line 229 "..\..\..\ExtendedPreview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Top;
        
        #line default
        #line hidden
        
        
        #line 234 "..\..\..\ExtendedPreview.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border TextBoxBorder;
        
        #line default
        #line hidden
        
        
        #line 259 "..\..\..\ExtendedPreview.xaml"
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
            System.Uri resourceLocater = new System.Uri("/DesignScriptStudio.Graph.Ui;component/extendedpreview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ExtendedPreview.xaml"
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
            
            #line 9 "..\..\..\ExtendedPreview.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.OnMouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LeftThumb = ((System.Windows.Controls.Primitives.Thumb)(target));
            
            #line 34 "..\..\..\ExtendedPreview.xaml"
            this.LeftThumb.DragDelta += new System.Windows.Controls.Primitives.DragDeltaEventHandler(this.OnLeftThumbDragDelta);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RightThumb = ((System.Windows.Controls.Primitives.Thumb)(target));
            
            #line 43 "..\..\..\ExtendedPreview.xaml"
            this.RightThumb.DragDelta += new System.Windows.Controls.Primitives.DragDeltaEventHandler(this.OnRightThumbDragDelta);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LeftBottomThumb = ((System.Windows.Controls.Primitives.Thumb)(target));
            
            #line 52 "..\..\..\ExtendedPreview.xaml"
            this.LeftBottomThumb.DragDelta += new System.Windows.Controls.Primitives.DragDeltaEventHandler(this.OnLeftBubbtomThumbDragDelta);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BottomThumb = ((System.Windows.Controls.Primitives.Thumb)(target));
            
            #line 60 "..\..\..\ExtendedPreview.xaml"
            this.BottomThumb.DragDelta += new System.Windows.Controls.Primitives.DragDeltaEventHandler(this.OnBottomThumbDragDelta);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RightBubbtomThumb = ((System.Windows.Controls.Primitives.Thumb)(target));
            
            #line 71 "..\..\..\ExtendedPreview.xaml"
            this.RightBubbtomThumb.DragDelta += new System.Windows.Controls.Primitives.DragDeltaEventHandler(this.OnRightBubbtomThumbDragDelta);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PreviewPanel = ((System.Windows.Controls.StackPanel)(target));
            
            #line 76 "..\..\..\ExtendedPreview.xaml"
            this.PreviewPanel.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.OnTextBoxGridMouseWheel);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Top = ((System.Windows.Controls.Grid)(target));
            
            #line 229 "..\..\..\ExtendedPreview.xaml"
            this.Top.PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.OnTopMouseMove);
            
            #line default
            #line hidden
            return;
            case 9:
            this.TextBoxBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 10:
            
            #line 245 "..\..\..\ExtendedPreview.xaml"
            ((System.Windows.Controls.Border)(target)).PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.OnDotsMouseMove);
            
            #line default
            #line hidden
            return;
            case 11:
            this.InternalTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

