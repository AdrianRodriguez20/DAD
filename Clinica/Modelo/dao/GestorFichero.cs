using System;

namespace Modelo
{
    /// <summary>
    /// Clase para la gestión de ficheros
    /// </summary>
    public class GestorFichero
    {
        private String ruta;
        
        
        public GestorFichero(String ruta)
        {
            this.ruta = ruta;
        }


        public string Ruta
        {
            get => ruta;
            set => ruta = value;
        }
    }
}