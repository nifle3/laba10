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
            this.Radix = new System.Windows.Forms.RadioButton();
            this.Bubble = new System.Windows.Forms.RadioButton();
            this.Sort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // History
            // 
            this.History.FormattingEnabled = true;
            this.History.ItemHeight = 15;
            this.History.Location = new System.Drawing.Point(163, 12);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(625, 424);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.History);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox History;
        private Button button1;
        private GroupBox groupBox1;
        private RadioButton Radix;
        private RadioButton Bubble;
        private Button Sort;
        private Label label1;
    }
}