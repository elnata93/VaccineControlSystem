namespace VaccineControlSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreUsuariotextBox = new System.Windows.Forms.TextBox();
            this.ContrasenatextBox = new System.Windows.Forms.TextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cacelarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contraseña:";
            // 
            // NombreUsuariotextBox
            // 
            this.NombreUsuariotextBox.AllowDrop = true;
            this.NombreUsuariotextBox.Location = new System.Drawing.Point(135, 161);
            this.NombreUsuariotextBox.Name = "NombreUsuariotextBox";
            this.NombreUsuariotextBox.Size = new System.Drawing.Size(187, 20);
            this.NombreUsuariotextBox.TabIndex = 0;
            // 
            // ContrasenatextBox
            // 
            this.ContrasenatextBox.AllowDrop = true;
            this.ContrasenatextBox.Location = new System.Drawing.Point(135, 198);
            this.ContrasenatextBox.Name = "ContrasenatextBox";
            this.ContrasenatextBox.Size = new System.Drawing.Size(187, 20);
            this.ContrasenatextBox.TabIndex = 1;
            this.ContrasenatextBox.UseSystemPasswordChar = true;
            // 
            // Loginbutton
            // 
            this.Loginbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Loginbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Loginbutton.Location = new System.Drawing.Point(72, 250);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(99, 32);
            this.Loginbutton.TabIndex = 2;
            this.Loginbutton.Text = "Login";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VaccineControlSystem.Properties.Resources.Login_Manager;
            this.pictureBox1.Location = new System.Drawing.Point(144, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Cacelarbutton
            // 
            this.Cacelarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cacelarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Cacelarbutton.Location = new System.Drawing.Point(223, 250);
            this.Cacelarbutton.Name = "Cacelarbutton";
            this.Cacelarbutton.Size = new System.Drawing.Size(99, 32);
            this.Cacelarbutton.TabIndex = 4;
            this.Cacelarbutton.Text = "Cacelar";
            this.Cacelarbutton.UseVisualStyleBackColor = true;
            this.Cacelarbutton.Click += new System.EventHandler(this.Cacelarbutton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(401, 294);
            this.Controls.Add(this.Cacelarbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ContrasenatextBox);
            this.Controls.Add(this.NombreUsuariotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Loginbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreUsuariotextBox;
        private System.Windows.Forms.TextBox ContrasenatextBox;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Cacelarbutton;
    }
}