namespace Uniform_store
{
    partial class Reset_Password_form
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
            this.resetbutton = new System.Windows.Forms.Button();
            this.resetpasswordtextBox = new System.Windows.Forms.TextBox();
            this.confirmResetpasswordtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resetbutton
            // 
            this.resetbutton.BackColor = System.Drawing.Color.Maroon;
            this.resetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbutton.ForeColor = System.Drawing.Color.White;
            this.resetbutton.Location = new System.Drawing.Point(104, 252);
            this.resetbutton.Margin = new System.Windows.Forms.Padding(2);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(221, 44);
            this.resetbutton.TabIndex = 3;
            this.resetbutton.Text = "Restablecer";
            this.resetbutton.UseVisualStyleBackColor = false;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // resetpasswordtextBox
            // 
            this.resetpasswordtextBox.Location = new System.Drawing.Point(136, 167);
            this.resetpasswordtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.resetpasswordtextBox.Name = "resetpasswordtextBox";
            this.resetpasswordtextBox.Size = new System.Drawing.Size(277, 20);
            this.resetpasswordtextBox.TabIndex = 1;
            // 
            // confirmResetpasswordtextBox
            // 
            this.confirmResetpasswordtextBox.Location = new System.Drawing.Point(136, 205);
            this.confirmResetpasswordtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.confirmResetpasswordtextBox.Name = "confirmResetpasswordtextBox";
            this.confirmResetpasswordtextBox.Size = new System.Drawing.Size(277, 20);
            this.confirmResetpasswordtextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirmar";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Goldenrod;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(2, -5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(422, 89);
            this.textBox1.TabIndex = 32;
            this.textBox1.Text = "Restablecer Contraseña";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernametextBox
            // 
            this.usernametextBox.Location = new System.Drawing.Point(136, 120);
            this.usernametextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(276, 20);
            this.usernametextBox.TabIndex = 0;
            this.usernametextBox.TextChanged += new System.EventHandler(this.usernametextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Usuario";
            // 
            // Reset_Password_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 375);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernametextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmResetpasswordtextBox);
            this.Controls.Add(this.resetpasswordtextBox);
            this.Controls.Add(this.resetbutton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reset_Password_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Restablecer Contraseña";
            this.Load += new System.EventHandler(this.Reset_Password_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.TextBox resetpasswordtextBox;
        private System.Windows.Forms.TextBox confirmResetpasswordtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.Label label3;
    }
}