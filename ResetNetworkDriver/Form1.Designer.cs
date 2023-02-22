namespace ResetNetworkDriver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            appTabs = new TabControl();
            resettingTab = new TabPage();
            deviceCompoBox = new ComboBox();
            statusLabel = new Label();
            progressBar1 = new ProgressBar();
            settingsTab = new TabPage();
            driverCompoBox = new ComboBox();
            appTabs.SuspendLayout();
            resettingTab.SuspendLayout();
            settingsTab.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(160, 157);
            button1.Name = "button1";
            button1.Size = new Size(113, 41);
            button1.TabIndex = 0;
            button1.Text = "Reset device";
            button1.UseVisualStyleBackColor = true;
            // 
            // appTabs
            // 
            appTabs.Controls.Add(resettingTab);
            appTabs.Controls.Add(settingsTab);
            appTabs.Location = new Point(10, 10);
            appTabs.Name = "appTabs";
            appTabs.SelectedIndex = 0;
            appTabs.Size = new Size(471, 254);
            appTabs.TabIndex = 1;
            // 
            // resettingTab
            // 
            resettingTab.Controls.Add(deviceCompoBox);
            resettingTab.Controls.Add(statusLabel);
            resettingTab.Controls.Add(progressBar1);
            resettingTab.Controls.Add(button1);
            resettingTab.Location = new Point(4, 24);
            resettingTab.Name = "resettingTab";
            resettingTab.Padding = new Padding(3);
            resettingTab.Size = new Size(463, 226);
            resettingTab.TabIndex = 0;
            resettingTab.Text = "Resettings controlls";
            resettingTab.UseVisualStyleBackColor = true;
            // 
            // deviceCompoBox
            // 
            deviceCompoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deviceCompoBox.FormattingEnabled = true;
            deviceCompoBox.Location = new Point(45, 28);
            deviceCompoBox.Name = "deviceCompoBox";
            deviceCompoBox.Size = new Size(352, 23);
            deviceCompoBox.TabIndex = 3;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(46, 70);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(39, 15);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "Status";
            statusLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(45, 104);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(352, 23);
            progressBar1.TabIndex = 1;
            // 
            // settingsTab
            // 
            settingsTab.Controls.Add(driverCompoBox);
            settingsTab.Location = new Point(4, 24);
            settingsTab.Name = "settingsTab";
            settingsTab.Padding = new Padding(3);
            settingsTab.Size = new Size(463, 226);
            settingsTab.TabIndex = 1;
            settingsTab.Text = "Settings";
            settingsTab.UseVisualStyleBackColor = true;
            // 
            // driverCompoBox
            // 
            driverCompoBox.DropDownStyle = ComboBoxStyle.DropDownList;
            driverCompoBox.FormattingEnabled = true;
            driverCompoBox.Location = new Point(30, 50);
            driverCompoBox.Name = "driverCompoBox";
            driverCompoBox.Size = new Size(401, 23);
            driverCompoBox.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 269);
            Controls.Add(appTabs);
            Name = "Form1";
            Text = "Device reset";
            appTabs.ResumeLayout(false);
            resettingTab.ResumeLayout(false);
            resettingTab.PerformLayout();
            settingsTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TabControl appTabs;
        private TabPage resettingTab;
        private TabPage settingsTab;
        private ComboBox deviceCompoBox;
        private Label statusLabel;
        private ProgressBar progressBar1;
        private ComboBox driverCompoBox;
    }
}