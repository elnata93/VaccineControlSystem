namespace VaccineControlSystem.Registros
{
    partial class PacientesForm
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
            this.VacunagroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NoradioButton = new System.Windows.Forms.RadioButton();
            this.SiradioButton = new System.Windows.Forms.RadioButton();
            this.VacunacomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.EdadtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.VacunadataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SexogroupBox = new System.Windows.Forms.GroupBox();
            this.FemeninoradioButton = new System.Windows.Forms.RadioButton();
            this.MasculinoradioButton = new System.Windows.Forms.RadioButton();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.ApellidotextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PacienteerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.VacunagroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VacunadataGridView)).BeginInit();
            this.SexogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PacienteerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // VacunagroupBox
            // 
            this.VacunagroupBox.Controls.Add(this.label7);
            this.VacunagroupBox.Controls.Add(this.groupBox2);
            this.VacunagroupBox.Controls.Add(this.VacunacomboBox);
            this.VacunagroupBox.Location = new System.Drawing.Point(13, 262);
            this.VacunagroupBox.Name = "VacunagroupBox";
            this.VacunagroupBox.Size = new System.Drawing.Size(509, 67);
            this.VacunagroupBox.TabIndex = 61;
            this.VacunagroupBox.TabStop = false;
            this.VacunagroupBox.Text = "Vacuna";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(227, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Vacuna:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NoradioButton);
            this.groupBox2.Controls.Add(this.SiradioButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 38);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EsUnica:";
            // 
            // NoradioButton
            // 
            this.NoradioButton.AutoSize = true;
            this.NoradioButton.Location = new System.Drawing.Point(83, 15);
            this.NoradioButton.Name = "NoradioButton";
            this.NoradioButton.Size = new System.Drawing.Size(39, 17);
            this.NoradioButton.TabIndex = 1;
            this.NoradioButton.TabStop = true;
            this.NoradioButton.Text = "No";
            this.NoradioButton.UseVisualStyleBackColor = true;
            // 
            // SiradioButton
            // 
            this.SiradioButton.AutoSize = true;
            this.SiradioButton.Location = new System.Drawing.Point(23, 16);
            this.SiradioButton.Name = "SiradioButton";
            this.SiradioButton.Size = new System.Drawing.Size(34, 17);
            this.SiradioButton.TabIndex = 0;
            this.SiradioButton.TabStop = true;
            this.SiradioButton.Text = "Si";
            this.SiradioButton.UseVisualStyleBackColor = true;
            // 
            // VacunacomboBox
            // 
            this.VacunacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VacunacomboBox.FormattingEnabled = true;
            this.VacunacomboBox.Location = new System.Drawing.Point(284, 36);
            this.VacunacomboBox.Name = "VacunacomboBox";
            this.VacunacomboBox.Size = new System.Drawing.Size(219, 21);
            this.VacunacomboBox.TabIndex = 1;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::VaccineControlSystem.Properties.Resources._1457049638_Search;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(242, 57);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(62, 65);
            this.Buscarbutton.TabIndex = 60;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(528, 303);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(72, 26);
            this.Agregarbutton.TabIndex = 7;
            this.Agregarbutton.TabStop = false;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Eliminarbutton.Image = global::VaccineControlSystem.Properties.Resources._1456880026_Delete;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(379, 541);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(62, 65);
            this.Eliminarbutton.TabIndex = 10;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Guardarbutton.Image = global::VaccineControlSystem.Properties.Resources._1456869956_Save;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(272, 541);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(62, 65);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Nuevobutton.Image = global::VaccineControlSystem.Properties.Resources._1456869972_Add;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(160, 541);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(62, 65);
            this.Nuevobutton.TabIndex = 8;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // EdadtextBox
            // 
            this.EdadtextBox.Location = new System.Drawing.Point(69, 219);
            this.EdadtextBox.Name = "EdadtextBox";
            this.EdadtextBox.Size = new System.Drawing.Size(87, 20);
            this.EdadtextBox.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 54;
            this.label8.Text = "Edad:";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(69, 90);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(157, 20);
            this.IdtextBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "ID:";
            // 
            // VacunadataGridView
            // 
            this.VacunadataGridView.AllowUserToAddRows = false;
            this.VacunadataGridView.AllowUserToOrderColumns = true;
            this.VacunadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VacunadataGridView.Location = new System.Drawing.Point(12, 335);
            this.VacunadataGridView.Name = "VacunadataGridView";
            this.VacunadataGridView.ReadOnly = true;
            this.VacunadataGridView.Size = new System.Drawing.Size(588, 193);
            this.VacunadataGridView.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 33);
            this.label3.TabIndex = 50;
            this.label3.Text = "Registro de Pacientes";
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(397, 219);
            this.TelefonomaskedTextBox.Mask = "(999) 000-0000";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(87, 20);
            this.TelefonomaskedTextBox.TabIndex = 6;
            // 
            // SexogroupBox
            // 
            this.SexogroupBox.Controls.Add(this.FemeninoradioButton);
            this.SexogroupBox.Controls.Add(this.MasculinoradioButton);
            this.SexogroupBox.Location = new System.Drawing.Point(397, 87);
            this.SexogroupBox.Name = "SexogroupBox";
            this.SexogroupBox.Size = new System.Drawing.Size(158, 35);
            this.SexogroupBox.TabIndex = 4;
            this.SexogroupBox.TabStop = false;
            this.SexogroupBox.Text = "Sexo:";
            // 
            // FemeninoradioButton
            // 
            this.FemeninoradioButton.AutoSize = true;
            this.FemeninoradioButton.Location = new System.Drawing.Point(85, 15);
            this.FemeninoradioButton.Name = "FemeninoradioButton";
            this.FemeninoradioButton.Size = new System.Drawing.Size(71, 17);
            this.FemeninoradioButton.TabIndex = 1;
            this.FemeninoradioButton.TabStop = true;
            this.FemeninoradioButton.Text = "Femenino";
            this.FemeninoradioButton.UseVisualStyleBackColor = true;
            // 
            // MasculinoradioButton
            // 
            this.MasculinoradioButton.AutoSize = true;
            this.MasculinoradioButton.Location = new System.Drawing.Point(6, 15);
            this.MasculinoradioButton.Name = "MasculinoradioButton";
            this.MasculinoradioButton.Size = new System.Drawing.Size(73, 17);
            this.MasculinoradioButton.TabIndex = 0;
            this.MasculinoradioButton.TabStop = true;
            this.MasculinoradioButton.Text = "Masculino";
            this.MasculinoradioButton.UseVisualStyleBackColor = true;
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(397, 135);
            this.DirecciontextBox.Multiline = true;
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(203, 60);
            this.DirecciontextBox.TabIndex = 5;
            // 
            // ApellidotextBox
            // 
            this.ApellidotextBox.Location = new System.Drawing.Point(69, 175);
            this.ApellidotextBox.Name = "ApellidotextBox";
            this.ApellidotextBox.Size = new System.Drawing.Size(235, 20);
            this.ApellidotextBox.TabIndex = 2;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(69, 135);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(234, 20);
            this.NombretextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nombre:";
            // 
            // PacienteerrorProvider
            // 
            this.PacienteerrorProvider.ContainerControl = this;
            // 
            // PacientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 618);
            this.Controls.Add(this.VacunagroupBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.EdadtextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VacunadataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TelefonomaskedTextBox);
            this.Controls.Add(this.SexogroupBox);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.ApellidotextBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PacientesForm";
            this.Text = "PacientesForm";
            this.VacunagroupBox.ResumeLayout(false);
            this.VacunagroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VacunadataGridView)).EndInit();
            this.SexogroupBox.ResumeLayout(false);
            this.SexogroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PacienteerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox VacunagroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton NoradioButton;
        private System.Windows.Forms.RadioButton SiradioButton;
        private System.Windows.Forms.ComboBox VacunacomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.TextBox EdadtextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView VacunadataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.GroupBox SexogroupBox;
        private System.Windows.Forms.RadioButton FemeninoradioButton;
        private System.Windows.Forms.RadioButton MasculinoradioButton;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.TextBox ApellidotextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider PacienteerrorProvider;
    }
}