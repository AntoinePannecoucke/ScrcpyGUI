﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90315FC2D69D44E2159A4DCABB793232E10A938D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using ScrcpyGUI;
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


namespace ScrcpyGUI {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox always_on_top_checkbox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox max_fps_checkbox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox crop_checkbox;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox window_title_checkbox;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox window_borderless_checkbox;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox fullscreen_checkbox;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox no_control_checkbox;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox stay_awake_checkbox;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox show_touches_checkbox;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox max_size_checkbox;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox max_bit_rate_checkbox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ScrcpyGUI;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.always_on_top_checkbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 2:
            this.max_fps_checkbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            
            #line 41 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumericTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.crop_checkbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            
            #line 73 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumericTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 84 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumericTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 95 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumericTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 106 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumericTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 9:
            this.window_title_checkbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            this.window_borderless_checkbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 11:
            this.fullscreen_checkbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 12:
            this.no_control_checkbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 13:
            this.stay_awake_checkbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 14:
            this.show_touches_checkbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 15:
            this.max_size_checkbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 16:
            
            #line 183 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumericTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 17:
            this.max_bit_rate_checkbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 18:
            
            #line 201 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumericTextBox_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 211 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Launch_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
