using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using Olympus.InfoSiteClient.Extensions;
using Olympus.InfoSiteClient.Models;

namespace Olympus.InfoSiteClient
{

    public class PullingMainMatch
    {
        private readonly static HttpClient httpClient = new HttpClient();

        static PullingMainMatch()
        {
            httpClient.Timeout = TimeSpan.FromMinutes(30);
        }

        public IList<CommonMatchEx> Query(string infoSiteAPI, DateTime from, DateTime to, DateTime stamp)
        {
            const string path = "api/EventSchedule/getEventsByDate?rd_checked=true";
            var request = $"{infoSiteAPI.TrimEnd('/')}/{path}&date_from={from:yyyy-MM-dd}&date_to={to:yyyy-MM-dd}&stamp={stamp:yyyy-MM-dd HH:mm:ss}";

            var response = httpClient.GetAsync(request).Result;

            if (response.IsSuccessStatusCode)
            {
                var jsonData = response.Content.ReadAsStringAsync().Result.ToString();
                var matches = JsonConvert.DeserializeObject<List<CommonMatchEx>>(jsonData, new TrimmingConverter());

                return matches != null && matches.Any() ? FilterMatches(matches) : matches;
            }
            else
            {
                var responseText = response.Content.ReadAsStringAsync().Result.ToString();
                var message = $"httpClient Error: {response.ReasonPhrase}. Response: {responseText}";
                throw new HttpRequestException(message);
            }
        }

        private List<CommonMatchEx> FilterMatches(IList<CommonMatchEx> matches)
        {
            var hasExInfoEvents = matches.Where(e => e.ext_info != null);
            var checkedMatches = hasExInfoEvents.Where(e => e.ext_info.rd_checked.GetValueOrDefault(false));
            var matchedMatches = hasExInfoEvents.Where(e => !e.ext_info.rd_checked.GetValueOrDefault(false) && e.ext_info.create_match_id > 0);
            var filteredMatches = checkedMatches.Union(matchedMatches);
            var soccerMatches = filteredMatches.Where(m => m.ext_info.sport_id == 1);

            return soccerMatches.ToList();
        }
    }
}