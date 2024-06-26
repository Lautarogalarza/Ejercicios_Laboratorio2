namespace Hilos_Ejemplo5
{
    partial class Form1
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
            progressBar1 = new ProgressBar();
            label1 = new Label();
            txtMostrar = new TextBox();
            btnMostrar = new Button();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            progressBar4 = new ProgressBar();
            progressBar5 = new ProgressBar();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnReiniciar = new Button();
            BtnVerInfo = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(776, 58);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 73);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // txtMostrar
            // 
            txtMostrar.Location = new Point(12, 506);
            txtMostrar.Name = "txtMostrar";
            txtMostrar.Size = new Size(253, 23);
            txtMostrar.TabIndex = 2;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(271, 505);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(12, 107);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(776, 58);
            progressBar2.TabIndex = 4;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(12, 198);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(776, 58);
            progressBar3.TabIndex = 5;
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(12, 289);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(776, 58);
            progressBar4.TabIndex = 6;
            // 
            // progressBar5
            // 
            progressBar5.Location = new Point(12, 387);
            progressBar5.Name = "progressBar5";
            progressBar5.Size = new Size(776, 58);
            progressBar5.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 168);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 259);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 9;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 350);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 10;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 448);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 11;
            label5.Text = "label5";
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(517, 506);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(75, 23);
            btnReiniciar.TabIndex = 12;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // BtnVerInfo
            // 
            BtnVerInfo.Location = new Point(614, 506);
            BtnVerInfo.Name = "BtnVerInfo";
            BtnVerInfo.Size = new Size(75, 23);
            BtnVerInfo.TabIndex = 13;
            BtnVerInfo.Text = "Ver Info";
            BtnVerInfo.UseVisualStyleBackColor = true;
            BtnVerInfo.Click += BtnVerInfo_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(713, 505);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(btnCancelar);
            Controls.Add(BtnVerInfo);
            Controls.Add(btnReiniciar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(progressBar5);
            Controls.Add(progressBar4);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(btnMostrar);
            Controls.Add(txtMostrar);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private TextBox txtMostrar;
        private Button btnMostrar;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private ProgressBar progressBar4;
        private ProgressBar progressBar5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnReiniciar;
        private Button BtnVerInfo;
        private Button btnCancelar;
    }
}