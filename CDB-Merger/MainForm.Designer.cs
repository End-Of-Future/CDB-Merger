namespace CDB_Merger
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.主数据库MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他数据库OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.合并MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检查数据库CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.忽略重复项IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.替换重复项RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.源代码开源ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.制作团队ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.数据DToolStripMenuItem,
            this.关于AToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.toolStripSeparator1,
            this.合并MToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新建NToolStripMenuItem.Text = "新建(&N)";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主数据库MToolStripMenuItem,
            this.其他数据库OToolStripMenuItem});
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 主数据库MToolStripMenuItem
            // 
            this.主数据库MToolStripMenuItem.Name = "主数据库MToolStripMenuItem";
            this.主数据库MToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.主数据库MToolStripMenuItem.Text = "主数据库(&M)";
            this.主数据库MToolStripMenuItem.Click += new System.EventHandler(this.Open_As_Main);
            // 
            // 其他数据库OToolStripMenuItem
            // 
            this.其他数据库OToolStripMenuItem.Name = "其他数据库OToolStripMenuItem";
            this.其他数据库OToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.其他数据库OToolStripMenuItem.Text = "其他数据库(&O)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 合并MToolStripMenuItem
            // 
            this.合并MToolStripMenuItem.Name = "合并MToolStripMenuItem";
            this.合并MToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.合并MToolStripMenuItem.Text = "合并(&M)";
            // 
            // 数据DToolStripMenuItem
            // 
            this.数据DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.检查数据库CToolStripMenuItem,
            this.忽略重复项IToolStripMenuItem,
            this.替换重复项RToolStripMenuItem});
            this.数据DToolStripMenuItem.Name = "数据DToolStripMenuItem";
            this.数据DToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.数据DToolStripMenuItem.Text = "数据(&D)";
            // 
            // 检查数据库CToolStripMenuItem
            // 
            this.检查数据库CToolStripMenuItem.Name = "检查数据库CToolStripMenuItem";
            this.检查数据库CToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.检查数据库CToolStripMenuItem.Text = "检查数据库(&C)";
            // 
            // 忽略重复项IToolStripMenuItem
            // 
            this.忽略重复项IToolStripMenuItem.Checked = true;
            this.忽略重复项IToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.忽略重复项IToolStripMenuItem.Name = "忽略重复项IToolStripMenuItem";
            this.忽略重复项IToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.忽略重复项IToolStripMenuItem.Text = "忽略重复项(&I)";
            // 
            // 替换重复项RToolStripMenuItem
            // 
            this.替换重复项RToolStripMenuItem.Name = "替换重复项RToolStripMenuItem";
            this.替换重复项RToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.替换重复项RToolStripMenuItem.Text = "替换重复项(&R)";
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.源代码开源ToolStripMenuItem,
            this.制作团队ToolStripMenuItem});
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.关于AToolStripMenuItem.Text = "关于(&A)";
            // 
            // 源代码开源ToolStripMenuItem
            // 
            this.源代码开源ToolStripMenuItem.Name = "源代码开源ToolStripMenuItem";
            this.源代码开源ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.源代码开源ToolStripMenuItem.Text = "源代码开源";
            // 
            // 制作团队ToolStripMenuItem
            // 
            this.制作团队ToolStripMenuItem.Name = "制作团队ToolStripMenuItem";
            this.制作团队ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.制作团队ToolStripMenuItem.Text = "制作团队";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "主数据库：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "其他数据库：";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(84, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(704, 23);
            this.textBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(84, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(704, 378);
            this.listBox1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件FToolStripMenuItem;
        private ToolStripMenuItem 新建NToolStripMenuItem;
        private ToolStripMenuItem 打开ToolStripMenuItem;
        private ToolStripMenuItem 主数据库MToolStripMenuItem;
        private ToolStripMenuItem 其他数据库OToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 合并MToolStripMenuItem;
        private ToolStripMenuItem 数据DToolStripMenuItem;
        private ToolStripMenuItem 检查数据库CToolStripMenuItem;
        private ToolStripMenuItem 忽略重复项IToolStripMenuItem;
        private ToolStripMenuItem 替换重复项RToolStripMenuItem;
        private ToolStripMenuItem 关于AToolStripMenuItem;
        private ToolStripMenuItem 源代码开源ToolStripMenuItem;
        private ToolStripMenuItem 制作团队ToolStripMenuItem;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ListBox listBox1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}