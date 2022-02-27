namespace DiscordSRV___Kongolian
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.WindowBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.TBAppID = new System.Windows.Forms.TextBox();
            this.lblAppID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBuild = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TbsubText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TBDetails = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbBID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TbsID = new System.Windows.Forms.TextBox();
            this.CBTimeStamps = new System.Windows.Forms.CheckBox();
            this.LblError = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TBStxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TBBtxt = new System.Windows.Forms.TextBox();
            this.WindowBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowBar
            // 
            this.WindowBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.WindowBar.Controls.Add(this.label1);
            this.WindowBar.Controls.Add(this.btnExit);
            this.WindowBar.Location = new System.Drawing.Point(0, 0);
            this.WindowBar.Name = "WindowBar";
            this.WindowBar.Size = new System.Drawing.Size(750, 35);
            this.WindowBar.TabIndex = 0;
            this.WindowBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowBar_MouseDown);
            this.WindowBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.WindowBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowBar_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Discord Integration Interface";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowBar_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowBar_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnExit.InitialImage")));
            this.btnExit.Location = new System.Drawing.Point(715, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PBLogo
            // 
            this.PBLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PBLogo.BackgroundImage")));
            this.PBLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("PBLogo.InitialImage")));
            this.PBLogo.Location = new System.Drawing.Point(1, 36);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(100, 100);
            this.PBLogo.TabIndex = 1;
            this.PBLogo.TabStop = false;
            // 
            // TBAppID
            // 
            this.TBAppID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.TBAppID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBAppID.ForeColor = System.Drawing.SystemColors.Menu;
            this.TBAppID.Location = new System.Drawing.Point(285, 61);
            this.TBAppID.Name = "TBAppID";
            this.TBAppID.Size = new System.Drawing.Size(453, 29);
            this.TBAppID.TabIndex = 2;
            this.TBAppID.Text = "947177821787271210";
            this.TBAppID.TextChanged += new System.EventHandler(this.TBAppID_TextChanged);
            this.TBAppID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBAppID_KeyPress);
            // 
            // lblAppID
            // 
            this.lblAppID.AutoSize = true;
            this.lblAppID.Location = new System.Drawing.Point(110, 63);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(161, 21);
            this.lblAppID.TabIndex = 3;
            this.lblAppID.Text = "Application ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "The Application ID is usally 16 - 20 Characters long!";
            // 
            // BtnBuild
            // 
            this.BtnBuild.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnBuild.FlatAppearance.BorderSize = 2;
            this.BtnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuild.Location = new System.Drawing.Point(12, 411);
            this.BtnBuild.Name = "BtnBuild";
            this.BtnBuild.Size = new System.Drawing.Size(726, 51);
            this.BtnBuild.TabIndex = 5;
            this.BtnBuild.Text = "Build";
            this.BtnBuild.UseVisualStyleBackColor = true;
            this.BtnBuild.Click += new System.EventHandler(this.BtnBuild_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Customization";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sub-Text:";
            // 
            // TbsubText
            // 
            this.TbsubText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.TbsubText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbsubText.ForeColor = System.Drawing.SystemColors.Menu;
            this.TbsubText.Location = new System.Drawing.Point(188, 211);
            this.TbsubText.Name = "TbsubText";
            this.TbsubText.Size = new System.Drawing.Size(550, 29);
            this.TbsubText.TabIndex = 9;
            this.TbsubText.Text = "Testing An Amazing App";
            this.TbsubText.TextChanged += new System.EventHandler(this.TbsubText_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Details:";
            // 
            // TBDetails
            // 
            this.TBDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.TBDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBDetails.ForeColor = System.Drawing.SystemColors.Menu;
            this.TBDetails.Location = new System.Drawing.Point(188, 176);
            this.TBDetails.Name = "TBDetails";
            this.TBDetails.Size = new System.Drawing.Size(550, 29);
            this.TBDetails.TabIndex = 11;
            this.TBDetails.Text = "Cool discord integration app made by Drkongy";
            this.TBDetails.TextChanged += new System.EventHandler(this.TBDetails_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Big Image ID:";
            // 
            // TbBID
            // 
            this.TbBID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.TbBID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbBID.ForeColor = System.Drawing.SystemColors.Menu;
            this.TbBID.Location = new System.Drawing.Point(187, 246);
            this.TbBID.Name = "TbBID";
            this.TbBID.Size = new System.Drawing.Size(550, 29);
            this.TbBID.TabIndex = 13;
            this.TbBID.Text = "monkiclickercursordarkhd_1";
            this.TbBID.TextChanged += new System.EventHandler(this.TbBID_TextChanged);
            this.TbBID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbBID_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Small Image ID:";
            // 
            // TbsID
            // 
            this.TbsID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.TbsID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbsID.ForeColor = System.Drawing.SystemColors.Menu;
            this.TbsID.Location = new System.Drawing.Point(187, 281);
            this.TbsID.Name = "TbsID";
            this.TbsID.Size = new System.Drawing.Size(550, 29);
            this.TbsID.TabIndex = 15;
            this.TbsID.Text = "monkiclickercursordarkhd_1";
            this.TbsID.TextChanged += new System.EventHandler(this.TbsID_TextChanged);
            this.TbsID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbBID_KeyPress);
            // 
            // CBTimeStamps
            // 
            this.CBTimeStamps.AutoSize = true;
            this.CBTimeStamps.Checked = true;
            this.CBTimeStamps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBTimeStamps.Location = new System.Drawing.Point(519, 138);
            this.CBTimeStamps.Name = "CBTimeStamps";
            this.CBTimeStamps.Size = new System.Drawing.Size(219, 25);
            this.CBTimeStamps.TabIndex = 18;
            this.CBTimeStamps.Text = "TimeStamp Display";
            this.CBTimeStamps.UseVisualStyleBackColor = true;
            this.CBTimeStamps.CheckedChanged += new System.EventHandler(this.CBTimeStamps_CheckedChanged);
            // 
            // LblError
            // 
            this.LblError.AutoSize = true;
            this.LblError.ForeColor = System.Drawing.Color.IndianRed;
            this.LblError.Location = new System.Drawing.Point(190, 387);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(0, 21);
            this.LblError.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label9.Location = new System.Drawing.Point(12, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "Small Image Text:";
            // 
            // TBStxt
            // 
            this.TBStxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.TBStxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBStxt.ForeColor = System.Drawing.SystemColors.Menu;
            this.TBStxt.Location = new System.Drawing.Point(186, 351);
            this.TBStxt.Name = "TBStxt";
            this.TBStxt.Size = new System.Drawing.Size(550, 29);
            this.TBStxt.TabIndex = 22;
            this.TBStxt.Text = "Small Image Text";
            this.TBStxt.TextChanged += new System.EventHandler(this.TBStxt_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Big Image Text:";
            // 
            // TBBtxt
            // 
            this.TBBtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.TBBtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBBtxt.ForeColor = System.Drawing.SystemColors.Menu;
            this.TBBtxt.Location = new System.Drawing.Point(187, 316);
            this.TBBtxt.Name = "TBBtxt";
            this.TBBtxt.Size = new System.Drawing.Size(550, 29);
            this.TBBtxt.TabIndex = 20;
            this.TBBtxt.Text = "Big Image Text";
            this.TBBtxt.TextChanged += new System.EventHandler(this.TBBtxt_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(750, 475);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TBStxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TBBtxt);
            this.Controls.Add(this.LblError);
            this.Controls.Add(this.CBTimeStamps);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TbsID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbBID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBDetails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbsubText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnBuild);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAppID);
            this.Controls.Add(this.TBAppID);
            this.Controls.Add(this.PBLogo);
            this.Controls.Add(this.WindowBar);
            this.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Main";
            this.Text = "Discord";
            this.Load += new System.EventHandler(this.Main_Load);
            this.WindowBar.ResumeLayout(false);
            this.WindowBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel WindowBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.TextBox TBAppID;
        private System.Windows.Forms.Label lblAppID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBuild;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbsubText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbBID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbsID;
        private System.Windows.Forms.CheckBox CBTimeStamps;
        private System.Windows.Forms.Label LblError;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TBStxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TBBtxt;
    }
}

