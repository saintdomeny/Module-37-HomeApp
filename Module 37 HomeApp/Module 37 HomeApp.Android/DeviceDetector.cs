﻿using System;
using System.Collections.Generic;
using System.Text;
using Android.OS;
using Xamarin.Forms;

[assembly: Dependency(typeof(Module_37_HomeApp.Droid.DeviceDetector))]
namespace Module_37_HomeApp.Droid
{
    public class DeviceDetector : IDeviceDetector
    {
        public string GetDevice()
        {
            // Сообщаем строку с информацией о платформе
            return $"Запущено на устройстве {Build.Product},{System.Environment.NewLine} платформа {Device.RuntimePlatform}";
        }
    }
}
