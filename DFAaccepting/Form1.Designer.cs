namespace DFAaccepting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.newstatebutton = new System.Windows.Forms.Button();
            this.arcbutton = new System.Windows.Forms.Button();
            this.alphabet = new System.Windows.Forms.TextBox();
            this.clearpoints = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.makeinitial = new System.Windows.Forms.Button();
            this.makefinal = new System.Windows.Forms.Button();
            this.isaccepting = new System.Windows.Forms.Button();
            this.inputstring = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(112, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 360);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // newstatebutton
            // 
            this.newstatebutton.Location = new System.Drawing.Point(12, 93);
            this.newstatebutton.Name = "newstatebutton";
            this.newstatebutton.Size = new System.Drawing.Size(75, 23);
            this.newstatebutton.TabIndex = 1;
            this.newstatebutton.Text = "newstate";
            this.newstatebutton.UseVisualStyleBackColor = true;
            this.newstatebutton.Click += new System.EventHandler(this.newstatebutton_Click);
            // 
            // arcbutton
            // 
            this.arcbutton.Location = new System.Drawing.Point(12, 222);
            this.arcbutton.Name = "arcbutton";
            this.arcbutton.Size = new System.Drawing.Size(75, 23);
            this.arcbutton.TabIndex = 2;
            this.arcbutton.Text = "draw arc";
            this.arcbutton.UseVisualStyleBackColor = true;
            this.arcbutton.Click += new System.EventHandler(this.arcbutton_Click);
            // 
            // alphabet
            // 
            this.alphabet.Location = new System.Drawing.Point(63, 258);
            this.alphabet.Name = "alphabet";
            this.alphabet.Size = new System.Drawing.Size(39, 20);
            this.alphabet.TabIndex = 3;
            // 
            // clearpoints
            // 
            this.clearpoints.Location = new System.Drawing.Point(12, 297);
            this.clearpoints.Name = "clearpoints";
            this.clearpoints.Size = new System.Drawing.Size(75, 23);
            this.clearpoints.TabIndex = 4;
            this.clearpoints.Text = "clear points";
            this.clearpoints.UseVisualStyleBackColor = true;
            this.clearpoints.Click += new System.EventHandler(this.clearpoints_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(977, 405);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 5;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // makeinitial
            // 
            this.makeinitial.Location = new System.Drawing.Point(12, 64);
            this.makeinitial.Name = "makeinitial";
            this.makeinitial.Size = new System.Drawing.Size(75, 23);
            this.makeinitial.TabIndex = 6;
            this.makeinitial.Text = "makeinitial";
            this.makeinitial.UseVisualStyleBackColor = true;
            this.makeinitial.Click += new System.EventHandler(this.makeinitial_Click);
            // 
            // makefinal
            // 
            this.makefinal.Location = new System.Drawing.Point(12, 122);
            this.makefinal.Name = "makefinal";
            this.makefinal.Size = new System.Drawing.Size(75, 23);
            this.makefinal.TabIndex = 7;
            this.makefinal.Text = "makefinal";
            this.makefinal.UseVisualStyleBackColor = true;
            this.makefinal.Click += new System.EventHandler(this.makefinal_Click);
            // 
            // isaccepting
            // 
            this.isaccepting.Location = new System.Drawing.Point(599, 405);
            this.isaccepting.Name = "isaccepting";
            this.isaccepting.Size = new System.Drawing.Size(105, 23);
            this.isaccepting.TabIndex = 8;
            this.isaccepting.Text = "accepting or not";
            this.isaccepting.UseVisualStyleBackColor = true;
            this.isaccepting.Click += new System.EventHandler(this.isaccepting_Click);
            // 
            // inputstring
            // 
            this.inputstring.Location = new System.Drawing.Point(413, 407);
            this.inputstring.Name = "inputstring";
            this.inputstring.Size = new System.Drawing.Size(131, 20);
            this.inputstring.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "input your string :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "alphabet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 483);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputstring);
            this.Controls.Add(this.isaccepting);
            this.Controls.Add(this.makefinal);
            this.Controls.Add(this.makeinitial);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.clearpoints);
            this.Controls.Add(this.alphabet);
            this.Controls.Add(this.arcbutton);
            this.Controls.Add(this.newstatebutton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newstatebutton;
        private System.Windows.Forms.Button arcbutton;
        private System.Windows.Forms.TextBox alphabet;
        private System.Windows.Forms.Button clearpoints;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button makeinitial;
        private System.Windows.Forms.Button makefinal;
        private System.Windows.Forms.Button isaccepting;
        private System.Windows.Forms.TextBox inputstring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

