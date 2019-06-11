using System;
using System.Activities;
using System.Net;
using Newtonsoft.Json;

namespace Projekt
{
    public sealed class miasto : CodeActivity
    {
        public InArgument<string> Wybor { get; set; }
        public DanePogody Level { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            using (WebClient wc = new WebClient())
            {
                string x = context.GetValue(Wybor);
                switch (x)
                {
                    case "1":
                        {   //Krakow
                            string json = wc.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=Krakow&APPID=3b27d020dc80badae70ce5941e3e6166");
                            var result = JsonConvert.DeserializeObject<DanePogody.root>(json);
                            DanePogody.root outPut = result;

                            var temp = JsonConvert.DeserializeObject<DanePogody.Main>(json);
                            DanePogody.Main outPutM = temp;

                            Console.WriteLine("{0}", outPut.name);
                            Console.WriteLine("Temperatura wynosi: {0} C", outPut.main.temp- 273.15);
                            Console.WriteLine("Cisnienie wynosi: {0}", outPut.main.pressure);
                            Console.WriteLine("Predkosc wiatru: {0} \n", outPut.wind.speed);
                            break;
                        }
                    case "2":
                        {   //Warszawa
                            string json = wc.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=Warszawa&APPID=3b27d020dc80badae70ce5941e3e6166");
                            var result = JsonConvert.DeserializeObject<DanePogody.root>(json);
                            DanePogody.root outPut = result;

                            var temp = JsonConvert.DeserializeObject<DanePogody.Main>(json);
                            DanePogody.Main outPutM = temp;

                            Console.WriteLine("{0}", outPut.name);
                            Console.WriteLine("Temperatura wynosi: {0} C", outPut.main.temp - 273.15);
                            Console.WriteLine("Cisnienie wynosi: {0}", outPut.main.pressure);
                            Console.WriteLine("Predkosc wiatru: {0} \n", outPut.wind.speed);
                            break;
                        }
                    case "3":
                        {   //Wroclaw
                            string json = wc.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=Wroclaw&APPID=3b27d020dc80badae70ce5941e3e6166");
                            var result = JsonConvert.DeserializeObject<DanePogody.root>(json);
                            DanePogody.root outPut = result;

                            var temp = JsonConvert.DeserializeObject<DanePogody.Main>(json);
                            DanePogody.Main outPutM = temp;

                            Console.WriteLine("{0}", outPut.name);
                            Console.WriteLine("Temperatura wynosi: {0} C", outPut.main.temp - 273.15);
                            Console.WriteLine("Cisnienie wynosi: {0}", outPut.main.pressure);
                            Console.WriteLine("Predkosc wiatru: {0} \n", outPut.wind.speed);
                            break;
                        }
                    case "4":
                        {   //Parczew
                            string json = wc.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=Parczew&APPID=3b27d020dc80badae70ce5941e3e6166");
                            var result = JsonConvert.DeserializeObject<DanePogody.root>(json);
                            DanePogody.root outPut = result;

                            var temp = JsonConvert.DeserializeObject<DanePogody.Main>(json);
                            DanePogody.Main outPutM = temp;

                            Console.WriteLine("{0}", outPut.name);
                            Console.WriteLine("Temperatura wynosi: {0} C", outPut.main.temp - 273.15);
                            Console.WriteLine("Cisnienie wynosi: {0}", outPut.main.pressure);
                            Console.WriteLine("Predkosc wiatru: {0} \n", outPut.wind.speed);
                            break;
                        }
                    case "5":
                        {   //Lublin
                            string json = wc.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=Lublin&APPID=3b27d020dc80badae70ce5941e3e6166");
                            var result = JsonConvert.DeserializeObject<DanePogody.root>(json);
                            DanePogody.root outPut = result;

                            var temp = JsonConvert.DeserializeObject<DanePogody.Main>(json);
                            DanePogody.Main outPutM = temp;

                            Console.WriteLine("{0}", outPut.name);
                            Console.WriteLine("Temperatura wynosi: {0} C", outPut.main.temp - 273.15);
                            Console.WriteLine("Cisnienie wynosi: {0}", outPut.main.pressure);
                            Console.WriteLine("Predkosc wiatru: {0} \n", outPut.wind.speed);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Pogoda niedostępna, wybrano niepoprawny numer miasta.");
                        }
                        break;
                }
            }
        }
    }
}
