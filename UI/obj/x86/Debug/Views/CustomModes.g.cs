<<<<<<< HEAD
﻿#pragma checksum "C:\Users\aruiz\Documents\GitHub\GhostMan\UI\Views\CustomModes.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "943E68952661EABB2F1B6960852D5F635C810F9805D84BBF898B43E0B407D6C7"
=======
﻿#pragma checksum "C:\CositasEpicas\GitKraken\GhostMan\UI\Views\CustomModes.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A8C7B737F28946CA083A163D3CDB55D6FF71985CE305CB1540C576C3870514B2"
>>>>>>> Albert
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
    partial class CustomModes : 
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
            case 5: // Views\CustomModes.xaml line 100
                {
                    this.LstMapas = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 6: // Views\CustomModes.xaml line 157
                {
                    this.lsvLeaderboards = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 7: // Views\CustomModes.xaml line 183
                {
                    this.btnPlay = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnPlay).Click += this.btnPlay_Click;
                }
                break;
            case 12: // Views\CustomModes.xaml line 106
                {
                    global::Windows.UI.Xaml.Controls.Button element12 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element12).Click += this.btnBack_Click;
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

