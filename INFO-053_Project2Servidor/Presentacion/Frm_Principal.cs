using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servidor.Logica;

namespace Servidor.Presentacion
{
    
    public partial class Frm_Principal : Form
    {
        #region Atributos
        Cla_Mensaje Obj_Util = new Cla_Mensaje();
        static Cla_Persistencia Obj_Persistencia;
        static Cla_Terminal[] Array_Terminal;
        static Cla_Viaje[] Array_Viaje;
        
        #endregion

        public Frm_Principal()
        {
            InitializeComponent();
        }

        #region Teclas
        private void Frm_Principal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                if (Obj_Util.Salir() == 1)
                    Dispose();
            }
        }
        #endregion

        #region Botones
        private void Cmd_Viajes_Click(object sender, EventArgs e)
        {
            Frm_Viaje Frm_OViaje = new Frm_Viaje();  
            this.Hide();
            Frm_OViaje.ShowDialog();
            this.Show();
        }

        private void Cmd_Sockect_Click(object sender, EventArgs e)
        {
            Frm_Sockect Frm_OSockect = new Frm_Sockect(); 
            this.Hide();    
            Frm_OSockect.ShowDialog();  
            this.Show();    
        }
        #endregion

        private void Cmd_Terminales_Click(object sender, EventArgs e)
        {
            Frm_Terminal Frm_OTerminal = new Frm_Terminal();
            this.Hide();
            Frm_OTerminal.ShowDialog();
            this.Show();
        }
    }
}
