# Hotel Project
## Proje Çalıştırma Rehberi
### Gereksinimler
1 - Connection String Ayarı:

SQL Server Object Explorer'dan, mevcut veritabanının (tercihen local) "Properties" bölümünden "Connection String" kısmını kopyalayın.
Proje içindeki "DataAccess" katmanında bulunan Context.cs sınıfındaki connection string ile değiştirin.

2 - Veritabanı Güncellemesi:

Package Manager Console'u açın ve yeni connection string ile Update-Database komutunu çalıştırın.
Not: "DEFAULT PROJECT" kısmında API_Folder\Hotel_Layer.DataAccess seçilmelidir.

3 - Script Çalıştırma:

SSMS (SQL Server Management Studio) yüklü olmalıdır. Paylaşılacak script ile yeni bir sorgu açarak çalıştırın.
Not: USE kısmında, connection string’teki Initial Catalog ile aynı ismi taşıyan veritabanını kullandığınızdan emin olun.

4 - Projenin Başlatılması:

"Configure Startup Projects" kısmından "Multiple Startup Projects" ayarlayın ve "UI" ile "API"’yi seçin.
Bu proje, API consume temelli olduğundan statik veri sayısı oldukça azdır.

5 - Gerçek Zamanlı Mail Gönderimi:

"AdminMailController" içerisinde, frontend kısmında client.Authenticate("(sizin mailiniz)@gmail.com", "(uygulama şifresi)"); kısmını ayarlayın.
Google Eklentilerden uygulama anahtarlarını aratın ve "Visual Studio" adıyla bir anahtar üretin. Başarısız olursanız, mail ile iletişime geçebilirsiniz.

6 - Internet Bağlantısı:

Proje, RapidAPI Dashboard kullanarak Twitter, Instagram ve LinkedIn için follower ve follow by count’ları gerektirir. Bu yüzden internet bağlantısı gereklidir.
Giriş Bilgileri
Kullanıcı Adı: damlataskin
Şifre: 1
Kullanıcı Kaydı
Kayıt ol kısmından yeni kullanıcı oluşturabilirsiniz. (Şifre, Identity kütüphanesi default sınırlamalarından dolayı 6 sayısal karakter, 1 sembol, 1 büyük harf ve 1 küçük harf içermelidir.)
Sonrasında sidebar'dan (Admin Paneli) ayarlar kısmından şifre ve kullanıcı adını güncelleyebilirsiniz. (Veritabanında ilk indexteki kullanıcı bilgileri geçerli olacaktır!)

