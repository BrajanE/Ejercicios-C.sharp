namespace _5_5
{
    partial class FrmConversor
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
            this.lbl_tituloBinario = new System.Windows.Forms.Label();
            this.lbl_tituloDecimal = new System.Windows.Forms.Label();
            this.txb_binario = new System.Windows.Forms.TextBox();
            this.txb_decimal = new System.Windows.Forms.TextBox();
            this.txb_binResult = new System.Windows.Forms.TextBox();
            this.txb_decimResult = new System.Windows.Forms.TextBox();
            this.btn_binXdecimal = new System.Windows.Forms.Button();
            this.btn_deciXbinario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_tituloBinario
            // 
            this.lbl_tituloBinario.AutoSize = true;
            this.lbl_tituloBinario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tituloBinario.Location = new System.Drawing.Point(12, 21);
            this.lbl_tituloBinario.Name = "lbl_tituloBinario";
            this.lbl_tituloBinario.Size = new System.Drawing.Size(135, 21);
            this.lbl_tituloBinario.TabIndex = 0;
            this.lbl_tituloBinario.Text = "Binario a Decimal";
            // 
            // lbl_tituloDecimal
            // 
            this.lbl_tituloDecimal.AutoSize = true;
            this.lbl_tituloDecimal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tituloDecimal.Location = new System.Drawing.Point(12, 53);
            this.lbl_tituloDecimal.Name = "lbl_tituloDecimal";
            this.lbl_tituloDecimal.Size = new System.Drawing.Size(129, 20);
            this.lbl_tituloDecimal.TabIndex = 1;
            this.lbl_tituloDecimal.Text = "Decimal a Binario";
            // 
            // txb_binario
            // 
            this.txb_binario.Location = new System.Drawing.Point(175, 19);
            this.txb_binario.Name = "txb_binario";
            this.txb_binario.Size = new System.Drawing.Size(136, 23);
            this.txb_binario.TabIndex = 2;
            // 
            // txb_decimal
            // 
            this.txb_decimal.Location = new System.Drawing.Point(175, 50);
            this.txb_decimal.Name = "txb_decimal";
            this.txb_decimal.Size = new System.Drawing.Size(136, 23);
            this.txb_decimal.TabIndex = 3;
            // 
            // txb_binResult
            // 
            this.txb_binResult.Location = new System.Drawing.Point(398, 19);
            this.txb_binResult.Name = "txb_binResult";
            this.txb_binResult.ReadOnly = true;
            this.txb_binResult.Size = new System.Drawing.Size(136, 23);
            this.txb_binResult.TabIndex = 4;
            // 
            // txb_decimResult
            // 
            this.txb_decimResult.Location = new System.Drawing.Point(398, 48);
            this.txb_decimResult.Name = "txb_decimResult";
            this.txb_decimResult.ReadOnly = true;
            this.txb_decimResult.Size = new System.Drawing.Size(136, 23);
            this.txb_decimResult.TabIndex = 5;
            // 
            // btn_binXdecimal
            // 
            this.btn_binXdecimal.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_binXdecimal.Location = new System.Drawing.Point(317, 19);
            this.btn_binXdecimal.Name = "btn_binXdecimal";
            this.btn_binXdecimal.Size = new System.Drawing.Size(75, 23);
            this.btn_binXdecimal.TabIndex = 6;
            this.btn_binXdecimal.Text = "->";
            this.btn_binXdecimal.UseVisualStyleBackColor = true;
            this.btn_binXdecimal.Click += new System.EventHandler(this.btn_binXdecimal_Click);
            // 
            // btn_deciXbinario
            // 
            this.btn_deciXbinario.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_deciXbinario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_deciXbinario.Location = new System.Drawing.Point(317, 50);
            this.btn_deciXbinario.Name = "btn_deciXbinario";
            this.btn_deciXbinario.Size = new System.Drawing.Size(75, 23);
            this.btn_deciXbinario.TabIndex = 7;
            this.btn_deciXbinario.Text = "->";
            this.btn_deciXbinario.UseVisualStyleBackColor = true;
            this.btn_deciXbinario.Click += new System.EventHandler(this.btn_deciXbinario_Click);
            // 
            // FrmConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 95);
            this.Controls.Add(this.btn_deciXbinario);
            this.Controls.Add(this.btn_binXdecimal);
            this.Controls.Add(this.txb_decimResult);
            this.Controls.Add(this.txb_binResult);
            this.Controls.Add(this.txb_decimal);
            this.Controls.Add(this.txb_binario);
            this.Controls.Add(this.lbl_tituloDecimal);
            this.Controls.Add(this.lbl_tituloBinario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmConversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Numerico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tituloBinario;
        private System.Windows.Forms.Label lbl_tituloDecimal;
        private System.Windows.Forms.TextBox txb_binario;
        private System.Windows.Forms.TextBox txb_decimal;
        private System.Windows.Forms.TextBox txb_binResult;
        private System.Windows.Forms.TextBox txb_decimResult;
        private System.Windows.Forms.Button btn_binXdecimal;
        private System.Windows.Forms.Button btn_deciXbinario;
    }
}
