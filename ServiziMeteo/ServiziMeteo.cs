using ModelliMeteo;
using Newtonsoft.Json;

namespace ServiziMeteo
{
    public static class ServiziMeteo
    {
        public static RootMeteo DaiMeteo()
        {
            string Uri = "https://www.meteotrentino.it/protcivtn-meteo/api/front/previsioneOpenDataLocalita?localita=TRENTO";

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(Uri).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        string result = content.ReadAsStringAsync().Result;

                        RootMeteo ModelloMeteo = JsonConvert.DeserializeObject<RootMeteo>(result);

                        return ModelloMeteo;
                    }
                }
            }
        }
    }
}
