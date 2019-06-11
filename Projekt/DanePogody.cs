namespace Projekt
{
    public class DanePogody
    {
        public class Main
        {
            public double temp { get; set; }
            public int pressure { get; set; }
        }

        public class Wind
        {
            public double speed { get; set; }
        }

        public class root
        {
            public string name { get; set; }
            public Main main { get; set; }
            public Wind wind { get; set; }
        }

    }
}
