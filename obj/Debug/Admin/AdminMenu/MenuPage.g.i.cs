#pragma checksum "..\..\..\..\Admin\AdminMenu\MenuPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CC6DF425A0402F3519F476B03139F448591D945251DCBA3B672EB2E5182604BF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Policlinic.AdminPage;
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


namespace Policlinic.AdminPage {
    
    
    /// <summary>
    /// MenuPage
    /// </summary>
    public partial class MenuPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\..\Admin\AdminMenu\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FilealBtn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Admin\AdminMenu\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DoctorsBtn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Admin\AdminMenu\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PatietsBtn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Admin\AdminMenu\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VisitsBtn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Admin\AdminMenu\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddDoctorBtn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Admin\AdminMenu\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddPatientBtn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Admin\AdminMenu\MenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddFilialBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Policlinic;component/admin/adminmenu/menupage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Admin\AdminMenu\MenuPage.xaml"
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
            this.FilealBtn = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\Admin\AdminMenu\MenuPage.xaml"
            this.FilealBtn.Click += new System.Windows.RoutedEventHandler(this.FilealBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DoctorsBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.PatietsBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.VisitsBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.AddDoctorBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.AddPatientBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.AddFilialBtn = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\Admin\AdminMenu\MenuPage.xaml"
            this.AddFilialBtn.Click += new System.Windows.RoutedEventHandler(this.AddFilialBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

