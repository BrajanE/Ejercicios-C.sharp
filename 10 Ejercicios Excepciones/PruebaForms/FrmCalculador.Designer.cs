namespace PruebaForms
{
    partial class FrmCalculador
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
            this.lbl_km = new System.Windows.Forms.Label();
            this.lbl_litros = new System.Windows.Forms.Label();
            this.txb_kilometros = new System.Windows.Forms.TextBox();
            this.txb_litros = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.rtb_informacion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_km
            // 
            this.lbl_km.AutoSize = true;
            this.lbl_km.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_km.Location = new System.Drawing.Point(12, 9);
            this.lbl_km.Name = "lbl_km";
            this.lbl_km.Size = new System.Drawing.Size(90, 21);
            this.lbl_km.TabIndex = 0;
            this.lbl_km.Text = "Kilometros";
            // 
            // lbl_litros
            // 
            this.lbl_litros.AutoSize = true;
            this.lbl_litros.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_litros.Location = new System.Drawing.Point(12, 76);
            this.lbl_litros.Name = "lbl_litros";
            this.lbl_litros.Size = new System.Drawing.Size(51, 21);
            this.lbl_litros.TabIndex = 1;
            this.lbl_litros.Text = "Litros";
            // 
            // txb_kilometros
            // 
            this.txb_kilometros.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txb_kilometros.Location = new System.Drawing.Point(12, 33);
            this.txb_kilometros.Name = "txb_kilometros";
            this.txb_kilometros.Size = new System.Drawing.Size(136, 29);
            this.txb_kilometros.TabIndex = 2;
            // 
            // txb_litros
            // 
            this.txb_litros.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txb_litros.Location = new System.Drawing.Point(12, 100);
            this.txb_litros.Name = "txb_litros";
            this.txb_litros.Size = new System.Drawing.Size(136, 29);
            this.txb_litros.TabIndex = 3;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_calcular.Location = new System.Drawing.Point(29, 157);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(100, 32);
            this.btn_calcular.TabIndex = 4;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // rtb_informacion
            // 
            this.rtb_informacion.Location = new System.Drawing.Point(154, 12);
            this.rtb_informacion.Name = "rtb_informacion";
            this.rtb_informacion.ReadOnly = true;
            this.rtb_informacion.Size = new System.Drawing.Size(134, 190);
            this.rtb_informacion.TabIndex = 5;
            this.rtb_informacion.Text = "";
            // 
            // FrmCalculador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 214);
            this.Controls.Add(this.rtb_informacion);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txb_litros);
            this.Controls.Add(this.txb_kilometros);
            this.Controls.Add(this.lbl_litros);
            this.Controls.Add(this.lbl_km);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculador";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_km;
        private System.Windows.Forms.Label lbl_litros;
        private System.Windows.Forms.TextBox txb_kilometros;
        private System.Windows.Forms.TextBox txb_litros;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.RichTextBox rtb_informacion;
    }
}
