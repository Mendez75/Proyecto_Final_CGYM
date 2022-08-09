namespace Uniform_store
{
    partial class Forget_password
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
            this.components = new System.ComponentModel.Container();
            this.sendbutton = new System.Windows.Forms.Button();
            this.verifybutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.forgetEmailtextBox = new System.Windows.Forms.TextBox();
            this.codetextBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.EmailerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmailerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // sendbutton
            // 
            this.sendbutton.BackColor = System.Drawing.Color.Maroon;
            this.sendbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbutton.ForeColor = System.Drawing.Color.White;
            this.sendbutton.Location = new System.Drawing.Point(394, 143);
            this.sendbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(86, 30);
            this.sendbutton.TabIndex = 0;
            this.sendbutton.Text = "Enviar";
            this.sendbutton.UseVisualStyleBackColor = false;
            this.sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // verifybutton
            // 
            this.verifybutton.BackColor = System.Drawing.Color.Maroon;
            this.verifybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifybutton.ForeColor = System.Drawing.Color.White;
            this.verifybutton.Location = new System.Drawing.Point(439, 225);
            this.verifybutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.verifybutton.Name = "verifybutton";
            this.verifybutton.Size = new System.Drawing.Size(90, 31);
            this.verifybutton.TabIndex = 1;
            this.verifybutton.Text = "Verificar";
            this.verifybutton.UseVisualStyleBackColor = false;
            this.verifybutton.Click += new System.EventHandler(this.verifybutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código de verificación";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Goldenrod;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(646, 68);
            this.textBox1.TabIndex = 32;
            this.textBox1.Text = "Olvidé Mi Contraseña";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // forgetEmailtextBox
            // 
            this.forgetEmailtextBox.Location = new System.Drawing.Point(68, 149);
            this.forgetEmailtextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.forgetEmailtextBox.Name = "forgetEmailtextBox";
            this.forgetEmailtextBox.Size = new System.Drawing.Size(312, 20);
            this.forgetEmailtextBox.TabIndex = 33;
            // 
            // codetextBox
            // 
            this.codetextBox.Location = new System.Drawing.Point(182, 232);
            this.codetextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codetextBox.Name = "codetextBox";
            this.codetextBox.Size = new System.Drawing.Size(253, 20);
            this.codetextBox.TabIndex = 34;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(189, 335);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(246, 20);
            this.linkLabel1.TabIndex = 35;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Ya tiene la cuenta? Inicie sesión";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // EmailerrorProvider
            // 
            this.EmailerrorProvider.ContainerControl = this;
            // 
            // Forget_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 381);
            this.ControlBox = false;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.codetextBox);
            this.Controls.Add(this.forgetEmailtextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verifybutton);
            this.Controls.Add(this.sendbutton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Forget_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.EmailerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.Button verifybutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox forgetEmailtextBox;
        private System.Windows.Forms.TextBox codetextBox;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ErrorProvider EmailerrorProvider;
    }
}