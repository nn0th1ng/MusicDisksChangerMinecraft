namespace RPcreator
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
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox3 = new TextBox();
            cancel = new Button();
            save = new Button();
            groupBox2 = new GroupBox();
            delete = new Button();
            disks = new ListBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            textBox2 = new TextBox();
            music = new ListBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            openToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            folderBrowserDialog2 = new FolderBrowserDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 23);
            textBox1.TabIndex = 0;
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(cancel);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(save);
            groupBox1.Location = new Point(12, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 410);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "path to save resource pack";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 59);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 6;
            label1.Text = "Resource  Pack name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 76);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(283, 23);
            textBox3.TabIndex = 5;
            // 
            // cancel
            // 
            cancel.Location = new Point(87, 381);
            cancel.Name = "cancel";
            cancel.Size = new Size(75, 23);
            cancel.TabIndex = 4;
            cancel.Text = "cancel";
            cancel.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            save.Location = new Point(6, 381);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 3;
            save.Text = "Create";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(delete);
            groupBox2.Controls.Add(disks);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(music);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(315, 28);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(473, 410);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "add music";
            // 
            // delete
            // 
            delete.Enabled = false;
            delete.Location = new Point(6, 139);
            delete.Name = "delete";
            delete.Size = new Size(121, 23);
            delete.TabIndex = 7;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // disks
            // 
            disks.FormattingEnabled = true;
            disks.ItemHeight = 15;
            disks.Location = new Point(399, 51);
            disks.Name = "disks";
            disks.Size = new Size(68, 349);
            disks.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "muisc disk";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "13", "cat", "blocks", "chirp", "far", "mall", "mellohi", "stal", "strad", "ward", "11", "wait", "otherside", "5", "pigstep", "relic", "precipice", "creator", "creator_music_box", "tears", "lava_chicken" });
            comboBox1.Location = new Point(6, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(6, 110);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 3;
            button1.Text = "add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(461, 23);
            textBox2.TabIndex = 2;
            textBox2.Click += textBox2_Click;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // music
            // 
            music.FormattingEnabled = true;
            music.ItemHeight = 15;
            music.Location = new Point(226, 51);
            music.Name = "music";
            music.Size = new Size(167, 349);
            music.TabIndex = 1;
            music.SelectedIndexChanged += music_SelectedIndexChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, newToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(38, 22);
            toolStripDropDownButton1.Text = "File";
            toolStripDropDownButton1.ToolTipText = "\r\n";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(101, 22);
            openToolStripMenuItem.Text = "open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(101, 22);
            newToolStripMenuItem.Text = "new";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private FolderBrowserDialog folderBrowserDialog1;
        private ListBox music;
        private Button button1;
        private TextBox textBox2;
        private Button save;
        private Button cancel;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private ComboBox comboBox1;
        private ListBox disks;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem openToolStripMenuItem;
        private FolderBrowserDialog folderBrowserDialog2;
        private ToolStripMenuItem newToolStripMenuItem;
        private Button delete;
    }
}
