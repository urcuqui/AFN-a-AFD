using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFN_a_AFD.modelo
{
    public class Transicion
    {
        public  string estadoInicio;
        public  string estadoFinal;
        public  string simbolo;
        public Transicion(string inicio, string final, string si)
        {
            estadoInicio = inicio;
            estadoFinal = final;
            simbolo = si;
        }
        public string getestadoInicio()
        {
            return estadoInicio;
        }
        public string getestadoestadoFinal()
        {
            return estadoFinal;
        }
        public string getsimbolo()
        {
            return simbolo;
        }
        public bool equals(Transicion transicion)
        {
            if ((transicion.getsimbolo().Equals(simbolo)) && (transicion.getestadoInicio().Equals(estadoInicio)) && transicion.getestadoestadoFinal().Equals(estadoFinal))
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }


    }
}
