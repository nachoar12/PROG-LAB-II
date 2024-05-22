using PP_Escaner_Arriaga_Ignacio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mapa : Documento
    {
        private int ancho;
        private int alto;

        public Mapa(string titulo, string autor, int anio, string barcode, int ancho, int alto) : base(anio, autor, barcode, "",titulo)
        {
            this.ancho = ancho;
            this.alto = alto;
        }

        public int Ancho { get => ancho; }

        public int Alto { get => alto; }

        public int Superficie => Ancho * Alto;

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Mapa otroMapa = (Mapa)obj;

            return (Barcode == otroMapa.Barcode) ||
                   (Titulo == otroMapa.Titulo && Autor == otroMapa.Autor && Anio == otroMapa.Anio && Superficie == otroMapa.Superficie);
        }

        public static bool operator ==(Mapa? m1, Mapa? m2)
        {
            if (ReferenceEquals(m1, m2))
            {
                return true;
            }

            if (m1 == null || m2 == null)
            {
                return false;
            }

            return m1.Equals(m2);
        }

        public static bool operator !=(Mapa m1, Mapa m2)
        {
            return !(m1 == m2);
        }


        public override string ToString()
        {
            StringBuilder msb = new StringBuilder();
            msb.AppendLine(base.ToString());
            msb.AppendLine($"Ancho: {Ancho}");
            msb.AppendLine($"Alto: {Alto}");
            msb.AppendLine($"Superficie: {Superficie}");
            return msb.ToString();
        }
    }

}
