using Modelo;
using System;
using System.Collections.Generic;

namespace Controlador
{
    public class FichaController
    {
        FichaDAO fichaDAO = new FichaDAO(new GestorFichero("fichaspacientes.txt"));

        public List<string[]> listarFichasNhc(String contenido)
        {
            List<Ficha> fichas = null;
          
                fichas = fichaDAO.findByNhc(Convert.ToInt32(contenido));
          

            List<string[]> pacientesStr = new List<string[]>(); ;
            if (fichas != null)
            {
                foreach (Ficha ficha in fichas)
                {
                    pacientesStr.Add(new string[] { ficha.FechaVisita , ficha.Motivo ,ficha.Preinscripción });

                }
            }

            return pacientesStr;
        }
    }
}