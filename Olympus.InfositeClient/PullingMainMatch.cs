using Newtonsoft.Json;
using Olympus.InfoSiteClient.Extensions;
using Olympus.InfoSiteClient.Models;

namespace Olympus.InfoSiteClient;

public class PullingMainMatch
{
    public IList<CommonMatchEx> Query(string infoSiteAPI, DateTime from, DateTime to, DateTime stamp)
    {
        var matches = new List<CommonMatchEx>();

        using (var httpClient = new HttpClient())
        {
            httpClient.Timeout = TimeSpan.FromMinutes(30);
            httpClient.BaseAddress = new Uri(infoSiteAPI);
            var path = string.Format("api/EventSchedule/getEventsByDate?rd_checked=true&date_from={0:yyyy-MM-dd}&date_to={1:yyyy-MM-dd}&stamp={2:yyyy-MM-dd HH:mm:ss}", from, to, stamp);

            var response = httpClient.GetAsync(path).Result;

            if (response.IsSuccessStatusCode)
            {
                var jsonData = response.Content.ReadAsStringAsync().Result.ToString();
                matches = JsonConvert.DeserializeObject<List<CommonMatchEx>>(jsonData, new TrimmingConverter());

                return matches.Any() ? FilterMatches(matches) : matches;
            }
            else
            {
                var responseText = response.Content.ReadAsStringAsync().Result.ToString();
                var message = $"httpClient Error: {response.ReasonPhrase}. Response: {responseText}";
                throw new Exception(message);
            }
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