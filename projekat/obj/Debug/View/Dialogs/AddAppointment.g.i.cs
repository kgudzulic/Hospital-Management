﻿#pragma checksum "..\..\..\..\View\Dialogs\AddAppointment.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5C409269B1600F9C5D1E2C540B6EC0174E7B92E82CD4E92C9D1858D86842E578"
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
using projekat.View.Dialogs;


namespace projekat.View.Dialogs {
    
    
    /// <summary>
    /// AddAppointment
    /// </summary>
    public partial class AddAppointment : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\View\Dialogs\AddAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Rooms;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\View\Dialogs\AddAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb3;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\View\Dialogs\AddAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb2;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\View\Dialogs\AddAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb1;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\View\Dialogs\AddAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Doctors;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\View\Dialogs\AddAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Patients;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\View\Dialogs\AddAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock errormessage;
        
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
            System.Uri resourceLocater = new System.Uri("/projekat;component/view/dialogs/addappointment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Dialogs\AddAppointment.xaml"
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
            
            #line 9 "..\..\..\..\View\Dialogs\AddAppointment.xaml"
            ((System.Windows.Controls.Grid)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Grid_Loaded_1);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Rooms = ((System.Windows.Controls.ComboBox)(target));
            
            #line 18 "..\..\..\..\View\Dialogs\AddAppointment.xaml"
            this.Rooms.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Rooms_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tb3 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tb2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tb1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            
            #line 28 "..\..\..\..\View\Dialogs\AddAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Doctors = ((System.Windows.Controls.ComboBox)(target));
            
            #line 35 "..\..\..\..\View\Dialogs\AddAppointment.xaml"
            this.Doctors.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Doctors_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Patients = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\..\..\View\Dialogs\AddAppointment.xaml"
            this.Patients.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Patients_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.errormessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

