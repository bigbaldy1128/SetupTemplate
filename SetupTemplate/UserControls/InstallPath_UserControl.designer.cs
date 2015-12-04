namespace SetupTemplate.UserControls
{
    partial class InstallPath_UserControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallPath_UserControl));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.installPath_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.hdFreeSpace_label = new System.Windows.Forms.Label();
            this.needSpace_label = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 58);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 55);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "选择“代码卫士（服务端）”的安装文件夹。";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择安装位置";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(33, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Setup将安装 软件安装开发与测试管理平台（服务端） 在下列文件夹。要安装到不同文件夹，单击 [浏览] 并选择其他的文件夹。单击 [下一步] 继续。";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.installPath_textBox);
            this.groupBox1.Location = new System.Drawing.Point(39, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 64);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "目标文件夹";
            // 
            // installPath_textBox
            // 
            this.installPath_textBox.Location = new System.Drawing.Point(20, 26);
            this.installPath_textBox.Name = "installPath_textBox";
            this.installPath_textBox.Size = new System.Drawing.Size(330, 21);
            this.installPath_textBox.TabIndex = 0;
            this.installPath_textBox.Text = "C:\\CodeSecurity";
            this.installPath_textBox.TextChanged += new System.EventHandler(this.installPath_textBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "浏览...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "所需空间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "可用空间：";
            // 
            // hdFreeSpace_label
            // 
            this.hdFreeSpace_label.AutoSize = true;
            this.hdFreeSpace_label.Location = new System.Drawing.Point(96, 290);
            this.hdFreeSpace_label.Name = "hdFreeSpace_label";
            this.hdFreeSpace_label.Size = new System.Drawing.Size(0, 12);
            this.hdFreeSpace_label.TabIndex = 14;
            // 
            // needSpace_label
            // 
            this.needSpace_label.AutoSize = true;
            this.needSpace_label.Location = new System.Drawing.Point(96, 268);
            this.needSpace_label.Name = "needSpace_label";
            this.needSpace_label.Size = new System.Drawing.Size(0, 12);
            this.needSpace_label.TabIndex = 15;
            // 
            // InstallPath_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.needSpace_label);
            this.Controls.Add(this.hdFreeSpace_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Name = "InstallPath_UserControl";
            this.Size = new System.Drawing.Size(530, 320);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox installPath_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label hdFreeSpace_label;
        private System.Windows.Forms.Label needSpace_label;
    }
}
