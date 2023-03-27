namespace app10
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
            this.History = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sort = new System.Windows.Forms.Button();
            this.Radix = new System.Windows.Forms.RadioButton();
            this.Bubble = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Iter = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Ifi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // History
            // 
            this.History.FormattingEnabled = true;
            this.History.ItemHeight = 15;
            this.History.Location = new System.Drawing.Point(236, 50);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(681, 499);
            this.History.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сгенерировать массив";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Sort);
            this.groupBox1.Controls.Add(this.Radix);
            this.groupBox1.Controls.Add(this.Bubble);
            this.groupBox1.Location = new System.Drawing.Point(7, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите сортировку";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(6, 87);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(138, 32);
            this.Sort.TabIndex = 2;
            this.Sort.Text = "Сортировать";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.button2_Click);
            // 
            // Radix
            // 
            this.Radix.AutoSize = true;
            this.Radix.Location = new System.Drawing.Point(3, 44);
            this.Radix.Name = "Radix";
            this.Radix.Size = new System.Drawing.Size(97, 19);
            this.Radix.TabIndex = 1;
            this.Radix.TabStop = true;
            this.Radix.Text = "Поразрядная";
            this.Radix.UseVisualStyleBackColor = true;
            // 
            // Bubble
            // 
            this.Bubble.AutoSize = true;
            this.Bubble.Location = new System.Drawing.Point(3, 19);
            this.Bubble.Name = "Bubble";
            this.Bubble.Size = new System.Drawing.Size(78, 19);
            this.Bubble.TabIndex = 0;
            this.Bubble.TabStop = true;
            this.Bubble.Text = "Выбором";
            this.Bubble.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(80, 20);
            this.toolStripMenuItem1.Text = "Статистика";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(58, 20);
            this.toolStripMenuItem2.Text = "В файл";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество итерация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество сравнений";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Затраченное время";
            // 
            // Iter
            // 
            this.Iter.AutoSize = true;
            this.Iter.Location = new System.Drawing.Point(145, 250);
            this.Iter.Name = "Iter";
            this.Iter.Size = new System.Drawing.Size(0, 15);
            this.Iter.TabIndex = 7;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(145, 305);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(0, 15);
            this.Time.TabIndex = 8;
            // 
            // Ifi
            // 
            this.Ifi.AutoSize = true;
            this.Ifi.Location = new System.Drawing.Point(145, 276);
            this.Ifi.Name = "Ifi";
            this.Ifi.Size = new System.Drawing.Size(0, 15);
            this.Ifi.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 570);
            this.Controls.Add(this.Ifi);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Iter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.History);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox History;
        private Button button1;
        private GroupBox groupBox1;
        private RadioButton Radix;
        private RadioButton Bubble;
        private Button Sort;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private Label label2;
        private Label label3;
        private Label label4;
        public Label Iter;
        public Label Time;
        public Label Ifi;
    }
}