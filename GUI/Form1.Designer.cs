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
            this.btnRegistrarMaterial = new System.Windows.Forms.Button();
            this.btnClasificados = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnMostrarCola = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Resgitrar1 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.grpRegistrar = new System.Windows.Forms.GroupBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpRegistrar.SuspendLayout();
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
            // btnRegistrarMaterial
            // 
            this.btnRegistrarMaterial.Location = new System.Drawing.Point(6, 29);
            this.btnRegistrarMaterial.Name = "btnRegistrarMaterial";
            this.btnRegistrarMaterial.Size = new System.Drawing.Size(178, 36);
            this.btnRegistrarMaterial.TabIndex = 1;
            this.btnRegistrarMaterial.Text = "Registrar Material";
            this.btnRegistrarMaterial.UseVisualStyleBackColor = true;
            this.btnRegistrarMaterial.Click += new System.EventHandler(this.btnRegistrarMaterial_Click);
            // 
            // btnClasificados
            // 
            this.btnClasificados.Location = new System.Drawing.Point(6, 183);
            this.btnClasificados.Name = "btnClasificados";
            this.btnClasificados.Size = new System.Drawing.Size(178, 36);
            this.btnClasificados.TabIndex = 2;
            this.btnClasificados.Text = "Mostrar Materiales Clasificados";
            this.btnClasificados.UseVisualStyleBackColor = true;
            this.btnClasificados.Click += new System.EventHandler(this.btnClasificados_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(6, 234);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(178, 36);
            this.btnHistorial.TabIndex = 3;
            this.btnHistorial.Text = "Mostrar Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnMostrarCola
            // 
            this.btnMostrarCola.Location = new System.Drawing.Point(6, 132);
            this.btnMostrarCola.Name = "btnMostrarCola";
            this.btnMostrarCola.Size = new System.Drawing.Size(178, 36);
            this.btnMostrarCola.TabIndex = 4;
            this.btnMostrarCola.Text = "Mostrar Cola de Materiales";
            this.btnMostrarCola.UseVisualStyleBackColor = true;
            this.btnMostrarCola.Click += new System.EventHandler(this.btnMostrarCola_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(6, 80);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(178, 36);
            this.btnProcesar.TabIndex = 5;
            this.btnProcesar.Text = "Procesar materiales";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrarMaterial);
            this.groupBox1.Controls.Add(this.btnHistorial);
            this.groupBox1.Controls.Add(this.btnMostrarCola);
            this.groupBox1.Controls.Add(this.btnProcesar);
            this.groupBox1.Controls.Add(this.btnClasificados);
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
            this.lbl_Resgitrar1.Location = new System.Drawing.Point(6, 26);
            this.lbl_Resgitrar1.Name = "lbl_Resgitrar1";
            this.lbl_Resgitrar1.Size = new System.Drawing.Size(211, 212);
            this.lbl_Resgitrar1.TabIndex = 7;
            this.lbl_Resgitrar1.Text = "Tipos de material disponibles:\r\n\r\n1. Plástico\r\n2. Vidrio\r\n3. Papel\r\n4. Metal\r\n\r\nI" +
    "ngrese el tipo de Material (1-4):\r\n\r\nIngrese el nombre del Material:\r\n";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(223, 145);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(68, 20);
            this.txtTipo.TabIndex = 8;
            // 
            // grpRegistrar
            // 
            this.grpRegistrar.Controls.Add(this.txtSalida);
            this.grpRegistrar.Controls.Add(this.btnRegistrar);
            this.grpRegistrar.Controls.Add(this.txtNombre);
            this.grpRegistrar.Controls.Add(this.lbl_Resgitrar1);
            this.grpRegistrar.Controls.Add(this.txtTipo);
            this.grpRegistrar.Location = new System.Drawing.Point(249, 65);
            this.grpRegistrar.Name = "grpRegistrar";
            this.grpRegistrar.Size = new System.Drawing.Size(385, 283);
            this.grpRegistrar.TabIndex = 9;
            this.grpRegistrar.TabStop = false;
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(0, -3);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ReadOnly = true;
            this.txtSalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSalida.Size = new System.Drawing.Size(385, 283);
            this.txtSalida.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(141, 228);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 38);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Confirmar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(223, 180);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(123, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(708, 389);
            this.Controls.Add(this.grpRegistrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.grpRegistrar.ResumeLayout(false);
            this.grpRegistrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarMaterial;
        private System.Windows.Forms.Button btnClasificados;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnMostrarCola;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Resgitrar1;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.GroupBox grpRegistrar;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

