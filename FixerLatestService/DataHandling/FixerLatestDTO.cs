using System;
using Newtonsoft.Json;

namespace Fixer
{
    public class FixerLatestDTO
    {
        public LatestRatesRoot LatestRates { get; set; }
        public Rates Rates { get; set; }

        public void DeserializeLatestRates(string LatestRatesResponse)
        {
            LatestRates = JsonConvert.DeserializeObject<LatestRatesRoot>(LatestRatesResponse);
        }

        

        

    }
}
