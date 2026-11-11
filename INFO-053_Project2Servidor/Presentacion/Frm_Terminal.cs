using Servidor.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servidor.Presentacion
{
    public partial class Frm_Terminal : Form
    {

        Cla_Mensaje Msg = new Cla_Mensaje();

        static Cla_Terminal Obj_Terminal = new Cla_Terminal();
        static Cla_Viaje Obj_Viaje = new Cla_Viaje();
        static Cla_Persistencia Obj_Persistencia = new Cla_Persistencia();
        static Cla_Terminal[] Array_Terminal = new Cla_Terminal[20];
        static Cla_Viaje[] Array_Viaje=new Cla_Viaje[20];
        int Indice_Viaje = 0;
        public Frm_Terminal()
        {
            InitializeComponent();
            Obj_Persistencia.Mostrar_Arreglo();
            Indice_Viaje = Obj_Persistencia.Indice_Viaje;

            // AUTONUMERACION DEL CODIGO DE VIAJE
                        
            Txt_Cod_Viaje.Text = (Indice_Viaje + 1).ToString("000");
            
            if (Array_Viaje[0] != null)
            {
                Msg.Mensaje(Array_Viaje[0].Dsc_Viaje);
                Msg.Mensaje("Bendito Dios");
            }

        }
    }
}
