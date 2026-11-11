using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servidor.Logica
{
    internal class Cla_Terminal
    {
        #region Atributos
        public int Cod_Terminal { get; set; }
        public string Dsc_Terminal { get; set; }
        #endregion
        #region Metodos
        public Cla_Terminal()
        {
        }
        public Cla_Terminal(int PCodigo, String PDescripcion)
        {
            Cod_Terminal = PCodigo;
            Dsc_Terminal = PDescripcion;
        }
        #endregion
        #region Metodos
        public int Buscar_Terminal(Cla_Terminal[] PArray_Terminal, 
                                   int PCodigo)
        {
            for (int i = 0; i < PArray_Terminal.Length; i++)
            {
                if (PArray_Terminal[i] != null)
                {
                    if (PArray_Terminal[i].Cod_Terminal == PCodigo)
                        return i;
                }
                else
                    return -1;
            }

            return -1;
        }
        public string Obtener_Terminal(Cla_Terminal[] PArray_Terminal,
                                       int PCodigo)
        { 
            for (int i = 0; i < PArray_Terminal.Length; i++)
            {
                if (PArray_Terminal[i] != null)
                {
                    if (PArray_Terminal[i].Cod_Terminal == PCodigo)
                        return PArray_Terminal[i].Dsc_Terminal;
                }
                else
                    return null;
            }

            return null;
        }
        #endregion
    }
}
