
namespace _20201203
{
    partial class D10S
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(D10S));
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.btnGolDelSiglo = new System.Windows.Forms.Button();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.btnLeerDb = new System.Windows.Forms.Button();
            this.btnLeerLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // picFondo
            // 
            this.picFondo.Image = ((System.Drawing.Image)(resources.GetObject("picFondo.Image")));
            this.picFondo.Location = new System.Drawing.Point(12, 12);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(1201, 391);
            this.picFondo.TabIndex = 0;
            this.picFondo.TabStop = false;
            // 
            // btnGolDelSiglo
            // 
            this.btnGolDelSiglo.Location = new System.Drawing.Point(1092, 437);
            this.btnGolDelSiglo.Name = "btnGolDelSiglo";
            this.btnGolDelSiglo.Size = new System.Drawing.Size(117, 46);
            this.btnGolDelSiglo.TabIndex = 1;
            this.btnGolDelSiglo.Text = "Gol del Siglo";
            this.btnGolDelSiglo.UseVisualStyleBackColor = true;
            this.btnGolDelSiglo.Click += new System.EventHandler(this.btnGolDelSiglo_Click);
            // 
            // pic5
            // 
            this.pic5.Image = ((System.Drawing.Image)(resources.GetObject("pic5.Image")));
            this.pic5.Location = new System.Drawing.Point(10, 12);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(299, 391);
            this.pic5.TabIndex = 2;
            this.pic5.TabStop = false;
            this.pic5.Visible = false;
            // 
            // pic4
            // 
            this.pic4.Image = ((System.Drawing.Image)(resources.GetObject("pic4.Image")));
            this.pic4.Location = new System.Drawing.Point(308, 12);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(225, 391);
            this.pic4.TabIndex = 3;
            this.pic4.TabStop = false;
            this.pic4.Visible = false;
            // 
            // pic3
            // 
            this.pic3.Image = ((System.Drawing.Image)(resources.GetObject("pic3.Image")));
            this.pic3.Location = new System.Drawing.Point(533, 12);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(165, 391);
            this.pic3.TabIndex = 4;
            this.pic3.TabStop = false;
            this.pic3.Visible = false;
            // 
            // pic2
            // 
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.Location = new System.Drawing.Point(698, 12);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(200, 391);
            this.pic2.TabIndex = 5;
            this.pic2.TabStop = false;
            this.pic2.Visible = false;
            // 
            // pic1
            // 
            this.pic1.Image = ((System.Drawing.Image)(resources.GetObject("pic1.Image")));
            this.pic1.Location = new System.Drawing.Point(899, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(315, 391);
            this.pic1.TabIndex = 6;
            this.pic1.TabStop = false;
            this.pic1.Visible = false;
            // 
            // btnLeerDb
            // 
            this.btnLeerDb.Location = new System.Drawing.Point(817, 437);
            this.btnLeerDb.Name = "btnLeerDb";
            this.btnLeerDb.Size = new System.Drawing.Size(117, 46);
            this.btnLeerDb.TabIndex = 7;
            this.btnLeerDb.Text = "Leer DB";
            this.btnLeerDb.UseVisualStyleBackColor = true;
            this.btnLeerDb.Click += new System.EventHandler(this.btnLeerDb_Click);
            // 
            // btnLeerLog
            // 
            this.btnLeerLog.Location = new System.Drawing.Point(956, 437);
            this.btnLeerLog.Name = "btnLeerLog";
            this.btnLeerLog.Size = new System.Drawing.Size(117, 46);
            this.btnLeerLog.TabIndex = 8;
            this.btnLeerLog.Text = "Leer Log";
            this.btnLeerLog.UseVisualStyleBackColor = true;
            this.btnLeerLog.Click += new System.EventHandler(this.btnLeerLog_Click);
            // 
            // D10S
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 495);
            this.Controls.Add(this.btnLeerLog);
            this.Controls.Add(this.btnLeerDb);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.btnGolDelSiglo);
            this.Controls.Add(this.picFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "D10S";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D10S";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.D10S_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.Button btnGolDelSiglo;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button btnLeerDb;
        private System.Windows.Forms.Button btnLeerLog;
    }
}

