namespace BDLaunch
{
    public class ServiceIni
    {
        public string host;
        public int port;
        public string authServer; 
        public ServiceIni()
        {
            string iniFile = $@"{BDLaunchView.basePath}service.ini";
            string[] content = File.ReadAllLines(iniFile);

            foreach (var line in content)
            {
                if (line.Contains("AUTHENTIC_DOMAIN="))
                {
                    int idx = line.IndexOf("=") + 1;
                    host = line.Substring(idx);
                }
                if (line.Contains("AUTHENTIC_PORT="))
                {
                    int idx = line.IndexOf("=") + 1;
                    port = int.Parse(line.Substring(idx));
                }
            }
            authServer = host;
        }
    }
}
