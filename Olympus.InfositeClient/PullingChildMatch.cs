using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Olympus.InfoSiteClient.Extensions;
using Olympus.InfoSiteClient.Models;

namespace Olympus.InfoSiteClient
{

    public class PullingChildMatch
    {
        private readonly static HttpClient httpClient = new HttpClient();

        static PullingChildMatch()
        {
            httpClient.Timeout = TimeSpan.FromMinutes(30);
        }

        public IList<ChildMatch> Query(string infoSiteAPI, DateTime from, DateTime to)
        {
            const string path = "api/EventSchedule/getChildEventsByDate?rd_checked=true";
            var stamp = DateTime.Today.AddYears(-10);
            var request = $"{infoSiteAPI.TrimEnd('/')}/{path}&date_from={from:yyyy-MM-dd}&date_to={to:yyyy-MM-dd}&stamp={stamp:yyyy-MM-dd HH:mm:ss}";

            var response = httpClient.GetAsync(request).Result;

            if (response.IsSuccessStatusCode)
            {
                var jsonData = response.Content.ReadAsStringAsync().Result.ToString();
                var matches = JsonConvert.DeserializeObject<List<ChildMatch>>(jsonData, new TrimmingConverter());

                return matches ?? new List<ChildMatch>();
            }
            else
            {
                var responseText = response.Content.ReadAsStringAsync().Result.ToString();
                var message = $"httpClient Error: {response.ReasonPhrase}. Response: {responseText}";
                throw new HttpRequestException(message);
            }
        }
    }
}