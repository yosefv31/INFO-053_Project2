using System;
using System.Collections;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.Logica
{
    internal class Cla_Viaje
    {
        #region Atributos
        public static Cla_Terminal Obj_Terminal = new Cla_Terminal();
        public ArrayList Lista_Terminal = new ArrayList();
        public int Cod_Viaje { get; set; }
        public string Dsc_Viaje { get; set; }
        public string Term_Salida { get; set; }
        public string Term_Llegada { get; set; }
        public int Capacidad { get; set; }

        public int[,] Mat_Espacios { get; set;}
        public int[] Vec_Fila_Final { get; set;}

        public double Costo { get; set; }
        #endregion
        #region Metodos
        public Cla_Viaje(int PCod_Viaje,
                         string PDsc_viaje,
                         string PTerm_Salida,
                         string PTerm_Llegada,
                         int    PCapacidad,
                         double PCosto)
        {
            Cod_Viaje = PCod_Viaje; 
            Dsc_Viaje = PDsc_viaje;
            Term_Salida = PTerm_Salida;
            Term_Llegada=PTerm_Llegada;
            Capacidad = PCapacidad;
            Costo = PCosto;
            int[,] Mat_Espacios;
            Vec_Fila_Final = new int[10];
            LLenar_Matriz();
        }
        public Cla_Viaje()
        {
        }
        public void LLenar_Matriz()
        {
            Mat_Espacios = new int[((Capacidad - 10) / 5), 5];
            Vec_Fila_Final = new int[10];

            for (int i = 0; i < Mat_Espacios.GetLength(0); i++)
                for (int j = 0; j < Mat_Espacios.GetLength(1); j++)
                    Mat_Espacios[i, j] = 1;

            for (int k = 0; k < Vec_Fila_Final.GetLength(0); k++)
                Vec_Fila_Final[k] = 1;


        }
        public int Buscar_Viaje(Cla_Viaje[] PArray_Viaje, int PCodigo)
        {
            for (int i = 0; i < PArray_Viaje.Length; i++)
            {
                if (PArray_Viaje[i] != null)
                {
                    if (PArray_Viaje[i].Cod_Viaje == PCodigo)
                        return i;
                }
                else
                    return -1;
            }

            return -1;
        }
        public string Busca_Espacios(int Can_Boletos)
        {
            string Filas = "";
            int Remanente = Can_Boletos;
            for (int i = 0; i < Mat_Espacios.GetLength(0); i++)
            {
                for (int j = 0; j < Mat_Espacios.GetLength(1); j++)
                    if (Mat_Espacios[i, j] == 1)
                    {
                        if (Remanente != 0)
                        {
                            if (Remanente == Can_Boletos)
                                Filas += (i + 1).ToString() + (j + 1).ToString();
                            else
                                Filas += (j + 1).ToString();

                            Mat_Espacios[i, j] = 0;
                            Remanente -= 1;
                        }
                        else
                            return Filas;
                    }
            }

            for (int k = 0; k < Vec_Fila_Final.GetLength(0); k++)
            {
                if (Vec_Fila_Final[k] == 1)
                {
                    if (Remanente != 0)
                    {
                        if (Remanente == Can_Boletos)
                            Filas += (Mat_Espacios.GetLength(0) + 1).ToString() + (k + 1).ToString();
                        else
                            Filas += (k + 1).ToString();

                        Vec_Fila_Final[k] = 0;
                        Remanente -= 1;
                    }
                    else
                        return Filas;
                }
            }
            if (Remanente == Can_Boletos)
                return "-1";
            else
                return Filas;
        }
        #endregion
    }
}

