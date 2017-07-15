
using System;
using Xamarin.Forms;

namespace MyDemoAzureOfflineSync
{
    public partial class MyDemoAzureOfflineSyncPage : ContentPage
    {
        public MyDemoAzureOfflineSyncPage()
        {
            InitializeComponent();
            BindingContext = new ContactsVM();
        }
    }
}
