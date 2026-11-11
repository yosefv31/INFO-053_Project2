namespace Servidor.Presentacion
{
    partial class Frm_Terminal
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
            this.Txt_Cod_Viaje = new System.Windows.Forms.TextBox();
            this.Lbl_Cod_Viaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Cod_Viaje
            // 
            this.Txt_Cod_Viaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.Txt_Cod_Viaje.Location = new System.Drawing.Point(505, 209);
            this.Txt_Cod_Viaje.Name = "Txt_Cod_Viaje";
            this.Txt_Cod_Viaje.Size = new System.Drawing.Size(80, 32);
            this.Txt_Cod_Viaje.TabIndex = 3;
            // 
            // Lbl_Cod_Viaje
            // 
            this.Lbl_Cod_Viaje.AutoSize = true;
            this.Lbl_Cod_Viaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Lbl_Cod_Viaje.Location = new System.Drawing.Point(215, 209);
            this.Lbl_Cod_Viaje.Name = "Lbl_Cod_Viaje";
            this.Lbl_Cod_Viaje.Size = new System.Drawing.Size(186, 29);
            this.Lbl_Cod_Viaje.TabIndex = 2;
            this.Lbl_Cod_Viaje.Text = "Código de Viaje";
            // 
            // Frm_Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_Cod_Viaje);
            this.Controls.Add(this.Lbl_Cod_Viaje);
            this.Name = "Frm_Terminal";
            this.Text = "Frm_Terminal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Cod_Viaje;
        private System.Windows.Forms.Label Lbl_Cod_Viaje;
    }
}