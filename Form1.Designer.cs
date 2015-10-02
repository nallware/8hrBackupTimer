namespace _8HrBackupTimer
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
            this.btnStart = new System.Windows.Forms.Button();
            this.pbarShiftCountdown = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pbarWeek = new System.Windows.Forms.ProgressBar();
            this.btnEnd = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMinsMinus = new System.Windows.Forms.Button();
            this.btnMinsAdd = new System.Windows.Forms.Button();
            this.tbAdjMins = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblMakeupMins = new System.Windows.Forms.Label();
            this.gbMakeup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbMakeup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(11, 168);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 22);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Shift";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbarShiftCountdown
            // 
            this.pbarShiftCountdown.Location = new System.Drawing.Point(12, 39);
            this.pbarShiftCountdown.Maximum = 481;
            this.pbarShiftCountdown.Name = "pbarShiftCountdown";
            this.pbarShiftCountdown.Size = new System.Drawing.Size(308, 23);
            this.pbarShiftCountdown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Shift Hours";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(272, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "7";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(9, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "|";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(9, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "|";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(103, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(9, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "|";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(141, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(9, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "|";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(179, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(9, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "|";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(217, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(9, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "|";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(255, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(9, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "|";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(293, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(9, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "|";
            // 
            // pbarWeek
            // 
            this.pbarWeek.Location = new System.Drawing.Point(12, 139);
            this.pbarWeek.Maximum = 2400;
            this.pbarWeek.Name = "pbarWeek";
            this.pbarWeek.Size = new System.Drawing.Size(308, 23);
            this.pbarWeek.Step = 1;
            this.pbarWeek.TabIndex = 24;
            // 
            // btnEnd
            // 
            this.btnEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEnd.Location = new System.Drawing.Point(245, 168);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 22);
            this.btnEnd.TabIndex = 25;
            this.btnEnd.Text = "End Shift";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(276, 123);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(19, 13);
            this.label24.TabIndex = 89;
            this.label24.Text = "36";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(212, 123);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(19, 13);
            this.label25.TabIndex = 88;
            this.label25.Text = "28";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(148, 123);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(19, 13);
            this.label26.TabIndex = 87;
            this.label26.Text = "20";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(84, 122);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(19, 13);
            this.label27.TabIndex = 86;
            this.label27.Text = "12";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(32, 123);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(13, 13);
            this.label28.TabIndex = 85;
            this.label28.Text = "4";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(306, 123);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(19, 13);
            this.label30.TabIndex = 84;
            this.label30.Text = "40";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(180, 123);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(19, 13);
            this.label31.TabIndex = 83;
            this.label31.Text = "24";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(58, 123);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(13, 13);
            this.label32.TabIndex = 82;
            this.label32.Text = "8";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(116, 123);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(19, 13);
            this.label34.TabIndex = 81;
            this.label34.Text = "16";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(244, 122);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(19, 13);
            this.label36.TabIndex = 80;
            this.label36.Text = "32";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(9, 123);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(13, 13);
            this.label37.TabIndex = 79;
            this.label37.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(11, 99);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 15);
            this.label20.TabIndex = 78;
            this.label20.Text = "Week Hours";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMinsMinus);
            this.groupBox1.Controls.Add(this.btnMinsAdd);
            this.groupBox1.Controls.Add(this.tbAdjMins);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(11, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 42);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Corrections";
            // 
            // btnMinsMinus
            // 
            this.btnMinsMinus.Enabled = false;
            this.btnMinsMinus.Location = new System.Drawing.Point(118, 15);
            this.btnMinsMinus.Name = "btnMinsMinus";
            this.btnMinsMinus.Size = new System.Drawing.Size(23, 23);
            this.btnMinsMinus.TabIndex = 3;
            this.btnMinsMinus.Text = "_";
            this.btnMinsMinus.UseVisualStyleBackColor = true;
            this.btnMinsMinus.Click += new System.EventHandler(this.btnMinsMinus_Click_1);
            // 
            // btnMinsAdd
            // 
            this.btnMinsAdd.Enabled = false;
            this.btnMinsAdd.Location = new System.Drawing.Point(94, 15);
            this.btnMinsAdd.Name = "btnMinsAdd";
            this.btnMinsAdd.Size = new System.Drawing.Size(23, 23);
            this.btnMinsAdd.TabIndex = 2;
            this.btnMinsAdd.Text = "+";
            this.btnMinsAdd.UseVisualStyleBackColor = true;
            this.btnMinsAdd.Click += new System.EventHandler(this.btnMinsAdd_Click);
            // 
            // tbAdjMins
            // 
            this.tbAdjMins.Location = new System.Drawing.Point(52, 17);
            this.tbAdjMins.Name = "tbAdjMins";
            this.tbAdjMins.Size = new System.Drawing.Size(41, 20);
            this.tbAdjMins.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Minutes";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(119, 173);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 15);
            this.label21.TabIndex = 91;
            this.label21.Text = "Remaining: 0:00";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(24, 70);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 20);
            this.lblMessage.TabIndex = 92;
            // 
            // lblMakeupMins
            // 
            this.lblMakeupMins.AutoSize = true;
            this.lblMakeupMins.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMakeupMins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMakeupMins.ForeColor = System.Drawing.Color.Red;
            this.lblMakeupMins.Location = new System.Drawing.Point(8, 20);
            this.lblMakeupMins.Name = "lblMakeupMins";
            this.lblMakeupMins.Size = new System.Drawing.Size(43, 15);
            this.lblMakeupMins.TabIndex = 93;
            this.lblMakeupMins.Text = "Mins: 0";
            // 
            // gbMakeup
            // 
            this.gbMakeup.Controls.Add(this.button1);
            this.gbMakeup.Controls.Add(this.lblMakeupMins);
            this.gbMakeup.Location = new System.Drawing.Point(176, 196);
            this.gbMakeup.Name = "gbMakeup";
            this.gbMakeup.Size = new System.Drawing.Size(147, 42);
            this.gbMakeup.TabIndex = 91;
            this.gbMakeup.TabStop = false;
            this.gbMakeup.Text = "Makeup Time";
            this.gbMakeup.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Fixed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnEnd;
            this.ClientSize = new System.Drawing.Size(333, 248);
            this.Controls.Add(this.gbMakeup);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.pbarWeek);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbarShiftCountdown);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "8Hr Shift Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMakeup.ResumeLayout(false);
            this.gbMakeup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar pbarShiftCountdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ProgressBar pbarWeek;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMinsMinus;
        private System.Windows.Forms.Button btnMinsAdd;
        private System.Windows.Forms.TextBox tbAdjMins;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblMakeupMins;
        private System.Windows.Forms.GroupBox gbMakeup;
        private System.Windows.Forms.Button button1;
    }
}

