using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using Newtonsoft.Json;
using Servidor.Logica;

namespace Servidor.Presentacion
{
    public partial class Frm_Sockect : Form
    {
        #region Atributos
        Cla_Mensaje Obj_Util = new Cla_Mensaje();
        static Cla_Persistencia Obj_Persistencia= new Cla_Persistencia();
        static Cla_Viaje[] Array_Viaje=new Cla_Viaje[20];

        private TcpListener tcpListener;
        private Thread listenThread;
        private String lastMessage;
        private int clientesConectados;
        #endregion
        public Frm_Sockect()
        {
            InitializeComponent();

            Obj_Persistencia.Mostrar_Arreglo();
            Array_Viaje = Obj_Persistencia.Cargar_Matriz2();
            Obj_Util.Mensaje("1ro");
            Obj_Util.Mensaje(Obj_Persistencia.Indice_Viaje.ToString());

            if (Array_Viaje[0] != null)
                Obj_Util.Mensaje(Array_Viaje[0].Dsc_Viaje);
            else
            {
                Obj_Util.Mensaje("Error No Existen Viajes Registrados");
                //this.tcpListener.Stop();
                //this.listenThread.Abort();
                //this.Hide();
            }


            //Obj_Util.Mensaje(Obj_Persistencia.Indice_Viaje.ToString());

            Txt_Mensajes.Text = "Servidor Iniciado. Esperando por clientes...\n";
            tcpListener = new TcpListener(IPAddress.Any, 30000);
            listenThread = new Thread(new ThreadStart(ListenForClients));
            listenThread.Start();
        }


        #region Eventos
        private void Frm_Sockect_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                if (Obj_Util.Salir() == 1)
                    Btn_Salir_Click(sender, e);
            }
        }
        #endregion
        #region Procedimientos
        private void ListenForClients()
        {
            this.tcpListener.Start();
            while (true)
            {
                //blocks until a client has connected to the server
                TcpClient client = this.tcpListener.AcceptTcpClient();
                //create a thread to handle communication
                //with connected client
                clientesConectados++;

                if (InvokeRequired)
                    Invoke(new Action(() => Txt_Clientes.Text = clientesConectados.ToString()));

                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }
        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] message = new byte[4096];
            int bytesRead;
            while (true)
            {
                bytesRead = 0;
                try
                {
                    //blocks until a client sends a message
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    //a socket error has occured
                }
                if (bytesRead == 0)
                {
                    //the client has disconnected from the server
                    clientesConectados--;

                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => Txt_Clientes.Text = clientesConectados.ToString()));
                    }
                    break;
                }

                //message has successfully been received
                //encoder = new ASCIIEncoding();
                System.Diagnostics.Debug.WriteLine(encoder.GetString(message, 0, bytesRead));
                lastMessage = encoder.GetString(message, 0, bytesRead);


                if (InvokeRequired)
                {
                    Obj_Util.Mensaje(lastMessage);  
                    Invoke(new Action(() => Txt_Mensajes.Text += "Peticion:"+ lastMessage + "\r\n"));
                    String Opcion = Validar_Peticion(lastMessage);                  
                    byte[] buffer = new byte[4096];

                    buffer = encoder.GetBytes(Opcion);
                    Invoke(new Action(() => Txt_Mensajes.Text += "Respuesta:" + Opcion + "\r\n"));
                    clientStream.Write(buffer, 0, buffer.Length);
                    clientStream.Flush();
                }
            }
            // tcpClient.Close();
            // clientesConectados--;

            //if (InvokeRequired)
            //{
            //  Invoke(new Action(() => Txt_Clientes.Text = clientesConectados.ToString()));
            //}

        }
        
        public string Validar_Peticion(string Peticion)

        {
            int Indice_AViaje = -1;
            int Indice_Viaje = -1;
            string Asientos = "";
            for (int i = 1; i < Peticion.Trim().Length; i++)
                System.Console.Write("Posicion:{0} Letra: {1}", i, Peticion.Substring(i-1, 1));

            try
            {
                int Cod_Viaje = Int32.Parse(Peticion.Substring(0, 2));
                int Can_Boletos = Int32.Parse(Peticion.Substring(2, 2));

                //Obj_Trama = new Cla_Trama(Cod_Viaje, Can_Boletos);

                if (Can_Boletos > 5)
                    return "3Execede Cantidad Permitida";
                else
                    Indice_AViaje = Validar_Viaje(Cod_Viaje);

                if (Indice_AViaje != -1)
                {
                    Indice_Viaje = Array_Viaje[Indice_AViaje].Buscar_Viaje(Array_Viaje, Cod_Viaje);

                    if (Indice_Viaje != -1)
                    {
                        Asientos = Array_Viaje[Indice_Viaje].Busca_Espacios(Can_Boletos);
                        Obj_Util.Mensaje(Asientos);

                        if (Asientos != "-1")
                            return "1" + (Array_Viaje[Indice_Viaje].Cod_Viaje.ToString("00") +
                                   Asientos +
                                   (Array_Viaje[Indice_Viaje].Costo * Can_Boletos).ToString());
                        else
                            return "0No Hay Asientos Disponibles";

                    }
                    else
                        return "4Codigo de Viaje No Existe";
                }
                else
                    return "4Codigo de Viaje No Existe";

            }
            catch
            {
                return "5Formato Inválido";

            }
           
        }
        public int Validar_Viaje(int PCod_Viaje)
        {
            for (int i = 0; i < Array_Viaje.GetLength(0); i++)
            {
                if (Array_Viaje[i] != null) 
                   if (Array_Viaje[i].Cod_Viaje == PCod_Viaje)
                       return i;
            }
            return -1; 
        }   
        #endregion

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            if (clientesConectados == 0)
               {
                this.tcpListener.Stop();
                this.listenThread.Abort();
                this.Hide();
               }
            else
                Obj_Util.Mensaje("No se Puede Salir del Programa, Existen Clientes Conectados");
        }

        private void Frm_Sockect_Load(object sender, EventArgs e)
        {
        }
    }
}

