﻿#pragma checksum "..\..\NieuwArtiest.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4961C14FB89872B0C91F2D890B540BB8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using Top2000;


namespace Top2000 {
    
    
    /// <summary>
    /// NieuwArtiest
    /// </summary>
    public partial class NieuwArtiest : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\NieuwArtiest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgFoto;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\NieuwArtiest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnWijzig;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\NieuwArtiest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNaam;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\NieuwArtiest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbUrl;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\NieuwArtiest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpslaan;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\NieuwArtiest.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAnnuleren;
        
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
            System.Uri resourceLocater = new System.Uri("/Top2000;component/nieuwartiest.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NieuwArtiest.xaml"
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
            this.imgFoto = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.btnWijzig = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\NieuwArtiest.xaml"
            this.btnWijzig.Click += new System.Windows.RoutedEventHandler(this.btnWijzig_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbNaam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbUrl = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnOpslaan = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\NieuwArtiest.xaml"
            this.btnOpslaan.Click += new System.Windows.RoutedEventHandler(this.btnOpslaan_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAnnuleren = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\NieuwArtiest.xaml"
            this.btnAnnuleren.Click += new System.Windows.RoutedEventHandler(this.btnAnnuleren_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

