﻿#pragma checksum "..\..\DODAJ_KONTRAHENTA.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C3EBFB713C8A474B7EBD9CE50C826202"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
using test;


namespace test {
    
    
    /// <summary>
    /// DODAJ_KONTRAHENTA
    /// </summary>
    public partial class DODAJ_KONTRAHENTA : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\DODAJ_KONTRAHENTA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gridKontrahenci;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\DODAJ_KONTRAHENTA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox imie_dodaj;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\DODAJ_KONTRAHENTA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nazwisko_dodaj;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\DODAJ_KONTRAHENTA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox telefon_dodaj;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\DODAJ_KONTRAHENTA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox miejscowosc_dodaj;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\DODAJ_KONTRAHENTA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox data_dodaj;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\DODAJ_KONTRAHENTA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ocena_dodaj;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\DODAJ_KONTRAHENTA.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox opis_dodaj;
        
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
            System.Uri resourceLocater = new System.Uri("/test;component/dodaj_kontrahenta.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DODAJ_KONTRAHENTA.xaml"
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
            this.gridKontrahenci = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.imie_dodaj = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.nazwisko_dodaj = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.telefon_dodaj = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.miejscowosc_dodaj = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.data_dodaj = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ocena_dodaj = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.opis_dodaj = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 30 "..\..\DODAJ_KONTRAHENTA.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
