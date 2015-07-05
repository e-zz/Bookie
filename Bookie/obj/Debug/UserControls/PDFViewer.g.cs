﻿#pragma checksum "..\..\..\UserControls\PDFViewer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9B75B82829F3281EDE58D4C7638FF49A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bookie.UserControls;
using MoonPdfLib;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Bookie.UserControls {
    
    
    /// <summary>
    /// PDFViewer
    /// </summary>
    public partial class PDFViewer : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 117 "..\..\..\UserControls\PDFViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox gotopage;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\UserControls\PDFViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label pageCount;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\UserControls\PDFViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BookMarkLabel;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\UserControls\PDFViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NoteLabel;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\UserControls\PDFViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private MoonPdfLib.MoonPdfPanel moonPdfPanel;
        
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
            System.Uri resourceLocater = new System.Uri("/Bookie;V15186.1410.0.0;component/usercontrols/pdfviewer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\PDFViewer.xaml"
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
            
            #line 82 "..\..\..\UserControls\PDFViewer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 85 "..\..\..\UserControls\PDFViewer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonBase_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 88 "..\..\..\UserControls\PDFViewer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 91 "..\..\..\UserControls\PDFViewer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonBase1_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 94 "..\..\..\UserControls\PDFViewer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonBase9_OnClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 98 "..\..\..\UserControls\PDFViewer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 101 "..\..\..\UserControls\PDFViewer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonBase2_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 104 "..\..\..\UserControls\PDFViewer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_5);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 107 "..\..\..\UserControls\PDFViewer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_6);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 110 "..\..\..\UserControls\PDFViewer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonBas3_OnClick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 112 "..\..\..\UserControls\PDFViewer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            case 12:
            this.gotopage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            
            #line 118 "..\..\..\UserControls\PDFViewer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GotoPage_OnClick);
            
            #line default
            #line hidden
            return;
            case 14:
            this.pageCount = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            this.BookMarkLabel = ((System.Windows.Controls.Button)(target));
            
            #line 127 "..\..\..\UserControls\PDFViewer.xaml"
            this.BookMarkLabel.Click += new System.Windows.RoutedEventHandler(this.BookMarkLabel_OnClick);
            
            #line default
            #line hidden
            return;
            case 16:
            this.NoteLabel = ((System.Windows.Controls.Button)(target));
            
            #line 128 "..\..\..\UserControls\PDFViewer.xaml"
            this.NoteLabel.Click += new System.Windows.RoutedEventHandler(this.NoteLabel_OnClick);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 129 "..\..\..\UserControls\PDFViewer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 130 "..\..\..\UserControls\PDFViewer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonBase5_OnClick);
            
            #line default
            #line hidden
            return;
            case 19:
            this.moonPdfPanel = ((MoonPdfLib.MoonPdfPanel)(target));
            
            #line 136 "..\..\..\UserControls\PDFViewer.xaml"
            this.moonPdfPanel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.moonPdfPanel_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

