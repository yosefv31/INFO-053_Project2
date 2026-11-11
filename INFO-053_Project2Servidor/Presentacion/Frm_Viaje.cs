using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Servidor.Logica;


namespace Servidor.Presentacion
{
    public partial class Frm_Viaje : Form
    {
        #region Atributos
        Cla_Mensaje Msg = new Cla_Mensaje();
        static Cla_Persistencia Obj_Persistencia = new Cla_Persistencia();
        static Cla_Terminal Obj_Terminal = new Cla_Terminal();
        static Cla_Terminal[] Array_Terminal = new Cla_Terminal[20];
        static Cla_Viaje[] Array_Viaje = new Cla_Viaje[20];
        static Cla_Viaje Obj_Viaje = new Cla_Viaje();
                
        ArrayList Lista_Terminal = new ArrayList();
        ArrayList Lista_Terminal2 = new ArrayList();

        static int Indice_TSalida = 0;
        static int Indice_TLlegada = 0;
        static int Indice_Viaje = 0;
        static int Indice_Busqueda = -1;


        #endregion

        public Frm_Viaje()
        {
            InitializeComponent();

            // COMO NO HAY PANTALLA DE MANTENIMIENTO DE TERMINALES SE INCLUYEN A PIE

            Array_Terminal[0] = new Cla_Terminal();
            Array_Terminal[0].Cod_Terminal = 1;
            Array_Terminal[0].Dsc_Terminal = "SAN JOSE";

            Array_Terminal[1] = new Cla_Terminal();
            Array_Terminal[1].Cod_Terminal = 2;
            Array_Terminal[1].Dsc_Terminal = "EL COCO";

            Array_Terminal[2] = new Cla_Terminal();
            Array_Terminal[2].Cod_Terminal = 3;
            Array_Terminal[2].Dsc_Terminal = "JACO";

            Array_Terminal[3] = new Cla_Terminal();
            Array_Terminal[3].Cod_Terminal = 4;
            Array_Terminal[3].Dsc_Terminal = "DOMINICAL";

            Array_Terminal[3] = new Cla_Terminal();
            Array_Terminal[3].Cod_Terminal = 5;
            Array_Terminal[3].Dsc_Terminal = "LIBERIA";

            Llenar_Combo();
            Limpiar_Campos();
            Obj_Persistencia.Mostrar_Arreglo();
            Indice_Viaje = Obj_Persistencia.Indice_Viaje;

            // AUTONUMERACION DEL CODIGO DE VIAJE
            Txt_Cod_Viaje.Text = (Indice_Viaje + 1).ToString("000");
        }


