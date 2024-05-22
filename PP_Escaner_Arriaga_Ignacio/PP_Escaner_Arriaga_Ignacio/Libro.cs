using PP_Escaner_Arriaga_Ignacio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro : Documento
    {
        // Campos
        private int numPaginas;

        // Propiedades

        public string ISBN { get => numNormalizado; }

        public int NumPaginas { get => numPaginas; }

        // Constructor
        public Libro(int anio, string autor, string barcode, string isbn, string titulo, int numPaginas)
       : base(anio, autor, barcode, isbn, titulo)
        {
            this.numPaginas = numPaginas;
        }


        // Sobrecarga de operadores

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Libro other = (Libro)obj;
            return Barcode == other.Barcode || ISBN == other.ISBN || (Titulo == other.Titulo && Autor == other.Autor);
        }

        public static bool operator ==(Libro? l1, Libro? l2)
        {
            if (ReferenceEquals(l1, l2))
            {
                return true;
            }

            if (l1 == null || l2 == null)
            {
                return false;
            }

            return l1.Equals(l2);
        }

        public static bool operator !=(Libro l1, Libro l2)
        {
            return !(l1 == l2);
        }

        // Métodos

        public override string ToString()
        {
            StringBuilder lsb = new StringBuilder();
            lsb.AppendLine(base.ToString());
            lsb.AppendLine($"ISBN: {ISBN}");
            lsb.AppendLine($"Cód de barras: {this.Barcode}");
            lsb.AppendLine($"Número de páginas: {this.NumPaginas}");
            return lsb.ToString();

        }
    }

}
