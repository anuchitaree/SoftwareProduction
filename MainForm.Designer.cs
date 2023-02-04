namespace SoftwareProduction
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TbProductKey = new System.Windows.Forms.TextBox();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbProductRegistration = new System.Windows.Forms.TextBox();
            this.TbActivationCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.TbMacAddress = new System.Windows.Forms.TextBox();
            this.BtnMac = new System.Windows.Forms.Button();
            this.TbMacEnc = new System.Windows.Forms.TextBox();
            this.BtnMac1 = new System.Windows.Forms.Button();
            this.Mac = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TbProductKey
            // 
            this.TbProductKey.Location = new System.Drawing.Point(143, 35);
            this.TbProductKey.Name = "TbProductKey";
            this.TbProductKey.Size = new System.Drawing.Size(259, 23);
            this.TbProductKey.TabIndex = 1;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(408, 35);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(75, 23);
            this.BtnGenerate.TabIndex = 2;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Production key (ขาย serial number)";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Working standard ",
            "Data management"});
            this.comboBox1.Location = new System.Drawing.Point(16, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Group of Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Production registration bring from your PC.";
            // 
            // TbProductRegistration
            // 
            this.TbProductRegistration.Location = new System.Drawing.Point(143, 101);
            this.TbProductRegistration.Name = "TbProductRegistration";
            this.TbProductRegistration.Size = new System.Drawing.Size(259, 23);
            this.TbProductRegistration.TabIndex = 7;
            // 
            // TbActivationCode
            // 
            this.TbActivationCode.Location = new System.Drawing.Point(12, 183);
            this.TbActivationCode.Name = "TbActivationCode";
            this.TbActivationCode.Size = new System.Drawing.Size(390, 23);
            this.TbActivationCode.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Activation code";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(415, 102);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 10;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // TbMacAddress
            // 
            this.TbMacAddress.Location = new System.Drawing.Point(146, 269);
            this.TbMacAddress.Name = "TbMacAddress";
            this.TbMacAddress.Size = new System.Drawing.Size(256, 23);
            this.TbMacAddress.TabIndex = 11;
            this.TbMacAddress.WordWrap = false;
            // 
            // BtnMac
            // 
            this.BtnMac.Location = new System.Drawing.Point(418, 230);
            this.BtnMac.Name = "BtnMac";
            this.BtnMac.Size = new System.Drawing.Size(75, 23);
            this.BtnMac.TabIndex = 12;
            this.BtnMac.Text = "get mac";
            this.BtnMac.UseVisualStyleBackColor = true;
            this.BtnMac.Click += new System.EventHandler(this.BtnMac_Click);
            // 
            // TbMacEnc
            // 
            this.TbMacEnc.Location = new System.Drawing.Point(143, 230);
            this.TbMacEnc.Name = "TbMacEnc";
            this.TbMacEnc.Size = new System.Drawing.Size(259, 23);
            this.TbMacEnc.TabIndex = 13;
            // 
            // BtnMac1
            // 
            this.BtnMac1.Location = new System.Drawing.Point(418, 269);
            this.BtnMac1.Name = "BtnMac1";
            this.BtnMac1.Size = new System.Drawing.Size(75, 23);
            this.BtnMac1.TabIndex = 14;
            this.BtnMac1.Text = "MAC";
            this.BtnMac1.UseVisualStyleBackColor = true;
            this.BtnMac1.Click += new System.EventHandler(this.BtnMac1_Click);
            // 
            // Mac
            // 
            this.Mac.AutoSize = true;
            this.Mac.Location = new System.Drawing.Point(143, 210);
            this.Mac.Name = "Mac";
            this.Mac.Size = new System.Drawing.Size(10, 15);
            this.Mac.TabIndex = 15;
            this.Mac.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mac address";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Encode machine code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Deode machine code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = ":";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 308);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Mac);
            this.Controls.Add(this.BtnMac1);
            this.Controls.Add(this.TbMacEnc);
            this.Controls.Add(this.BtnMac);
            this.Controls.Add(this.TbMacAddress);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbActivationCode);
            this.Controls.Add(this.TbProductRegistration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.TbProductKey);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Software Production Generate & Activate code";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox TbProductKey;
        private Button BtnGenerate;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private TextBox TbProductRegistration;
        private TextBox TbActivationCode;
        private Label label4;
        private Button BtnSubmit;
        private TextBox TbMacAddress;
        private Button BtnMac;
        private TextBox TbMacEnc;
        private Button BtnMac1;
        private Label Mac;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label label8;
    }
}