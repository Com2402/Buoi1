namespace Buoi_1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_name = new System.Windows.Forms.ComboBox();
            this.pic_name = new System.Windows.Forms.PictureBox();
            this.timer_photo = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.serial_STM = new System.IO.Ports.SerialPort(this.components);
            this.lst_data = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_name)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ho & Ten";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkVisited = true;
            this.linkLabel1.Location = new System.Drawing.Point(52, 76);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 16);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "https://github.com/Com2402/Buoi1";
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(138, 36);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(228, 22);
            this.txt_name.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cbo_name);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 200);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbo_name
            // 
            this.cbo_name.FormattingEnabled = true;
            this.cbo_name.Items.AddRange(new object[] {
            "AC1",
            "AC2",
            "AC3",
            "AC4",
            "AC5"});
            this.cbo_name.Location = new System.Drawing.Point(136, 76);
            this.cbo_name.Name = "cbo_name";
            this.cbo_name.Size = new System.Drawing.Size(228, 24);
            this.cbo_name.TabIndex = 4;
            this.cbo_name.SelectedIndexChanged += new System.EventHandler(this.cbo_name_SelectedIndexChanged);
            // 
            // pic_name
            // 
            this.pic_name.Image = ((System.Drawing.Image)(resources.GetObject("pic_name.Image")));
            this.pic_name.Location = new System.Drawing.Point(455, 12);
            this.pic_name.Name = "pic_name";
            this.pic_name.Size = new System.Drawing.Size(333, 426);
            this.pic_name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_name.TabIndex = 5;
            this.pic_name.TabStop = false;
            // 
            // timer_photo
            // 
            this.timer_photo.Tick += new System.EventHandler(this.timer_photo_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // serial_STM
            // 
            this.serial_STM.PortName = "COM21";
            this.serial_STM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serial_STM_DataReceived);
            // 
            // lst_data
            // 
            this.lst_data.FormattingEnabled = true;
            this.lst_data.ItemHeight = 16;
            this.lst_data.Location = new System.Drawing.Point(12, 222);
            this.lst_data.Name = "lst_data";
            this.lst_data.Size = new System.Drawing.Size(378, 212);
            this.lst_data.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_data);
            this.Controls.Add(this.pic_name);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_name)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_name;
        private System.Windows.Forms.PictureBox pic_name;
        private System.Windows.Forms.Timer timer_photo;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort serial_STM;
        private System.Windows.Forms.ListBox lst_data;
    }
}

