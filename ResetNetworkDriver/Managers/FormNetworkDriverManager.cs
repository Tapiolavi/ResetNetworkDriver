using ResetNetworkDriver.Interfaces;
using System;
using System.Windows.Forms;
using SimpleDeviceManager.Interfaces;

namespace ResetNetworkDriver.Managers
{
    public class FormNetworkDriverManager : IFormNetworkDriverManager
    {
        private IDeviceDriverManager deviceDriverManager;

        private string selectedDriver;
        public ComboBox netWorkAdapterCompobox;
        public ComboBox networkDriverSettingCombobox;

        /// <summary>
        /// Rapid implementation to manage any form activity for net 6.0 forms. TODO: depinc comboboxes etc selectors.
        ///
        /// </summary>
        /// <param name="_netWorkAdapterCompobox">The ComboBox control used to display and select network adapters.</param>
        /// <param name="_networkDriverSettingCombobox">The ComboBox control used to display and select network driver settings.</param>
        public FormNetworkDriverManager(ref IDeviceDriverManager _deviceDriverManager, ref ComboBox _netWorkAdapterCompobox, ref ComboBox _networkDriverSettingCombobox)
        {
            netWorkAdapterCompobox = _netWorkAdapterCompobox;
            networkDriverSettingCombobox = _networkDriverSettingCombobox;

            deviceDriverManager = _deviceDriverManager;
        }

        private void populateDriverSettingCompobox(ref ComboBox combobox)
        {
            combobox.Items.Clear();

            foreach (string adapterName in deviceDriverManager.GetServiceNames())
            {
                combobox.Items.Add(adapterName);
            }
        }

        public void updateNetworkDriverCompoboxItems(ref ComboBox combobox)
        {
            combobox.Items.Clear();

            foreach (string networkAdapterName in getNetworkDriverService().getDeviceList())
            {
                combobox.Items.Add(networkAdapterName);
            }

            var savedNetworkAdapterName = Properties.Settings.Default.SelectedDevice;

            if (!string.IsNullOrEmpty(savedNetworkAdapterName))
            {
                combobox.SelectedIndex = combobox.FindStringExact(savedNetworkAdapterName);
            }
        }

        public ComboBox initializeDriverSettingCompbox(ref ComboBox combobox)
        {
            populateDriverSettingCompobox(ref combobox);

            combobox.SelectedIndex = combobox.FindStringExact(selectedDriver);

            combobox.SelectedIndexChanged += new EventHandler(ComboBoxSelectedIndexChanged);

            return combobox;
        }

        public void ComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = ((ComboBox)sender).SelectedItem.ToString();

            if (string.IsNullOrEmpty(selectedItem))
            {
                return;
            }

            changeDriver(selectedItem);

            updateNetworkDriverCompoboxItems(ref netWorkAdapterCompobox);
        }

        public void changeDriver(string driverName)
        {
            selectedDriver = driverName;

            Properties.Settings.Default.SelectedDriver = driverName;
            Properties.Settings.Default.Save();
        }

        public IDeviceDriver getNetworkDriverService()
        {
            return deviceDriverManager.GetService(selectedDriver);
        }
    }
}
