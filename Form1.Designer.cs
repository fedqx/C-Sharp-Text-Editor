namespace TextEditor
{
    partial class Mtext
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mtext));
            this.codebox = new System.Windows.Forms.TextBox();
            this.casbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.cppreference = new System.Windows.Forms.LinkLabel();
            this.creference = new System.Windows.Forms.LinkLabel();
            this.csharpreference = new System.Windows.Forms.LinkLabel();
            this.javareference = new System.Windows.Forms.LinkLabel();
            this.asmreference = new System.Windows.Forms.LinkLabel();
            this.openbutton = new System.Windows.Forms.Button();
            this.sfbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Filenamelabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // codebox
            // 
            this.codebox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.codebox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.codebox.ForeColor = System.Drawing.SystemColors.Window;
            this.codebox.Location = new System.Drawing.Point(12, 110);
            this.codebox.Margin = new System.Windows.Forms.Padding(2);
            this.codebox.Multiline = true;
            this.codebox.Name = "codebox";
            this.codebox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.codebox.Size = new System.Drawing.Size(751, 402);
            this.codebox.TabIndex = 0;
            this.codebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // casbutton
            // 
            this.casbutton.BackColor = System.Drawing.SystemColors.Window;
            this.casbutton.Location = new System.Drawing.Point(797, 466);
            this.casbutton.Margin = new System.Windows.Forms.Padding(2);
            this.casbutton.Name = "casbutton";
            this.casbutton.Size = new System.Drawing.Size(105, 19);
            this.casbutton.TabIndex = 1;
            this.casbutton.Text = "Create And Save";
            this.casbutton.UseVisualStyleBackColor = false;
            this.casbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(242, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "mtext by fedqx (Fatih Melih ÖZGÜN)";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(688, 11);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 18);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "My Website";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(596, 13);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(72, 17);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "My Github";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // cppreference
            // 
            this.cppreference.AutoSize = true;
            this.cppreference.LinkColor = System.Drawing.Color.Red;
            this.cppreference.Location = new System.Drawing.Point(838, 210);
            this.cppreference.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cppreference.Name = "cppreference";
            this.cppreference.Size = new System.Drawing.Size(79, 13);
            this.cppreference.TabIndex = 7;
            this.cppreference.TabStop = true;
            this.cppreference.Text = "C++ Reference";
            this.cppreference.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cppreference_LinkClicked);
            // 
            // creference
            // 
            this.creference.AutoSize = true;
            this.creference.LinkColor = System.Drawing.Color.Red;
            this.creference.Location = new System.Drawing.Point(850, 241);
            this.creference.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creference.Name = "creference";
            this.creference.Size = new System.Drawing.Size(67, 13);
            this.creference.TabIndex = 8;
            this.creference.TabStop = true;
            this.creference.Text = "C Reference";
            this.creference.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creference_LinkClicked);
            // 
            // csharpreference
            // 
            this.csharpreference.AutoSize = true;
            this.csharpreference.LinkColor = System.Drawing.Color.Red;
            this.csharpreference.Location = new System.Drawing.Point(843, 182);
            this.csharpreference.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.csharpreference.Name = "csharpreference";
            this.csharpreference.Size = new System.Drawing.Size(74, 13);
            this.csharpreference.TabIndex = 9;
            this.csharpreference.TabStop = true;
            this.csharpreference.Text = "C# Reference";
            this.csharpreference.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.csharpreference_LinkClicked);
            // 
            // javareference
            // 
            this.javareference.AutoSize = true;
            this.javareference.LinkColor = System.Drawing.Color.Red;
            this.javareference.Location = new System.Drawing.Point(834, 154);
            this.javareference.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.javareference.Name = "javareference";
            this.javareference.Size = new System.Drawing.Size(83, 13);
            this.javareference.TabIndex = 10;
            this.javareference.TabStop = true;
            this.javareference.Text = "Java Reference";
            this.javareference.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.javareference_LinkClicked);
            // 
            // asmreference
            // 
            this.asmreference.AutoSize = true;
            this.asmreference.LinkColor = System.Drawing.Color.Red;
            this.asmreference.Location = new System.Drawing.Point(813, 128);
            this.asmreference.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.asmreference.Name = "asmreference";
            this.asmreference.Size = new System.Drawing.Size(104, 13);
            this.asmreference.TabIndex = 11;
            this.asmreference.TabStop = true;
            this.asmreference.Text = "Assembly Reference";
            this.asmreference.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.asmreference_LinkClicked);
            // 
            // openbutton
            // 
            this.openbutton.BackColor = System.Drawing.SystemColors.Window;
            this.openbutton.Location = new System.Drawing.Point(12, 12);
            this.openbutton.Name = "openbutton";
            this.openbutton.Size = new System.Drawing.Size(75, 23);
            this.openbutton.TabIndex = 14;
            this.openbutton.Text = "Open File";
            this.openbutton.UseVisualStyleBackColor = false;
            this.openbutton.Click += new System.EventHandler(this.openbutton_Click);
            // 
            // sfbutton
            // 
            this.sfbutton.BackColor = System.Drawing.SystemColors.Window;
            this.sfbutton.Location = new System.Drawing.Point(11, 56);
            this.sfbutton.Name = "sfbutton";
            this.sfbutton.Size = new System.Drawing.Size(75, 23);
            this.sfbutton.TabIndex = 15;
            this.sfbutton.Text = "Save File";
            this.sfbutton.UseVisualStyleBackColor = false;
            this.sfbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(103, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "You are Editing:";
            // 
            // Filenamelabel
            // 
            this.Filenamelabel.AutoSize = true;
            this.Filenamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Filenamelabel.Location = new System.Drawing.Point(218, 62);
            this.Filenamelabel.Name = "Filenamelabel";
            this.Filenamelabel.Size = new System.Drawing.Size(48, 17);
            this.Filenamelabel.TabIndex = 17;
            this.Filenamelabel.Text = "No file";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDown1.Location = new System.Drawing.Point(796, 331);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            402,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 18;
            this.numericUpDown1.Value = new decimal(new int[] {
            402,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(821, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Text Box size:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Mtext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(950, 535);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Filenamelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sfbutton);
            this.Controls.Add(this.openbutton);
            this.Controls.Add(this.asmreference);
            this.Controls.Add(this.javareference);
            this.Controls.Add(this.csharpreference);
            this.Controls.Add(this.creference);
            this.Controls.Add(this.cppreference);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.casbutton);
            this.Controls.Add(this.codebox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Mtext";
            this.Text = "Mtext";
            this.Load += new System.EventHandler(this.Mtext_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Mtext_DragDrop);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codebox;
        private System.Windows.Forms.Button casbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel cppreference;
        private System.Windows.Forms.LinkLabel creference;
        private System.Windows.Forms.LinkLabel csharpreference;
        private System.Windows.Forms.LinkLabel javareference;
        private System.Windows.Forms.LinkLabel asmreference;
        private System.Windows.Forms.Button openbutton;
        private System.Windows.Forms.Button sfbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Filenamelabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
    }
}

