namespace CentralitaPolimorfismo.WindowsForm
{
    partial class FrmPrincipal
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
            this.btnLLamada = new System.Windows.Forms.Button();
            this.btnFacturacionTotal = new System.Windows.Forms.Button();
            this.btnFacturacionLocal = new System.Windows.Forms.Button();
            this.btnFacturacionProvincial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLLamada
            // 
            this.btnLLamada.Location = new System.Drawing.Point(17, 22);
            this.btnLLamada.Name = "btnLLamada";
            this.btnLLamada.Size = new System.Drawing.Size(264, 62);
            this.btnLLamada.TabIndex = 0;
            this.btnLLamada.Text = "Generar Llamada";
            this.btnLLamada.UseVisualStyleBackColor = true;
            this.btnLLamada.Click += new System.EventHandler(this.btnLLamada_Click);
            // 
            // btnFacturacionTotal
            // 
            this.btnFacturacionTotal.Location = new System.Drawing.Point(17, 106);
            this.btnFacturacionTotal.Name = "btnFacturacionTotal";
            this.btnFacturacionTotal.Size = new System.Drawing.Size(264, 62);
            this.btnFacturacionTotal.TabIndex = 1;
            this.btnFacturacionTotal.Text = "Facturacion Total";
            this.btnFacturacionTotal.UseVisualStyleBackColor = true;
            this.btnFacturacionTotal.Click += new System.EventHandler(this.btnFacturacionTotal_Click);
            // 
            // btnFacturacionLocal
            // 
            this.btnFacturacionLocal.Location = new System.Drawing.Point(17, 189);
            this.btnFacturacionLocal.Name = "btnFacturacionLocal";
            this.btnFacturacionLocal.Size = new System.Drawing.Size(264, 62);
            this.btnFacturacionLocal.TabIndex = 2;
            this.btnFacturacionLocal.Text = "Facturacion Local";
            this.btnFacturacionLocal.UseVisualStyleBackColor = true;
            this.btnFacturacionLocal.Click += new System.EventHandler(this.btnFacturacionLocal_Click);
            // 
            // btnFacturacionProvincial
            // 
            this.btnFacturacionProvincial.Location = new System.Drawing.Point(17, 272);
            this.btnFacturacionProvincial.Name = "btnFacturacionProvincial";
            this.btnFacturacionProvincial.Size = new System.Drawing.Size(264, 62);
            this.btnFacturacionProvincial.TabIndex = 3;
            this.btnFacturacionProvincial.Text = "Facturacion Provincial";
            this.btnFacturacionProvincial.UseVisualStyleBackColor = true;
            this.btnFacturacionProvincial.Click += new System.EventHandler(this.btnFacturacionProvincial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(17, 359);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(264, 62);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 438);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacturacionProvincial);
            this.Controls.Add(this.btnFacturacionLocal);
            this.Controls.Add(this.btnFacturacionTotal);
            this.Controls.Add(this.btnLLamada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefonica";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLLamada;
        private System.Windows.Forms.Button btnFacturacionTotal;
        private System.Windows.Forms.Button btnFacturacionLocal;
        private System.Windows.Forms.Button btnFacturacionProvincial;
        private System.Windows.Forms.Button btnSalir;
    }
}

