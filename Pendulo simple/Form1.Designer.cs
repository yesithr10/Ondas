namespace Pendulo_simple
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
            this.Datos = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.txtOscilaciones = new System.Windows.Forms.TextBox();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.TxtLongitud = new System.Windows.Forms.TextBox();
            this.gradosLbl = new System.Windows.Forms.Label();
            this.OscilacionesLbl = new System.Windows.Forms.Label();
            this.masaLbl = new System.Windows.Forms.Label();
            this.longitudLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrecuencia = new System.Windows.Forms.TextBox();
            this.txtGravedad = new System.Windows.Forms.TextBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.txtEmail);
            this.Datos.Controls.Add(this.label4);
            this.Datos.Controls.Add(this.txtTiempo);
            this.Datos.Controls.Add(this.lblTiempo);
            this.Datos.Controls.Add(this.txtOscilaciones);
            this.Datos.Controls.Add(this.txtMasa);
            this.Datos.Controls.Add(this.TxtLongitud);
            this.Datos.Controls.Add(this.gradosLbl);
            this.Datos.Controls.Add(this.OscilacionesLbl);
            this.Datos.Controls.Add(this.masaLbl);
            this.Datos.Controls.Add(this.longitudLbl);
            this.Datos.Location = new System.Drawing.Point(75, 62);
            this.Datos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(333, 403);
            this.Datos.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(150, 340);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 26);
            this.txtEmail.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 345);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email: ";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(150, 275);
            this.txtTiempo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(148, 26);
            this.txtTiempo.TabIndex = 9;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(36, 280);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(65, 20);
            this.lblTiempo.TabIndex = 8;
            this.lblTiempo.Text = "Tiempo:";
            // 
            // txtOscilaciones
            // 
            this.txtOscilaciones.Location = new System.Drawing.Point(149, 204);
            this.txtOscilaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOscilaciones.Name = "txtOscilaciones";
            this.txtOscilaciones.Size = new System.Drawing.Size(148, 26);
            this.txtOscilaciones.TabIndex = 6;
            // 
            // txtMasa
            // 
            this.txtMasa.Location = new System.Drawing.Point(149, 134);
            this.txtMasa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(148, 26);
            this.txtMasa.TabIndex = 5;
            // 
            // TxtLongitud
            // 
            this.TxtLongitud.Location = new System.Drawing.Point(149, 67);
            this.TxtLongitud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtLongitud.Name = "TxtLongitud";
            this.TxtLongitud.Size = new System.Drawing.Size(148, 26);
            this.TxtLongitud.TabIndex = 4;
            // 
            // gradosLbl
            // 
            this.gradosLbl.AutoSize = true;
            this.gradosLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradosLbl.Location = new System.Drawing.Point(106, 0);
            this.gradosLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gradosLbl.Name = "gradosLbl";
            this.gradosLbl.Size = new System.Drawing.Size(111, 20);
            this.gradosLbl.TabIndex = 3;
            this.gradosLbl.Text = "10 GRADOS";
            // 
            // OscilacionesLbl
            // 
            this.OscilacionesLbl.AutoSize = true;
            this.OscilacionesLbl.Location = new System.Drawing.Point(36, 207);
            this.OscilacionesLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OscilacionesLbl.Name = "OscilacionesLbl";
            this.OscilacionesLbl.Size = new System.Drawing.Size(106, 20);
            this.OscilacionesLbl.TabIndex = 2;
            this.OscilacionesLbl.Text = "Oscilaciones: ";
            // 
            // masaLbl
            // 
            this.masaLbl.AutoSize = true;
            this.masaLbl.Location = new System.Drawing.Point(36, 137);
            this.masaLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.masaLbl.Name = "masaLbl";
            this.masaLbl.Size = new System.Drawing.Size(56, 20);
            this.masaLbl.TabIndex = 1;
            this.masaLbl.Text = "Masa: ";
            // 
            // longitudLbl
            // 
            this.longitudLbl.AutoSize = true;
            this.longitudLbl.Location = new System.Drawing.Point(36, 70);
            this.longitudLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.longitudLbl.Name = "longitudLbl";
            this.longitudLbl.Size = new System.Drawing.Size(79, 20);
            this.longitudLbl.TabIndex = 0;
            this.longitudLbl.Text = "Longitud: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 495);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "FRECUENCIA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 552);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "GRAVEDAD:";
            // 
            // txtFrecuencia
            // 
            this.txtFrecuencia.Location = new System.Drawing.Point(225, 491);
            this.txtFrecuencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFrecuencia.Name = "txtFrecuencia";
            this.txtFrecuencia.Size = new System.Drawing.Size(148, 26);
            this.txtFrecuencia.TabIndex = 10;
            // 
            // txtGravedad
            // 
            this.txtGravedad.Location = new System.Drawing.Point(225, 542);
            this.txtGravedad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGravedad.Name = "txtGravedad";
            this.txtGravedad.Size = new System.Drawing.Size(148, 26);
            this.txtGravedad.TabIndex = 11;
            // 
            // btnImportar
            // 
            this.btnImportar.Image = global::Pendulo_simple.Properties.Resources.ic_send_128_28719;
            this.btnImportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImportar.Location = new System.Drawing.Point(267, 614);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(141, 109);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Text = "IMPORTAR";
            this.btnImportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = global::Pendulo_simple.Properties.Resources.Calculator_31111;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalcular.Location = new System.Drawing.Point(75, 614);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(141, 109);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 775);
            this.Controls.Add(this.txtGravedad);
            this.Controls.Add(this.txtFrecuencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Datos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Datos;
        private System.Windows.Forms.TextBox txtOscilaciones;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.TextBox TxtLongitud;
        private System.Windows.Forms.Label gradosLbl;
        private System.Windows.Forms.Label OscilacionesLbl;
        private System.Windows.Forms.Label masaLbl;
        private System.Windows.Forms.Label longitudLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFrecuencia;
        private System.Windows.Forms.TextBox txtGravedad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
    }
}

