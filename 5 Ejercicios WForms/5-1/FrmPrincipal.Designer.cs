namespace _5_1
{
    partial class FrmPrincipal
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
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.txb_apellido = new System.Windows.Forms.TextBox();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_apellido = new System.Windows.Forms.Label();
            this.btn_saludar = new System.Windows.Forms.Button();
            this.cmb_materias = new System.Windows.Forms.ComboBox();
            this.lb_materia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(79, 123);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.PlaceholderText = "Nombre";
            this.txb_nombre.Size = new System.Drawing.Size(100, 23);
            this.txb_nombre.TabIndex = 0;
            // 
            // txb_apellido
            // 
            this.txb_apellido.Location = new System.Drawing.Point(222, 123);
            this.txb_apellido.Name = "txb_apellido";
            this.txb_apellido.PlaceholderText = "Apellido";
            this.txb_apellido.Size = new System.Drawing.Size(100, 23);
            this.txb_apellido.TabIndex = 1;
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_nombre.Location = new System.Drawing.Point(46, 84);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(133, 21);
            this.lb_nombre.TabIndex = 2;
            this.lb_nombre.Text = "Ingrese Nombre";
            // 
            // lb_apellido
            // 
            this.lb_apellido.AutoSize = true;
            this.lb_apellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_apellido.Location = new System.Drawing.Point(222, 84);
            this.lb_apellido.Name = "lb_apellido";
            this.lb_apellido.Size = new System.Drawing.Size(135, 21);
            this.lb_apellido.TabIndex = 3;
            this.lb_apellido.Text = "Ingrese Apellido";
            // 
            // btn_saludar
            // 
            this.btn_saludar.Location = new System.Drawing.Point(156, 220);
            this.btn_saludar.Name = "btn_saludar";
            this.btn_saludar.Size = new System.Drawing.Size(84, 50);
            this.btn_saludar.TabIndex = 4;
            this.btn_saludar.Text = "Saludar";
            this.btn_saludar.UseVisualStyleBackColor = true;
            this.btn_saludar.Click += new System.EventHandler(this.btn_saludar_Click);
            // 
            // cmb_materias
            // 
            this.cmb_materias.FormattingEnabled = true;
            this.cmb_materias.Location = new System.Drawing.Point(115, 191);
            this.cmb_materias.Name = "cmb_materias";
            this.cmb_materias.Size = new System.Drawing.Size(168, 23);
            this.cmb_materias.TabIndex = 5;
            // 
            // lb_materia
            // 
            this.lb_materia.AutoSize = true;
            this.lb_materia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_materia.Location = new System.Drawing.Point(117, 163);
            this.lb_materia.Name = "lb_materia";
            this.lb_materia.Size = new System.Drawing.Size(135, 21);
            this.lb_materia.TabIndex = 6;
            this.lb_materia.Text = "Materia Favorita";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.lb_materia);
            this.Controls.Add(this.cmb_materias);
            this.Controls.Add(this.btn_saludar);
            this.Controls.Add(this.lb_apellido);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.txb_apellido);
            this.Controls.Add(this.txb_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Hola, Windows Forms!";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.TextBox txb_apellido;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_apellido;
        private System.Windows.Forms.Button btn_saludar;
        private System.Windows.Forms.ComboBox cmb_materias;
        private System.Windows.Forms.Label lb_materia;
    }
}
