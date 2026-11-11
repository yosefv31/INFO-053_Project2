namespace Servidor.Presentacion
{
    partial class Frm_Sockect
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
            this.Lbl_Clientesc = new System.Windows.Forms.Label();
            this.Txt_Clientes = new System.Windows.Forms.TextBox();
            this.Txt_Mensajes = new System.Windows.Forms.TextBox();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Clientesc
            // 
            this.Lbl_Clientesc.AutoSize = true;
            this.Lbl_Clientesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Clientesc.Location = new System.Drawing.Point(22, 23);
            this.Lbl_Clientesc.Name = "Lbl_Clientesc";
            this.Lbl_Clientesc.Size = new System.Drawing.Size(183, 24);
            this.Lbl_Clientesc.TabIndex = 0;
            this.Lbl_Clientesc.Text = "Clientes Conectados";
            // 
            // Txt_Clientes
            // 
            this.Txt_Clientes.Enabled = false;
            this.Txt_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Clientes.Location = new System.Drawing.Point(211, 23);
            this.Txt_Clientes.Name = "Txt_Clientes";
            this.Txt_Clientes.Size = new System.Drawing.Size(167, 29);
            this.Txt_Clientes.TabIndex = 1;
            // 
            // Txt_Mensajes
            // 
            this.Txt_Mensajes.Location = new System.Drawing.Point(26, 69);
            this.Txt_Mensajes.Multiline = true;
            this.Txt_Mensajes.Name = "Txt_Mensajes";
            this.Txt_Mensajes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Txt_Mensajes.Size = new System.Drawing.Size(752, 350);
            this.Txt_Mensajes.TabIndex = 2;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Btn_Salir.Location = new System.Drawing.Point(704, 426);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(72, 39);
            this.Btn_Salir.TabIndex = 14;
            this.Btn_Salir.Text = "&Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Frm_Sockect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 493);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Txt_Mensajes);
            this.Controls.Add(this.Txt_Clientes);
            this.Controls.Add(this.Lbl_Clientesc);
            this.KeyPreview = true;
            this.Name = "Frm_Sockect";
            this.Text = "Buses UH - Venta de Boletos";
            this.Load += new System.EventHandler(this.Frm_Sockect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Clientesc;
        private System.Windows.Forms.TextBox Txt_Clientes;
        private System.Windows.Forms.TextBox Txt_Mensajes;
        private System.Windows.Forms.Button Btn_Salir;
    }
}