        #region Codigo_Botones

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar_Campos();
        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Obj_Persistencia.Cargar_Matriz(Array_Viaje,2);
            this.Hide();    
        }
        private void Bnt_Grabar_Click(object sender, EventArgs e)
        {
            if (Validar_Viaje())
            {
                if (Msg.Grabar() == 1)
                {

                    if (Btn_Borrar.Enabled == true)
                        System.Console.WriteLine("*");
                    /*BD.Sentencia = Pue.Actualizar_Bd(Txt_Cod_Puesto.Text,
                                                     Txt_Descripcion.Text,
                                                     Double.Parse(Txt_Salario.Text).ToString());*/
                    else
                    /*BD.Sentencia = Pue.Insertar_Bd(Txt_Cod_Puesto.Text,
                                                   Txt_Descripcion.Text,
                                                   double.Parse(Txt_Salario.Text).ToString());*/

                    if (Grabar_Campos() == true)
                    {
                        Msg.Mensaje("Registro Grabado");
                        Limpiar_Campos();
                    }
                }
                else
                    Msg.Mensaje("Registro NO Grabado");
            }
            else
            {
                Msg.Mensaje("Registro NO Grabado, Revise los Datos");
                Txt_Cod_Viaje.Focus();
            }

        }
        #endregion
        #region Eventos
        private void Frm_Viaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                if (Msg.Salir() == 1)
                    Btn_Salir_Click(sender, e);
            }
        }

        private void Txt_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Cmb_TSalida.Focus();
            }
        }

        private void Nud_Capacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Msk_Costo.Focus();
            }

        }

        private void Msk_Costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Msk_Costo.Text = Msk_Costo.Text.Trim();
                Bnt_Grabar.Focus();
            }
        }

        private void Cmb_TSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Cmb_TLlegada.Focus();
            }

        }

        private void Cmb_TLlegada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Nud_Capacidad.Focus();
            }
        }

        private void Txt_Cod_Viaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (Validar_Viaje())
                    Txt_Descripcion.Focus();
            }
        }

        private void Cmb_TSalida_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Indice_TSalida = Convert.ToInt32(Cmb_TSalida.SelectedValue.ToString());
            Console.WriteLine("Indice de Salida {0}", Indice_TSalida);

            if (!Validar_Terminal())
            {
                Cmb_TSalida.Focus();
            }
        }
        private void Cmb_TLlegada_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Indice_TLlegada = Convert.ToInt32(Cmb_TLlegada.SelectedValue.ToString());
            Console.WriteLine("Indice de Llegada {0}", Indice_TLlegada);

            if (!Validar_Terminal())
            {
                Cmb_TLlegada.Focus();
            }
        }
        private bool Validar_Terminal()
        {
            if (Indice_TSalida == Indice_TLlegada)
            {
                Msg.Mensaje("La Terminal de Salida, debe ser Diferente a la de Llegada");
                return false;
            }
            else
                return true;
        }
        #endregion
        #region Metodos
        private void Limpiar_Campos()
        {
            Txt_Cod_Viaje.Text = string.Format("{0,3:000}",Indice_Viaje+1);
            Txt_Descripcion.Text = "";
            Cmb_TSalida.SelectedIndex = -1;
            Cmb_TLlegada.SelectedIndex = -1; 
            Nud_Capacidad.Value = 40;
            Msk_Costo.Text = "";
            Txt_Cod_Viaje.Focus();
        }
        private void Llenar_Combo()
        {
            for (int i = 0; i < Array_Terminal.Length; i++)
            {
                if (Array_Terminal[i] != null)
                {
                    Lista_Terminal.Add(new Cla_Terminal(Array_Terminal[i].Cod_Terminal,
                                                        Array_Terminal[i].Dsc_Terminal));
                    Lista_Terminal2.Add(new Cla_Terminal(Array_Terminal[i].Cod_Terminal,
                                                         Array_Terminal[i].Dsc_Terminal));

                }
                System.Console.WriteLine(Lista_Terminal.ToString());    

            }

            Cmb_TSalida.ValueMember = "Cod_Terminal";
            Cmb_TSalida.DisplayMember = "Dsc_Terminal";
            Cmb_TSalida.DataSource = Lista_Terminal;

            Cmb_TLlegada.ValueMember = "Cod_Terminal";
            Cmb_TLlegada.DisplayMember = "Dsc_Terminal";
            Cmb_TLlegada.DataSource = Lista_Terminal2;
        }

        private void Llenar_Campos()
        {
            Txt_Cod_Viaje.Text = Array_Viaje[Indice_Busqueda].Cod_Viaje.ToString();
            Txt_Descripcion.Text = Array_Viaje[Indice_Busqueda].Dsc_Viaje;


            Cmb_TSalida.Text = Obj_Terminal.Obtener_Terminal(Array_Terminal,
                                                             Convert.ToInt32(Array_Viaje[Indice_Busqueda].Term_Salida));

            Cmb_TLlegada.Text = Obj_Terminal.Obtener_Terminal(Array_Terminal,
                                                             Convert.ToInt32(Array_Viaje[Indice_Busqueda].Term_Llegada));
            Nud_Capacidad.Value = Array_Viaje[Indice_Busqueda].Capacidad;
            Msk_Costo.Text = Array_Viaje[Indice_Busqueda].Costo.ToString();
        }
    private Boolean Validar_Viaje()
        {
            if (Txt_Cod_Viaje.TextLength < 1)
            {
                Msg.Mensaje("Debe Digitar el Código de Viaje");
                Txt_Cod_Viaje.Focus();
                return false;
            }
            else
            {

                Indice_Busqueda = Obj_Viaje.Buscar_Viaje(Array_Viaje,
                                  Convert.ToInt32(Txt_Cod_Viaje.Text));

                if (Indice_Busqueda != -1)
                {
                    Llenar_Campos();
                    Txt_Cod_Viaje.Focus();
                    Msg.Mensaje("El Código de Viaje ya Existe");
                    Txt_Cod_Viaje.Focus();
                    return false;
                }
                else
                    return true;

                if (!Validar_Terminal())
                {
                    Cmb_TLlegada.Focus();
                    return false;
                }


                if (Txt_Descripcion.Text.Length < 10)
                {
                    Msg.Mensaje("La Descripción de la Terminal debe tener al MENOS 10 CARACTERES");
                    Txt_Descripcion.Focus();
                    return false;
                }

                if (Nud_Capacidad.Value < 0)
                {
                    Msg.Mensaje("Capacidad del viaje debe ser de al Menos 40 Pasajeros");
                    Nud_Capacidad.Focus();
                    return false;
                }

                if (Nud_Capacidad.Value < 0)
                {
                    Msg.Mensaje("Capacidad del viaje debe ser de al Menos 40 Pasajeros");
                    Nud_Capacidad.Focus();
                    return false;
                }

                if (Int32.Parse(Msk_Costo.Text) <= 0)
                {
                    Msg.Mensaje("Monto Mínimo de viaje deber ser igual a 3000");
                    Msk_Costo.Focus();
                    return false;
                }
            }
        }
        private bool Grabar_Campos()
        {
            try
            {
                Array_Viaje[Indice_Viaje] = new Cla_Viaje();
                Array_Viaje[Indice_Viaje].Cod_Viaje = Indice_Viaje + 1;
                Array_Viaje[Indice_Viaje].Dsc_Viaje = Txt_Descripcion.Text;
                Array_Viaje[Indice_Viaje].Term_Salida = Cmb_TSalida.SelectedValue.ToString();   
                Array_Viaje[Indice_Viaje].Term_Llegada = Cmb_TLlegada.SelectedValue.ToString();
                Array_Viaje[Indice_Viaje].Capacidad = Convert.ToInt32(Nud_Capacidad.Text);
                Array_Viaje[Indice_Viaje].Costo = Convert.ToInt32(Msk_Costo.Text);
                Array_Viaje[Indice_Viaje].LLenar_Matriz();

                Indice_Viaje++;
                return true;
            }
            catch (Exception ex)
            {
                Msg.Mensaje("Se presento el Siguiente Error al Grabar el Registro: " + ex.Message.ToString());
                return false;

            }
        }
        #endregion

    }
}
