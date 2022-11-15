namespace _15_5_FromsNotepad
{
    partial class FrmNote
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ts_archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirTs_archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarTs_archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoTs_archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbx_lectoescritura = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsSs_cantCaracteres = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_archivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ts_archivo
            // 
            this.ts_archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirTs_archivo,
            this.guardarTs_archivo,
            this.guardarComoTs_archivo});
            this.ts_archivo.Name = "ts_archivo";
            this.ts_archivo.Size = new System.Drawing.Size(60, 20);
            this.ts_archivo.Text = "Archivo";
            // 
            // abrirTs_archivo
            // 
            this.abrirTs_archivo.Name = "abrirTs_archivo";
            this.abrirTs_archivo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirTs_archivo.Size = new System.Drawing.Size(231, 22);
            this.abrirTs_archivo.Text = "Abrir";
            this.abrirTs_archivo.Click += new System.EventHandler(this.abrirTs_archivo_Click);
            // 
            // guardarTs_archivo
            // 
            this.guardarTs_archivo.Name = "guardarTs_archivo";
            this.guardarTs_archivo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarTs_archivo.Size = new System.Drawing.Size(231, 22);
            this.guardarTs_archivo.Text = "Guardar";
            this.guardarTs_archivo.Click += new System.EventHandler(this.guardarTs_archivo_Click);
            // 
            // guardarComoTs_archivo
            // 
            this.guardarComoTs_archivo.Name = "guardarComoTs_archivo";
            this.guardarComoTs_archivo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.guardarComoTs_archivo.Size = new System.Drawing.Size(231, 22);
            this.guardarComoTs_archivo.Text = "Guardar como...";
            this.guardarComoTs_archivo.Click += new System.EventHandler(this.guardarComoTs_archivo_Click);
            // 
            // rtbx_lectoescritura
            // 
            this.rtbx_lectoescritura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbx_lectoescritura.Location = new System.Drawing.Point(0, 24);
            this.rtbx_lectoescritura.Name = "rtbx_lectoescritura";
            this.rtbx_lectoescritura.Size = new System.Drawing.Size(473, 537);
            this.rtbx_lectoescritura.TabIndex = 1;
            this.rtbx_lectoescritura.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSs_cantCaracteres});
            this.toolStrip1.Location = new System.Drawing.Point(0, 536);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(473, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.TextChanged += new System.EventHandler(this.toolStrip1_TextChanged);
            // 
            // tsSs_cantCaracteres
            // 
            this.tsSs_cantCaracteres.Name = "tsSs_cantCaracteres";
            this.tsSs_cantCaracteres.Size = new System.Drawing.Size(86, 22);
            this.tsSs_cantCaracteres.Text = "toolStripLabel1";
            // 
            // FrmNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 561);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rtbx_lectoescritura);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.FrmNote_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ts_archivo;
        private System.Windows.Forms.ToolStripMenuItem abrirTs_archivo;
        private System.Windows.Forms.ToolStripMenuItem guardarTs_archivo;
        private System.Windows.Forms.ToolStripMenuItem guardarComoTs_archivo;
        private System.Windows.Forms.RichTextBox rtbx_lectoescritura;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsSs_cantCaracteres;
    }
}
