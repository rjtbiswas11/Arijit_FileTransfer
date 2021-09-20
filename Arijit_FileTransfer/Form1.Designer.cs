
namespace Arijit_FileTransfer
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
            this.sourcePathTextBox = new System.Windows.Forms.TextBox();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.timerTextBox = new System.Windows.Forms.TextBox();
            this.timerLabel = new System.Windows.Forms.Label();
            this.openSourceDialogButton = new System.Windows.Forms.Button();
            this.openDestinationDialogButton = new System.Windows.Forms.Button();
            this.destinationPathTextBox = new System.Windows.Forms.TextBox();
            this.destinationPathLabel = new System.Windows.Forms.Label();
            this.sourcePathLabel = new System.Windows.Forms.Label();
            this.stopServiceButton = new System.Windows.Forms.Button();
            this.startServiceButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.controlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourcePathTextBox
            // 
            this.sourcePathTextBox.Location = new System.Drawing.Point(242, 98);
            this.sourcePathTextBox.Name = "sourcePathTextBox";
            this.sourcePathTextBox.Size = new System.Drawing.Size(210, 20);
            this.sourcePathTextBox.TabIndex = 0;
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.timerTextBox);
            this.controlsPanel.Controls.Add(this.timerLabel);
            this.controlsPanel.Controls.Add(this.openSourceDialogButton);
            this.controlsPanel.Controls.Add(this.openDestinationDialogButton);
            this.controlsPanel.Controls.Add(this.destinationPathTextBox);
            this.controlsPanel.Controls.Add(this.destinationPathLabel);
            this.controlsPanel.Controls.Add(this.sourcePathLabel);
            this.controlsPanel.Controls.Add(this.stopServiceButton);
            this.controlsPanel.Controls.Add(this.startServiceButton);
            this.controlsPanel.Controls.Add(this.sourcePathTextBox);
            this.controlsPanel.Location = new System.Drawing.Point(12, 12);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(636, 276);
            this.controlsPanel.TabIndex = 1;
            // 
            // timerTextBox
            // 
            this.timerTextBox.Location = new System.Drawing.Point(299, 199);
            this.timerTextBox.Name = "timerTextBox";
            this.timerTextBox.Size = new System.Drawing.Size(35, 20);
            this.timerTextBox.TabIndex = 8;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(114, 199);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(173, 13);
            this.timerLabel.TabIndex = 2;
            this.timerLabel.Text = "Polling Interval Time in Milliseconds";
            // 
            // openSourceDialogButton
            // 
            this.openSourceDialogButton.Location = new System.Drawing.Point(458, 98);
            this.openSourceDialogButton.Name = "openSourceDialogButton";
            this.openSourceDialogButton.Size = new System.Drawing.Size(43, 20);
            this.openSourceDialogButton.TabIndex = 7;
            this.openSourceDialogButton.Text = "openSourceDialogButton";
            this.openSourceDialogButton.UseVisualStyleBackColor = true;
            this.openSourceDialogButton.Click += new System.EventHandler(this.openSourceDialogButton_Click);
            // 
            // openDestinationDialogButton
            // 
            this.openDestinationDialogButton.Location = new System.Drawing.Point(458, 149);
            this.openDestinationDialogButton.Name = "openDestinationDialogButton";
            this.openDestinationDialogButton.Size = new System.Drawing.Size(43, 20);
            this.openDestinationDialogButton.TabIndex = 6;
            this.openDestinationDialogButton.Text = "openDestinationDialogButton";
            this.openDestinationDialogButton.UseVisualStyleBackColor = true;
            this.openDestinationDialogButton.Click += new System.EventHandler(this.openDestinationDialogButton_Click);
            // 
            // destinationPathTextBox
            // 
            this.destinationPathTextBox.Location = new System.Drawing.Point(242, 150);
            this.destinationPathTextBox.Name = "destinationPathTextBox";
            this.destinationPathTextBox.Size = new System.Drawing.Size(210, 20);
            this.destinationPathTextBox.TabIndex = 5;
            // 
            // destinationPathLabel
            // 
            this.destinationPathLabel.AutoSize = true;
            this.destinationPathLabel.Location = new System.Drawing.Point(108, 157);
            this.destinationPathLabel.Name = "destinationPathLabel";
            this.destinationPathLabel.Size = new System.Drawing.Size(60, 13);
            this.destinationPathLabel.TabIndex = 4;
            this.destinationPathLabel.Text = "Destination";
            // 
            // sourcePathLabel
            // 
            this.sourcePathLabel.AutoSize = true;
            this.sourcePathLabel.Location = new System.Drawing.Point(108, 98);
            this.sourcePathLabel.Name = "sourcePathLabel";
            this.sourcePathLabel.Size = new System.Drawing.Size(41, 13);
            this.sourcePathLabel.TabIndex = 3;
            this.sourcePathLabel.Text = "Source";
            // 
            // stopServiceButton
            // 
            this.stopServiceButton.Location = new System.Drawing.Point(455, 33);
            this.stopServiceButton.Name = "stopServiceButton";
            this.stopServiceButton.Size = new System.Drawing.Size(75, 23);
            this.stopServiceButton.TabIndex = 2;
            this.stopServiceButton.Text = "Stop Service";
            this.stopServiceButton.UseVisualStyleBackColor = true;
            this.stopServiceButton.Click += new System.EventHandler(this.stopServiceButton_Click);
            // 
            // startServiceButton
            // 
            this.startServiceButton.Location = new System.Drawing.Point(68, 33);
            this.startServiceButton.Name = "startServiceButton";
            this.startServiceButton.Size = new System.Drawing.Size(75, 23);
            this.startServiceButton.TabIndex = 1;
            this.startServiceButton.Text = "Start Service";
            this.startServiceButton.UseVisualStyleBackColor = true;
            this.startServiceButton.Click += new System.EventHandler(this.startServiceButton_Click);
            this.startServiceButton.MouseEnter += new System.EventHandler(this.startServiceButton_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 335);
            this.Controls.Add(this.controlsPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox sourcePathTextBox;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Label destinationPathLabel;
        private System.Windows.Forms.Label sourcePathLabel;
        private System.Windows.Forms.Button stopServiceButton;
        private System.Windows.Forms.Button startServiceButton;
        private System.Windows.Forms.Button openSourceDialogButton;
        private System.Windows.Forms.Button openDestinationDialogButton;
        private System.Windows.Forms.TextBox destinationPathTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.TextBox timerTextBox;
    }
}

