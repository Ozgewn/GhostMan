<<<<<<< HEAD
﻿#pragma checksum "C:\Users\aruiz\Documents\GitHub\GhostMan\UI\Views\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "56F9697794588DFFD893AB98118F43BF1FD22E2C939562AFB9CFA075A0FA94E9"
=======
﻿#pragma checksum "C:\CositasEpicas\GitKraken\GhostMan\UI\Views\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "56F9697794588DFFD893AB98118F43BF1FD22E2C939562AFB9CFA075A0FA94E9"
>>>>>>> Albert
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\MainPage.xaml line 15
                {
                    this.visualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 3: // Views\MainPage.xaml line 16
                {
                    this.Narrow = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4: // Views\MainPage.xaml line 34
                {
                    this.Wide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5: // Views\MainPage.xaml line 59
                {
                    this.nombre = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Views\MainPage.xaml line 60
                {
                    this.contenedor = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 7: // Views\MainPage.xaml line 61
                {
                    this.playBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.playBtn).Click += this.playBtn_Click;
                }
                break;
            case 8: // Views\MainPage.xaml line 64
                {
                    this.createBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.createBtn).Click += this.createBtn_Click;
                }
                break;
            case 9: // Views\MainPage.xaml line 65
                {
                    this.createImg = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 10: // Views\MainPage.xaml line 62
                {
                    this.playImg = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

