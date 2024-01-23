namespace HotelProjectUI.Dtos.DashboardDto
{
    public class TwitterFollowerCount
    {
        public Data data { get; set; }


        public class Data
        {
            public string id { get; set; }
            public User_Info user_info { get; set; }
        }

        public class User_Info
        {
            public int followers_count { get; set; }
            public int friends_count { get; set; }
        }
    }
}
