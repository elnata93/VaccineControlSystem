﻿namespace VaccineControlSystem.Consultas
{
    partial class ConsultaHistorial
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
            this.Imprimir = new System.Windows.Forms.Button();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CamposcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConteotextBox = new System.Windows.Forms.TextBox();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Imprimir
            // 
            this.Imprimir.Location = new System.Drawing.Point(488, 335);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(75, 23);
            this.Imprimir.TabIndex = 57;
            this.Imprimir.Text = "Imprimir";
            this.Imprimir.UseVisualStyleBackColor = true;
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Location = new System.Drawing.Point(235, 33);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(226, 20);
            this.FiltrotextBox.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Filtrar Por";
            // 
            // CamposcomboBox
            // 
            this.CamposcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CamposcomboBox.FormattingEnabled = true;
            this.CamposcomboBox.Items.AddRange(new object[] {
            "PacienteId",
            "Nombres"});
            this.CamposcomboBox.Location = new System.Drawing.Point(97, 32);
            this.CamposcomboBox.Name = "CamposcomboBox";
            this.CamposcomboBox.Size = new System.Drawing.Size(121, 21);
            this.CamposcomboBox.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Conteo:";
            // 
            // ConteotextBox
            // 
            this.ConteotextBox.Location = new System.Drawing.Point(66, 336);
            this.ConteotextBox.Name = "ConteotextBox";
            this.ConteotextBox.ReadOnly = true;
            this.ConteotextBox.Size = new System.Drawing.Size(100, 20);
            this.ConteotextBox.TabIndex = 52;
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.AllowUserToAddRows = false;
            this.ConsultadataGridView.AllowUserToOrderColumns = true;
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(11, 59);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.ReadOnly = true;
            this.ConsultadataGridView.Size = new System.Drawing.Size(551, 274);
            this.ConsultadataGridView.TabIndex = 50;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::VaccineControlSystem.Properties.Resources._1459753068_Search;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(467, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(95, 41);
            this.BuscarButton.TabIndex = 51;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // ConsultaHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(573, 363);
            this.Controls.Add(this.Imprimir);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CamposcomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConteotextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.ConsultadataGridView);
            this.MaximizeBox = false;
            this.Name = "ConsultaHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaHistorial";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Imprimir;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CamposcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConteotextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
    }
}