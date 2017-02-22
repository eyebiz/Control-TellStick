using System;
using System.Threading;
using System.Windows.Forms;

namespace Control_TellStick
{
    public partial class Form1 : Form
    {
        TelldusFunctions tellFunc = null;
        static string TelldusIP = "http://11.0.0.2"; // Set to your IP-adress or name

        // Set the Bearer Token to your token
        static string TelldusToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCIsImF1ZCI6IlNob3dBbmRUZWxsZHVzIiwiZXhwIjoxNTE5MjM5MDUyfQ.eyJyZW5ldyI6dHJ1ZSwidHRsIjozMTUzNjAwMH0.lvqQ0tlCBlTdJK_GYqLmLHWWOzzcl_n83wbKt5QMI68";
        DeviceRootObject tellDevices;
        SensorRootObject tellSensors;
        Thread backgroundThread;

        public Form1()
        {
            InitializeComponent();
            try
            {
                tellFunc = new TelldusFunctions(TelldusIP, TelldusToken);
            }
            catch (Exception ex)
            {
                statusStrip.Text = (ex.Message);
            }
        }

        private void btnGetDevices_Click(object sender, EventArgs e)
        {
            try
            {
                tellDevices = tellFunc.GetListOfDevices();
                comboBoxDevices.Items.Clear();
                foreach (Device td in tellDevices.device)
                {
                    comboBoxDevices.Items.Add(td.name);
                }
                comboBoxDevices.SelectedIndex = 0;
                btnDeviceMoreInfo.Enabled = true;
            }
            catch (Exception ex)
            {
                statusStrip.Text = (ex.Message);
            }
        }

        private string stateToString(int state)
        {
            if (state == 2) return "Off";
            if (state == 1) return "On";
            else return "Other";
        }

        private string scaleToString(int scale)
        {
            if (scale == 0) return " °C";
            else return " °F";
        }

        private void comboBoxDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbDeviceID.Text = tellDevices.device[comboBoxDevices.SelectedIndex].id.ToString();
            tbDeviceState.Text = stateToString(tellDevices.device[comboBoxDevices.SelectedIndex].state);
        }

        private void btnDeviceOff_Click(object sender, EventArgs e)
        {
            tellFunc.TurnOff(Int32.Parse(tbDeviceID.Text));
            backgroundThread = new Thread(() => refreshDevice(Int32.Parse(tbDeviceID.Text)));
            backgroundThread.Start();
        }

        private void btnDeviceOn_Click(object sender, EventArgs e)
        {
            tellFunc.TurnOn(Int32.Parse(tbDeviceID.Text));
            backgroundThread = new Thread(() => refreshDevice(Int32.Parse(tbDeviceID.Text)));
            backgroundThread.Start();
        }

        private void btnDeviceMoreInfo_Click(object sender, EventArgs e)
        {
            DeviceData device = tellFunc.GetDeviceData(Int32.Parse(tbDeviceID.Text));
            tbDeviceMoreInfo.Text = device.id + " " + device.name + " " + device.protocol + " " + device.state;
        }

        private void refreshDeviceList()
        {
            string statusText = "Refreshing Devices.";
            tellDevices = tellFunc.GetListOfDevices();
            for (int i = 0; i < 10; i++)
            {
                Invoke(new UpdateUI(() => setStatus(statusText, true)));
                Thread.Sleep(500);
                statusText += ".";
            }
            tellDevices = tellFunc.GetListOfDevices();
            Invoke(new UpdateUI(() => { tbDeviceState.Text = stateToString(tellDevices.device[comboBoxDevices.SelectedIndex].state); setStatus("Idle.", false); }));
        }

        private void refreshDevice(int deviceID)
        {
            string statusText = "Sending command and refreshing device.";
            DeviceData device = tellFunc.GetDeviceData(deviceID);
            for (int i = 0; i < 3; i++)
            {
                Invoke(new UpdateUI(() => setStatus(statusText, true)));
                Thread.Sleep(500);
                statusText += ".";
            }
            device = tellFunc.GetDeviceData(deviceID);
            Invoke(new UpdateUI(() => { tbDeviceState.Text = stateToString(device.state); setStatus("Idle.", false); }));
        }

        public delegate void UpdateUI();

        public void setStatus(string status, bool disableUI)
        {
            tsStatus.Text = status;
            tsStatus.Invalidate();
            //this.ActiveControl = tbRelease;

            if (disableUI)
            {
                btnDeviceOff.Enabled = false;
                btnDeviceOn.Enabled = false;
                btnGetDevices.Enabled = false;
                comboBoxDevices.Enabled = false;
                tsProgress.Style = ProgressBarStyle.Marquee;
            }
            else
            {
                btnDeviceOff.Enabled = true;
                btnDeviceOn.Enabled = true;
                btnGetDevices.Enabled = true;
                comboBoxDevices.Enabled = true;
                tsProgress.Style = ProgressBarStyle.Blocks;
            }
            Application.DoEvents();
        }

        private void btnGetSensors_Click(object sender, EventArgs e)
        {
            try
            {
                tellSensors = tellFunc.GetListOfSensors();
                comboBoxSensors.Items.Clear();
                foreach (Sensor ts in tellSensors.sensor)
                {
                    comboBoxSensors.Items.Add(ts.name);
                }
                comboBoxSensors.SelectedIndex = 0;
                btnSensorMoreInfo.Enabled = true;
            }
            catch (Exception ex)
            {
                statusStrip.Text = (ex.Message);
            }
        }

        private void comboBoxSensors_SelectedIndexChanged(object sender, EventArgs e)
        {
            SensorData sd = tellFunc.GetSensorData(tellSensors.sensor[comboBoxSensors.SelectedIndex].id);
            tbSensorID.Text = sd.id.ToString();
            //tbSensorTemp.Text = sd.data[0].value.ToString() + " °C";
            //if (sd.data.Count > 1)
            //    tbSensorHumidity.Text = sd.data[1].value.ToString() + " %";
            //else tbSensorHumidity.Text = "";
            string sensorScale = "";
            tbSensorData.Text = "";
            foreach (Data d in sd.data)
            {
                if (d.name == "temp") sensorScale = " °C";
                if (d.name == "humidity") sensorScale = " %";
                tbSensorData.Text += Program.FirstLetterToUpper(d.name) + ": " + d.value + sensorScale + " | ";
            }
        }

        private void btnSensorMoreInfo_Click(object sender, EventArgs e)
        {
            SensorData sd = tellFunc.GetSensorData(tellSensors.sensor[comboBoxSensors.SelectedIndex].id);
            tbSensorMoreInfo.Text = sd.id + " " + sd.name + " " + sd.model + " " + sd.protocol + " " + sd.data[0].name;
        }
    }
}

