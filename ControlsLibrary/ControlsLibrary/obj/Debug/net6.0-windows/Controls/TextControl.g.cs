﻿#pragma checksum "..\..\..\..\Controls\TextControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C10375C94A410AC4E3EBF874034F3927EB50729E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ControlsLibrary.Controls;
using ControlsLibrary.ViewModel;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ControlsLibrary.Controls {
    
    
    /// <summary>
    /// TextControl
    /// </summary>
    public partial class TextControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\Controls\TextControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canvas;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Controls\TextControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border pictureBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Controls\TextControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.RotateTransform rotateTransform;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Controls\TextControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ScaleTransform scaleTransformation;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ControlsLibrary;component/controls/textcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Controls\TextControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.canvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.pictureBox = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.rotateTransform = ((System.Windows.Media.RotateTransform)(target));
            return;
            case 4:
            this.scaleTransformation = ((System.Windows.Media.ScaleTransform)(target));
            return;
            case 5:
            
            #line 64 "..\..\..\..\Controls\TextControl.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 65 "..\..\..\..\Controls\TextControl.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 66 "..\..\..\..\Controls\TextControl.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Rectangle_MouseMove);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 83 "..\..\..\..\Controls\TextControl.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 84 "..\..\..\..\Controls\TextControl.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.Rectangle_PreviewMouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 85 "..\..\..\..\Controls\TextControl.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.Rectangle_PreviewMouseMove);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

