namespace GUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btton_RegistrarMaterial = new System.Windows.Forms.Button();
            this.bttn_MostrarMaterialesClasificados = new System.Windows.Forms.Button();
            this.bttn_MostrarHistorial = new System.Windows.Forms.Button();
            this.bttn_MostrarColaDeMateriales = new System.Windows.Forms.Button();
            this.bttn_ProcesarMateriales = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Resgitrar1 = new System.Windows.Forms.Label();
            this.txtBox_TipoMaterial = new System.Windows.Forms.TextBox();
            this.grpRegistrar1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.grpRegistrar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE RECICLAJE";
            // 
            // btton_RegistrarMaterial
            // 
            this.btton_RegistrarMaterial.Location = new System.Drawing.Point(6, 29);
            this.btton_RegistrarMaterial.Name = "btton_RegistrarMaterial";
            this.btton_RegistrarMaterial.Size = new System.Drawing.Size(178, 36);
            this.btton_RegistrarMaterial.TabIndex = 1;
            this.btton_RegistrarMaterial.Text = "Registrar Material";
            this.btton_RegistrarMaterial.UseVisualStyleBackColor = true;
            this.btton_RegistrarMaterial.Click += new System.EventHandler(this.btton_RegistrarMaterial_Click);
            // 
            // bttn_MostrarMaterialesClasificados
            // 
            this.bttn_MostrarMaterialesClasificados.Location = new System.Drawing.Point(6, 183);
            this.bttn_MostrarMaterialesClasificados.Name = "bttn_MostrarMaterialesClasificados";
            this.bttn_MostrarMaterialesClasificados.Size = new System.Drawing.Size(178, 36);
            this.bttn_MostrarMaterialesClasificados.TabIndex = 2;
            this.bttn_MostrarMaterialesClasificados.Text = "Mostrar Materiales Clasificados";
            this.bttn_MostrarMaterialesClasificados.UseVisualStyleBackColor = true;
            // 
            // bttn_MostrarHistorial
            // 
            this.bttn_MostrarHistorial.Location = new System.Drawing.Point(6, 234);
            this.bttn_MostrarHistorial.Name = "bttn_MostrarHistorial";
            this.bttn_MostrarHistorial.Size = new System.Drawing.Size(178, 36);
            this.bttn_MostrarHistorial.TabIndex = 3;
            this.bttn_MostrarHistorial.Text = "Mostrar Historial";
            this.bttn_MostrarHistorial.UseVisualStyleBackColor = true;
            // 
            // bttn_MostrarColaDeMateriales
            // 
            this.bttn_MostrarColaDeMateriales.Location = new System.Drawing.Point(6, 132);
            this.bttn_MostrarColaDeMateriales.Name = "bttn_MostrarColaDeMateriales";
            this.bttn_MostrarColaDeMateriales.Size = new System.Drawing.Size(178, 36);
            this.bttn_MostrarColaDeMateriales.TabIndex = 4;
            this.bttn_MostrarColaDeMateriales.Text = "Mostrar Cola de Materiales";
            this.bttn_MostrarColaDeMateriales.UseVisualStyleBackColor = true;
            // 
            // bttn_ProcesarMateriales
            // 
            this.bttn_ProcesarMateriales.Location = new System.Drawing.Point(6, 80);
            this.bttn_ProcesarMateriales.Name = "bttn_ProcesarMateriales";
            this.bttn_ProcesarMateriales.Size = new System.Drawing.Size(178, 36);
            this.bttn_ProcesarMateriales.TabIndex = 5;
            this.bttn_ProcesarMateriales.Text = "Procesar materiales";
            this.bttn_ProcesarMateriales.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btton_RegistrarMaterial);
            this.groupBox1.Controls.Add(this.bttn_MostrarHistorial);
            this.groupBox1.Controls.Add(this.bttn_MostrarColaDeMateriales);
            this.groupBox1.Controls.Add(this.bttn_ProcesarMateriales);
            this.groupBox1.Controls.Add(this.bttn_MostrarMaterialesClasificados);
            this.groupBox1.Location = new System.Drawing.Point(42, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 286);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPCIONES";
            // 
            // lbl_Resgitrar1
            // 
            this.lbl_Resgitrar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_Resgitrar1.Location = new System.Drawing.Point(6, 16);
            this.lbl_Resgitrar1.Name = "lbl_Resgitrar1";
            this.lbl_Resgitrar1.Size = new System.Drawing.Size(342, 212);
            this.lbl_Resgitrar1.TabIndex = 7;
            this.lbl_Resgitrar1.Text = "                        REGISTRAR NUEVO MATERIAL\r\n Tipos disponibles:\r\n\r\n1. Plást" +
    "ico\r\n\r\n2. Vidrio\r\n\r\n3. Papel\r\n\r\n4. Metal\r\n\r\nIngrese el tipo de Material (1-4)\r\n";
            // 
            // txtBox_TipoMaterial
            // 
            this.txtBox_TipoMaterial.Location = new System.Drawing.Point(9, 234);
            this.txtBox_TipoMaterial.Name = "txtBox_TipoMaterial";
            this.txtBox_TipoMaterial.Size = new System.Drawing.Size(68, 20);
            this.txtBox_TipoMaterial.TabIndex = 8;
            // 
            // grpRegistrar1
            // 
            this.grpRegistrar1.Controls.Add(this.lbl_Resgitrar1);
            this.grpRegistrar1.Controls.Add(this.txtBox_TipoMaterial);
            this.grpRegistrar1.Location = new System.Drawing.Point(288, 65);
            this.grpRegistrar1.Name = "grpRegistrar1";
            this.grpRegistrar1.Size = new System.Drawing.Size(385, 283);
            this.grpRegistrar1.TabIndex = 9;
            this.grpRegistrar1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(757, 389);
            this.Controls.Add(this.grpRegistrar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.grpRegistrar1.ResumeLayout(false);
            this.grpRegistrar1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btton_RegistrarMaterial;
        private System.Windows.Forms.Button bttn_MostrarMaterialesClasificados;
        private System.Windows.Forms.Button bttn_MostrarHistorial;
        private System.Windows.Forms.Button bttn_MostrarColaDeMateriales;
        private System.Windows.Forms.Button bttn_ProcesarMateriales;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Resgitrar1;
        private System.Windows.Forms.TextBox txtBox_TipoMaterial;
        private System.Windows.Forms.GroupBox grpRegistrar1;
    }
}

