namespace I02
{
    partial class frmRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbDatosUsuario = new GroupBox();
            nupEdad = new NumericUpDown();
            lblEdad = new Label();
            lblNombre = new Label();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            btnIngresar = new Button();
            gbGenero = new GroupBox();
            rbNonB = new RadioButton();
            rbMasc = new RadioButton();
            rbFem = new RadioButton();
            gbCursos = new GroupBox();
            cbJs = new CheckBox();
            cbCsharp = new CheckBox();
            cbCplusplus = new CheckBox();
            lstbPaises = new ListBox();
            btnHardcode = new Button();
            gbDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupEdad).BeginInit();
            gbGenero.SuspendLayout();
            gbCursos.SuspendLayout();
            SuspendLayout();
            // 
            // gbDatosUsuario
            // 
            gbDatosUsuario.Controls.Add(nupEdad);
            gbDatosUsuario.Controls.Add(lblEdad);
            gbDatosUsuario.Controls.Add(lblNombre);
            gbDatosUsuario.Controls.Add(lblDireccion);
            gbDatosUsuario.Controls.Add(txtDireccion);
            gbDatosUsuario.Controls.Add(txtNombre);
            gbDatosUsuario.Location = new Point(12, 21);
            gbDatosUsuario.Name = "gbDatosUsuario";
            gbDatosUsuario.Size = new Size(191, 130);
            gbDatosUsuario.TabIndex = 0;
            gbDatosUsuario.TabStop = false;
            gbDatosUsuario.Text = "Detalles del usuario";
            // 
            // nupEdad
            // 
            nupEdad.Location = new Point(67, 97);
            nupEdad.Name = "nupEdad";
            nupEdad.Size = new Size(100, 23);
            nupEdad.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(6, 99);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 6;
            lblEdad.Text = "Edad";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(6, 57);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 5;
            lblDireccion.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(67, 57);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(67, 21);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(358, 396);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(116, 42);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // gbGenero
            // 
            gbGenero.Controls.Add(rbNonB);
            gbGenero.Controls.Add(rbMasc);
            gbGenero.Controls.Add(rbFem);
            gbGenero.Location = new Point(280, 27);
            gbGenero.Name = "gbGenero";
            gbGenero.Size = new Size(200, 124);
            gbGenero.TabIndex = 2;
            gbGenero.TabStop = false;
            gbGenero.Text = "Genero";
            // 
            // rbNonB
            // 
            rbNonB.AutoSize = true;
            rbNonB.Location = new Point(6, 81);
            rbNonB.Name = "rbNonB";
            rbNonB.Size = new Size(81, 19);
            rbNonB.TabIndex = 6;
            rbNonB.TabStop = true;
            rbNonB.Text = "No Binario";
            rbNonB.UseVisualStyleBackColor = true;
            // 
            // rbMasc
            // 
            rbMasc.AutoSize = true;
            rbMasc.Location = new Point(6, 25);
            rbMasc.Name = "rbMasc";
            rbMasc.Size = new Size(80, 19);
            rbMasc.TabIndex = 4;
            rbMasc.TabStop = true;
            rbMasc.Text = "Masculino";
            rbMasc.UseVisualStyleBackColor = true;
            // 
            // rbFem
            // 
            rbFem.AutoSize = true;
            rbFem.Location = new Point(6, 53);
            rbFem.Name = "rbFem";
            rbFem.Size = new Size(78, 19);
            rbFem.TabIndex = 5;
            rbFem.TabStop = true;
            rbFem.Text = "Femenino";
            rbFem.UseVisualStyleBackColor = true;
            // 
            // gbCursos
            // 
            gbCursos.Controls.Add(cbJs);
            gbCursos.Controls.Add(cbCsharp);
            gbCursos.Controls.Add(cbCplusplus);
            gbCursos.Location = new Point(274, 229);
            gbCursos.Name = "gbCursos";
            gbCursos.Size = new Size(200, 100);
            gbCursos.TabIndex = 3;
            gbCursos.TabStop = false;
            gbCursos.Text = "Cursos";
            // 
            // cbJs
            // 
            cbJs.AutoSize = true;
            cbJs.Location = new Point(6, 72);
            cbJs.Name = "cbJs";
            cbJs.Size = new Size(74, 19);
            cbJs.TabIndex = 6;
            cbJs.Text = "JavaScrip";
            cbJs.UseVisualStyleBackColor = true;
            // 
            // cbCsharp
            // 
            cbCsharp.AutoSize = true;
            cbCsharp.Location = new Point(6, 22);
            cbCsharp.Name = "cbCsharp";
            cbCsharp.Size = new Size(41, 19);
            cbCsharp.TabIndex = 4;
            cbCsharp.Text = "C#";
            cbCsharp.UseVisualStyleBackColor = true;
            // 
            // cbCplusplus
            // 
            cbCplusplus.AutoSize = true;
            cbCplusplus.Location = new Point(6, 47);
            cbCplusplus.Name = "cbCplusplus";
            cbCplusplus.Size = new Size(53, 19);
            cbCplusplus.TabIndex = 5;
            cbCplusplus.Text = "C ++";
            cbCplusplus.UseVisualStyleBackColor = true;
            // 
            // lstbPaises
            // 
            lstbPaises.FormattingEnabled = true;
            lstbPaises.ItemHeight = 15;
            lstbPaises.Location = new Point(18, 229);
            lstbPaises.Name = "lstbPaises";
            lstbPaises.Size = new Size(185, 139);
            lstbPaises.TabIndex = 4;
            // 
            // btnHardcode
            // 
            btnHardcode.Location = new Point(18, 396);
            btnHardcode.Name = "btnHardcode";
            btnHardcode.Size = new Size(117, 42);
            btnHardcode.TabIndex = 5;
            btnHardcode.Text = "Cargar Datos";
            btnHardcode.UseVisualStyleBackColor = true;
            btnHardcode.Click += btnHardcode_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 450);
            Controls.Add(btnHardcode);
            Controls.Add(lstbPaises);
            Controls.Add(gbCursos);
            Controls.Add(gbGenero);
            Controls.Add(btnIngresar);
            Controls.Add(gbDatosUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            FormClosing += frmRegistro_FormClosing;
            Load += Form1_Load;
            gbDatosUsuario.ResumeLayout(false);
            gbDatosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupEdad).EndInit();
            gbGenero.ResumeLayout(false);
            gbGenero.PerformLayout();
            gbCursos.ResumeLayout(false);
            gbCursos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbDatosUsuario;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private NumericUpDown nupEdad;
        private Label lblNombre;
        private Label lblDireccion;
        private Label lblEdad;
        private Button btnIngresar;
        private GroupBox gbGenero;
        private RadioButton rbMasc;
        private GroupBox gbCursos;
        private RadioButton rbFem;
        private RadioButton rbNonB;
        private CheckBox cbJs;
        private CheckBox cbCsharp;
        private CheckBox cbCplusplus;
        private ListBox lstbPaises;
        private Button btnHardcode;
    }
}