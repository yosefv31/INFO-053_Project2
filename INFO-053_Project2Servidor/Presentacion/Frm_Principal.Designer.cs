namespace Servidor.Presentacion
{
    partial class Frm_Principal
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
            this.Cmd_Viajes = new System.Windows.Forms.Button();
            this.Cmd_Sockect = new System.Windows.Forms.Button();
            this.Lbl_Principal = new System.Windows.Forms.Label();
            this.Cmd_Terminales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cmd_Viajes
            // 
            this.Cmd_Viajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Viajes.Location = new System.Drawing.Point(44, 161);
            this.Cmd_Viajes.Name = "Cmd_Viajes";
            this.Cmd_Viajes.Size = new System.Drawing.Size(173, 71);
            this.Cmd_Viajes.TabIndex = 0;
            this.Cmd_Viajes.Text = "Mantenimiento de &Viajes";
            this.Cmd_Viajes.UseVisualStyleBackColor = true;
            this.Cmd_Viajes.Click += new System.EventHandler(this.Cmd_Viajes_Click);
            // 
            // Cmd_Sockect
            // 
            this.Cmd_Sockect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Sockect.Location = new System.Drawing.Point(44, 254);
            this.Cmd_Sockect.Name = "Cmd_Sockect";
            this.Cmd_Sockect.Size = new System.Drawing.Size(173, 71);
            this.Cmd_Sockect.TabIndex = 1;
            this.Cmd_Sockect.Text = "&Sockect de Comunicacion";
            this.Cmd_Sockect.UseVisualStyleBackColor = true;
            this.Cmd_Sockect.Click += new System.EventHandler(this.Cmd_Sockect_Click);
            // 
            // Lbl_Principal
            // 
            this.Lbl_Principal.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Principal.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Principal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl_Principal.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Principal.Name = "Lbl_Principal";
            this.Lbl_Principal.Size = new System.Drawing.Size(251, 60);
            this.Lbl_Principal.TabIndex = 2;
            this.Lbl_Principal.Text = "Menu Principal";
            this.Lbl_Principal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cmd_Terminales
            // 
            this.Cmd_Terminales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Terminales.Location = new System.Drawing.Point(44, 72);
            this.Cmd_Terminales.Name = "Cmd_Terminales";
            this.Cmd_Terminales.Size = new System.Drawing.Size(173, 71);
            this.Cmd_Terminales.TabIndex = 3;
            this.Cmd_Terminales.Text = "Mantenimiento de &Terminales";
            this.Cmd_Terminales.UseVisualStyleBackColor = true;
            this.Cmd_Terminales.Click += new System.EventHandler(this.Cmd_Terminales_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 346);
            this.Controls.Add(this.Cmd_Terminales);
            this.Controls.Add(this.Lbl_Principal);
            this.Controls.Add(this.Cmd_Sockect);
            this.Controls.Add(this.Cmd_Viajes);
            this.KeyPreview = true;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Principal";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Principal_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cmd_Viajes;
        private System.Windows.Forms.Button Cmd_Sockect;
        private System.Windows.Forms.Label Lbl_Principal;
        private System.Windows.Forms.Button Cmd_Terminales;
    }
}