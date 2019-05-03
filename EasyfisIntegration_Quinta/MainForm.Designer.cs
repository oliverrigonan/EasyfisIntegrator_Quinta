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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_openExplorer = new System.Windows.Forms.Button();
            this.txt_currentToken = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_APIURLHostEasyfis = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmb_defaultTerm = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_defaultDiscount = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_defaultWTAX = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_defaultVATInput = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_defaultVATOuput = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_timeTrigger = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_returnPath = new System.Windows.Forms.TextBox();
            this.txt_hotelCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_APIURLSource = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
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
            this.tab_settings.Controls.Add(this.label3);
            this.tab_settings.Controls.Add(this.btn_openExplorer);
            this.tab_settings.Controls.Add(this.txt_currentToken);
            this.tab_settings.Controls.Add(this.label14);
            this.tab_settings.Controls.Add(this.label15);
            this.tab_settings.Controls.Add(this.groupBox1);
            this.tab_settings.Controls.Add(this.txt_timeTrigger);
            this.tab_settings.Controls.Add(this.btn_edit);
            this.tab_settings.Controls.Add(this.btn_save);
            this.tab_settings.Controls.Add(this.label7);
            this.tab_settings.Controls.Add(this.txt_returnPath);
            this.tab_settings.Controls.Add(this.txt_hotelCode);
            this.tab_settings.Controls.Add(this.label6);
            this.tab_settings.Controls.Add(this.txt_APIURLSource);
            this.tab_settings.Location = new System.Drawing.Point(4, 25);
            this.tab_settings.Name = "tab_settings";
            this.tab_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab_settings.Size = new System.Drawing.Size(725, 555);
            this.tab_settings.TabIndex = 1;
            this.tab_settings.Text = "Settings";
            this.tab_settings.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Current Token:";
            // 
            // btn_openExplorer
            // 
            this.btn_openExplorer.BackColor = System.Drawing.Color.LightGray;
            this.btn_openExplorer.FlatAppearance.BorderSize = 0;
            this.btn_openExplorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openExplorer.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openExplorer.ForeColor = System.Drawing.Color.Black;
            this.btn_openExplorer.Location = new System.Drawing.Point(633, 137);
            this.btn_openExplorer.Name = "btn_openExplorer";
            this.btn_openExplorer.Size = new System.Drawing.Size(84, 31);
            this.btn_openExplorer.TabIndex = 20;
            this.btn_openExplorer.Text = "Open";
            this.btn_openExplorer.UseVisualStyleBackColor = false;
            this.btn_openExplorer.Click += new System.EventHandler(this.btn_openExplorer_Click);
            // 
            // txt_currentToken
            // 
            this.txt_currentToken.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_currentToken.Location = new System.Drawing.Point(8, 85);
            this.txt_currentToken.Name = "txt_currentToken";
            this.txt_currentToken.Size = new System.Drawing.Size(474, 28);
            this.txt_currentToken.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(484, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 19);
            this.label14.TabIndex = 19;
            this.label14.Text = "Time Trigger:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(5, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 19);
            this.label15.TabIndex = 21;
            this.label15.Text = "Return Path";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_APIURLHostEasyfis);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmb_defaultTerm);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmb_defaultDiscount);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmb_defaultWTAX);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmb_defaultVATInput);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmb_defaultVATOuput);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(9, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 278);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Easyfis Settings";
            // 
            // txt_APIURLHostEasyfis
            // 
            this.txt_APIURLHostEasyfis.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_APIURLHostEasyfis.ForeColor = System.Drawing.Color.Black;
            this.txt_APIURLHostEasyfis.Location = new System.Drawing.Point(17, 54);
            this.txt_APIURLHostEasyfis.Name = "txt_APIURLHostEasyfis";
            this.txt_APIURLHostEasyfis.Size = new System.Drawing.Size(542, 28);
            this.txt_APIURLHostEasyfis.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(17, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 19);
            this.label13.TabIndex = 26;
            this.label13.Text = "API URL Host";
            // 
            // cmb_defaultTerm
            // 
            this.cmb_defaultTerm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_defaultTerm.ForeColor = System.Drawing.Color.Black;
            this.cmb_defaultTerm.FormattingEnabled = true;
            this.cmb_defaultTerm.Location = new System.Drawing.Point(307, 168);
            this.cmb_defaultTerm.Name = "cmb_defaultTerm";
            this.cmb_defaultTerm.Size = new System.Drawing.Size(252, 29);
            this.cmb_defaultTerm.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(307, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "Term";
            // 
            // cmb_defaultDiscount
            // 
            this.cmb_defaultDiscount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_defaultDiscount.ForeColor = System.Drawing.Color.Black;
            this.cmb_defaultDiscount.FormattingEnabled = true;
            this.cmb_defaultDiscount.Location = new System.Drawing.Point(307, 111);
            this.cmb_defaultDiscount.Name = "cmb_defaultDiscount";
            this.cmb_defaultDiscount.Size = new System.Drawing.Size(252, 29);
            this.cmb_defaultDiscount.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(307, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Discount";
            // 
            // cmb_defaultWTAX
            // 
            this.cmb_defaultWTAX.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_defaultWTAX.ForeColor = System.Drawing.Color.Black;
            this.cmb_defaultWTAX.FormattingEnabled = true;
            this.cmb_defaultWTAX.Location = new System.Drawing.Point(17, 226);
            this.cmb_defaultWTAX.Name = "cmb_defaultWTAX";
            this.cmb_defaultWTAX.Size = new System.Drawing.Size(252, 29);
            this.cmb_defaultWTAX.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(17, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "WTAX";
            // 
            // cmb_defaultVATInput
            // 
            this.cmb_defaultVATInput.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_defaultVATInput.ForeColor = System.Drawing.Color.Black;
            this.cmb_defaultVATInput.FormattingEnabled = true;
            this.cmb_defaultVATInput.Location = new System.Drawing.Point(17, 168);
            this.cmb_defaultVATInput.Name = "cmb_defaultVATInput";
            this.cmb_defaultVATInput.Size = new System.Drawing.Size(252, 29);
            this.cmb_defaultVATInput.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(17, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "VAT Input";
            // 
            // cmb_defaultVATOuput
            // 
            this.cmb_defaultVATOuput.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_defaultVATOuput.ForeColor = System.Drawing.Color.Black;
            this.cmb_defaultVATOuput.FormattingEnabled = true;
            this.cmb_defaultVATOuput.Location = new System.Drawing.Point(17, 111);
            this.cmb_defaultVATOuput.Name = "cmb_defaultVATOuput";
            this.cmb_defaultVATOuput.Size = new System.Drawing.Size(252, 29);
            this.cmb_defaultVATOuput.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(17, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "VAT Ouput";
            // 
            // txt_timeTrigger
            // 
            this.txt_timeTrigger.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timeTrigger.Location = new System.Drawing.Point(488, 85);
            this.txt_timeTrigger.Name = "txt_timeTrigger";
            this.txt_timeTrigger.Size = new System.Drawing.Size(229, 28);
            this.txt_timeTrigger.TabIndex = 18;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(484, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hotel Code:";
            // 
            // txt_returnPath
            // 
            this.txt_returnPath.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_returnPath.Location = new System.Drawing.Point(8, 138);
            this.txt_returnPath.Name = "txt_returnPath";
            this.txt_returnPath.Size = new System.Drawing.Size(619, 28);
            this.txt_returnPath.TabIndex = 20;
            // 
            // txt_hotelCode
            // 
            this.txt_hotelCode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hotelCode.Location = new System.Drawing.Point(488, 32);
            this.txt_hotelCode.Name = "txt_hotelCode";
            this.txt_hotelCode.Size = new System.Drawing.Size(229, 28);
            this.txt_hotelCode.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "API URL Source:";
            // 
            // txt_APIURLSource
            // 
            this.txt_APIURLSource.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_APIURLSource.Location = new System.Drawing.Point(8, 32);
            this.txt_APIURLSource.Name = "txt_APIURLSource";
            this.txt_APIURLSource.Size = new System.Drawing.Size(474, 28);
            this.txt_APIURLSource.TabIndex = 9;
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
            this.label4.Size = new System.Drawing.Size(298, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Easyfis Integrator V.1.20190425.2112.NOR";
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
            this.tab_settings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_defaultVATOuput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_defaultTerm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_defaultDiscount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_defaultWTAX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_defaultVATInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_APIURLHostEasyfis;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_timeTrigger;
        private System.Windows.Forms.Timer tmr_timeTrigger;
        private System.Windows.Forms.FolderBrowserDialog fbd_returnDataPath;
        private System.Windows.Forms.Button btn_openExplorer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_returnPath;
    }
}