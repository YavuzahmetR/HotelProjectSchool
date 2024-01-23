using Azure;
using HotelProjectUI.Dtos.DashboardDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProjectUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //INSTAGRAM RAPID API - FOLLOWER/FOLLOWED BY 
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/lokrowa"),
                Headers =
            {
                { "X-RapidAPI-Key", "c4ad6ca49amsh8468315b906cc9fp1dd4adjsn0b5a09c464eb" },
                { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
            },

            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                InstagramFollowerCount ınstagramFollowerCount = JsonConvert.DeserializeObject<InstagramFollowerCount>(body);
                ViewBag.v1 = ınstagramFollowerCount.followers;
                ViewBag.v2 = ınstagramFollowerCount.following;
            }

            //TWITTER RAPID API - FOLLOWER/FOLLOWED BY
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=kosekoyun"),
                Headers =
    {
        { "X-RapidAPI-Key", "c4ad6ca49amsh8468315b906cc9fp1dd4adjsn0b5a09c464eb" },
        { "X-RapidAPI-Host", "twitter32.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                TwitterFollowerCount twitterFollowerCount = JsonConvert.DeserializeObject<TwitterFollowerCount>(body2);
                ViewBag.v3 = twitterFollowerCount.data.user_info.friends_count;
                ViewBag.v4 = twitterFollowerCount.data.user_info.followers_count;
            }

            //LINKEDIN RAPID API - FOLLOWER/CONNECTIONS 
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fr-levent-i%25C5%259F%25C4%25B1k-20152119a%2F&include_skills=false"),
                Headers =
    {
        { "X-RapidAPI-Key", "c4ad6ca49amsh8468315b906cc9fp1dd4adjsn0b5a09c464eb" },
        { "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                LinkedinFollowerCount linkedinFollowerCount = JsonConvert.DeserializeObject<LinkedinFollowerCount>(body3);
                ViewBag.v5 = linkedinFollowerCount.data.followers_count;
            }
            return View();
        }
    }
}
//İnternet bağlantısı gerektirir ayrıca ayda toplam 50 istek başına bedava abone olundu apilere.
