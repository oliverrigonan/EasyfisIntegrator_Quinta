namespace EasyfisIntegration_Quinta
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnl_title = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.tab_container = new System.Windows.Forms.TabControl();
            this.tab_activity = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_currentDate = new System.Windows.Forms.DateTimePicker();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.txt_activity = new System.Windows.Forms.TextBox();
            this.tab_settings = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_IsTimeTrigger = new System.Windows.Forms.CheckBox();
            this.txt_APIURLHostEasyfis = new System.Windows.Forms.TextBox();
            this.txt_timeTrigger = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_APIURLSource = new System.Windows.Forms.TextBox();
            this.txt_currentToken = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_hotelCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tmr_timeTrigger = new System.Windows.Forms.Timer(this.components);
            this.fbd_returnDataPath = new System.Windows.Forms.FolderBrowserDialog();
            this.pnl_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab_container.SuspendLayout();
            this.tab_activity.SuspendLayout();
            this.tab_settings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_title
            // 
            this.pnl_title.AllowDrop = true;
            this.pnl_title.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_title.Controls.Add(this.pictureBox1);
            this.pnl_title.Controls.Add(this.lbl_title);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(0, 0);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(733, 53);
            this.pnl_title.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EasyfisIntegration_Quinta.Properties.Resources.fab;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(54, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(242, 34);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Easyfis Integrator";
            // 
            // tab_container
            // 
            this.tab_container.Controls.Add(this.tab_activity);
            this.tab_container.Controls.Add(this.tab_settings);
            this.tab_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_container.Location = new System.Drawing.Point(0, 53);
            this.tab_container.Name = "tab_container";
            this.tab_container.SelectedIndex = 0;
            this.tab_container.Size = new System.Drawing.Size(733, 584);
            this.tab_container.TabIndex = 1;
            // 
            // tab_activity
            // 
            this.tab_activity.Controls.Add(this.label2);
            this.tab_activity.Controls.Add(this.txt_time);
            this.tab_activity.Controls.Add(this.label1);
            this.tab_activity.Controls.Add(this.dtp_currentDate);
            this.tab_activity.Controls.Add(this.btn_stop);
            this.tab_activity.Controls.Add(this.btn_start);
            this.tab_activity.Controls.Add(this.txt_activity);
            this.tab_activity.Location = new System.Drawing.Point(4, 25);
            this.tab_activity.Name = "tab_activity";
            this.tab_activity.Padding = new System.Windows.Forms.Padding(3);
            this.tab_activity.Size = new System.Drawing.Size(725, 555);
            this.tab_activity.TabIndex = 0;
            this.tab_activity.Text = "Activity";
            this.tab_activity.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time:";
            // 
            // txt_time
            // 
            this.txt_time.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_time.Location = new System.Drawing.Point(191, 32);
            this.txt_time.Name = "txt_time";
            this.txt_time.ReadOnly = true;
            this.txt_time.Size = new System.Drawing.Size(176, 28);
            this.txt_time.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date:";
            // 
            // dtp_currentDate
            // 
            this.dtp_currentDate.Checked = false;
            this.dtp_currentDate.CustomFormat = "";
            this.dtp_currentDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_currentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_currentDate.Location = new System.Drawing.Point(8, 32);
            this.dtp_currentDate.Name = "dtp_currentDate";
            this.dtp_currentDate.Size = new System.Drawing.Size(177, 28);
            this.dtp_currentDate.TabIndex = 3;
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.IndianRed;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.ForeColor = System.Drawing.Color.White;
            this.btn_stop.Location = new System.Drawing.Point(642, 458);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 36);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.Location = new System.Drawing.Point(561, 458);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 36);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txt_activity
            // 
            this.txt_activity.BackColor = System.Drawing.Color.Black;
            this.txt_activity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_activity.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_activity.ForeColor = System.Drawing.Color.White;
            this.txt_activity.Location = new System.Drawing.Point(8, 66);
            this.txt_activity.MaxLength = 1000000000;
            this.txt_activity.Multiline = true;
            this.txt_activity.Name = "txt_activity";
            this.txt_activity.ReadOnly = true;
            this.txt_activity.Size = new System.Drawing.Size(709, 386);
            this.txt_activity.TabIndex = 0;
            // 
            // tab_settings
            // 
            this.tab_settings.Controls.Add(this.panel1);
            this.tab_settings.Controls.Add(this.btn_edit);
            this.tab_settings.Controls.Add(this.btn_save);
            this.tab_settings.Location = new System.Drawing.Point(4, 25);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_settings.Size = new System.Drawing.Size(725, 555);
            this.tab_settings.TabIndex = 1;
            this.tab_settings.Text = "Settings";
            this.tab_settings.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cbx_IsTimeTrigger);
            this.panel1.Controls.Add(this.txt_APIURLHostEasyfis);
            this.panel1.Controls.Add(this.txt_timeTrigger);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_APIURLSource);
            this.panel1.Controls.Add(this.txt_currentToken);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_hotelCode);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 446);
            this.panel1.TabIndex = 28;
            // 
            // cbx_IsTimeTrigger
            // 
            this.cbx_IsTimeTrigger.AutoSize = true;
            this.cbx_IsTimeTrigger.Location = new System.Drawing.Point(262, 243);
            this.cbx_IsTimeTrigger.Name = "cbx_IsTimeTrigger";
            this.cbx_IsTimeTrigger.Size = new System.Drawing.Size(133, 21);
            this.cbx_IsTimeTrigger.TabIndex = 27;
            this.cbx_IsTimeTrigger.Text = "Is Time Trigger?";
            this.cbx_IsTimeTrigger.UseVisualStyleBackColor = true;
            // 
            // txt_APIURLHostEasyfis
            // 
            this.txt_APIURLHostEasyfis.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_APIURLHostEasyfis.ForeColor = System.Drawing.Color.Black;
            this.txt_APIURLHostEasyfis.Location = new System.Drawing.Point(13, 151);
            this.txt_APIURLHostEasyfis.Name = "txt_APIURLHostEasyfis";
            this.txt_APIURLHostEasyfis.Size = new System.Drawing.Size(682, 28);
            this.txt_APIURLHostEasyfis.TabIndex = 18;
            // 
            // txt_timeTrigger
            // 
            this.txt_timeTrigger.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timeTrigger.Location = new System.Drawing.Point(13, 237);
            this.txt_timeTrigger.Name = "txt_timeTrigger";
            this.txt_timeTrigger.Size = new System.Drawing.Size(229, 28);
            this.txt_timeTrigger.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(9, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 19);
            this.label13.TabIndex = 26;
            this.label13.Text = "API URL Host";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 19);
            this.label14.TabIndex = 19;
            this.label14.Text = "Time Trigger:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Current Token:";
            // 
            // txt_APIURLSource
            // 
            this.txt_APIURLSource.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_APIURLSource.Location = new System.Drawing.Point(13, 27);
            this.txt_APIURLSource.Name = "txt_APIURLSource";
            this.txt_APIURLSource.Size = new System.Drawing.Size(682, 28);
            this.txt_APIURLSource.TabIndex = 9;
            // 
            // txt_currentToken
            // 
            this.txt_currentToken.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currentToken.Location = new System.Drawing.Point(13, 88);
            this.txt_currentToken.Name = "txt_currentToken";
            this.txt_currentToken.Size = new System.Drawing.Size(474, 28);
            this.txt_currentToken.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "API URL Source:";
            // 
            // txt_hotelCode
            // 
            this.txt_hotelCode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hotelCode.Location = new System.Drawing.Point(497, 88);
            this.txt_hotelCode.Name = "txt_hotelCode";
            this.txt_hotelCode.Size = new System.Drawing.Size(198, 28);
            this.txt_hotelCode.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(493, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hotel Code:";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.LightGray;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(642, 458);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 36);
            this.btn_edit.TabIndex = 14;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LightGray;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(561, 458);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 36);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnl_footer.Controls.Add(this.label5);
            this.pnl_footer.Controls.Add(this.label4);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Location = new System.Drawing.Point(0, 578);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(733, 59);
            this.pnl_footer.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "© 2018 EASYFIS CORPORATION | www.easyfis.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Easyfis Integrator V.1.201909201642.NOR";
            // 
            // tmr_timeTrigger
            // 
            this.tmr_timeTrigger.Enabled = true;
            this.tmr_timeTrigger.Interval = 1000;
            this.tmr_timeTrigger.Tick += new System.EventHandler(this.tmr_timeTriggerTick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 637);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.tab_container);
            this.Controls.Add(this.pnl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyFIS Integrator - Quinta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab_container.ResumeLayout(false);
            this.tab_activity.ResumeLayout(false);
            this.tab_activity.PerformLayout();
            this.tab_settings.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_footer.ResumeLayout(false);
            this.pnl_footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TabControl tab_container;
        private System.Windows.Forms.TabPage tab_activity;
        private System.Windows.Forms.TabPage tab_settings;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.TextBox txt_activity;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.DateTimePicker dtp_currentDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_currentToken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_hotelCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_APIURLSource;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_APIURLHostEasyfis;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_timeTrigger;
        private System.Windows.Forms.Timer tmr_timeTrigger;
        private System.Windows.Forms.FolderBrowserDialog fbd_returnDataPath;
        private System.Windows.Forms.CheckBox cbx_IsTimeTrigger;
        private System.Windows.Forms.Panel panel1;
    }
}