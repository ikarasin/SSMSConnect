using System.Data;

namespace SSMSConnect
{
    partial class SettingsDialog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewServers = new System.Windows.Forms.DataGridView();
            this.ServerPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserDomain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerIsEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkBoxConnectAtStartup = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewServers
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewServers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServerPath,
            this.ServerDescription,
            this.UserDomain,
            this.ServerIsEnabled});
            this.dataGridViewServers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewServers.Name = "dataGridViewServers";
            this.dataGridViewServers.RowHeadersWidth = 62;
            this.dataGridViewServers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewServers.Size = new System.Drawing.Size(1061, 355);
            this.dataGridViewServers.TabIndex = 0;
            // 
            // ServerPath
            // 
            this.ServerPath.HeaderText = "Server Path";
            this.ServerPath.Name = "ServerPath";
            this.ServerPath.Width = 500;
            // 
            // ServerDescription
            // 
            this.ServerDescription.HeaderText = "Server Description";
            this.ServerDescription.Name = "ServerDescription";
            this.ServerDescription.Width = 200;
            // 
            // UserDomain
            // 
            this.UserDomain.HeaderText = "User Domain (leave blank for all)";
            this.UserDomain.Name = "UserDomain";
            this.UserDomain.Width = 200;
            // 
            // ServerIsEnabled
            // 
            this.ServerIsEnabled.HeaderText = "Enabled";
            this.ServerIsEnabled.Name = "ServerIsEnabled";
            // 
            // checkBoxConnectAtStartup
            // 
            this.checkBoxConnectAtStartup.AutoSize = true;
            this.checkBoxConnectAtStartup.Location = new System.Drawing.Point(13, 388);
            this.checkBoxConnectAtStartup.Name = "checkBoxConnectAtStartup";
            this.checkBoxConnectAtStartup.Size = new System.Drawing.Size(164, 17);
            this.checkBoxConnectAtStartup.TabIndex = 3;
            this.checkBoxConnectAtStartup.Text = "Connect at startup is enabled";
            this.checkBoxConnectAtStartup.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnSave.Location = new System.Drawing.Point(395, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 41);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCancel.Location = new System.Drawing.Point(594, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 41);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SettingsDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1085, 477);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.checkBoxConnectAtStartup);
            this.Controls.Add(this.dataGridViewServers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SSMSConnect Options";
            this.Shown += new System.EventHandler(this.SettingsDialog_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewServers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserDomain;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ServerIsEnabled;
        private System.Windows.Forms.CheckBox checkBoxConnectAtStartup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}