namespace TestClient
{
    public class TfsServer
    {
        private readonly string name;
        private readonly string url;

        public TfsServer(string name, string url)
        {
            this.name = name;
            this.url = url;
        }

        public string Url
        {
            get { return url; }
        }

        public string Name
        {
            get { return name; }
        }
    }
}
