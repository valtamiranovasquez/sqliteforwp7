﻿#pragma checksum "E:\Documents\Microsoft\Windows Phone\Aplicaciones\SQLiteforWP7\SQLiteforWP7\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1390DC52974369D48AEA0E0C29112719"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SQLiteforWP7 {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox txtcodigo;
        
        internal System.Windows.Controls.Button btngrabar;
        
        internal System.Windows.Controls.TextBox txtnombre;
        
        internal System.Windows.Controls.Button btnmodificar;
        
        internal System.Windows.Controls.Button btnlistar;
        
        internal System.Windows.Controls.Button btneliminar;
        
        internal System.Windows.Controls.ListBox lista;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SQLiteforWP7;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txtcodigo = ((System.Windows.Controls.TextBox)(this.FindName("txtcodigo")));
            this.btngrabar = ((System.Windows.Controls.Button)(this.FindName("btngrabar")));
            this.txtnombre = ((System.Windows.Controls.TextBox)(this.FindName("txtnombre")));
            this.btnmodificar = ((System.Windows.Controls.Button)(this.FindName("btnmodificar")));
            this.btnlistar = ((System.Windows.Controls.Button)(this.FindName("btnlistar")));
            this.btneliminar = ((System.Windows.Controls.Button)(this.FindName("btneliminar")));
            this.lista = ((System.Windows.Controls.ListBox)(this.FindName("lista")));
        }
    }
}
