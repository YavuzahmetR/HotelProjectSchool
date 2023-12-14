using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Layer.DTO.Dtos.Room
{
    public class UpdateRoomDto
    {
        public int RoomID { get; set; }
        [Required(ErrorMessage = "Oda Numarası Girmek Zorunludur !")]
        public string RoomNumber { get; set; }
        public string? RoomImage { get; set; }
        [Required(ErrorMessage = "Fiyat Girmek Zorunludur !")]
        [Range(1000,9999,ErrorMessage ="Fiyat 1000 para birimi ile 9999 para birimi arasında olmalı!")]
        public int Price { get; set; }
        public string? Wifi { get; set; }
        [Required(ErrorMessage = "Oda Başlığı Girmek Zorunludur !")]
        [StringLength(75,ErrorMessage ="En fazla 50 karakter kullanın.")]
        public string RoomTitle { get; set; }
        [Required(ErrorMessage = "Yatak Sayısı Girmek Zorunludur !")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Banyo Sayısı Girmek Zorunludur !")]
        public string BathCount { get; set; }
        public string? Description { get; set; }
    }
}
