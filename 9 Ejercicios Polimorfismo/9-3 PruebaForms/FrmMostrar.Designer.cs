﻿namespace _9_3_PruebaForms
{
    partial class FrmMostrar
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
            this.rtbx_informador = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbx_informador
            // 
            this.rtbx_informador.Location = new System.Drawing.Point(12, 12);
            this.rtbx_informador.Name = "rtbx_informador";
            this.rtbx_informador.Size = new System.Drawing.Size(299, 400);
            this.rtbx_informador.TabIndex = 0;
            this.rtbx_informador.Text = "";
            // 
            // FrmMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 427);
            this.Controls.Add(this.rtbx_informador);
            this.Name = "FrmMostrar";
            this.Text = "FrmMostrar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbx_informador;
    }
}