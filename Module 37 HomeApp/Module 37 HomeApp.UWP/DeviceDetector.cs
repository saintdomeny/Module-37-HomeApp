using System;
using System.Collections.Generic;
using System.Text;
using Windows.Security.ExchangeActiveSyncProvisioning;
using Xamarin.Forms;

[assembly: Dependency(typeof(Module_37_HomeApp.UWP.DeviceDetector))]
namespace Module_37_HomeApp.UWP
{
    public class DeviceDetector : IDeviceDetector
    {
        public string GetDevice()
        {
            // Создаем объект класса с информацией об устройстве
            var devInfo = new EasClientDeviceInformation();
            // Сообщаем строку с информацией о платформе
            return $"Запущено на устройстве {devInfo.SystemManufacturer},{Environment.NewLine} платформа {Device.RuntimePlatform}";
        }
    }
}
