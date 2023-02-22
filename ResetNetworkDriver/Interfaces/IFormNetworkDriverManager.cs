using SimpleDeviceManager.Interfaces;
using System;
using System.Windows.Forms;

namespace ResetNetworkDriver.Interfaces
{
    public interface IFormNetworkDriverManager
    {
        ComboBox initializeDriverSettingCompbox(ref ComboBox combobox);
        IDeviceDriver getNetworkDriverService();
        void ComboBoxSelectedIndexChanged(object sender, EventArgs e);
        void changeDriver(string selectedItem);
    }
}
