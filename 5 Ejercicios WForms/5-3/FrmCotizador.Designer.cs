namespace _5_3
{
    partial class FrmCotizador
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
            this.txb_euroCant = new System.Windows.Forms.TextBox();
            this.txb_dolarCant = new System.Windows.Forms.TextBox();
            this.txb_pesosCant = new System.Windows.Forms.TextBox();
            this.txb_euroValor = new System.Windows.Forms.TextBox();
            this.txb_dolarValor = new System.Windows.Forms.TextBox();
            this.txb_pesoValor = new System.Windows.Forms.TextBox();
            this.btn_euro = new System.Windows.Forms.Button();
            this.btn_dolar = new System.Windows.Forms.Button();
            this.btn_pesos = new System.Windows.Forms.Button();
            this.btn_cotizar = new System.Windows.Forms.Button();
            this.lbl_cotizacion = new System.Windows.Forms.Label();
            this.lbl_euro1 = new System.Windows.Forms.Label();
            this.lbl_dolar1 = new System.Windows.Forms.Label();
            this.lbl_peso1 = new System.Windows.Forms.Label();
            this.lbl_euro2 = new System.Windows.Forms.Label();
            this.lbl_dolar2 = new System.Windows.Forms.Label();
            this.lbl_peso2 = new System.Windows.Forms.Label();
            this.txb_euroXeuro = new System.Windows.Forms.TextBox();
            this.txb_euroXdolar = new System.Windows.Forms.TextBox();
            this.txb_euroXpeso = new System.Windows.Forms.TextBox();
            this.txb_dolarXeuro = new System.Windows.Forms.TextBox();
            this.txb_dolarXdolar = new System.Windows.Forms.TextBox();
            this.txb_dolarXpeso = new System.Windows.Forms.TextBox();
            this.txb_pesoXeuro = new System.Windows.Forms.TextBox();
            this.txb_pesoXdolar = new System.Windows.Forms.TextBox();
            this.txb_pesoXpeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txb_euroCant
            // 
            this.txb_euroCant.Location = new System.Drawing.Point(98, 77);
            this.txb_euroCant.Name = "txb_euroCant";
            this.txb_euroCant.Size = new System.Drawing.Size(100, 23);
            this.txb_euroCant.TabIndex = 0;
            // 
            // txb_dolarCant
            // 
            this.txb_dolarCant.Location = new System.Drawing.Point(98, 106);
            this.txb_dolarCant.Name = "txb_dolarCant";
            this.txb_dolarCant.Size = new System.Drawing.Size(100, 23);
            this.txb_dolarCant.TabIndex = 1;
            // 
            // txb_pesosCant
            // 
            this.txb_pesosCant.Location = new System.Drawing.Point(98, 135);
            this.txb_pesosCant.Name = "txb_pesosCant";
            this.txb_pesosCant.Size = new System.Drawing.Size(100, 23);
            this.txb_pesosCant.TabIndex = 2;
            // 
            // txb_euroValor
            // 
            this.txb_euroValor.Location = new System.Drawing.Point(296, 26);
            this.txb_euroValor.Name = "txb_euroValor";
            this.txb_euroValor.Size = new System.Drawing.Size(100, 23);
            this.txb_euroValor.TabIndex = 3;
            // 
            // txb_dolarValor
            // 
            this.txb_dolarValor.Location = new System.Drawing.Point(402, 26);
            this.txb_dolarValor.Name = "txb_dolarValor";
            this.txb_dolarValor.Size = new System.Drawing.Size(100, 23);
            this.txb_dolarValor.TabIndex = 4;
            // 
            // txb_pesoValor
            // 
            this.txb_pesoValor.Location = new System.Drawing.Point(508, 26);
            this.txb_pesoValor.Name = "txb_pesoValor";
            this.txb_pesoValor.Size = new System.Drawing.Size(100, 23);
            this.txb_pesoValor.TabIndex = 5;
            // 
            // btn_euro
            // 
            this.btn_euro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_euro.Location = new System.Drawing.Point(204, 77);
            this.btn_euro.Name = "btn_euro";
            this.btn_euro.Size = new System.Drawing.Size(75, 23);
            this.btn_euro.TabIndex = 6;
            this.btn_euro.Text = "->";
            this.btn_euro.UseVisualStyleBackColor = true;
            this.btn_euro.Click += new System.EventHandler(this.btn_euro_Click);
            // 
            // btn_dolar
            // 
            this.btn_dolar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_dolar.Location = new System.Drawing.Point(204, 106);
            this.btn_dolar.Name = "btn_dolar";
            this.btn_dolar.Size = new System.Drawing.Size(75, 23);
            this.btn_dolar.TabIndex = 7;
            this.btn_dolar.Text = "->";
            this.btn_dolar.UseVisualStyleBackColor = true;
            this.btn_dolar.Click += new System.EventHandler(this.btn_dolar_Click);
            // 
            // btn_pesos
            // 
            this.btn_pesos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_pesos.Location = new System.Drawing.Point(204, 135);
            this.btn_pesos.Name = "btn_pesos";
            this.btn_pesos.Size = new System.Drawing.Size(75, 23);
            this.btn_pesos.TabIndex = 8;
            this.btn_pesos.Text = "->";
            this.btn_pesos.UseVisualStyleBackColor = true;
            this.btn_pesos.Click += new System.EventHandler(this.btn_pesos_Click);
            // 
            // btn_cotizar
            // 
            this.btn_cotizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cotizar.Location = new System.Drawing.Point(202, 26);
            this.btn_cotizar.Name = "btn_cotizar";
            this.btn_cotizar.Size = new System.Drawing.Size(75, 23);
            this.btn_cotizar.TabIndex = 9;
            this.btn_cotizar.Text = "Bloquear";
            this.btn_cotizar.UseVisualStyleBackColor = true;
            this.btn_cotizar.Click += new System.EventHandler(this.btn_cotizar_Click);
            // 
            // lbl_cotizacion
            // 
            this.lbl_cotizacion.AutoSize = true;
            this.lbl_cotizacion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cotizacion.Location = new System.Drawing.Point(98, 26);
            this.lbl_cotizacion.Name = "lbl_cotizacion";
            this.lbl_cotizacion.Size = new System.Drawing.Size(86, 21);
            this.lbl_cotizacion.TabIndex = 10;
            this.lbl_cotizacion.Text = "Cotizacion";
            // 
            // lbl_euro1
            // 
            this.lbl_euro1.AutoSize = true;
            this.lbl_euro1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_euro1.Location = new System.Drawing.Point(29, 77);
            this.lbl_euro1.Name = "lbl_euro1";
            this.lbl_euro1.Size = new System.Drawing.Size(43, 21);
            this.lbl_euro1.TabIndex = 11;
            this.lbl_euro1.Text = "Euro";
            // 
            // lbl_dolar1
            // 
            this.lbl_dolar1.AutoSize = true;
            this.lbl_dolar1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dolar1.Location = new System.Drawing.Point(29, 106);
            this.lbl_dolar1.Name = "lbl_dolar1";
            this.lbl_dolar1.Size = new System.Drawing.Size(49, 21);
            this.lbl_dolar1.TabIndex = 12;
            this.lbl_dolar1.Text = "Dolar";
            // 
            // lbl_peso1
            // 
            this.lbl_peso1.AutoSize = true;
            this.lbl_peso1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_peso1.Location = new System.Drawing.Point(29, 135);
            this.lbl_peso1.Name = "lbl_peso1";
            this.lbl_peso1.Size = new System.Drawing.Size(44, 21);
            this.lbl_peso1.TabIndex = 13;
            this.lbl_peso1.Text = "Peso";
            // 
            // lbl_euro2
            // 
            this.lbl_euro2.AutoSize = true;
            this.lbl_euro2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_euro2.Location = new System.Drawing.Point(328, 52);
            this.lbl_euro2.Name = "lbl_euro2";
            this.lbl_euro2.Size = new System.Drawing.Size(43, 21);
            this.lbl_euro2.TabIndex = 14;
            this.lbl_euro2.Text = "Euro";
            // 
            // lbl_dolar2
            // 
            this.lbl_dolar2.AutoSize = true;
            this.lbl_dolar2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dolar2.Location = new System.Drawing.Point(434, 52);
            this.lbl_dolar2.Name = "lbl_dolar2";
            this.lbl_dolar2.Size = new System.Drawing.Size(49, 21);
            this.lbl_dolar2.TabIndex = 15;
            this.lbl_dolar2.Text = "Dolar";
            // 
            // lbl_peso2
            // 
            this.lbl_peso2.AutoSize = true;
            this.lbl_peso2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_peso2.Location = new System.Drawing.Point(540, 52);
            this.lbl_peso2.Name = "lbl_peso2";
            this.lbl_peso2.Size = new System.Drawing.Size(44, 21);
            this.lbl_peso2.TabIndex = 16;
            this.lbl_peso2.Text = "Peso";
            // 
            // txb_euroXeuro
            // 
            this.txb_euroXeuro.Location = new System.Drawing.Point(296, 76);
            this.txb_euroXeuro.Name = "txb_euroXeuro";
            this.txb_euroXeuro.Size = new System.Drawing.Size(100, 23);
            this.txb_euroXeuro.TabIndex = 17;
            // 
            // txb_euroXdolar
            // 
            this.txb_euroXdolar.Location = new System.Drawing.Point(402, 75);
            this.txb_euroXdolar.Name = "txb_euroXdolar";
            this.txb_euroXdolar.Size = new System.Drawing.Size(100, 23);
            this.txb_euroXdolar.TabIndex = 18;
            // 
            // txb_euroXpeso
            // 
            this.txb_euroXpeso.Location = new System.Drawing.Point(508, 75);
            this.txb_euroXpeso.Name = "txb_euroXpeso";
            this.txb_euroXpeso.Size = new System.Drawing.Size(100, 23);
            this.txb_euroXpeso.TabIndex = 19;
            // 
            // txb_dolarXeuro
            // 
            this.txb_dolarXeuro.Location = new System.Drawing.Point(296, 104);
            this.txb_dolarXeuro.Name = "txb_dolarXeuro";
            this.txb_dolarXeuro.Size = new System.Drawing.Size(100, 23);
            this.txb_dolarXeuro.TabIndex = 20;
            // 
            // txb_dolarXdolar
            // 
            this.txb_dolarXdolar.Location = new System.Drawing.Point(402, 104);
            this.txb_dolarXdolar.Name = "txb_dolarXdolar";
            this.txb_dolarXdolar.Size = new System.Drawing.Size(100, 23);
            this.txb_dolarXdolar.TabIndex = 21;
            // 
            // txb_dolarXpeso
            // 
            this.txb_dolarXpeso.Location = new System.Drawing.Point(508, 104);
            this.txb_dolarXpeso.Name = "txb_dolarXpeso";
            this.txb_dolarXpeso.Size = new System.Drawing.Size(100, 23);
            this.txb_dolarXpeso.TabIndex = 22;
            // 
            // txb_pesoXeuro
            // 
            this.txb_pesoXeuro.Location = new System.Drawing.Point(296, 133);
            this.txb_pesoXeuro.Name = "txb_pesoXeuro";
            this.txb_pesoXeuro.Size = new System.Drawing.Size(100, 23);
            this.txb_pesoXeuro.TabIndex = 23;
            // 
            // txb_pesoXdolar
            // 
            this.txb_pesoXdolar.Location = new System.Drawing.Point(402, 133);
            this.txb_pesoXdolar.Name = "txb_pesoXdolar";
            this.txb_pesoXdolar.Size = new System.Drawing.Size(100, 23);
            this.txb_pesoXdolar.TabIndex = 24;
            // 
            // txb_pesoXpeso
            // 
            this.txb_pesoXpeso.Location = new System.Drawing.Point(508, 133);
            this.txb_pesoXpeso.Name = "txb_pesoXpeso";
            this.txb_pesoXpeso.Size = new System.Drawing.Size(100, 23);
            this.txb_pesoXpeso.TabIndex = 25;
            // 
            // FrmCotizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 179);
            this.Controls.Add(this.txb_pesoXpeso);
            this.Controls.Add(this.txb_pesoXdolar);
            this.Controls.Add(this.txb_pesoXeuro);
            this.Controls.Add(this.txb_dolarXpeso);
            this.Controls.Add(this.txb_dolarXdolar);
            this.Controls.Add(this.txb_dolarXeuro);
            this.Controls.Add(this.txb_euroXpeso);
            this.Controls.Add(this.txb_euroXdolar);
            this.Controls.Add(this.txb_euroXeuro);
            this.Controls.Add(this.lbl_peso2);
            this.Controls.Add(this.lbl_dolar2);
            this.Controls.Add(this.lbl_euro2);
            this.Controls.Add(this.lbl_peso1);
            this.Controls.Add(this.lbl_dolar1);
            this.Controls.Add(this.lbl_euro1);
            this.Controls.Add(this.lbl_cotizacion);
            this.Controls.Add(this.btn_cotizar);
            this.Controls.Add(this.btn_pesos);
            this.Controls.Add(this.btn_dolar);
            this.Controls.Add(this.btn_euro);
            this.Controls.Add(this.txb_pesoValor);
            this.Controls.Add(this.txb_dolarValor);
            this.Controls.Add(this.txb_euroValor);
            this.Controls.Add(this.txb_pesosCant);
            this.Controls.Add(this.txb_dolarCant);
            this.Controls.Add(this.txb_euroCant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCotizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.FrmCotizador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_euroCant;
        private System.Windows.Forms.TextBox txb_dolarCant;
        private System.Windows.Forms.TextBox txb_pesosCant;
        private System.Windows.Forms.TextBox txb_euroValor;
        private System.Windows.Forms.TextBox txb_dolarValor;
        private System.Windows.Forms.TextBox txb_pesoValor;
        private System.Windows.Forms.Button btn_euro;
        private System.Windows.Forms.Button btn_dolar;
        private System.Windows.Forms.Button btn_pesos;
        private System.Windows.Forms.Button btn_cotizar;
        private System.Windows.Forms.Label lbl_cotizacion;
        private System.Windows.Forms.Label lbl_euro1;
        private System.Windows.Forms.Label lbl_dolar1;
        private System.Windows.Forms.Label lbl_peso1;
        private System.Windows.Forms.Label lbl_euro2;
        private System.Windows.Forms.Label lbl_dolar2;
        private System.Windows.Forms.Label lbl_peso2;
        private System.Windows.Forms.TextBox txb_euroXeuro;
        private System.Windows.Forms.TextBox txb_euroXdolar;
        private System.Windows.Forms.TextBox txb_euroXpeso;
        private System.Windows.Forms.TextBox txb_dolarXeuro;
        private System.Windows.Forms.TextBox txb_dolarXdolar;
        private System.Windows.Forms.TextBox txb_dolarXpeso;
        private System.Windows.Forms.TextBox txb_pesoXeuro;
        private System.Windows.Forms.TextBox txb_pesoXdolar;
        private System.Windows.Forms.TextBox txb_pesoXpeso;
    }
}
