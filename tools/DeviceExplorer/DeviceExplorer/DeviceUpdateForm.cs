using Microsoft.Azure.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DeviceExplorer
{
    public partial class DeviceUpdateForm : Form
    {
        private RegistryManager registryManager;
        private string selectedDeviceID;
        private int devicesMaxCount;

        private string lastValidPrimaryKey;
        private string lastValidSecondaryKey;

        public DeviceUpdateForm(RegistryManager manager, int maxDevices, string deviceID)
        {
            InitializeComponent();
            this.registryManager = manager;
            this.devicesMaxCount = maxDevices;
            this.deviceIDComboBox.Text = deviceID;
            updateControls(deviceID);
        }

        private async void updateControls(string selectedDevice)
        {
            try
            {
                var _device = await registryManager.GetDeviceAsync(selectedDevice);

                if (_device != null)
                {
                    txtConnectionStatus.Text = _device.ConnectionState.ToString();
                    txtLastActivity.Text = _device.LastActivityTime.ToString();
                    txtLastConnection.Text = _device.ConnectionStateUpdatedTime.ToString();
                    if ((_device.Authentication.SymmetricKey != null) &&
                        !((_device.Authentication.SymmetricKey.PrimaryKey == null) ||
                           (_device.Authentication.SymmetricKey.SecondaryKey == null)))
                    {
                        primaryLabel.Text = "Primary Key:";
                        secondaryLabel.Text = "Secondary Key:";
                        primaryKeyTextBox.Text = _device.Authentication.SymmetricKey.PrimaryKey;
                        secondaryKeyTextBox.Text = _device.Authentication.SymmetricKey.SecondaryKey;
                    }
                    else if (_device.Authentication.X509Thumbprint != null)
                    {
                        primaryLabel.Text = "Primary Thumbprint:";
                        secondaryLabel.Text = "Secondary Thumbprint:";
                        primaryKeyTextBox.Text = _device.Authentication.X509Thumbprint.PrimaryThumbprint;
                        secondaryKeyTextBox.Text = _device.Authentication.X509Thumbprint.SecondaryThumbprint;
                    }

                    lastValidPrimaryKey = primaryKeyTextBox.Text;
                    lastValidSecondaryKey = secondaryKeyTextBox.Text;
                }      
            }
            catch (Exception ex)
            {
                using (new CenterDialog(this))
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
             
                var updatedDevice = await registryManager.GetDeviceAsync(this.deviceIDComboBox.Text);

                if (updatedDevice != null)
                {
                    if ((updatedDevice.Authentication.SymmetricKey != null) &&
                        !((updatedDevice.Authentication.SymmetricKey.PrimaryKey == null) ||
                          (updatedDevice.Authentication.SymmetricKey.SecondaryKey == null)))
                    {
                        updatedDevice.Authentication.SymmetricKey.PrimaryKey = primaryKeyTextBox.Text;
                        updatedDevice.Authentication.SymmetricKey.SecondaryKey = secondaryKeyTextBox.Text;
                    }
                    else if (updatedDevice.Authentication.X509Thumbprint != null)
                    {
                        updatedDevice.Authentication.X509Thumbprint.PrimaryThumbprint = primaryKeyTextBox.Text;
                        updatedDevice.Authentication.X509Thumbprint.SecondaryThumbprint = secondaryKeyTextBox.Text;
                    }

                    await registryManager.UpdateDeviceAsync(updatedDevice, true);

                    using (new CenterDialog(this))
                    {
                        MessageBox.Show("Device updated successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
                else
                {
                    using (new CenterDialog(this))
                    {
                        MessageBox.Show("Device not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                using (new CenterDialog(this))
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void restoreButton_Click(object sender, EventArgs e)
        {
            primaryKeyTextBox.Text = lastValidPrimaryKey;
            secondaryKeyTextBox.Text = lastValidSecondaryKey;
        }

        private async void DeviceUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            await registryManager.CloseAsync();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            updateControls(this.deviceIDComboBox.Text);
        }

    
    }
}
