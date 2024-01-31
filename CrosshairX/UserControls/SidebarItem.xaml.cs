using System;
using Fluent.Icons;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace CrosshairX.UserControls
{
    public sealed partial class SidebarItem : UserControl
    {
        public string Text
        {
            get => TextBlock.Text;
            set => TextBlock.Text = value;
        }

        public FluentSymbol Icon
        {
            get => IconBlock.Symbol;
            set => IconBlock.Symbol = value;
        }

        public ICommand? Command
        {
            get => ButtonBlock.Command;
            set => ButtonBlock.Command = value;
        }

        public Type? NavigateTo
        {
            get => ButtonBlock.CommandParameter as Type;
            set => ButtonBlock.CommandParameter = value;
        }

        public SidebarItem()
        {
            InitializeComponent();
        }
    }
}
