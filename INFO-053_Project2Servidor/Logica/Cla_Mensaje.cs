using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Servidor.Logica
{
    public class Cla_Mensaje
    {
        public int Salir()
        {
            return Dialogo("Desea Salir ?", "Atención");
        }

        public int Grabar()
        {
            return Dialogo("Desea Grabar el Registro", "Atención");
        }
        public int Borrar()
        {
            return Dialogo("Desea Borrar el Registro", "Atención");
        }    
        private int Dialogo(string Pregunta, String Titulo)
        {
           MessageBoxResult result = MessageBox.Show(Pregunta, 
                                                     Titulo, 
                                                     MessageBoxButton.YesNoCancel, 
                                                     MessageBoxImage.Warning);
           switch (result)
           {
               case MessageBoxResult.Yes:
                   // User pressed Yes button
                   // ...
                   return 1;
               case MessageBoxResult.No:
                   // User pressed No button
                   // ...
                   return 0;
               case MessageBoxResult.Cancel:
                   return 0;
           }

           return 0;
        }
        public void Mensaje(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Atencion",
                            MessageBoxButton.OK,
                            MessageBoxImage.Warning);
        }
    }
}
