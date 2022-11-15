namespace _14_5_PruebaForms
{
    partial class FrmMenu
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
            this.btn_generarLLamada = new System.Windows.Forms.Button();
            this.btn_facTotal = new System.Windows.Forms.Button();
            this.btn_facLocal = new System.Windows.Forms.Button();
            this.btn_facProvincial = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_historial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_generarLLamada
            // 
            this.btn_generarLLamada.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_generarLLamada.Location = new System.Drawing.Point(12, 12);
            this.btn_generarLLamada.Name = "btn_generarLLamada";
            this.btn_generarLLamada.Size = new System.Drawing.Size(208, 60);
            this.btn_generarLLamada.TabIndex = 0;
            this.btn_generarLLamada.Text = "Generar LLamada";
            this.btn_generarLLamada.UseVisualStyleBackColor = true;
            this.btn_generarLLamada.Click += new System.EventHandler(this.btn_generarLLamada_Click);
            // 
            // btn_facTotal
            // 
            this.btn_facTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_facTotal.Location = new System.Drawing.Point(12, 78);
            this.btn_facTotal.Name = "btn_facTotal";
            this.btn_facTotal.Size = new System.Drawing.Size(208, 60);
            this.btn_facTotal.TabIndex = 1;
            this.btn_facTotal.Text = "Facturacion Total";
            this.btn_facTotal.UseVisualStyleBackColor = true;
            this.btn_facTotal.Click += new System.EventHandler(this.btn_facTotal_Click);
            // 
            // btn_facLocal
            // 
            this.btn_facLocal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_facLocal.Location = new System.Drawing.Point(12, 144);
            this.btn_facLocal.Name = "btn_facLocal";
            this.btn_facLocal.Size = new System.Drawing.Size(208, 60);
            this.btn_facLocal.TabIndex = 2;
            this.btn_facLocal.Text = "Facturacion Local";
            this.btn_facLocal.UseVisualStyleBackColor = true;
            this.btn_facLocal.Click += new System.EventHandler(this.btn_facLocal_Click);
            // 
            // btn_facProvincial
            // 
            this.btn_facProvincial.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_facProvincial.Location = new System.Drawing.Point(12, 210);
            this.btn_facProvincial.Name = "btn_facProvincial";
            this.btn_facProvincial.Size = new System.Drawing.Size(208, 60);
            this.btn_facProvincial.TabIndex = 3;
            this.btn_facProvincial.Text = "Facturacion Provincial";
            this.btn_facProvincial.UseVisualStyleBackColor = true;
            this.btn_facProvincial.Click += new System.EventHandler(this.btn_facProvincial_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.Location = new System.Drawing.Point(12, 276);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(208, 60);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_historial
            // 
            this.btn_historial.Location = new System.Drawing.Point(68, 370);
            this.btn_historial.Name = "btn_historial";
            this.btn_historial.Size = new System.Drawing.Size(91, 60);
            this.btn_historial.TabIndex = 5;
            this.btn_historial.Text = "Registro LLamadas";
            this.btn_historial.UseVisualStyleBackColor = true;
            this.btn_historial.Click += new System.EventHandler(this.btn_historial_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 442);
            this.Controls.Add(this.btn_historial);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_facProvincial);
            this.Controls.Add(this.btn_facLocal);
            this.Controls.Add(this.btn_facTotal);
            this.Controls.Add(this.btn_generarLLamada);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefonica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_generarLLamada;
        private System.Windows.Forms.Button btn_facTotal;
        private System.Windows.Forms.Button btn_facLocal;
        private System.Windows.Forms.Button btn_facProvincial;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_historial;
    }
}