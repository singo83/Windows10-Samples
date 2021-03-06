﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Gpio;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ApiDetection
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            var ns = "Windows.Phone.UI.Input.HardwareButtons";
            if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent(ns))
            {
                Windows.Phone.UI.Input.HardwareButtons.CameraPressed += HardwareButtons_CameraPressed;
            }
        }

        private async void HardwareButtons_CameraPressed(object sender, CameraEventArgs e)
        {
            MessageDialog dialog = new MessageDialog("Hello from the camera button!");
            await dialog.ShowAsync();
        }
    }
}
