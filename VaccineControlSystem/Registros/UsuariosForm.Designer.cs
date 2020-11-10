namespace VaccineControlSystem.Registros
{
    partial class UsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CiudadcomboBox = new System.Windows.Forms.ComboBox();
            this.TipoUsuariocomboBox = new System.Windows.Forms.ComboBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.ApellidotextBox = new System.Windows.Forms.TextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NombreUsuariotextBox = new System.Windows.Forms.TextBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.UsuarioerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.ContrasenatextBox = new System.Windows.Forms.TextBox();
            this.Examinarbutton = new System.Windows.Forms.Button();
            this.ImagenopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ImagenpictureBox = new System.Windows.Forms.PictureBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de Usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ciudad:";
            // 
            // CiudadcomboBox
            // 
            this.CiudadcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CiudadcomboBox.FormattingEnabled = true;
            this.CiudadcomboBox.Location = new System.Drawing.Point(390, 341);
            this.CiudadcomboBox.Name = "CiudadcomboBox";
            this.CiudadcomboBox.Size = new System.Drawing.Size(224, 21);
            this.CiudadcomboBox.TabIndex = 10;
            // 
            // TipoUsuariocomboBox
            // 
            this.TipoUsuariocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoUsuariocomboBox.FormattingEnabled = true;
            this.TipoUsuariocomboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.TipoUsuariocomboBox.Location = new System.Drawing.Point(105, 341);
            this.TipoUsuariocomboBox.Name = "TipoUsuariocomboBox";
            this.TipoUsuariocomboBox.Size = new System.Drawing.Size(200, 21);
            this.TipoUsuariocomboBox.TabIndex = 8;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(105, 117);
            this.NombretextBox.MaxLength = 30;
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(199, 20);
            this.NombretextBox.TabIndex = 2;
            this.NombretextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombretextBox_KeyPress);
            // 
            // ApellidotextBox
            // 
            this.ApellidotextBox.Location = new System.Drawing.Point(105, 150);
            this.ApellidotextBox.MaxLength = 30;
            this.ApellidotextBox.Name = "ApellidotextBox";
            this.ApellidotextBox.Size = new System.Drawing.Size(199, 20);
            this.ApellidotextBox.TabIndex = 3;
            this.ApellidotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidotextBox_KeyPress);
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(104, 183);
            this.DirecciontextBox.MaxLength = 100;
            this.DirecciontextBox.Multiline = true;
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(200, 40);
            this.DirecciontextBox.TabIndex = 4;
            this.DirecciontextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DirecciontextBox_KeyPress);
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(105, 238);
            this.TelefonomaskedTextBox.Mask = "(999) 000-0000";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(128, 20);
            this.TelefonomaskedTextBox.TabIndex = 5;
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(105, 50);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(121, 20);
            this.IdtextBox.TabIndex = 0;
            this.IdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdtextBox_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Email:";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(104, 271);
            this.EmailtextBox.MaxLength = 50;
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(200, 20);
            this.EmailtextBox.TabIndex = 6;
            this.EmailtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailtextBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Nombre Usuario:";
            // 
            // NombreUsuariotextBox
            // 
            this.NombreUsuariotextBox.Location = new System.Drawing.Point(105, 83);
            this.NombreUsuariotextBox.MaxLength = 30;
            this.NombreUsuariotextBox.Name = "NombreUsuariotextBox";
            this.NombreUsuariotextBox.Size = new System.Drawing.Size(199, 20);
            this.NombreUsuariotextBox.TabIndex = 1;
            this.NombreUsuariotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreUsuariotextBox_KeyPress);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(506, 47);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(106, 20);
            this.FechadateTimePicker.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(341, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Imagen:";
            // 
            // UsuarioerrorProvider
            // 
            this.UsuarioerrorProvider.ContainerControl = this;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Contraseña:";
            // 
            // ContrasenatextBox
            // 
            this.ContrasenatextBox.Location = new System.Drawing.Point(104, 304);
            this.ContrasenatextBox.MaxLength = 30;
            this.ContrasenatextBox.Name = "ContrasenatextBox";
            this.ContrasenatextBox.Size = new System.Drawing.Size(199, 20);
            this.ContrasenatextBox.TabIndex = 7;
            this.ContrasenatextBox.UseSystemPasswordChar = true;
            this.ContrasenatextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContrasenatextBox_KeyPress);
            // 
            // Examinarbutton
            // 
            this.Examinarbutton.Location = new System.Drawing.Point(392, 83);
            this.Examinarbutton.Name = "Examinarbutton";
            this.Examinarbutton.Size = new System.Drawing.Size(44, 21);
            this.Examinarbutton.TabIndex = 9;
            this.Examinarbutton.Text = "...";
            this.Examinarbutton.UseVisualStyleBackColor = true;
            this.Examinarbutton.Click += new System.EventHandler(this.Examinarbutton_Click);
            // 
            // ImagenopenFileDialog
            // 
            this.ImagenopenFileDialog.FileName = "openFileDialog1";
            // 
            // ImagenpictureBox
            // 
            this.ImagenpictureBox.Location = new System.Drawing.Point(390, 110);
            this.ImagenpictureBox.Name = "ImagenpictureBox";
            this.ImagenpictureBox.Size = new System.Drawing.Size(222, 189);
            this.ImagenpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenpictureBox.TabIndex = 37;
            this.ImagenpictureBox.TabStop = false;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::VaccineControlSystem.Properties.Resources._1459753068_Search;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(254, 30);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(49, 47);
            this.Buscarbutton.TabIndex = 14;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Eliminarbutton.Image = global::VaccineControlSystem.Properties.Resources._1459753062_Delete;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(390, 429);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(54, 50);
            this.Eliminarbutton.TabIndex = 13;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Guardarbutton.Image = global::VaccineControlSystem.Properties.Resources._1459753117_Save;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(283, 429);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(53, 50);
            this.Guardarbutton.TabIndex = 12;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Nuevobutton.Image = global::VaccineControlSystem.Properties.Resources._1459753052_Add;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(171, 429);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(55, 50);
            this.Nuevobutton.TabIndex = 11;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(632, 491);
            this.Controls.Add(this.Examinarbutton);
            this.Controls.Add(this.ContrasenatextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ImagenpictureBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.NombreUsuariotextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.TelefonomaskedTextBox);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.ApellidotextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.TipoUsuariocomboBox);
            this.Controls.Add(this.CiudadcomboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UsuariosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenpictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CiudadcomboBox;
        private System.Windows.Forms.ComboBox TipoUsuariocomboBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox ApellidotextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NombreUsuariotextBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.PictureBox ImagenpictureBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider UsuarioerrorProvider;
        private System.Windows.Forms.TextBox ContrasenatextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Examinarbutton;
        private System.Windows.Forms.OpenFileDialog ImagenopenFileDialog;
    }
}