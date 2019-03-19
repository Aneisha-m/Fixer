using System;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Fixer
{
    public class FixerLatestService
    {
        // Call Manager
        public FixerLatestCallManager fixerLatestCallManager = new FixerLatestCallManager();
        // DTO
        public FixerLatestDTO fixerLatestDTO = new FixerLatestDTO();
        // JSON Object
        public JObject LatestRatesJson;
        public JObject TotalRates;
        
        // runs method in DTO and deserialize 
        public FixerLatestService()
        {
            fixerLatestDTO.DeserializeLatestRates(fixerLatestCallManager.GetLatestRates());
            LatestRatesJson = JObject.Parse(fixerLatestCallManager.GetLatestRates());
            TotalRates = JObject.Parse(LatestRatesJson["rates"].ToString());
           
        }

        
        //Count Rates for total Rates Check
        public int CountRates()
        {
            return TotalRates.Count;
        }

       
        
       

       
    }
}
