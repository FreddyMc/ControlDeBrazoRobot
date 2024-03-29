﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Module.AForge;
using System.Windows.Forms;

namespace ControlDeBrazo
{
    public partial class FrmSelectorDeCamara : Form
    {
        private readonly CaptureDeviceManager _captureDeviceManager;
        public FrmSelectorDeCamara()
        {
            InitializeComponent();
            _captureDeviceManager = new CaptureDeviceManager();
            CargarDispositivos();
        }


        private void btnApplySettings_Click(object sender, EventArgs e)
        {
            var mainForm = (FrmPrincipal)Application.OpenForms["FrmPrincipal"];
            if (mainForm == null)
            {
                MessageBox.Show(@"Can not reached Main Form.", @"Warning");
                return;
            }

            var deviceSignature = cbCaptureDevices.SelectedValue;
            var deviceResolution = cbVideoResolutions.SelectedIndex;

            if (deviceSignature == null || deviceResolution == -1)
            {
                MessageBox.Show(@"Can not reached the device and/or device resolution properties.", @"Warning");
                return;
            }

            var currDevice = _captureDeviceManager.GetCaptureDevices().FirstOrDefault(i => i.DeviceSignature.Equals(deviceSignature));
            if (currDevice == null)
            {
                MessageBox.Show(@"Can not reached the device.", @"Warning");
                return;
            }

            currDevice.Resolution = deviceResolution;
            mainForm.Camara = currDevice;

            DialogResult = DialogResult.OK;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSelectDevice_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedValue = cbCaptureDevices.SelectedValue;
                if (selectedValue == null) return;

                LoadDeviceResolutions(selectedValue.ToString());
            }
            catch
            {
                // ignored
            }
        }

        private void CargarDispositivos()
        {
            try
            {
                var captureDevices = _captureDeviceManager.GetCaptureDevices();
                if (captureDevices == null || !captureDevices.Any()) return;

                cbCaptureDevices.DisplayMember = "Name";
                cbCaptureDevices.ValueMember = "DeviceSignature";
                cbCaptureDevices.DataSource = captureDevices;

                if (cbCaptureDevices.Items.Count > 0)
                    cbCaptureDevices.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Can not load Capture Devices. Err : {ex.InnerException?.Message}");
            }
        }

        private void LoadDeviceResolutions(string deviceSignature)
        {
            try
            {
                cbVideoResolutions.Items.Clear();
                foreach (var reso in _captureDeviceManager.GetDeviceResolutions(deviceSignature))
                {
                    cbVideoResolutions.Items.Add(reso);
                }

                if (cbVideoResolutions.Items.Count > 0)
                    cbVideoResolutions.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Device Resolutions can not be loaded. Err : {ex.InnerException?.Message}");
            }
        }
    }
}
