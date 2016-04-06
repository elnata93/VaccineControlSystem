namespace VaccineControlSystem
{
    partial class VaccineControlSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaccineControlSystem));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSeccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciudadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciudadesConsultasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunaConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesConsultasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.historialConsultasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripLabel();
            this.CiudadestoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UsuariostoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.VacunastoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PacientestoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.HistorialtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.registToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirToolStripMenuItem,
            this.cerrarSeccionToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.fileToolStripMenuItem.Text = "&Archivos";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // cerrarSeccionToolStripMenuItem
            // 
            this.cerrarSeccionToolStripMenuItem.Name = "cerrarSeccionToolStripMenuItem";
            this.cerrarSeccionToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.cerrarSeccionToolStripMenuItem.Text = "Cerrar Seccion";
            this.cerrarSeccionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSeccionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(173, 24);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ciudadesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.vacunasToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.editToolStripMenuItem.Text = "&Registros";
            // 
            // ciudadesToolStripMenuItem
            // 
            this.ciudadesToolStripMenuItem.Name = "ciudadesToolStripMenuItem";
            this.ciudadesToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.ciudadesToolStripMenuItem.Text = "Ciudades";
            this.ciudadesToolStripMenuItem.Click += new System.EventHandler(this.ciudadesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // vacunasToolStripMenuItem
            // 
            this.vacunasToolStripMenuItem.Name = "vacunasToolStripMenuItem";
            this.vacunasToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.vacunasToolStripMenuItem.Text = "Vacunas";
            this.vacunasToolStripMenuItem.Click += new System.EventHandler(this.vacunasToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // registToolStripMenuItem
            // 
            this.registToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosConsultasToolStripMenuItem,
            this.ciudadesConsultasToolStripMenuItem1,
            this.vacunaConsultasToolStripMenuItem,
            this.pacientesConsultasToolStripMenuItem1,
            this.historialConsultasToolStripMenuItem1});
            this.registToolStripMenuItem.Name = "registToolStripMenuItem";
            this.registToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.registToolStripMenuItem.Text = "&Consultas";
            // 
            // usuariosConsultasToolStripMenuItem
            // 
            this.usuariosConsultasToolStripMenuItem.Name = "usuariosConsultasToolStripMenuItem";
            this.usuariosConsultasToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.usuariosConsultasToolStripMenuItem.Text = "&Usuarios";
            this.usuariosConsultasToolStripMenuItem.Click += new System.EventHandler(this.ConsultaUsuariosToolStripMenuItem_Click);
            // 
            // ciudadesConsultasToolStripMenuItem1
            // 
            this.ciudadesConsultasToolStripMenuItem1.Name = "ciudadesConsultasToolStripMenuItem1";
            this.ciudadesConsultasToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.ciudadesConsultasToolStripMenuItem1.Text = "&Ciudades";
            this.ciudadesConsultasToolStripMenuItem1.Click += new System.EventHandler(this.ciudadesToolStripMenuItem1_Click);
            // 
            // vacunaConsultasToolStripMenuItem
            // 
            this.vacunaConsultasToolStripMenuItem.Name = "vacunaConsultasToolStripMenuItem";
            this.vacunaConsultasToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.vacunaConsultasToolStripMenuItem.Text = "&Vacunas";
            this.vacunaConsultasToolStripMenuItem.Click += new System.EventHandler(this.vacunaToolStripMenuItem_Click);
            // 
            // pacientesConsultasToolStripMenuItem1
            // 
            this.pacientesConsultasToolStripMenuItem1.Name = "pacientesConsultasToolStripMenuItem1";
            this.pacientesConsultasToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.pacientesConsultasToolStripMenuItem1.Text = "&Pacientes";
            this.pacientesConsultasToolStripMenuItem1.Click += new System.EventHandler(this.pacientesToolStripMenuItem1_Click);
            // 
            // historialConsultasToolStripMenuItem1
            // 
            this.historialConsultasToolStripMenuItem1.Name = "historialConsultasToolStripMenuItem1";
            this.historialConsultasToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.historialConsultasToolStripMenuItem1.Text = "Historial";
            this.historialConsultasToolStripMenuItem1.Click += new System.EventHandler(this.historialConsultasToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.helpToolStripMenuItem.Text = "&Ayuda";
            // 
            // acercaToolStripMenuItem
            // 
            this.acercaToolStripMenuItem.Name = "acercaToolStripMenuItem";
            this.acercaToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.acercaToolStripMenuItem.Text = "Acerca de VCS";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(23, 23);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.CiudadestoolStripButton,
            this.UsuariostoolStripButton,
            this.VacunastoolStripButton,
            this.PacientestoolStripButton,
            this.HistorialtoolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1026, 30);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(0, 27);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // CiudadestoolStripButton
            // 
            this.CiudadestoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CiudadestoolStripButton.Image = global::VaccineControlSystem.Properties.Resources.app_type_tourist_512px_GREY_converted;
            this.CiudadestoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CiudadestoolStripButton.Name = "CiudadestoolStripButton";
            this.CiudadestoolStripButton.Size = new System.Drawing.Size(27, 27);
            this.CiudadestoolStripButton.Text = "toolStripButton3";
            this.CiudadestoolStripButton.ToolTipText = "Ciudades";
            this.CiudadestoolStripButton.Click += new System.EventHandler(this.CiudadestoolStripButton_Click);
            // 
            // UsuariostoolStripButton
            // 
            this.UsuariostoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UsuariostoolStripButton.Image = global::VaccineControlSystem.Properties.Resources.o_9f484807f4d727cd_3;
            this.UsuariostoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UsuariostoolStripButton.Name = "UsuariostoolStripButton";
            this.UsuariostoolStripButton.Size = new System.Drawing.Size(27, 27);
            this.UsuariostoolStripButton.Text = "toolStripButton6";
            this.UsuariostoolStripButton.ToolTipText = "Usuarios";
            this.UsuariostoolStripButton.Click += new System.EventHandler(this.UsuariostoolStripButton_Click);
            // 
            // VacunastoolStripButton
            // 
            this.VacunastoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VacunastoolStripButton.Image = global::VaccineControlSystem.Properties.Resources.medicine_jar;
            this.VacunastoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VacunastoolStripButton.Name = "VacunastoolStripButton";
            this.VacunastoolStripButton.Size = new System.Drawing.Size(27, 27);
            this.VacunastoolStripButton.Text = "toolStripButton4";
            this.VacunastoolStripButton.ToolTipText = "Vacunas";
            this.VacunastoolStripButton.Click += new System.EventHandler(this.VacunastoolStripButton_Click);
            // 
            // PacientestoolStripButton
            // 
            this.PacientestoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PacientestoolStripButton.Image = global::VaccineControlSystem.Properties.Resources.o_eab4bbccb0a5c0a4_5;
            this.PacientestoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PacientestoolStripButton.Name = "PacientestoolStripButton";
            this.PacientestoolStripButton.Size = new System.Drawing.Size(27, 27);
            this.PacientestoolStripButton.Text = "toolStripButton2";
            this.PacientestoolStripButton.ToolTipText = "Pacientes";
            this.PacientestoolStripButton.Click += new System.EventHandler(this.PacientestoolStripButton_Click);
            // 
            // HistorialtoolStripButton
            // 
            this.HistorialtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HistorialtoolStripButton.Image = global::VaccineControlSystem.Properties.Resources.Order_online_offer_cart_shopping;
            this.HistorialtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HistorialtoolStripButton.Name = "HistorialtoolStripButton";
            this.HistorialtoolStripButton.Size = new System.Drawing.Size(27, 27);
            this.HistorialtoolStripButton.Text = "Historial";
            this.HistorialtoolStripButton.ToolTipText = "Historial";
            this.HistorialtoolStripButton.Click += new System.EventHandler(this.HistorialtoolStripButton_Click);
            // 
            // VaccineControlSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1026, 649);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VaccineControlSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vaccine Control System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VaccineControlSystem_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosConsultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSeccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciudadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ciudadesConsultasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vacunaConsultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesConsultasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem historialConsultasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton CiudadestoolStripButton;
        private System.Windows.Forms.ToolStripButton PacientestoolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripButton1;
        private System.Windows.Forms.ToolStripButton UsuariostoolStripButton;
        private System.Windows.Forms.ToolStripButton VacunastoolStripButton;
        private System.Windows.Forms.ToolStripButton HistorialtoolStripButton;
        private System.Windows.Forms.ToolStripMenuItem acercaToolStripMenuItem;
    }
}

