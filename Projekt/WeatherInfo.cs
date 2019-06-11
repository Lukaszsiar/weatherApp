
namespace weatherproject
{

    public class Main
    {
        public double temp { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
    }

  
    public class WeatherInfo
    {
     
        public Main main { get; set; }  
        public Wind wind { get; set; } 
    }
}
