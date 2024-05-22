using System.Text;

namespace PP_Escaner_Arriaga_Ignacio
{
    public abstract class Documento
    {
        private int anio;
        private string autor;
        private string barcode;
        private Paso estado;
        protected string numNormalizado;
        private string titulo;

        public Documento(int anio, string autor, string barcode, string numNormalizado, string titulo)
        {
            this.anio = anio;
            this.autor = autor;
            this.barcode = barcode;
            this.estado = Paso.Inicio;
            this.numNormalizado = numNormalizado;
            this.titulo = titulo;
        }

        public int Anio { get => anio; }

        public string Autor { get => autor; }

        public string Barcode { get => barcode; }

        public Paso Estado { get => estado; }

        public virtual string NumNormalizado { get => numNormalizado; }

        public string Titulo { get => titulo; }

        public enum Paso
        {
            Inicio,
            Distribuido,
            EnEscaner,
            EnRevision,
            Terminado
        }

        public bool AvanzarEstado()
        {
            if (estado == Paso.Terminado)
            {
                return false;
            }

            estado = (Paso)(((int)estado) + 1);
            return true;
        }

        public override string ToString()
        {
            StringBuilder dsb = new StringBuilder();
            dsb.AppendLine($"Titulo: {titulo}");
            dsb.AppendLine($"Autor: {autor}");
            dsb.AppendLine($"Año: {anio}");
            return dsb.ToString();
        }

    }


}
