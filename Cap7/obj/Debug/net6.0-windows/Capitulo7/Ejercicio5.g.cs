﻿#pragma checksum "..\..\..\..\Capitulo7\Ejercicio5.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DB034617067C19EE5D41DF4846FC19046F32B03F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Cap7.Capitulo7;
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


namespace Cap7.Capitulo7 {
    
    
    /// <summary>
    /// Ejercicio5
    /// </summary>
    public partial class Ejercicio5 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Capitulo7\Ejercicio5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox calificacion;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Capitulo7\Ejercicio5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button agregar;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\Capitulo7\Ejercicio5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Imprimir;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\Capitulo7\Ejercicio5.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox pantalla;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Cap7;V1.0.0.0;component/capitulo7/ejercicio5.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Capitulo7\Ejercicio5.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.calificacion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.agregar = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\..\Capitulo7\Ejercicio5.xaml"
            this.agregar.Click += new System.Windows.RoutedEventHandler(this.agregar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Imprimir = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\Capitulo7\Ejercicio5.xaml"
            this.Imprimir.Click += new System.Windows.RoutedEventHandler(this.Imprimir_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pantalla = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

