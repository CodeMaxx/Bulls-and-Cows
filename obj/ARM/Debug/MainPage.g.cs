﻿#pragma checksum "F:\Windows apps dev\BullsAndCows\BullsAndCows\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "482309990E67F81D9E140B192D6E79F0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BullsAndCows
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.moveButtons = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 2:
                {
                    this.startGameButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.startGameButton).Click += this.startGameButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.instructionsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 34 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.instructionsButton).Click += this.instructionsButton_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.exitButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 39 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.exitButton).Click += this.exitButton_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.statsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 44 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.statsButton).Click += this.statsButton_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.GameName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

