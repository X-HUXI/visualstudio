namespace gameWindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(905, 410);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(1, 413);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(905, 244);
            this.listBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(931, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "进入游戏";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1108, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "退出游戏";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(938, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "玩家输入";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(932, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 25);
            this.textBox1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(934, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 178);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "行走动作";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(194, 134);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(84, 38);
            this.button11.TabIndex = 8;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button10.Location = new System.Drawing.Point(102, 134);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(86, 38);
            this.button10.TabIndex = 7;
            this.button10.Text = "向南";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(8, 134);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 38);
            this.button9.TabIndex = 6;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button8.Location = new System.Drawing.Point(194, 91);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 37);
            this.button8.TabIndex = 5;
            this.button8.Text = "向东";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(102, 91);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 37);
            this.button7.TabIndex = 4;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button6.Location = new System.Drawing.Point(8, 91);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 37);
            this.button6.TabIndex = 3;
            this.button6.Text = "向西";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(194, 42);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 43);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Location = new System.Drawing.Point(102, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 43);
            this.button4.TabIndex = 1;
            this.button4.Text = "向北";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 43);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button12.Location = new System.Drawing.Point(1134, 119);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(77, 24);
            this.button12.TabIndex = 7;
            this.button12.Text = "确定";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(938, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "快捷命令";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(934, 439);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 25);
            this.textBox2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(927, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "音乐播放";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(1036, 517);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(85, 32);
            this.button13.TabIndex = 11;
            this.button13.Text = "播放";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(1036, 565);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(85, 32);
            this.button14.TabIndex = 12;
            this.button14.Text = "暂停";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(934, 610);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(277, 45);
            this.axWindowsMediaPlayer1.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 667);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "游戏界面";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
    }
}

