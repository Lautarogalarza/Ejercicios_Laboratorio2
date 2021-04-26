namespace Ejercicio_Herencia.WindowsForm
{
    partial class FrmCatedra
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
            this.gpbAlumno = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.lsbAlumnos = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gpbAlumnoCalificado = new System.Windows.Forms.GroupBox();
            this.lsbAlumnoCalificado = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gpbAlumno.SuspendLayout();
            this.gpbAlumnoCalificado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAlumno
            // 
            this.gpbAlumno.Controls.Add(this.btnEliminar);
            this.gpbAlumno.Controls.Add(this.btnModificar);
            this.gpbAlumno.Controls.Add(this.cmbOrdenar);
            this.gpbAlumno.Controls.Add(this.btnCalificar);
            this.gpbAlumno.Controls.Add(this.lsbAlumnos);
            this.gpbAlumno.Controls.Add(this.btnAceptar);
            this.gpbAlumno.Location = new System.Drawing.Point(10, 12);
            this.gpbAlumno.Name = "gpbAlumno";
            this.gpbAlumno.Size = new System.Drawing.Size(473, 249);
            this.gpbAlumno.TabIndex = 0;
            this.gpbAlumno.TabStop = false;
            this.gpbAlumno.Text = "Alumnos";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(137, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(81, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Location = new System.Drawing.Point(35, 222);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(393, 21);
            this.cmbOrdenar.TabIndex = 5;
            this.cmbOrdenar.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenar_SelectedIndexChanged);
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(376, 19);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(81, 23);
            this.btnCalificar.TabIndex = 3;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // lsbAlumnos
            // 
            this.lsbAlumnos.FormattingEnabled = true;
            this.lsbAlumnos.Location = new System.Drawing.Point(12, 56);
            this.lsbAlumnos.Name = "lsbAlumnos";
            this.lsbAlumnos.Size = new System.Drawing.Size(445, 160);
            this.lsbAlumnos.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(12, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(81, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gpbAlumnoCalificado
            // 
            this.gpbAlumnoCalificado.Controls.Add(this.lsbAlumnoCalificado);
            this.gpbAlumnoCalificado.Location = new System.Drawing.Point(12, 277);
            this.gpbAlumnoCalificado.Name = "gpbAlumnoCalificado";
            this.gpbAlumnoCalificado.Size = new System.Drawing.Size(473, 193);
            this.gpbAlumnoCalificado.TabIndex = 1;
            this.gpbAlumnoCalificado.TabStop = false;
            this.gpbAlumnoCalificado.Text = "Alumnos Calificados ";
            // 
            // lsbAlumnoCalificado
            // 
            this.lsbAlumnoCalificado.FormattingEnabled = true;
            this.lsbAlumnoCalificado.Location = new System.Drawing.Point(12, 19);
            this.lsbAlumnoCalificado.Name = "lsbAlumnoCalificado";
            this.lsbAlumnoCalificado.Size = new System.Drawing.Size(445, 160);
            this.lsbAlumnoCalificado.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(255, 19);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(81, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 482);
            this.Controls.Add(this.gpbAlumnoCalificado);
            this.Controls.Add(this.gpbAlumno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCatedra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCatedra";
            this.gpbAlumno.ResumeLayout(false);
            this.gpbAlumnoCalificado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAlumno;
        private System.Windows.Forms.GroupBox gpbAlumnoCalificado;
        private System.Windows.Forms.ListBox lsbAlumnos;
        private System.Windows.Forms.ListBox lsbAlumnoCalificado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cmbOrdenar;
        private System.Windows.Forms.Button btnEliminar;
    }
}