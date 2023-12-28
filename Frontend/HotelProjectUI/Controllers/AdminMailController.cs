using HotelProjectUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace HotelProjectUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AdminMailVM modelView)
        {
            //Mail Konfigürasyon nesne yaratımı.
            MimeMessage mimeMessage = new MimeMessage();
            //Maili Gönderen
            MailboxAddress mailboxAddress = new MailboxAddress("HotelierAdmin", "ayavuzisik@gmail.com");
            mimeMessage.From.Add(mailboxAddress);
            //Maili Alacak
            MailboxAddress mailboxAddressTo = new MailboxAddress("User",modelView.RecevierMail);
            mimeMessage.To.Add(mailboxAddressTo);
            //Mail İçeriği
            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = modelView.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            //Mail Konusu
            mimeMessage.Subject = modelView.Subject;

            //Simple Mail Transfer Protocol nesnesi oluşturuldu. - MailKit packagesi ile yapıldı.
            SmtpClient client = new SmtpClient();
            //Smtp sunucusuna bağlanma
            client.Connect("smtp.gmail.com", 587, false/*ssl*/);
            //Giriş yapma
            client.Authenticate("ayavuzisik@gmail.com", "vvohzwjvqjofqjss");
            //Maili gönderme
            client.Send(mimeMessage);
            //Bağlantıyı kapatma
            client.Disconnect(true);

            return View();
        }
    }
}
