
namespace calc
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.WelcomeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "Normal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(149, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "Easy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // WelcomeBox
            // 
            this.WelcomeBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.WelcomeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WelcomeBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.WelcomeBox.Font = new System.Drawing.Font("Goldman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBox.Location = new System.Drawing.Point(44, 44);
            this.WelcomeBox.Name = "WelcomeBox";
            this.WelcomeBox.ReadOnly = true;
            this.WelcomeBox.Size = new System.Drawing.Size(450, 33);
            this.WelcomeBox.TabIndex = 3;
            this.WelcomeBox.Text = "Welcome to shuffle X";
            this.WelcomeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Permanent Marker", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(66, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chose How You Wanna Play";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WelcomeBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox WelcomeBox;
        private System.Windows.Forms.Label label1;
    }
}