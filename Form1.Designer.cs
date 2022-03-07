namespace simple_mouse_click_tester
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.leftMB = new System.Windows.Forms.Button();
            this.middleMB = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rightMB = new System.Windows.Forms.Button();
            this.scrollU = new System.Windows.Forms.Button();
            this.scrollD = new System.Windows.Forms.Button();
            this.threeMB = new System.Windows.Forms.Button();
            this.fourMB = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.leftLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rightLbl = new System.Windows.Forms.Label();
            this.middleLbl = new System.Windows.Forms.Label();
            this.threeLbl = new System.Windows.Forms.Label();
            this.fourLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.doubleClickRB = new System.Windows.Forms.RadioButton();
            this.highlightRB = new System.Windows.Forms.RadioButton();
            this.realtimeRB = new System.Windows.Forms.RadioButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftMB
            // 
            this.leftMB.Location = new System.Drawing.Point(569, 41);
            this.leftMB.Name = "leftMB";
            this.leftMB.Size = new System.Drawing.Size(75, 23);
            this.leftMB.TabIndex = 9;
            this.leftMB.Text = "LMB";
            this.leftMB.UseVisualStyleBackColor = true;
            // 
            // middleMB
            // 
            this.middleMB.Location = new System.Drawing.Point(650, 41);
            this.middleMB.Name = "middleMB";
            this.middleMB.Size = new System.Drawing.Size(75, 23);
            this.middleMB.TabIndex = 1;
            this.middleMB.Text = "MMB";
            this.middleMB.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox1.Size = new System.Drawing.Size(535, 248);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDown);
            this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseUp);
            // 
            // rightMB
            // 
            this.rightMB.Location = new System.Drawing.Point(731, 41);
            this.rightMB.Name = "rightMB";
            this.rightMB.Size = new System.Drawing.Size(75, 23);
            this.rightMB.TabIndex = 3;
            this.rightMB.Text = "RMB";
            this.rightMB.UseVisualStyleBackColor = true;
            // 
            // scrollU
            // 
            this.scrollU.Location = new System.Drawing.Point(650, 12);
            this.scrollU.Name = "scrollU";
            this.scrollU.Size = new System.Drawing.Size(75, 23);
            this.scrollU.TabIndex = 4;
            this.scrollU.Text = "Scrl Up";
            this.scrollU.UseVisualStyleBackColor = true;
            // 
            // scrollD
            // 
            this.scrollD.Location = new System.Drawing.Point(650, 70);
            this.scrollD.Name = "scrollD";
            this.scrollD.Size = new System.Drawing.Size(75, 23);
            this.scrollD.TabIndex = 5;
            this.scrollD.TabStop = false;
            this.scrollD.Text = "Scrl Down";
            this.scrollD.UseVisualStyleBackColor = true;
            // 
            // threeMB
            // 
            this.threeMB.Location = new System.Drawing.Point(569, 102);
            this.threeMB.Name = "threeMB";
            this.threeMB.Size = new System.Drawing.Size(75, 23);
            this.threeMB.TabIndex = 6;
            this.threeMB.Text = "MB3";
            this.threeMB.UseVisualStyleBackColor = true;
            // 
            // fourMB
            // 
            this.fourMB.Location = new System.Drawing.Point(569, 131);
            this.fourMB.Name = "fourMB";
            this.fourMB.Size = new System.Drawing.Size(75, 23);
            this.fourMB.TabIndex = 7;
            this.fourMB.Text = "MB4";
            this.fourMB.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(569, 174);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(783, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Clicks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(731, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "LMB";
            // 
            // leftLbl
            // 
            this.leftLbl.AutoSize = true;
            this.leftLbl.Location = new System.Drawing.Point(792, 145);
            this.leftLbl.Name = "leftLbl";
            this.leftLbl.Size = new System.Drawing.Size(13, 15);
            this.leftLbl.TabIndex = 11;
            this.leftLbl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(731, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "RMB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(731, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "MMB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(731, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "MB3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(731, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "MB4";
            // 
            // rightLbl
            // 
            this.rightLbl.AutoSize = true;
            this.rightLbl.Location = new System.Drawing.Point(792, 165);
            this.rightLbl.Name = "rightLbl";
            this.rightLbl.Size = new System.Drawing.Size(13, 15);
            this.rightLbl.TabIndex = 16;
            this.rightLbl.Text = "0";
            // 
            // middleLbl
            // 
            this.middleLbl.AutoSize = true;
            this.middleLbl.Location = new System.Drawing.Point(792, 185);
            this.middleLbl.Name = "middleLbl";
            this.middleLbl.Size = new System.Drawing.Size(13, 15);
            this.middleLbl.TabIndex = 17;
            this.middleLbl.Text = "0";
            // 
            // threeLbl
            // 
            this.threeLbl.AutoSize = true;
            this.threeLbl.Location = new System.Drawing.Point(792, 205);
            this.threeLbl.Name = "threeLbl";
            this.threeLbl.Size = new System.Drawing.Size(13, 15);
            this.threeLbl.TabIndex = 18;
            this.threeLbl.Text = "0";
            // 
            // fourLbl
            // 
            this.fourLbl.AutoSize = true;
            this.fourLbl.Location = new System.Drawing.Point(792, 225);
            this.fourLbl.Name = "fourLbl";
            this.fourLbl.Size = new System.Drawing.Size(13, 15);
            this.fourLbl.TabIndex = 19;
            this.fourLbl.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.doubleClickRB);
            this.groupBox1.Controls.Add(this.highlightRB);
            this.groupBox1.Controls.Add(this.realtimeRB);
            this.groupBox1.Location = new System.Drawing.Point(569, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 52);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // doubleClickRB
            // 
            this.doubleClickRB.AutoSize = true;
            this.doubleClickRB.Location = new System.Drawing.Point(93, 25);
            this.doubleClickRB.Name = "doubleClickRB";
            this.doubleClickRB.Size = new System.Drawing.Size(41, 19);
            this.doubleClickRB.TabIndex = 2;
            this.doubleClickRB.TabStop = true;
            this.doubleClickRB.Text = "DC";
            this.doubleClickRB.UseVisualStyleBackColor = true;
            this.doubleClickRB.CheckedChanged += new System.EventHandler(this.doubleClickRB_CheckedChanged);
            // 
            // highlightRB
            // 
            this.highlightRB.AutoSize = true;
            this.highlightRB.Location = new System.Drawing.Point(48, 25);
            this.highlightRB.Name = "highlightRB";
            this.highlightRB.Size = new System.Drawing.Size(40, 19);
            this.highlightRB.TabIndex = 1;
            this.highlightRB.Text = "HL";
            this.highlightRB.UseVisualStyleBackColor = true;
            this.highlightRB.CheckedChanged += new System.EventHandler(this.highlightRB_CheckedChanged);
            // 
            // realtimeRB
            // 
            this.realtimeRB.AutoSize = true;
            this.realtimeRB.Checked = true;
            this.realtimeRB.Location = new System.Drawing.Point(6, 25);
            this.realtimeRB.Name = "realtimeRB";
            this.realtimeRB.Size = new System.Drawing.Size(37, 19);
            this.realtimeRB.TabIndex = 0;
            this.realtimeRB.TabStop = true;
            this.realtimeRB.Text = "RT";
            this.realtimeRB.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 267);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fourLbl);
            this.Controls.Add(this.threeLbl);
            this.Controls.Add(this.middleLbl);
            this.Controls.Add(this.rightLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.leftLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.fourMB);
            this.Controls.Add(this.threeMB);
            this.Controls.Add(this.scrollD);
            this.Controls.Add(this.scrollU);
            this.Controls.Add(this.rightMB);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.middleMB);
            this.Controls.Add(this.leftMB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Click tester";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button leftMB;
        private Button middleMB;
        private RichTextBox richTextBox1;
        private Button rightMB;
        private Button scrollU;
        private Button scrollD;
        private Button threeMB;
        private Button fourMB;
        private Button clearBtn;
        private Label label1;
        private Label label2;
        private Label leftLbl;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label rightLbl;
        private Label middleLbl;
        private Label threeLbl;
        private Label fourLbl;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox1;
        private RadioButton highlightRB;
        private RadioButton realtimeRB;
        private RadioButton doubleClickRB;
        private System.Windows.Forms.Timer timer2;
    }
}