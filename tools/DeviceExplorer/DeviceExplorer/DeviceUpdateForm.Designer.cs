namespace DeviceExplorer
{
    partial class DeviceUpdateForm
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
            this.deviceIDLabel = new System.Windows.Forms.Label();
            this.primaryLabel = new System.Windows.Forms.Label();
            this.secondaryLabel = new System.Windows.Forms.Label();
            this.primaryKeyTextBox = new System.Windows.Forms.TextBox();
            this.secondaryKeyTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deviceIDComboBox = new System.Windows.Forms.TextBox();
            this.restoreButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtConnectionStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastConnection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastActivity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deviceIDLabel
            // 
            this.deviceIDLabel.AutoSize = true;
            this.deviceIDLabel.Location = new System.Drawing.Point(9, 28);
            this.deviceIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deviceIDLabel.Name = "deviceIDLabel";
            this.deviceIDLabel.Size = new System.Drawing.Size(52, 13);
            this.deviceIDLabel.TabIndex = 0;
            this.deviceIDLabel.Text = "DeviceID";
            // 
            // primaryLabel
            // 
            this.primaryLabel.AutoSize = true;
            this.primaryLabel.Location = new System.Drawing.Point(9, 61);
            this.primaryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.primaryLabel.Name = "primaryLabel";
            this.primaryLabel.Size = new System.Drawing.Size(62, 13);
            this.primaryLabel.TabIndex = 2;
            this.primaryLabel.Text = "Primary Key";
            // 
            // secondaryLabel
            // 
            this.secondaryLabel.AutoSize = true;
            this.secondaryLabel.Location = new System.Drawing.Point(9, 84);
            this.secondaryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.secondaryLabel.Name = "secondaryLabel";
            this.secondaryLabel.Size = new System.Drawing.Size(79, 13);
            this.secondaryLabel.TabIndex = 3;
            this.secondaryLabel.Text = "Secondary Key";
            // 
            // primaryKeyTextBox
            // 
            this.primaryKeyTextBox.Location = new System.Drawing.Point(140, 57);
            this.primaryKeyTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.primaryKeyTextBox.Name = "primaryKeyTextBox";
            this.primaryKeyTextBox.Size = new System.Drawing.Size(304, 20);
            this.primaryKeyTextBox.TabIndex = 5;
            // 
            // secondaryKeyTextBox
            // 
            this.secondaryKeyTextBox.Location = new System.Drawing.Point(140, 82);
            this.secondaryKeyTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.secondaryKeyTextBox.Name = "secondaryKeyTextBox";
            this.secondaryKeyTextBox.Size = new System.Drawing.Size(304, 20);
            this.secondaryKeyTextBox.TabIndex = 6;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(64, 207);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(78, 26);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(308, 207);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(78, 26);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deviceIDComboBox
            // 
            this.deviceIDComboBox.Location = new System.Drawing.Point(142, 23);
            this.deviceIDComboBox.Name = "deviceIDComboBox";
            this.deviceIDComboBox.Size = new System.Drawing.Size(244, 20);
            this.deviceIDComboBox.TabIndex = 9;
            // 
            // restoreButton
            // 
            this.restoreButton.Location = new System.Drawing.Point(178, 206);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(87, 26);
            this.restoreButton.TabIndex = 10;
            this.restoreButton.Text = "Restore";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Refresh device";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConnectionStatus
            // 
            this.txtConnectionStatus.Location = new System.Drawing.Point(140, 109);
            this.txtConnectionStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtConnectionStatus.Name = "txtConnectionStatus";
            this.txtConnectionStatus.Size = new System.Drawing.Size(304, 20);
            this.txtConnectionStatus.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Connection Status";
            // 
            // txtLastConnection
            // 
            this.txtLastConnection.Location = new System.Drawing.Point(140, 133);
            this.txtLastConnection.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastConnection.Name = "txtLastConnection";
            this.txtLastConnection.Size = new System.Drawing.Size(304, 20);
            this.txtLastConnection.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "LastConnectionTime";
            // 
            // txtLastActivity
            // 
            this.txtLastActivity.Location = new System.Drawing.Point(140, 157);
            this.txtLastActivity.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastActivity.Name = "txtLastActivity";
            this.txtLastActivity.Size = new System.Drawing.Size(304, 20);
            this.txtLastActivity.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Last Activity Time";
            // 
            // DeviceUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 244);
            this.Controls.Add(this.txtLastActivity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastConnection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConnectionStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.deviceIDComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.secondaryKeyTextBox);
            this.Controls.Add(this.primaryKeyTextBox);
            this.Controls.Add(this.secondaryLabel);
            this.Controls.Add(this.primaryLabel);
            this.Controls.Add(this.deviceIDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DeviceUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DeviceUpdateForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeviceUpdateForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deviceIDLabel;
        private System.Windows.Forms.Label primaryLabel;
        private System.Windows.Forms.Label secondaryLabel;
        private System.Windows.Forms.TextBox primaryKeyTextBox;
        private System.Windows.Forms.TextBox secondaryKeyTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox deviceIDComboBox;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtConnectionStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastConnection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastActivity;
        private System.Windows.Forms.Label label3;
    }
}