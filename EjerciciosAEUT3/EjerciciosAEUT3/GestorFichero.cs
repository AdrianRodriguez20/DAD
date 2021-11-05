using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace EjerciciosAEUT3
{
    public class GestorFichero
    {
        private  String ruta = "dataexport_20211104T123407.csv";
      
        public GestorFichero()
        {

        }
        public GestorFichero(String ruta)
        {
            this.ruta = ruta;
        }
        
        
        public List<Prediccion> leerFichero()
        {
            List< List<String> > lista = new List<List<String>>();
   


    List<Prediccion> listaPredicciones = new List<Prediccion>();
                
            try
            {
                StreamReader sr = new StreamReader(ruta);
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    String[] campos = linea.Split(',');
                    lista.Add(new List<String>(campos));
               
                }

                for (int i = 1; i <= 3; i++)
                {
                    Prediccion p = new Prediccion();
                    p.Location = lista[0][i];
                    p.Lat = Convert.ToDouble(lista[1][i]);
                    p.Lon = Convert.ToDouble(lista[2][i],CultureInfo.InvariantCulture);
                    p.Asl = Convert.ToDouble(lista[3][i],CultureInfo.InvariantCulture);
                    p.Variable = lista[4][i];
                    p.Unit = lista[5][i]; 
                    p.Level = lista[6][i]; 
                    p.Resolution = lista[7][i]; 
                    p.Aggregation = lista[8][i]; 
                    p.Timestamp = lista[9][i];
                    List<Double> temperaturas = new List<double>();
                        for (int j = 10; j <= lista.Count-1; j++)
                        {
                         //   Console.WriteLine("("+(j+1)+")"+ lista[j][i]);
                         temperaturas.Add(Convert.ToDouble(lista[j][i],CultureInfo.InvariantCulture));  
                           
                        }
                    p.Temperature=temperaturas;
                    
                   Console.WriteLine(p.ToString());
                    listaPredicciones.Add(p);
                }

                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            return listaPredicciones;
        }
        
    }
  
    
    

}