using Newtonsoft.Json;
using Olympus.InfoSiteClient.Extensions;
using Olympus.InfoSiteClient.Models;

namespace Olympus.InfoSiteClient;

public class PullingChildMatch
{
    public IList<ChildMatch> Query(string infoSiteAPI, DateTime from, DateTime to)
    {
        var stamp = DateTime.Today.AddYears(-10);

        using (var httpClient = new HttpClient())
        {
            httpClient.Timeout = TimeSpan.FromMinutes(30);
            httpClient.BaseAddress = new Uri(infoSiteAPI);
            var path = string.Format("api/EventSchedule/getChildEventsByDate?rd_checked=true&date_from={0:yyyy-MM-dd}&date_to={1:yyyy-MM-dd}&stamp={2:yyyy-MM-dd HH:mm:ss}", from, to, stamp);

            var response = httpClient.GetAsync(path).Result;

            if (response.IsSuccessStatusCode)
            {
                var jsonData = response.Content.ReadAsStringAsync().Result.ToString();
                var matches = JsonConvert.DeserializeObject<List<ChildMatch>>(jsonData, new TrimmingConverter());

                return matches?? new List<ChildMatch>();
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