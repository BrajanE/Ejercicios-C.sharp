namespace _11_2_PruebaForms
{
    partial class FrmMenu
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
            this.btn_generarLLamada = new System.Windows.Forms.Button();
            this.btn_facTotal = new System.Windows.Forms.Button();
            this.btn_facLocal = new System.Windows.Forms.Button();
            this.btn_facProvincial = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_generarLLamada
            // 
            this.btn_generarLLamada.Location = new System.Drawing.Point(12, 12);
            this.btn_generarLLamada.Name = "btn_generarLLamada";
            this.btn_generarLLamada.Size = new System.Drawing.Size(236, 76);
            this.btn_generarLLamada.TabIndex = 0;
            this.btn_generarLLamada.Text = "Generar LLamada";
            this.btn_generarLLamada.UseVisualStyleBackColor = true;
            this.btn_generarLLamada.Click += new System.EventHandler(this.btn_generarLLamada_Click);
            // 
            // btn_facTotal
            // 
            this.btn_facTotal.Location = new System.Drawing.Point(12, 94);
            this.btn_facTotal.Name = "btn_facTotal";
            this.btn_facTotal.Size = new System.Drawing.Size(236, 76);
            this.btn_facTotal.TabIndex = 1;
            this.btn_facTotal.Text = "Facturacion Total";
            this.btn_facTotal.UseVisualStyleBackColor = true;
            this.btn_facTotal.Click += new System.EventHandler(this.btn_facTotal_Click);
            // 
            // btn_facLocal
            // 
            this.btn_facLocal.Location = new System.Drawing.Point(12, 176);
            this.btn_facLocal.Name = "btn_facLocal";
            this.btn_facLocal.Size = new System.Drawing.Size(236, 76);
            this.btn_facLocal.TabIndex = 2;
            this.btn_facLocal.Text = "Facturacion Local";
            this.btn_facLocal.UseVisualStyleBackColor = true;
            this.btn_facLocal.Click += new System.EventHandler(this.btn_facLocal_Click);
            // 
            // btn_facProvincial
            // 
            this.btn_facProvincial.Location = new System.Drawing.Point(12, 258);
            this.btn_facProvincial.Name = "btn_facProvincial";
            this.btn_facProvincial.Size = new System.Drawing.Size(236, 76);
            this.btn_facProvincial.TabIndex = 3;
            this.btn_facProvincial.Text = "Facturacion Provincial";
            this.btn_facProvincial.UseVisualStyleBackColor = true;
            this.btn_facProvincial.Click += new System.EventHandler(this.btn_facProvincial_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(12, 340);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(236, 76);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 427);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_facProvincial);
            this.Controls.Add(this.btn_facLocal);
            this.Controls.Add(this.btn_facTotal);
            this.Controls.Add(this.btn_generarLLamada);
            this.Name = "FrmMenu";
            this.Text = "Central Telefonica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_generarLLamada;
        private System.Windows.Forms.Button btn_facTotal;
        private System.Windows.Forms.Button btn_facLocal;
        private System.Windows.Forms.Button btn_facProvincial;
        private System.Windows.Forms.Button btn_salir;
    }
}
