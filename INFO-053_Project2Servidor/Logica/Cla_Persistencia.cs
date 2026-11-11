using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Servidor.Logica
{
    internal class Cla_Persistencia
    {
        #region Atributos
        static Cla_Mensaje Msg = new Cla_Mensaje();    
        public static Cla_Viaje[] PArray_Viaje { get; set; }
        public int Indice_Viaje { get; set; }
        #endregion

        #region Metodos 
        public Cla_Persistencia()
        {
            if (PArray_Viaje == null)
                PArray_Viaje = new Cla_Viaje[20];
            else
                Obtener_Indice();
        }
        #endregion

        #region Metodos
        public void Crear_Datos_Viaje()
        {
            PArray_Viaje[0] = new Cla_Viaje(1, "SAN JOSE EL COCO", "01", "02", 20, 4500);
            PArray_Viaje[1] = new Cla_Viaje(2, "EL COCO SAN JOSE", "02", "01", 20, 5500);
            Indice_Viaje = 2;
        }

        public void Cargar_Matriz(Cla_Viaje[] PMatriz, int PTipo)
        // 1 = Cargar la Matriz de la Pantalla con lo que tenga Array Viaja
        // 2 = Cargar Array_Viaje con la Matriz que Tenga La Pantalla  
        {
            if (PTipo == 1)
                {
                    PMatriz = PArray_Viaje;
                    if (PArray_Viaje[0] != null)
                        Obtener_Indice();
                 }
            else
                PArray_Viaje = PMatriz;
           
        }
        public Cla_Viaje[] Cargar_Matriz2()
        // 1 = Cargar la Matriz de la Pantalla con lo que tenga Array Viaja
        // 2 = Cargar Array_Viaje con la Matriz que Tenga La Pantalla  
        {
            if (PArray_Viaje[0] != null)
                Obtener_Indice();
            return PArray_Viaje;
        }
        public void Obtener_Indice()
        {
            Indice_Viaje = 0;
            for (int i = 0; i < PArray_Viaje.GetLength(0); i++)
                if (PArray_Viaje[i] != null)
                    Indice_Viaje++;
                else
                    if (i < PArray_Viaje.Length)
                        return;

            return;
        }
        public void Mostrar_Arreglo()
        {
            if (PArray_Viaje[0] != null)
                Msg.Mensaje(PArray_Viaje[0].Dsc_Viaje);
        }

        #endregion
    }
}
