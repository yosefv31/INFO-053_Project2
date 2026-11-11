using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.Logica
{
    internal class Cla_Trama
    {
        #region Atributos
        public int Cod_Viaje { get; set; }
        public string Term_Salida { get; set; }
        public string Term_Llegada { get; set; }
        public int Can_Boletos { get; set; }
        #endregion

        #region Metodos
        public Cla_Trama()
        {
        }
        public Cla_Trama(int PCodigo, 
                         int PCan_Boletos)
        {
            Cod_Viaje = PCodigo;
            Can_Boletos = PCan_Boletos;
        }
        #endregion
    }
}
