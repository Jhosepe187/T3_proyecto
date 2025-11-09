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
            this.btnRegistrarMaterial = new System.Windows.Forms.Button();
            this.btnClasificados = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnMostrarCola = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lbl_Resgitrar1 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.grpRegistrar = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.grpRegistrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrarMaterial
            // 
            this.btnRegistrarMaterial.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarMaterial.BackgroundImage = global::GUI.Properties.Resources.Texto__1_;
            this.btnRegistrarMaterial.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnRegistrarMaterial.FlatAppearance.BorderSize = 0;
            this.btnRegistrarMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarMaterial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarMaterial.Location = new System.Drawing.Point(270, 413);
            this.btnRegistrarMaterial.Name = "btnRegistrarMaterial";
            this.btnRegistrarMaterial.Size = new System.Drawing.Size(118, 34);
            this.btnRegistrarMaterial.TabIndex = 1;
            this.btnRegistrarMaterial.Text = "Registrar Material";
            this.btnRegistrarMaterial.UseVisualStyleBackColor = false;
            this.btnRegistrarMaterial.Click += new System.EventHandler(this.btnRegistrarMaterial_Click);
            // 
            // btnClasificados
            // 
            this.btnClasificados.BackgroundImage = global::GUI.Properties.Resources.Texto__1_;
            this.btnClasificados.FlatAppearance.BorderSize = 0;
            this.btnClasificados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClasificados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasificados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClasificados.Location = new System.Drawing.Point(340, 470);
            this.btnClasificados.Name = "btnClasificados";
            this.btnClasificados.Size = new System.Drawing.Size(119, 34);
            this.btnClasificados.TabIndex = 2;
            this.btnClasificados.Text = "Mostrar Materiales Clasificados";
            this.btnClasificados.UseVisualStyleBackColor = true;
            this.btnClasificados.Click += new System.EventHandler(this.btnClasificados_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackgroundImage = global::GUI.Properties.Resources.Texto__1_;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHistorial.Location = new System.Drawing.Point(515, 470);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(112, 29);
            this.btnHistorial.TabIndex = 3;
            this.btnHistorial.Text = "Mostrar Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnMostrarCola
            // 
            this.btnMostrarCola.BackgroundImage = global::GUI.Properties.Resources.Texto__1_;
            this.btnMostrarCola.FlatAppearance.BorderSize = 0;
            this.btnMostrarCola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarCola.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMostrarCola.Location = new System.Drawing.Point(586, 413);
            this.btnMostrarCola.Name = "btnMostrarCola";
            this.btnMostrarCola.Size = new System.Drawing.Size(122, 34);
            this.btnMostrarCola.TabIndex = 4;
            this.btnMostrarCola.Text = "Mostrar Cola de Materiales";
            this.btnMostrarCola.UseVisualStyleBackColor = true;
            this.btnMostrarCola.Click += new System.EventHandler(this.btnMostrarCola_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.Color.Transparent;
            this.btnProcesar.BackgroundImage = global::GUI.Properties.Resources.Texto__1_;
            this.btnProcesar.FlatAppearance.BorderSize = 0;
            this.btnProcesar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProcesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcesar.Location = new System.Drawing.Point(423, 415);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(127, 29);
            this.btnProcesar.TabIndex = 5;
            this.btnProcesar.Text = "Procesar materiales";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lbl_Resgitrar1
            // 
            this.lbl_Resgitrar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_Resgitrar1.Location = new System.Drawing.Point(6, 29);
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
            this.grpRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.grpRegistrar.BackgroundImage = global::GUI.Properties.Resources.Texto__1_;
            this.grpRegistrar.Controls.Add(this.btnRegistrar);
            this.grpRegistrar.Controls.Add(this.txtNombre);
            this.grpRegistrar.Controls.Add(this.lbl_Resgitrar1);
            this.grpRegistrar.Controls.Add(this.txtTipo);
            this.grpRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpRegistrar.Location = new System.Drawing.Point(299, 91);
            this.grpRegistrar.Name = "grpRegistrar";
            this.grpRegistrar.Size = new System.Drawing.Size(385, 274);
            this.grpRegistrar.TabIndex = 9;
            this.grpRegistrar.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrar.Location = new System.Drawing.Point(131, 220);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 38);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Confirmar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(223, 180);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(123, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtSalida
            // 
            this.txtSalida.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalida.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.Location = new System.Drawing.Point(270, 101);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ReadOnly = true;
            this.txtSalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSalida.Size = new System.Drawing.Size(438, 231);
            this.txtSalida.TabIndex = 10;
            this.txtSalida.TextChanged += new System.EventHandler(this.txtSalida_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::GUI.Properties.Resources.Texto__2_;
            this.ClientSize = new System.Drawing.Size(968, 583);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnRegistrarMaterial);
            this.Controls.Add(this.btnClasificados);
            this.Controls.Add(this.btnMostrarCola);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.grpRegistrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpRegistrar.ResumeLayout(false);
            this.grpRegistrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrarMaterial;
        private System.Windows.Forms.Button btnClasificados;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnMostrarCola;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lbl_Resgitrar1;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.GroupBox grpRegistrar;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombre;
    }
}

