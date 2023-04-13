using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using System.Runtime.InteropServices;
using Windows.UI.Popups;

namespace NetCoreApp
{
    public partial class MainViewUserControl : UserControl
    {
        public MainViewModel ViewModel { get; set; }
        public MainViewUserControl()
        {
            this.InitializeComponent();
            ViewModel = new MainViewModel()
            {
                UserName = "UWP"
            };
            ViewModel.SayHello();

            this.btn2.Click += async (s, e) =>
            {
                StringBuilder builder = new();
                builder.AppendLine(RuntimeInformation.FrameworkDescription);
                builder.AppendLine(RuntimeInformation.OSDescription);
                builder.Append($"ProcessArchitecture: {RuntimeInformation.ProcessArchitecture.ToString()}");
                MessageDialog dialog = new(builder.ToString(), "About");
                await dialog.ShowAsync();
            };
        }
    }
}
