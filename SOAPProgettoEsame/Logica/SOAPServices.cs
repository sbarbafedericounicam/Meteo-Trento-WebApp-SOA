using ModelliMeteo;
using Newtonsoft.Json;

using System.ServiceModel;


namespace SOAPProgettoEsame.Logica
{
    [ServiceContract]
    public interface ISoapService
    {

        [OperationContract]
        RootMeteo DaiTuttoMeteo();

        [OperationContract]
        Giorni RicercaGiorno(string data);
    }

    public class SoapService : ISoapService
    {
       

        public RootMeteo DaiTuttoMeteo()
        {
            string Uri = "https://www.meteotrentino.it/protcivtn-meteo/api/front/previsioneOpenDataLocalita?localita=TRENTO";

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync(Uri).Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        string result =  content.ReadAsStringAsync().Result;

                        RootMeteo ModelloMeteo = JsonConvert.DeserializeObject<RootMeteo>(result);

                        return ModelloMeteo;
                    }
                }
            }
        }

        public Giorni RicercaGiorno(string data)
        {
            RootMeteo meteo = DaiTuttoMeteo(); 
            foreach (var previsione in meteo.previsione)
            {
                foreach (var giorno in previsione.giorni)
                {
                    if (giorno.giorno == data)
                    {
                        return giorno;
                    }
                }
            }
            return null; 
        }
    }


}
