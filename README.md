# HotelProject
Projenin çalıştırılabilmesi için gerekli hususlar : 
1 - SQL Server Object Explorer'dan local veya bilgisayar adına varolan veritabanının(local tercihen) "Properties" Kısmından "Connection String" kısmının kopyalanıp Proje içinde "DataAccess" katmanında Context.cs sınıfında bulunan connection string ile değiştirilmesi.
2 - Package Manager Console'un açılıp girilen yeni Connection String ile "Update-Database" komutunun çalıştırılması. !!! DEFAULT PROJECT kısmı "API_Folder\Hotel_Layer.DataAccess seçilmeli !!!
3- Sonrasında SSMS'ten (bilgisayarda yüklü olmalı) paylaşacağım script new query açılarak çalıştırılmalı. (USE kısmının sizin connection string'te Initial Catalog'un karşılığında verilecek veritabanı ismi bulundurduğundan emin olun.)
4- Artık veritabanı oluşturuldu ve datalar basılmış halde bulunacak. Projeyi ayağa kaldırmak için "Configure Startup Projects" kısmından Multiple Startup Projects'e ayarlayıp "UI VE API" seçilmeli. Çünkü bu proje api consume temelli ve statik veri sayısı inanılmaz derecede az.
5- Gerçek Zamanda Mail göndermek isterseniz "AdminMailController" - Frontend kısmında "client.Authenticate("(sizin mailiniz)@gmail.com", "(uygulama şifresi)");" Google Eklentilerden uygulama anahtarlarını aratın ve "Visual Studio" Adına bir anahtar üretin. Başarılmadığı durumda mail üzerinden iletişime geçebilirim.
6- RapidAPI Dashboard kısmında kullanıldı. Twitter Instagram Linkedin için. Follower ve Follow By Count'ları için. Bu yüzden genel olarak proje internet bağlantısı gerektiriyor!.

