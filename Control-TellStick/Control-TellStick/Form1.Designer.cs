using System;

namespace Control_TellStick
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDevices = new System.Windows.Forms.TabPage();
            this.tbDeviceMoreInfo = new System.Windows.Forms.TextBox();
            this.btnDeviceMoreInfo = new System.Windows.Forms.Button();
            this.btnGetDevices = new System.Windows.Forms.Button();
            this.tbDeviceState = new System.Windows.Forms.TextBox();
            this.tbDeviceID = new System.Windows.Forms.TextBox();
            this.btnDeviceOn = new System.Windows.Forms.Button();
            this.btnDeviceOff = new System.Windows.Forms.Button();
            this.labelDeviceState = new System.Windows.Forms.Label();
            this.labelDeviceID = new System.Windows.Forms.Label();
            this.labelDeviceName = new System.Windows.Forms.Label();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.tabSensors = new System.Windows.Forms.TabPage();
            this.tbSensorHumidity = new System.Windows.Forms.TextBox();
            this.labelSensorHumidity = new System.Windows.Forms.Label();
            this.tbSensorMoreInfo = new System.Windows.Forms.TextBox();
            this.btnSensorMoreInfo = new System.Windows.Forms.Button();
            this.btnGetSensors = new System.Windows.Forms.Button();
            this.tbSensorTemp = new System.Windows.Forms.TextBox();
            this.tbSensorID = new System.Windows.Forms.TextBox();
            this.labelSensorTemp = new System.Windows.Forms.Label();
            this.labelSensorID = new System.Windows.Forms.Label();
            this.labelSensorName = new System.Windows.Forms.Label();
            this.comboBoxSensors = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbSensorData = new System.Windows.Forms.TextBox();
            this.labelSensorData = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabDevices.SuspendLayout();
            this.tabSensors.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDevices);
            this.tabControl1.Controls.Add(this.tabSensors);
            this.tabControl1.Location = new System.Drawing.Point(13, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 298);
            this.tabControl1.TabIndex = 3;
            // 
            // tabDevices
            // 
            this.tabDevices.BackColor = System.Drawing.Color.Transparent;
            this.tabDevices.Controls.Add(this.tbDeviceMoreInfo);
            this.tabDevices.Controls.Add(this.btnDeviceMoreInfo);
            this.tabDevices.Controls.Add(this.btnGetDevices);
            this.tabDevices.Controls.Add(this.tbDeviceState);
            this.tabDevices.Controls.Add(this.tbDeviceID);
            this.tabDevices.Controls.Add(this.btnDeviceOn);
            this.tabDevices.Controls.Add(this.btnDeviceOff);
            this.tabDevices.Controls.Add(this.labelDeviceState);
            this.tabDevices.Controls.Add(this.labelDeviceID);
            this.tabDevices.Controls.Add(this.labelDeviceName);
            this.tabDevices.Controls.Add(this.comboBoxDevices);
            this.tabDevices.Location = new System.Drawing.Point(4, 22);
            this.tabDevices.Name = "tabDevices";
            this.tabDevices.Padding = new System.Windows.Forms.Padding(3);
            this.tabDevices.Size = new System.Drawing.Size(633, 272);
            this.tabDevices.TabIndex = 0;
            this.tabDevices.Text = "Devices";
            // 
            // tbDeviceMoreInfo
            // 
            this.tbDeviceMoreInfo.Location = new System.Drawing.Point(10, 113);
            this.tbDeviceMoreInfo.Name = "tbDeviceMoreInfo";
            this.tbDeviceMoreInfo.Size = new System.Drawing.Size(614, 20);
            this.tbDeviceMoreInfo.TabIndex = 10;
            // 
            // btnDeviceMoreInfo
            // 
            this.btnDeviceMoreInfo.Enabled = false;
            this.btnDeviceMoreInfo.Location = new System.Drawing.Point(10, 84);
            this.btnDeviceMoreInfo.Name = "btnDeviceMoreInfo";
            this.btnDeviceMoreInfo.Size = new System.Drawing.Size(75, 23);
            this.btnDeviceMoreInfo.TabIndex = 9;
            this.btnDeviceMoreInfo.Text = "More Info";
            this.btnDeviceMoreInfo.UseVisualStyleBackColor = true;
            this.btnDeviceMoreInfo.Click += new System.EventHandler(this.btnDeviceMoreInfo_Click);
            // 
            // btnGetDevices
            // 
            this.btnGetDevices.Location = new System.Drawing.Point(10, 10);
            this.btnGetDevices.Name = "btnGetDevices";
            this.btnGetDevices.Size = new System.Drawing.Size(75, 23);
            this.btnGetDevices.TabIndex = 8;
            this.btnGetDevices.Text = "Get Devices";
            this.btnGetDevices.UseVisualStyleBackColor = true;
            this.btnGetDevices.Click += new System.EventHandler(this.btnGetDevices_Click);
            // 
            // tbDeviceState
            // 
            this.tbDeviceState.Location = new System.Drawing.Point(232, 58);
            this.tbDeviceState.Name = "tbDeviceState";
            this.tbDeviceState.ReadOnly = true;
            this.tbDeviceState.Size = new System.Drawing.Size(50, 20);
            this.tbDeviceState.TabIndex = 7;
            // 
            // tbDeviceID
            // 
            this.tbDeviceID.Location = new System.Drawing.Point(185, 58);
            this.tbDeviceID.Name = "tbDeviceID";
            this.tbDeviceID.ReadOnly = true;
            this.tbDeviceID.Size = new System.Drawing.Size(40, 20);
            this.tbDeviceID.TabIndex = 6;
            // 
            // btnDeviceOn
            // 
            this.btnDeviceOn.Location = new System.Drawing.Point(345, 57);
            this.btnDeviceOn.Name = "btnDeviceOn";
            this.btnDeviceOn.Size = new System.Drawing.Size(46, 23);
            this.btnDeviceOn.TabIndex = 5;
            this.btnDeviceOn.Text = "On";
            this.btnDeviceOn.UseVisualStyleBackColor = true;
            this.btnDeviceOn.Click += new System.EventHandler(this.btnDeviceOn_Click);
            // 
            // btnDeviceOff
            // 
            this.btnDeviceOff.Location = new System.Drawing.Point(288, 57);
            this.btnDeviceOff.Name = "btnDeviceOff";
            this.btnDeviceOff.Size = new System.Drawing.Size(51, 23);
            this.btnDeviceOff.TabIndex = 4;
            this.btnDeviceOff.Text = "Off";
            this.btnDeviceOff.UseVisualStyleBackColor = true;
            this.btnDeviceOff.Click += new System.EventHandler(this.btnDeviceOff_Click);
            // 
            // labelDeviceState
            // 
            this.labelDeviceState.AutoSize = true;
            this.labelDeviceState.Location = new System.Drawing.Point(228, 43);
            this.labelDeviceState.Name = "labelDeviceState";
            this.labelDeviceState.Size = new System.Drawing.Size(32, 13);
            this.labelDeviceState.TabIndex = 3;
            this.labelDeviceState.Text = "State";
            // 
            // labelDeviceID
            // 
            this.labelDeviceID.AutoSize = true;
            this.labelDeviceID.Location = new System.Drawing.Point(182, 42);
            this.labelDeviceID.Name = "labelDeviceID";
            this.labelDeviceID.Size = new System.Drawing.Size(18, 13);
            this.labelDeviceID.TabIndex = 2;
            this.labelDeviceID.Text = "ID";
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.AutoSize = true;
            this.labelDeviceName.Location = new System.Drawing.Point(7, 41);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(35, 13);
            this.labelDeviceName.TabIndex = 1;
            this.labelDeviceName.Text = "Name";
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(10, 57);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(169, 21);
            this.comboBoxDevices.TabIndex = 0;
            this.comboBoxDevices.SelectedIndexChanged += new System.EventHandler(this.comboBoxDevices_SelectedIndexChanged);
            // 
            // tabSensors
            // 
            this.tabSensors.BackColor = System.Drawing.Color.Transparent;
            this.tabSensors.Controls.Add(this.tbSensorData);
            this.tabSensors.Controls.Add(this.labelSensorData);
            this.tabSensors.Controls.Add(this.tbSensorHumidity);
            this.tabSensors.Controls.Add(this.labelSensorHumidity);
            this.tabSensors.Controls.Add(this.tbSensorMoreInfo);
            this.tabSensors.Controls.Add(this.btnSensorMoreInfo);
            this.tabSensors.Controls.Add(this.btnGetSensors);
            this.tabSensors.Controls.Add(this.tbSensorTemp);
            this.tabSensors.Controls.Add(this.tbSensorID);
            this.tabSensors.Controls.Add(this.labelSensorTemp);
            this.tabSensors.Controls.Add(this.labelSensorID);
            this.tabSensors.Controls.Add(this.labelSensorName);
            this.tabSensors.Controls.Add(this.comboBoxSensors);
            this.tabSensors.Location = new System.Drawing.Point(4, 22);
            this.tabSensors.Name = "tabSensors";
            this.tabSensors.Padding = new System.Windows.Forms.Padding(3);
            this.tabSensors.Size = new System.Drawing.Size(633, 272);
            this.tabSensors.TabIndex = 1;
            this.tabSensors.Text = "Sensors";
            // 
            // tbSensorHumidity
            // 
            this.tbSensorHumidity.Location = new System.Drawing.Point(288, 58);
            this.tbSensorHumidity.Name = "tbSensorHumidity";
            this.tbSensorHumidity.ReadOnly = true;
            this.tbSensorHumidity.Size = new System.Drawing.Size(50, 20);
            this.tbSensorHumidity.TabIndex = 23;
            // 
            // labelSensorHumidity
            // 
            this.labelSensorHumidity.AutoSize = true;
            this.labelSensorHumidity.Location = new System.Drawing.Point(284, 43);
            this.labelSensorHumidity.Name = "labelSensorHumidity";
            this.labelSensorHumidity.Size = new System.Drawing.Size(47, 13);
            this.labelSensorHumidity.TabIndex = 22;
            this.labelSensorHumidity.Text = "Humidity";
            // 
            // tbSensorMoreInfo
            // 
            this.tbSensorMoreInfo.Location = new System.Drawing.Point(10, 113);
            this.tbSensorMoreInfo.Name = "tbSensorMoreInfo";
            this.tbSensorMoreInfo.Size = new System.Drawing.Size(614, 20);
            this.tbSensorMoreInfo.TabIndex = 21;
            // 
            // btnSensorMoreInfo
            // 
            this.btnSensorMoreInfo.Enabled = false;
            this.btnSensorMoreInfo.Location = new System.Drawing.Point(10, 84);
            this.btnSensorMoreInfo.Name = "btnSensorMoreInfo";
            this.btnSensorMoreInfo.Size = new System.Drawing.Size(75, 23);
            this.btnSensorMoreInfo.TabIndex = 20;
            this.btnSensorMoreInfo.Text = "More Info";
            this.btnSensorMoreInfo.UseVisualStyleBackColor = true;
            this.btnSensorMoreInfo.Click += new System.EventHandler(this.btnSensorMoreInfo_Click);
            // 
            // btnGetSensors
            // 
            this.btnGetSensors.Location = new System.Drawing.Point(10, 10);
            this.btnGetSensors.Name = "btnGetSensors";
            this.btnGetSensors.Size = new System.Drawing.Size(75, 23);
            this.btnGetSensors.TabIndex = 19;
            this.btnGetSensors.Text = "Get Sensors";
            this.btnGetSensors.UseVisualStyleBackColor = true;
            this.btnGetSensors.Click += new System.EventHandler(this.btnGetSensors_Click);
            // 
            // tbSensorTemp
            // 
            this.tbSensorTemp.Location = new System.Drawing.Point(232, 58);
            this.tbSensorTemp.Name = "tbSensorTemp";
            this.tbSensorTemp.ReadOnly = true;
            this.tbSensorTemp.Size = new System.Drawing.Size(50, 20);
            this.tbSensorTemp.TabIndex = 18;
            // 
            // tbSensorID
            // 
            this.tbSensorID.Location = new System.Drawing.Point(185, 58);
            this.tbSensorID.Name = "tbSensorID";
            this.tbSensorID.ReadOnly = true;
            this.tbSensorID.Size = new System.Drawing.Size(40, 20);
            this.tbSensorID.TabIndex = 17;
            // 
            // labelSensorTemp
            // 
            this.labelSensorTemp.AutoSize = true;
            this.labelSensorTemp.Location = new System.Drawing.Point(228, 43);
            this.labelSensorTemp.Name = "labelSensorTemp";
            this.labelSensorTemp.Size = new System.Drawing.Size(34, 13);
            this.labelSensorTemp.TabIndex = 14;
            this.labelSensorTemp.Text = "Temp";
            // 
            // labelSensorID
            // 
            this.labelSensorID.AutoSize = true;
            this.labelSensorID.Location = new System.Drawing.Point(182, 42);
            this.labelSensorID.Name = "labelSensorID";
            this.labelSensorID.Size = new System.Drawing.Size(18, 13);
            this.labelSensorID.TabIndex = 13;
            this.labelSensorID.Text = "ID";
            // 
            // labelSensorName
            // 
            this.labelSensorName.AutoSize = true;
            this.labelSensorName.Location = new System.Drawing.Point(7, 41);
            this.labelSensorName.Name = "labelSensorName";
            this.labelSensorName.Size = new System.Drawing.Size(35, 13);
            this.labelSensorName.TabIndex = 12;
            this.labelSensorName.Text = "Name";
            // 
            // comboBoxSensors
            // 
            this.comboBoxSensors.FormattingEnabled = true;
            this.comboBoxSensors.Location = new System.Drawing.Point(10, 57);
            this.comboBoxSensors.Name = "comboBoxSensors";
            this.comboBoxSensors.Size = new System.Drawing.Size(169, 21);
            this.comboBoxSensors.TabIndex = 11;
            this.comboBoxSensors.SelectedIndexChanged += new System.EventHandler(this.comboBoxSensors_SelectedIndexChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgress,
            this.tsStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 306);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(668, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // tsProgress
            // 
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(29, 17);
            this.tsStatus.Text = "Idle.";
            // 
            // tbSensorData
            // 
            this.tbSensorData.Location = new System.Drawing.Point(344, 58);
            this.tbSensorData.Name = "tbSensorData";
            this.tbSensorData.ReadOnly = true;
            this.tbSensorData.Size = new System.Drawing.Size(200, 20);
            this.tbSensorData.TabIndex = 25;
            // 
            // labelSensorData
            // 
            this.labelSensorData.AutoSize = true;
            this.labelSensorData.Location = new System.Drawing.Point(340, 43);
            this.labelSensorData.Name = "labelSensorData";
            this.labelSensorData.Size = new System.Drawing.Size(30, 13);
            this.labelSensorData.TabIndex = 24;
            this.labelSensorData.Text = "Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 328);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Control-TellStick";
            this.tabControl1.ResumeLayout(false);
            this.tabDevices.ResumeLayout(false);
            this.tabDevices.PerformLayout();
            this.tabSensors.ResumeLayout(false);
            this.tabSensors.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDevices;
        private System.Windows.Forms.TextBox tbDeviceMoreInfo;
        private System.Windows.Forms.Button btnDeviceMoreInfo;
        private System.Windows.Forms.Button btnGetDevices;
        private System.Windows.Forms.TextBox tbDeviceState;
        private System.Windows.Forms.TextBox tbDeviceID;
        private System.Windows.Forms.Button btnDeviceOn;
        private System.Windows.Forms.Button btnDeviceOff;
        private System.Windows.Forms.Label labelDeviceState;
        private System.Windows.Forms.Label labelDeviceID;
        private System.Windows.Forms.Label labelDeviceName;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.TabPage tabSensors;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.TextBox tbSensorMoreInfo;
        private System.Windows.Forms.Button btnSensorMoreInfo;
        private System.Windows.Forms.Button btnGetSensors;
        private System.Windows.Forms.TextBox tbSensorTemp;
        private System.Windows.Forms.TextBox tbSensorID;
        private System.Windows.Forms.Label labelSensorTemp;
        private System.Windows.Forms.Label labelSensorID;
        private System.Windows.Forms.Label labelSensorName;
        private System.Windows.Forms.ComboBox comboBoxSensors;
        private System.Windows.Forms.TextBox tbSensorHumidity;
        private System.Windows.Forms.Label labelSensorHumidity;
        private System.Windows.Forms.TextBox tbSensorData;
        private System.Windows.Forms.Label labelSensorData;
    }
}

