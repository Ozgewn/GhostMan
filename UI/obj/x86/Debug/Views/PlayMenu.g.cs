﻿#pragma checksum "D:\GitHub\GhostMan\UI\Views\PlayMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "057036A3FF9C53E3AC3ECE597C507D2D3DE624DBCB22D69B0A81BC2670BD198C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UI.Views
{
    partial class PlayMenu : 
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
            case 9: // Views\PlayMenu.xaml line 90
                {
                    this.visualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 10: // Views\PlayMenu.xaml line 91
                {
                    this.Narrow = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 11: // Views\PlayMenu.xaml line 112
                {
                    this.Wide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 12: // Views\PlayMenu.xaml line 140
                {
                    this.contenedor = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 13: // Views\PlayMenu.xaml line 152
                {
                    this.btnBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnBack).Click += this.btnBack_Click;
                }
                break;
            case 14: // Views\PlayMenu.xaml line 141
                {
                    this.defaultBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.defaultBtn).Click += this.defaultBtn_Click;
                }
                break;
            case 15: // Views\PlayMenu.xaml line 144
                {
                    this.customBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.customBtn).Click += this.customBtn_Click;
                }
                break;
            case 16: // Views\PlayMenu.xaml line 148
                {
                    this.defaultTxt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // Views\PlayMenu.xaml line 149
                {
                    this.customTxt = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18: // Views\PlayMenu.xaml line 145
                {
                    this.customImg = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 19: // Views\PlayMenu.xaml line 142
                {
                    this.defaultImg = (global::Windows.UI.Xaml.Controls.Image)(target);
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

