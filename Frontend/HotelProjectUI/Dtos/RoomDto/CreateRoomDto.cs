﻿namespace HotelProjectUI.Dtos.RoomDto
{
    public class CreateRoomDto
    {
        public string RoomNumber { get; set; }
        public string RoomImage { get; set; }
        public int Price { get; set; }
        public string Wifi { get; set; }
        public string RoomTitle { get; set; }
        public string BedCount { get; set; }
        public string BathCount { get; set; }
        public string Description { get; set; }
    }
}
