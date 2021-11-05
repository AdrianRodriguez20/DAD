using System.Collections.Generic;

namespace EjerciciosAEUT3
{
    public class Prediccion
    {
        private string _location;
        private double _lat;
        private double _lon;
        private double _asl;
        private string _variable;
        private string _unit;
        private string _level;
        private string _resolution;
        private string _aggregation;
        private string _timestamp;
        private List<double> _temperature;


        public Prediccion()
        {
            
        }
        
      
        public Prediccion(string location, double lat, double lon, double asl, string variable, string unit, string level, string resolution, string aggregation, string timestamp, List<double> temperature)
        {
            _location = location;
            _lat = lat;
            _lon = lon;
            _asl = asl;
            _variable = variable;
            _unit = unit;
            _level = level;
            _resolution = resolution;
            _aggregation = aggregation;
            _timestamp = timestamp;
            _temperature = temperature;
        }

        public string Location
        {
            get => _location;
            set => _location = value;
        }

        public double Lat
        {
            get => _lat;
            set => _lat = value;
        }

        public double Lon
        {
            get => _lon;
            set => _lon = value;
        }

        public double Asl
        {
            get => _asl;
            set => _asl = value;
        }

        public string Variable
        {
            get => _variable;
            set => _variable = value;
        }

        public string Unit
        {
            get => _unit;
            set => _unit = value;
        }

        public string Level
        {
            get => _level;
            set => _level = value;
        }

        public string Resolution
        {
            get => _resolution;
            set => _resolution = value;
        }

        public string Aggregation
        {
            get => _aggregation;
            set => _aggregation = value;
        }

        public string Timestamp
        {
            get => _timestamp;
            set => _timestamp = value;
        }

        public List<double> Temperature
        {
            get => _temperature;
            set => _temperature = value;
        }

        public override string ToString()
        {
            return $"{_location} {_lat} {_lon} {_asl} {_variable} {_unit} {_level} {_resolution} {_aggregation} {_timestamp} {_temperature}";
        }
        
    }
    
}