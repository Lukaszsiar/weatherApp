using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;


namespace weatherproject
{
    class Program
    {

        static void Main(string[] args)
            {

            using(WebClient wc = new WebClient())
            {

                var json = wc.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=Krakow,PL&appid=d55e4671a5b45e80f03b70a550d7bcde");
                WeatherInfo weatherinfo = JsonConvert.DeserializeObject<WeatherInfo>(json);

                Console.WriteLine("Temperatura {0}°C",weatherinfo.main.temp - 273.15);
                Console.WriteLine("Temperatura maksymalna {0}°C", weatherinfo.main.temp_max - 273.15);
                Console.WriteLine("Temperatura minimalna {0}°C", weatherinfo.main.temp_min - 273.15);
                Console.WriteLine("Wilgotność {0}%", weatherinfo.main.humidity);
                Console.WriteLine("Cisnienie {0}hPa", weatherinfo.main.pressure);
                Console.WriteLine("Prędkość wiatru {0} m/s", weatherinfo.wind.speed);

                JsonSerializer jsonserializer = new JsonSerializer();

                using (StreamWriter sw = new StreamWriter("../../serializacja.txt"))
                    using(JsonWriter jw = new JsonTextWriter(sw))
                {
                    jsonserializer.Serialize(jw, weatherinfo);
                }
            }
            Console.ReadKey();
        }
    }
}
