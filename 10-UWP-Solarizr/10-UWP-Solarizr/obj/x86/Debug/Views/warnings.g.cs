﻿#pragma checksum "C:\Users\adeborja\Desktop\10-UWP-Solarizr\10-UWP-Solarizr\Views\warnings.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F7487C49C706BB2DC39E68C056006549"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _10_UWP_Solarizr.Views
{
    partial class warnings : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\warnings.xaml line 20
                {
                    global::Windows.UI.Xaml.Controls.Button element2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element2).Click += this.Button_Click;
                }
                break;
            case 3: // Views\warnings.xaml line 24
                {
                    this.menuSplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 4: // Views\warnings.xaml line 45
                {
                    this.btnHome = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnHome).Click += this.btnHome_Click;
                }
                break;
            case 5: // Views\warnings.xaml line 53
                {
                    this.btnMensajes = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnMensajes).Click += this.btnMensajes_Click;
                }
                break;
            case 6: // Views\warnings.xaml line 61
                {
                    this.btnAvisos = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAvisos).Click += this.btnAvisos_Click;
                }
                break;
            case 7: // Views\warnings.xaml line 69
                {
                    this.btnContactos = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnContactos).Click += this.btnContactos_Click;
                }
                break;
            case 8: // Views\warnings.xaml line 93
                {
                    this.msg1 = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 9: // Views\warnings.xaml line 105
                {
                    this.msg2 = (global::Windows.UI.Xaml.Controls.Border)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

