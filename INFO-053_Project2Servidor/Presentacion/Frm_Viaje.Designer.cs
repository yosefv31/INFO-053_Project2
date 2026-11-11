namespace Servidor.Presentacion
{
    partial class Frm_Viaje
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
            this.Lbl_Cod_Viaje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_TLlegada = new System.Windows.Forms.Label();
            this.Lbl_Costo = new System.Windows.Forms.Label();
            this.Costo = new System.Windows.Forms.Label();
            this.Cmb_TSalida = new System.Windows.Forms.ComboBox();
            this.Msk_Costo = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Descripcion = new System.Windows.Forms.Label();
            this.Nud_Capacidad = new System.Windows.Forms.NumericUpDown();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Txt_Cod_Viaje = new System.Windows.Forms.TextBox();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Bnt_Grabar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Cmb_TLlegada = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Capacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Cod_Viaje
            // 
            this.Lbl_Cod_Viaje.AutoSize = true;
            this.Lbl_Cod_Viaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Lbl_Cod_Viaje.Location = new System.Drawing.Point(17, 15);
            this.Lbl_Cod_Viaje.Name = "Lbl_Cod_Viaje";
            this.Lbl_Cod_Viaje.Size = new System.Drawing.Size(186, 29);
            this.Lbl_Cod_Viaje.TabIndex = 0;
            this.Lbl_Cod_Viaje.Text = "Código de Viaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label2.Location = new System.Drawing.Point(17, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Terminal de Salida";
            // 
            // Lbl_TLlegada
            // 
            this.Lbl_TLlegada.AutoSize = true;
            this.Lbl_TLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Lbl_TLlegada.Location = new System.Drawing.Point(17, 191);
            this.Lbl_TLlegada.Name = "Lbl_TLlegada";
            this.Lbl_TLlegada.Size = new System.Drawing.Size(236, 29);
            this.Lbl_TLlegada.TabIndex = 2;
            this.Lbl_TLlegada.Text = "Terminal de Llegada";
            // 
            // Lbl_Costo
            // 
            this.Lbl_Costo.AutoSize = true;
            this.Lbl_Costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Lbl_Costo.Location = new System.Drawing.Point(17, 298);
            this.Lbl_Costo.Name = "Lbl_Costo";
            this.Lbl_Costo.Size = new System.Drawing.Size(76, 29);
            this.Lbl_Costo.TabIndex = 3;
            this.Lbl_Costo.Text = "Costo";
            // 
            // Costo
            // 
            this.Costo.AutoSize = true;
            this.Costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Costo.Location = new System.Drawing.Point(17, 248);
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(129, 29);
            this.Costo.TabIndex = 4;
            this.Costo.Text = "Capacidad";
            // 
            // Cmb_TSalida
            // 
            this.Cmb_TSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Cmb_TSalida.FormattingEnabled = true;
            this.Cmb_TSalida.Location = new System.Drawing.Point(307, 114);
            this.Cmb_TSalida.Name = "Cmb_TSalida";
            this.Cmb_TSalida.Size = new System.Drawing.Size(181, 37);
            this.Cmb_TSalida.TabIndex = 3;
            this.Cmb_TSalida.SelectionChangeCommitted += new System.EventHandler(this.Cmb_TSalida_SelectionChangeCommitted);
            this.Cmb_TSalida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_TSalida_KeyPress);
            // 
            // Msk_Costo
            // 
            this.Msk_Costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.Msk_Costo.Location = new System.Drawing.Point(307, 296);
            this.Msk_Costo.Name = "Msk_Costo";
            this.Msk_Costo.Size = new System.Drawing.Size(181, 32);
            this.Msk_Costo.TabIndex = 6;
            this.Msk_Costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Msk_Costo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.Msk_Costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Msk_Costo_KeyPress);
            // 
            // Lbl_Descripcion
            // 
            this.Lbl_Descripcion.AutoSize = true;
            this.Lbl_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Lbl_Descripcion.Location = new System.Drawing.Point(17, 65);
            this.Lbl_Descripcion.Name = "Lbl_Descripcion";
            this.Lbl_Descripcion.Size = new System.Drawing.Size(141, 29);
            this.Lbl_Descripcion.TabIndex = 9;
            this.Lbl_Descripcion.Text = "Descripción";
            // 
            // Nud_Capacidad
            // 
            this.Nud_Capacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Nud_Capacidad.Location = new System.Drawing.Point(307, 243);
            this.Nud_Capacidad.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.Nud_Capacidad.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Nud_Capacidad.Name = "Nud_Capacidad";
            this.Nud_Capacidad.Size = new System.Drawing.Size(120, 35);
            this.Nud_Capacidad.TabIndex = 5;
            this.Nud_Capacidad.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.Nud_Capacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nud_Capacidad_KeyPress);
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.Txt_Descripcion.Location = new System.Drawing.Point(307, 65);
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(498, 32);
            this.Txt_Descripcion.TabIndex = 2;
            this.Txt_Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Descripcion_KeyPress);
            // 
            // Txt_Cod_Viaje
            // 
            this.Txt_Cod_Viaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.Txt_Cod_Viaje.Location = new System.Drawing.Point(307, 15);
            this.Txt_Cod_Viaje.Name = "Txt_Cod_Viaje";
            this.Txt_Cod_Viaje.Size = new System.Drawing.Size(80, 32);
            this.Txt_Cod_Viaje.TabIndex = 1;
            this.Txt_Cod_Viaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cod_Viaje_KeyPress);
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.Enabled = false;
            this.Btn_Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Btn_Borrar.Location = new System.Drawing.Point(432, 352);
            this.Btn_Borrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(119, 53);
            this.Btn_Borrar.TabIndex = 14;
            this.Btn_Borrar.Text = "&Eliminar";
            this.Btn_Borrar.UseVisualStyleBackColor = true;
            // 
            // Bnt_Grabar
            // 
            this.Bnt_Grabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Bnt_Grabar.Location = new System.Drawing.Point(305, 352);
            this.Bnt_Grabar.Margin = new System.Windows.Forms.Padding(4);
            this.Bnt_Grabar.Name = "Bnt_Grabar";
            this.Bnt_Grabar.Size = new System.Drawing.Size(119, 53);
            this.Bnt_Grabar.TabIndex = 11;
            this.Bnt_Grabar.Text = "&Grabar";
            this.Bnt_Grabar.UseVisualStyleBackColor = true;
            this.Bnt_Grabar.Click += new System.EventHandler(this.Bnt_Grabar_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Btn_Salir.Location = new System.Drawing.Point(686, 352);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(119, 53);
            this.Btn_Salir.TabIndex = 13;
            this.Btn_Salir.Text = "&Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Btn_Limpiar.Location = new System.Drawing.Point(559, 352);
            this.Btn_Limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(119, 53);
            this.Btn_Limpiar.TabIndex = 12;
            this.Btn_Limpiar.Text = "&Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Cmb_TLlegada
            // 
            this.Cmb_TLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Cmb_TLlegada.FormattingEnabled = true;
            this.Cmb_TLlegada.Location = new System.Drawing.Point(307, 183);
            this.Cmb_TLlegada.Name = "Cmb_TLlegada";
            this.Cmb_TLlegada.Size = new System.Drawing.Size(181, 37);
            this.Cmb_TLlegada.TabIndex = 4;
            this.Cmb_TLlegada.SelectionChangeCommitted += new System.EventHandler(this.Cmb_TLlegada_SelectionChangeCommitted);
            this.Cmb_TLlegada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cmb_TLlegada_KeyPress);
            // 
            // Frm_Viaje
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(816, 419);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Borrar);
            this.Controls.Add(this.Bnt_Grabar);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Txt_Cod_Viaje);
            this.Controls.Add(this.Txt_Descripcion);
            this.Controls.Add(this.Nud_Capacidad);
            this.Controls.Add(this.Lbl_Descripcion);
            this.Controls.Add(this.Msk_Costo);
            this.Controls.Add(this.Cmb_TLlegada);
            this.Controls.Add(this.Cmb_TSalida);
            this.Controls.Add(this.Costo);
            this.Controls.Add(this.Lbl_Costo);
            this.Controls.Add(this.Lbl_TLlegada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_Cod_Viaje);
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = "Frm_Viaje";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Viajes";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Viaje_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Capacidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Cod_Viaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_TLlegada;
        private System.Windows.Forms.Label Lbl_Costo;
        private System.Windows.Forms.Label Costo;
        private System.Windows.Forms.ComboBox Cmb_TSalida;
        private System.Windows.Forms.MaskedTextBox Msk_Costo;
        private System.Windows.Forms.Label Lbl_Descripcion;
        private System.Windows.Forms.NumericUpDown Nud_Capacidad;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.TextBox Txt_Cod_Viaje;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.Button Bnt_Grabar;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.ComboBox Cmb_TLlegada;
    }
}