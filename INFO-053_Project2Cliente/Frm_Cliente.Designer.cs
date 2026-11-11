namespace Cliente
{
    partial class Frm_Cliente
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
            Txt_Mensaje = new TextBox();
            Bnt_Enviar = new Button();
            Btn_Conectar = new Button();
            Btn_Desconectar = new Button();
            Txt_Servidor = new TextBox();
            SuspendLayout();
            // 
            // Txt_Mensaje
            // 
            Txt_Mensaje.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Mensaje.Location = new Point(4, 64);
            Txt_Mensaje.Margin = new Padding(3, 2, 3, 2);
            Txt_Mensaje.Multiline = true;
            Txt_Mensaje.Name = "Txt_Mensaje";
            Txt_Mensaje.Size = new Size(754, 209);
            Txt_Mensaje.TabIndex = 4;
            // 
            // Bnt_Enviar
            // 
            Bnt_Enviar.Enabled = false;
            Bnt_Enviar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Bnt_Enviar.Location = new Point(648, 289);
            Bnt_Enviar.Margin = new Padding(3, 2, 3, 2);
            Bnt_Enviar.Name = "Bnt_Enviar";
            Bnt_Enviar.Size = new Size(110, 37);
            Bnt_Enviar.TabIndex = 5;
            Bnt_Enviar.Text = "&Enviar";
            Bnt_Enviar.UseVisualStyleBackColor = true;
            Bnt_Enviar.Click += Bnt_Enviar_Click;
            // 
            // Btn_Conectar
            // 
            Btn_Conectar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Conectar.Location = new Point(512, 11);
            Btn_Conectar.Margin = new Padding(3, 2, 3, 2);
            Btn_Conectar.Name = "Btn_Conectar";
            Btn_Conectar.Size = new Size(108, 37);
            Btn_Conectar.TabIndex = 2;
            Btn_Conectar.Text = "&Conectar";
            Btn_Conectar.UseVisualStyleBackColor = true;
            Btn_Conectar.Click += Btn_Conectar_Click;
            // 
            // Btn_Desconectar
            // 
            Btn_Desconectar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Desconectar.Location = new Point(626, 11);
            Btn_Desconectar.Margin = new Padding(3, 2, 3, 2);
            Btn_Desconectar.Name = "Btn_Desconectar";
            Btn_Desconectar.Size = new Size(132, 37);
            Btn_Desconectar.TabIndex = 3;
            Btn_Desconectar.Text = "&Desconectar";
            Btn_Desconectar.UseVisualStyleBackColor = true;
            Btn_Desconectar.Click += Btn_Desconectar_Click;
            // 
            // Txt_Servidor
            // 
            Txt_Servidor.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Servidor.Location = new Point(4, 16);
            Txt_Servidor.Name = "Txt_Servidor";
            Txt_Servidor.Size = new Size(502, 32);
            Txt_Servidor.TabIndex = 1;
            // 
            // Frm_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 348);
            Controls.Add(Txt_Servidor);
            Controls.Add(Btn_Desconectar);
            Controls.Add(Btn_Conectar);
            Controls.Add(Bnt_Enviar);
            Controls.Add(Txt_Mensaje);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Frm_Cliente";
            Text = "Peticiones de Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_Mensaje;
        private Button Bnt_Enviar;
        private Button Btn_Conectar;
        private Button Btn_Desconectar;
        private TextBox Txt_Servidor;
    }
}