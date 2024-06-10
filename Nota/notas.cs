using System;
using System.Globalization;

namespace Nota
{
    internal class notas
    {
        public string Nome;
        public double A1;
        public double A2;
        public double A3;

        public double SomaNota()
        {
           return  A1 + A2 + A3;
        }

        public bool Aprovado()
        {
            if (SomaNota() >= 60.0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            } else
            {
                return 60.0 - SomaNota();
            }
        }
    }
}
