namespace VaccineControlSystem.Registros
{
    partial class HistorialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialForm));
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CentroSaludtextBox = new System.Windows.Forms.TextBox();
            this.ProvinciatextBox = new System.Windows.Forms.TextBox();
            this.MunicipiotextBox = new System.Windows.Forms.TextBox();
            this.PacientescomboBox = new System.Windows.Forms.ComboBox();
            this.DosisvacunacomboBox = new System.Windows.Forms.ComboBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.FechaVacunadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HistorialVacunadataGridView = new System.Windows.Forms.DataGridView();
            this.PacienteVacunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VacunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombresVacunas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.VacunaPacientecomboBox = new System.Windows.Forms.ComboBox();
            this.FechaHistorialdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.HistorialPacienteerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.HistorialVacunadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistorialPacienteerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::VaccineControlSystem.Properties.Resources._1459753052_Add;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(150, 521);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(51, 50);
            this.Nuevobutton.TabIndex = 10;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::VaccineControlSystem.Properties.Resources._1459753117_Save;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(275, 521);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(55, 50);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::VaccineControlSystem.Properties.Resources._1459753062_Delete;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(394, 521);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(51, 50);
            this.Eliminarbutton.TabIndex = 12;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::VaccineControlSystem.Properties.Resources._1459753068_Search;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(227, 65);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(49, 47);
            this.Buscarbutton.TabIndex = 13;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(101, 88);
            this.IdtextBox.MaxLength = 10;
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(100, 20);
            this.IdtextBox.TabIndex = 1;
            this.IdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdtextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Centro de Salud:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Provincia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Municipio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID del Paciente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dosis de Vacuna:";
            // 
            // CentroSaludtextBox
            // 
            this.CentroSaludtextBox.Location = new System.Drawing.Point(101, 130);
            this.CentroSaludtextBox.MaxLength = 50;
            this.CentroSaludtextBox.Name = "CentroSaludtextBox";
            this.CentroSaludtextBox.Size = new System.Drawing.Size(532, 20);
            this.CentroSaludtextBox.TabIndex = 2;
            this.CentroSaludtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CentroSaludtextBox_KeyPress);
            // 
            // ProvinciatextBox
            // 
            this.ProvinciatextBox.Location = new System.Drawing.Point(101, 172);
            this.ProvinciatextBox.MaxLength = 50;
            this.ProvinciatextBox.Name = "ProvinciatextBox";
            this.ProvinciatextBox.Size = new System.Drawing.Size(532, 20);
            this.ProvinciatextBox.TabIndex = 3;
            this.ProvinciatextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProvinciatextBox_KeyPress);
            // 
            // MunicipiotextBox
            // 
            this.MunicipiotextBox.Location = new System.Drawing.Point(101, 214);
            this.MunicipiotextBox.MaxLength = 50;
            this.MunicipiotextBox.Name = "MunicipiotextBox";
            this.MunicipiotextBox.Size = new System.Drawing.Size(532, 20);
            this.MunicipiotextBox.TabIndex = 4;
            this.MunicipiotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MunicipiotextBox_KeyPress);
            // 
            // PacientescomboBox
            // 
            this.PacientescomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PacientescomboBox.FormattingEnabled = true;
            this.PacientescomboBox.Location = new System.Drawing.Point(101, 256);
            this.PacientescomboBox.Name = "PacientescomboBox";
            this.PacientescomboBox.Size = new System.Drawing.Size(175, 21);
            this.PacientescomboBox.TabIndex = 5;
            // 
            // DosisvacunacomboBox
            // 
            this.DosisvacunacomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DosisvacunacomboBox.FormattingEnabled = true;
            this.DosisvacunacomboBox.Items.AddRange(new object[] {
            "Primera Dosis",
            "Segunda Dosis",
            "Tercera Dosis",
            "Primer Refuerzo",
            "Segundo Refuerzo"});
            this.DosisvacunacomboBox.Location = new System.Drawing.Point(101, 302);
            this.DosisvacunacomboBox.Name = "DosisvacunacomboBox";
            this.DosisvacunacomboBox.Size = new System.Drawing.Size(175, 21);
            this.DosisvacunacomboBox.TabIndex = 8;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(538, 300);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(95, 23);
            this.Addbutton.TabIndex = 9;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fecha de Vacuna:";
            // 
            // FechaVacunadateTimePicker
            // 
            this.FechaVacunadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaVacunadateTimePicker.Location = new System.Drawing.Point(419, 303);
            this.FechaVacunadateTimePicker.Name = "FechaVacunadateTimePicker";
            this.FechaVacunadateTimePicker.Size = new System.Drawing.Size(102, 20);
            this.FechaVacunadateTimePicker.TabIndex = 7;
            // 
            // HistorialVacunadataGridView
            // 
            this.HistorialVacunadataGridView.AllowUserToAddRows = false;
            this.HistorialVacunadataGridView.AllowUserToOrderColumns = true;
            this.HistorialVacunadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistorialVacunadataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PacienteVacunaId,
            this.VacunaId,
            this.NombresVacunas,
            this.Dosis,
            this.FechaVacuna});
            this.HistorialVacunadataGridView.Location = new System.Drawing.Point(12, 354);
            this.HistorialVacunadataGridView.Name = "HistorialVacunadataGridView";
            this.HistorialVacunadataGridView.ReadOnly = true;
            this.HistorialVacunadataGridView.Size = new System.Drawing.Size(621, 151);
            this.HistorialVacunadataGridView.TabIndex = 28;
            // 
            // PacienteVacunaId
            // 
            this.PacienteVacunaId.HeaderText = "PacienteVacunaId";
            this.PacienteVacunaId.Name = "PacienteVacunaId";
            this.PacienteVacunaId.ReadOnly = true;
            // 
            // VacunaId
            // 
            this.VacunaId.HeaderText = "VacunaId";
            this.VacunaId.Name = "VacunaId";
            this.VacunaId.ReadOnly = true;
            // 
            // NombresVacunas
            // 
            this.NombresVacunas.HeaderText = "NombresVacunas";
            this.NombresVacunas.Name = "NombresVacunas";
            this.NombresVacunas.ReadOnly = true;
            // 
            // Dosis
            // 
            this.Dosis.HeaderText = "Dosis";
            this.Dosis.Name = "Dosis";
            this.Dosis.ReadOnly = true;
            // 
            // FechaVacuna
            // 
            this.FechaVacuna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaVacuna.HeaderText = "FechaVacuna";
            this.FechaVacuna.Name = "FechaVacuna";
            this.FechaVacuna.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Vacunas del Paciente:";
            // 
            // VacunaPacientecomboBox
            // 
            this.VacunaPacientecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VacunaPacientecomboBox.FormattingEnabled = true;
            this.VacunaPacientecomboBox.Location = new System.Drawing.Point(419, 256);
            this.VacunaPacientecomboBox.Name = "VacunaPacientecomboBox";
            this.VacunaPacientecomboBox.Size = new System.Drawing.Size(214, 21);
            this.VacunaPacientecomboBox.TabIndex = 6;
            // 
            // FechaHistorialdateTimePicker
            // 
            this.FechaHistorialdateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.FechaHistorialdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaHistorialdateTimePicker.Location = new System.Drawing.Point(538, 84);
            this.FechaHistorialdateTimePicker.Name = "FechaHistorialdateTimePicker";
            this.FechaHistorialdateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.FechaHistorialdateTimePicker.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(181, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 31);
            this.label9.TabIndex = 30;
            this.label9.Text = "Historial del Paciente";
            // 
            // HistorialPacienteerrorProvider
            // 
            this.HistorialPacienteerrorProvider.ContainerControl = this;
            // 
            // HistorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(645, 583);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FechaHistorialdateTimePicker);
            this.Controls.Add(this.VacunaPacientecomboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HistorialVacunadataGridView);
            this.Controls.Add(this.FechaVacunadateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.DosisvacunacomboBox);
            this.Controls.Add(this.PacientescomboBox);
            this.Controls.Add(this.MunicipiotextBox);
            this.Controls.Add(this.ProvinciatextBox);
            this.Controls.Add(this.CentroSaludtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HistorialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de Pacientes";
            this.Load += new System.EventHandler(this.HistorialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HistorialVacunadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistorialPacienteerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CentroSaludtextBox;
        private System.Windows.Forms.TextBox ProvinciatextBox;
        private System.Windows.Forms.TextBox MunicipiotextBox;
        private System.Windows.Forms.ComboBox PacientescomboBox;
        private System.Windows.Forms.ComboBox DosisvacunacomboBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker FechaVacunadateTimePicker;
        private System.Windows.Forms.DataGridView HistorialVacunadataGridView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox VacunaPacientecomboBox;
        private System.Windows.Forms.DateTimePicker FechaHistorialdateTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider HistorialPacienteerrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombresVacunas;
        private System.Windows.Forms.DataGridViewTextBoxColumn VacunaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacienteVacunaId;
    }
}