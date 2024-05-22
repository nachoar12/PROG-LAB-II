using PP_Escaner_Arriaga_Ignacio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Escaner
    {
        public class Escaner
        {
            private List<Documento> listaDocumentos;
            private Departamento locacion;
            private string marca;
            private TipoDoc tipo;

          
            public List<Documento> ListaDocumentos
            {
                get => listaDocumentos; 
            }

            public Departamento Locacion
            {
                get => locacion; 
            }

            public string Marca
            {
                get => marca;
            }

            public TipoDoc Tipo
            {
                get => tipo;
            }

            public bool CambiarEstadoDocumento(Documento d)
            {
               
            }

            public Escaner(string marca, TipoDoc tipo)
            {
                this.marca = marca;
                this.tipo = tipo;
            }


            public enum Departamento
            {
                Nulo,
                Mapoteca,
                ProcesosTecnicos
            }

            public enum TipoDoc
            {
                Libro,
                Mapa
            }
        }

    }
}
