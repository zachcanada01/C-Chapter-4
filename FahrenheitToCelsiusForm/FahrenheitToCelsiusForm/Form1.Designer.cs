namespace FahrenheitToCelsiusForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.temptxt1 = new System.Windows.Forms.TextBox();
            this.temptxt2 = new System.Windows.Forms.TextBox();
            this.temptxt3 = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.tempOutput1 = new System.Windows.Forms.Label();
            this.tempOutput2 = new System.Windows.Forms.Label();
            this.tempOutput3 = new System.Windows.Forms.Label();
            this.hotOrCold = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(47, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature for 8:00 am";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(47, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperature for 12:00 pm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(47, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temperature for 5:00 pm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(399, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // temptxt1
            // 
            this.temptxt1.Location = new System.Drawing.Point(249, 72);
            this.temptxt1.Name = "temptxt1";
            this.temptxt1.Size = new System.Drawing.Size(100, 20);
            this.temptxt1.TabIndex = 4;
            // 
            // temptxt2
            // 
            this.temptxt2.Location = new System.Drawing.Point(249, 119);
            this.temptxt2.Name = "temptxt2";
            this.temptxt2.Size = new System.Drawing.Size(100, 20);
            this.temptxt2.TabIndex = 5;
            // 
            // temptxt3
            // 
            this.temptxt3.Location = new System.Drawing.Point(249, 163);
            this.temptxt3.Name = "temptxt3";
            this.temptxt3.Size = new System.Drawing.Size(100, 20);
            this.temptxt3.TabIndex = 6;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(262, 198);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // tempOutput1
            // 
            this.tempOutput1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tempOutput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tempOutput1.Location = new System.Drawing.Point(355, 72);
            this.tempOutput1.Name = "tempOutput1";
            this.tempOutput1.Size = new System.Drawing.Size(378, 20);
            this.tempOutput1.TabIndex = 8;
            // 
            // tempOutput2
            // 
            this.tempOutput2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tempOutput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tempOutput2.Location = new System.Drawing.Point(355, 119);
            this.tempOutput2.Name = "tempOutput2";
            this.tempOutput2.Size = new System.Drawing.Size(378, 20);
            this.tempOutput2.TabIndex = 9;
            // 
            // tempOutput3
            // 
            this.tempOutput3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tempOutput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tempOutput3.Location = new System.Drawing.Point(355, 162);
            this.tempOutput3.Name = "tempOutput3";
            this.tempOutput3.Size = new System.Drawing.Size(378, 21);
            this.tempOutput3.TabIndex = 10;
            // 
            // hotOrCold
            // 
            this.hotOrCold.AutoSize = true;
            this.hotOrCold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.hotOrCold.Location = new System.Drawing.Point(526, 198);
            this.hotOrCold.Name = "hotOrCold";
            this.hotOrCold.Size = new System.Drawing.Size(0, 18);
            this.hotOrCold.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hotOrCold);
            this.Controls.Add(this.tempOutput3);
            this.Controls.Add(this.tempOutput2);
            this.Controls.Add(this.tempOutput1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.temptxt3);
            this.Controls.Add(this.temptxt2);
            this.Controls.Add(this.temptxt1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox temptxt1;
        private System.Windows.Forms.TextBox temptxt2;
        private System.Windows.Forms.TextBox temptxt3;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label tempOutput1;
        private System.Windows.Forms.Label tempOutput2;
        private System.Windows.Forms.Label tempOutput3;
        private System.Windows.Forms.Label hotOrCold;
    }
}

