namespace _5_2
{
    partial class FrmRegistro
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
            this.gbx_detalles = new System.Windows.Forms.GroupBox();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.nud_edad = new System.Windows.Forms.NumericUpDown();
            this.txb_direccion = new System.Windows.Forms.TextBox();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.gbx_genero = new System.Windows.Forms.GroupBox();
            this.rbtn_noBinario = new System.Windows.Forms.RadioButton();
            this.rbtn_femenino = new System.Windows.Forms.RadioButton();
            this.rbtn_masculino = new System.Windows.Forms.RadioButton();
            this.gbx_cursos = new System.Windows.Forms.GroupBox();
            this.chb_javaScript = new System.Windows.Forms.CheckBox();
            this.chb_cMas = new System.Windows.Forms.CheckBox();
            this.chb_cSharp = new System.Windows.Forms.CheckBox();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.lbx_paises = new System.Windows.Forms.ListBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.gbx_detalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_edad)).BeginInit();
            this.gbx_genero.SuspendLayout();
            this.gbx_cursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_detalles
            // 
            this.gbx_detalles.Controls.Add(this.lbl_edad);
            this.gbx_detalles.Controls.Add(this.lbl_direccion);
            this.gbx_detalles.Controls.Add(this.lbl_nombre);
            this.gbx_detalles.Controls.Add(this.nud_edad);
            this.gbx_detalles.Controls.Add(this.txb_direccion);
            this.gbx_detalles.Controls.Add(this.txb_nombre);
            this.gbx_detalles.Location = new System.Drawing.Point(12, 12);
            this.gbx_detalles.Name = "gbx_detalles";
            this.gbx_detalles.Size = new System.Drawing.Size(200, 134);
            this.gbx_detalles.TabIndex = 0;
            this.gbx_detalles.TabStop = false;
            this.gbx_detalles.Text = "Detalles del usuario";
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(6, 99);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(33, 15);
            this.lbl_edad.TabIndex = 5;
            this.lbl_edad.Text = "Edad";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(6, 61);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(57, 15);
            this.lbl_direccion.TabIndex = 4;
            this.lbl_direccion.Text = "Direccion";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(6, 22);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre";
            // 
            // nud_edad
            // 
            this.nud_edad.Location = new System.Drawing.Point(73, 99);
            this.nud_edad.Name = "nud_edad";
            this.nud_edad.Size = new System.Drawing.Size(90, 23);
            this.nud_edad.TabIndex = 2;
            // 
            // txb_direccion
            // 
            this.txb_direccion.Location = new System.Drawing.Point(73, 61);
            this.txb_direccion.Name = "txb_direccion";
            this.txb_direccion.Size = new System.Drawing.Size(121, 23);
            this.txb_direccion.TabIndex = 1;
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(73, 22);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(121, 23);
            this.txb_nombre.TabIndex = 0;
            // 
            // gbx_genero
            // 
            this.gbx_genero.Controls.Add(this.rbtn_noBinario);
            this.gbx_genero.Controls.Add(this.rbtn_femenino);
            this.gbx_genero.Controls.Add(this.rbtn_masculino);
            this.gbx_genero.Location = new System.Drawing.Point(231, 12);
            this.gbx_genero.Name = "gbx_genero";
            this.gbx_genero.Size = new System.Drawing.Size(111, 100);
            this.gbx_genero.TabIndex = 1;
            this.gbx_genero.TabStop = false;
            this.gbx_genero.Text = "Genero";
            // 
            // rbtn_noBinario
            // 
            this.rbtn_noBinario.AutoSize = true;
            this.rbtn_noBinario.Location = new System.Drawing.Point(21, 68);
            this.rbtn_noBinario.Name = "rbtn_noBinario";
            this.rbtn_noBinario.Size = new System.Drawing.Size(81, 19);
            this.rbtn_noBinario.TabIndex = 2;
            this.rbtn_noBinario.TabStop = true;
            this.rbtn_noBinario.Text = "No Binario";
            this.rbtn_noBinario.UseVisualStyleBackColor = true;
            // 
            // rbtn_femenino
            // 
            this.rbtn_femenino.AutoSize = true;
            this.rbtn_femenino.Location = new System.Drawing.Point(21, 43);
            this.rbtn_femenino.Name = "rbtn_femenino";
            this.rbtn_femenino.Size = new System.Drawing.Size(78, 19);
            this.rbtn_femenino.TabIndex = 1;
            this.rbtn_femenino.TabStop = true;
            this.rbtn_femenino.Text = "Femenino";
            this.rbtn_femenino.UseVisualStyleBackColor = true;
            // 
            // rbtn_masculino
            // 
            this.rbtn_masculino.AutoSize = true;
            this.rbtn_masculino.Location = new System.Drawing.Point(21, 18);
            this.rbtn_masculino.Name = "rbtn_masculino";
            this.rbtn_masculino.Size = new System.Drawing.Size(80, 19);
            this.rbtn_masculino.TabIndex = 0;
            this.rbtn_masculino.TabStop = true;
            this.rbtn_masculino.Text = "Masculino";
            this.rbtn_masculino.UseVisualStyleBackColor = true;
            // 
            // gbx_cursos
            // 
            this.gbx_cursos.Controls.Add(this.chb_javaScript);
            this.gbx_cursos.Controls.Add(this.chb_cMas);
            this.gbx_cursos.Controls.Add(this.chb_cSharp);
            this.gbx_cursos.Location = new System.Drawing.Point(231, 118);
            this.gbx_cursos.Name = "gbx_cursos";
            this.gbx_cursos.Size = new System.Drawing.Size(111, 100);
            this.gbx_cursos.TabIndex = 2;
            this.gbx_cursos.TabStop = false;
            this.gbx_cursos.Text = "Cursos";
            // 
            // chb_javaScript
            // 
            this.chb_javaScript.AutoSize = true;
            this.chb_javaScript.Location = new System.Drawing.Point(21, 75);
            this.chb_javaScript.Name = "chb_javaScript";
            this.chb_javaScript.Size = new System.Drawing.Size(78, 19);
            this.chb_javaScript.TabIndex = 2;
            this.chb_javaScript.Text = "JavaScript";
            this.chb_javaScript.UseVisualStyleBackColor = true;
            // 
            // chb_cMas
            // 
            this.chb_cMas.AutoSize = true;
            this.chb_cMas.Location = new System.Drawing.Point(21, 50);
            this.chb_cMas.Name = "chb_cMas";
            this.chb_cMas.Size = new System.Drawing.Size(50, 19);
            this.chb_cMas.TabIndex = 1;
            this.chb_cMas.Text = "C++";
            this.chb_cMas.UseVisualStyleBackColor = true;
            // 
            // chb_cSharp
            // 
            this.chb_cSharp.AutoSize = true;
            this.chb_cSharp.Location = new System.Drawing.Point(21, 25);
            this.chb_cSharp.Name = "chb_cSharp";
            this.chb_cSharp.Size = new System.Drawing.Size(41, 19);
            this.chb_cSharp.TabIndex = 0;
            this.chb_cSharp.Text = "C#";
            this.chb_cSharp.UseVisualStyleBackColor = true;
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pais.Location = new System.Drawing.Point(12, 149);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(31, 17);
            this.lbl_pais.TabIndex = 3;
            this.lbl_pais.Text = "Pais";
            // 
            // lbx_paises
            // 
            this.lbx_paises.FormattingEnabled = true;
            this.lbx_paises.ItemHeight = 15;
            this.lbx_paises.Location = new System.Drawing.Point(12, 168);
            this.lbx_paises.Name = "lbx_paises";
            this.lbx_paises.Size = new System.Drawing.Size(200, 94);
            this.lbx_paises.TabIndex = 4;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ingresar.Location = new System.Drawing.Point(239, 233);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(91, 29);
            this.btn_ingresar.TabIndex = 5;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 270);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.lbx_paises);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.gbx_cursos);
            this.Controls.Add(this.gbx_genero);
            this.Controls.Add(this.gbx_detalles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRegistro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.gbx_detalles.ResumeLayout(false);
            this.gbx_detalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_edad)).EndInit();
            this.gbx_genero.ResumeLayout(false);
            this.gbx_genero.PerformLayout();
            this.gbx_cursos.ResumeLayout(false);
            this.gbx_cursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_detalles;
        private System.Windows.Forms.NumericUpDown nud_edad;
        private System.Windows.Forms.TextBox txb_direccion;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.GroupBox gbx_genero;
        private System.Windows.Forms.GroupBox gbx_cursos;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.RadioButton rbtn_noBinario;
        private System.Windows.Forms.RadioButton rbtn_femenino;
        private System.Windows.Forms.RadioButton rbtn_masculino;
        private System.Windows.Forms.CheckBox chb_javaScript;
        private System.Windows.Forms.CheckBox chb_cMas;
        private System.Windows.Forms.CheckBox chb_cSharp;
        private System.Windows.Forms.ListBox lbx_paises;
        private System.Windows.Forms.Button btn_ingresar;
    }
}
