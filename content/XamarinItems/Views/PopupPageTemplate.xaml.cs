using Rg.Plugins.Popup.Pages;

namespace MobileApp.Views
{
    public class ItemTemplate : PopupPage
    {
        public ItemTemplate()
        {
            InitializeComponent();
        }

        // Prevent hide popup
        protected override bool OnBackButtonPressed() => true;
    }
}