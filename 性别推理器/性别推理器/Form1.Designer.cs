namespace 性别推理器
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            选项ToolStripMenuItem = new ToolStripMenuItem();
            正常人ToolStripMenuItem = new ToolStripMenuItem();
            美国版ToolStripMenuItem = new ToolStripMenuItem();
            猎奇版ToolStripMenuItem = new ToolStripMenuItem();
            帮助ToolStripMenuItem = new ToolStripMenuItem();
            打赏ToolStripMenuItem = new ToolStripMenuItem();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            button1 = new Button();
            groupBox3 = new GroupBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 选项ToolStripMenuItem, 帮助ToolStripMenuItem, 打赏ToolStripMenuItem, 退出ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(377, 34);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 选项ToolStripMenuItem
            // 
            选项ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 正常人ToolStripMenuItem, 美国版ToolStripMenuItem, 猎奇版ToolStripMenuItem });
            选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            选项ToolStripMenuItem.Size = new Size(62, 28);
            选项ToolStripMenuItem.Text = "选项";
            // 
            // 正常人ToolStripMenuItem
            // 
            正常人ToolStripMenuItem.Checked = true;
            正常人ToolStripMenuItem.CheckState = CheckState.Checked;
            正常人ToolStripMenuItem.Name = "正常人ToolStripMenuItem";
            正常人ToolStripMenuItem.Size = new Size(270, 34);
            正常人ToolStripMenuItem.Text = "正常版";
            正常人ToolStripMenuItem.Click += 正常人ToolStripMenuItem_Click;
            // 
            // 美国版ToolStripMenuItem
            // 
            美国版ToolStripMenuItem.Name = "美国版ToolStripMenuItem";
            美国版ToolStripMenuItem.Size = new Size(270, 34);
            美国版ToolStripMenuItem.Text = "美国版";
            美国版ToolStripMenuItem.Click += 美国版ToolStripMenuItem_Click;
            // 
            // 猎奇版ToolStripMenuItem
            // 
            猎奇版ToolStripMenuItem.Name = "猎奇版ToolStripMenuItem";
            猎奇版ToolStripMenuItem.Size = new Size(270, 34);
            猎奇版ToolStripMenuItem.Text = "猎奇版";
            猎奇版ToolStripMenuItem.Click += 猎奇版ToolStripMenuItem_Click;
            // 
            // 帮助ToolStripMenuItem
            // 
            帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            帮助ToolStripMenuItem.Size = new Size(62, 28);
            帮助ToolStripMenuItem.Text = "帮助";
            帮助ToolStripMenuItem.Click += 帮助ToolStripMenuItem_Click;
            // 
            // 打赏ToolStripMenuItem
            // 
            打赏ToolStripMenuItem.Name = "打赏ToolStripMenuItem";
            打赏ToolStripMenuItem.Size = new Size(62, 28);
            打赏ToolStripMenuItem.Text = "打赏";
            打赏ToolStripMenuItem.Click += 打赏ToolStripMenuItem_Click;
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new Size(62, 28);
            退出ToolStripMenuItem.Text = "退出";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Dock = DockStyle.Left;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Location = new Point(3, 26);
            label1.Name = "label1";
            label1.Size = new Size(48, 26);
            label1.TabIndex = 1;
            label1.Text = "姓名";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 544);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(377, 31);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(86, 24);
            toolStripStatusLabel1.Text = "当前模式:";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(64, 24);
            toolStripStatusLabel2.Text = "正常版";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Right;
            textBox1.Location = new Point(57, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 30);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 66);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(377, 120);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(216, 69);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 28);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "母亲";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Dock = DockStyle.Fill;
            radioButton1.Location = new Point(3, 50);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(371, 67);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "父亲";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(3, 26);
            label2.Name = "label2";
            label2.Size = new Size(104, 24);
            label2.TabIndex = 0;
            label2.Text = "请选择身份:";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Location = new Point(0, 220);
            button1.Name = "button1";
            button1.Size = new Size(377, 70);
            button1.TabIndex = 6;
            button1.Text = "开始推理";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 290);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(377, 254);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "推理结果:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 575);
            Controls.Add(groupBox3);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "父母性别推理器";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 选项ToolStripMenuItem;
        private ToolStripMenuItem 正常人ToolStripMenuItem;
        private ToolStripMenuItem 美国版ToolStripMenuItem;
        private ToolStripMenuItem 猎奇版ToolStripMenuItem;
        private ToolStripMenuItem 帮助ToolStripMenuItem;
        private ToolStripMenuItem 打赏ToolStripMenuItem;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label2;
        private Button button1;
        private GroupBox groupBox3;
    }
}
