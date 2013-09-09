﻿#pragma checksum "..\..\..\LibraryView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EE29BB381C08AC72851E9E6DE4CCB329"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DesignScriptStudio.Graph.Core;
using DesignScriptStudio.Graph.Ui;
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
    /// LibraryView
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public partial class LibraryView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 9 "..\..\..\LibraryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DesignScriptStudio.Graph.Ui.LibraryView DesignScriptEditor;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\LibraryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Thumb topThumb;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\LibraryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MinimizeView;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\LibraryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image MaximizeView;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\LibraryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border content;
        
        #line default
        #line hidden
        
        
        #line 354 "..\..\..\LibraryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddNew;
        
        #line default
        #line hidden
        
        
        #line 363 "..\..\..\LibraryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Expand;
        
        #line default
        #line hidden
        
        
        #line 372 "..\..\..\LibraryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Collapse;
        
        #line default
        #line hidden
        
        
        #line 466 "..\..\..\LibraryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Search;
        
        #line default
        #line hidden
        
        
        #line 475 "..\..\..\LibraryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 487 "..\..\..\LibraryView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView InternalTreeView;
        
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
            System.Uri resourceLocater = new System.Uri("/DesignScriptStudio.Graph.Ui;component/libraryview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LibraryView.xaml"
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
            this.DesignScriptEditor = ((DesignScriptStudio.Graph.Ui.LibraryView)(target));
            return;
            case 2:
            
            #line 20 "..\..\..\LibraryView.xaml"
            ((System.Windows.Controls.Grid)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.OnLibraryKeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.topThumb = ((System.Windows.Controls.Primitives.Thumb)(target));
            
            #line 37 "..\..\..\LibraryView.xaml"
            this.topThumb.DragDelta += new System.Windows.Controls.Primitives.DragDeltaEventHandler(this.OnTopThumbDragDelta);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\LibraryView.xaml"
            this.topThumb.PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OnTopThumbMouseUp);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 47 "..\..\..\LibraryView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnMaxiMinimizeClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MinimizeView = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.MaximizeView = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.content = ((System.Windows.Controls.Border)(target));
            return;
            case 11:
            this.AddNew = ((System.Windows.Controls.Button)(target));
            
            #line 356 "..\..\..\LibraryView.xaml"
            this.AddNew.Click += new System.Windows.RoutedEventHandler(this.OnAddNewClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Expand = ((System.Windows.Controls.Button)(target));
            
            #line 365 "..\..\..\LibraryView.xaml"
            this.Expand.Click += new System.Windows.RoutedEventHandler(this.OnExpandClick);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Collapse = ((System.Windows.Controls.Button)(target));
            
            #line 374 "..\..\..\LibraryView.xaml"
            this.Collapse.Click += new System.Windows.RoutedEventHandler(this.OnCollapseClick);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 390 "..\..\..\LibraryView.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.OnSearchBarClick);
            
            #line default
            #line hidden
            return;
            case 16:
            this.Search = ((System.Windows.Controls.Button)(target));
            return;
            case 17:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 477 "..\..\..\LibraryView.xaml"
            this.SearchTextBox.KeyUp += new System.Windows.Input.KeyEventHandler(this.OnSearchTextBoxKeyUp);
            
            #line default
            #line hidden
            return;
            case 18:
            this.InternalTreeView = ((System.Windows.Controls.TreeView)(target));
            
            #line 495 "..\..\..\LibraryView.xaml"
            this.InternalTreeView.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.OnLibraryTreeViewClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 8:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseMoveEvent;
            
            #line 123 "..\..\..\LibraryView.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.OnTreeViewItemMouseMove);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonUpEvent;
            
            #line 124 "..\..\..\LibraryView.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.OnTreeViewItemExpandCollapse);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseRightButtonUpEvent;
            
            #line 125 "..\..\..\LibraryView.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.OnTreeViewItemClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 9:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 140 "..\..\..\LibraryView.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.OnTreeViewItemDoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.FrameworkElement.RequestBringIntoViewEvent;
            
            #line 141 "..\..\..\LibraryView.xaml"
            eventSetter.Handler = new System.Windows.RequestBringIntoViewEventHandler(this.OnTreeViewItemRequestBringIntoView);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 10:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;
            
            #line 221 "..\..\..\LibraryView.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.OnTreeViewItemDoubleClick);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.FrameworkElement.RequestBringIntoViewEvent;
            
            #line 222 "..\..\..\LibraryView.xaml"
            eventSetter.Handler = new System.Windows.RequestBringIntoViewEventHandler(this.OnTreeViewItemRequestBringIntoView);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 15:
            
            #line 422 "..\..\..\LibraryView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnCloseSearch);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

