using ResetNetworkDriver.Interfaces;
using ResetNetworkDriver.Managers;
using SimpleDeviceManager.Drivers;
using SimpleDeviceManager.Interfaces;
using SimpleDeviceManager;

namespace ResetNetworkDriver
{
    public partial class Form1 : Form
    {
        private IProgresBarManager progressService;
        private IFormNetworkDriverManager networkDriverManager;

        public Form1()
        {
            InitializeComponent();

            IDeviceDriverManager deviceDriverManager = new DeviceManager();

            deviceDriverManager.RegisterService("Network Wmi Driver", new DeviceDriverNetworkAdapters());
            deviceDriverManager.RegisterService("Network Nets Driver", new DeviceDriverNetsh());
            deviceDriverManager.RegisterService("System Device management Driver", new DeviceDriverSystemDeviceManager());

            string selectedDriver = "Network Wmi Driver";

            var selectedDriverSetting = Properties.Settings.Default.SelectedDriver;

            if (!string.IsNullOrEmpty(selectedDriverSetting))
            {
                selectedDriver = selectedDriverSetting;
            }

            string[] availableDriverNames = { "Network Wmi Driver", "Network Nets Driver", "System Device management Driver" };

            if (!availableDriverNames.Contains(selectedDriver))
            {
                selectedDriver = "Network Wmi Driver";
            }

            networkDriverManager = new FormNetworkDriverManager(ref deviceDriverManager, ref deviceCompoBox, ref driverCompoBox);

            networkDriverManager.changeDriver(selectedDriver);

            networkDriverManager.initializeDriverSettingCompbox(ref driverCompoBox);

            networkDriverManager.updateNetworkDriverCompoboxItems(ref deviceCompoBox);


            this.progressService = new ProgressBarManager(progressBar1, statusLabel);


            var selectedDeviceName = Properties.Settings.Default.SelectedDevice;

            if (!string.IsNullOrEmpty(selectedDeviceName))
            {
                deviceCompoBox.SelectedItem = selectedDeviceName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            int progresValue = 0;

            var selectedDeviceName = deviceCompoBox.SelectedItem as string;

            if (string.IsNullOrEmpty(selectedDeviceName))
            {
                MessageBox.Show("Please select a network device.");
                return;
            }

            progressService.Start();

            var isEnabled = networkDriverManager.getNetworkDriverService().IsDeviceEnabled(selectedDeviceName);

            if (isEnabled)
            {
                progresValue += 15;

                progressService.Update(progresValue, "Disabling network driver...");

                networkDriverManager.getNetworkDriverService().DisableDevice(selectedDeviceName);
            }
            progresValue += 17;

            progressService.Update(progresValue, "Disabled network driver...");


            // Wait for 5 seconds
            for (int i = 1; i <= 5; i++)
            {
                progresValue += 6;

                progressService.Update(progresValue, string.Format("Waiting {0} seconds...", 6 - i));

                Thread.Sleep(1000);
            }

            isEnabled = networkDriverManager.getNetworkDriverService().IsDeviceEnabled(selectedDeviceName);

            if (!isEnabled)
            {
                progresValue += 10;

                progressService.Update(progresValue, "Enabling network device...");

                networkDriverManager.getNetworkDriverService().EnableDevice(selectedDeviceName);

                progressService.Finish("Enabled network device...");
            }
            else
            {
                progressService.Finish("Network device was already enabled.");
            }

            Properties.Settings.Default.SelectedDevice = selectedDeviceName;
            Properties.Settings.Default.Save();

            button1.Enabled = true;
        }
    }
}