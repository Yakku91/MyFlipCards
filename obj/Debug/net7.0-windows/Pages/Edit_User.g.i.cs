﻿#pragma checksum "..\..\..\..\Pages\Edit_User.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F69791381110FCC1AFA99CA6C9B47FC7A91995F9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MyCards.ViewModels;
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


namespace MyCards.Pages {
    
    
    /// <summary>
    /// Edit_User
    /// </summary>
    public partial class Edit_User : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\Pages\Edit_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_firstname;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Pages\Edit_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_Lastname;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Pages\Edit_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_Email;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Pages\Edit_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBox_Username;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Pages\Edit_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtBox_Password1;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Pages\Edit_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtBox_Password2;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Pages\Edit_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Save;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Pages\Edit_User.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_DeleteUser;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MyCards;component/pages/edit_user.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Edit_User.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtBox_firstname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtBox_Lastname = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtBox_Email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtBox_Username = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtBox_Password1 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.txtBox_Password2 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.btn_Save = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\Pages\Edit_User.xaml"
            this.btn_Save.Click += new System.Windows.RoutedEventHandler(this.btn_Save_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_DeleteUser = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\Pages\Edit_User.xaml"
            this.btn_DeleteUser.Click += new System.Windows.RoutedEventHandler(this.btn_DeleteUser_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

