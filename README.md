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

-SQL DATA SCRİPT-
--USE [C:\USERS\ARROW\SOURCE\REPOS\HOTELPROJECT\API_FOLDER\HOTEL_LAYER.DATAACCESS\BIN\DEBUG\NET7.0\HOTELLOCALDB.MDF]
GO
SET IDENTITY_INSERT [dbo].[WorkPlaces] ON 

INSERT [dbo].[WorkPlaces] ([WorkPlaceID], [WorkPlaceName], [WorkPlaceCity]) VALUES (1, N'Ortaköy Hotelier', N'İstanbul')
INSERT [dbo].[WorkPlaces] ([WorkPlaceID], [WorkPlaceName], [WorkPlaceCity]) VALUES (2, N'Beşiktaş Hotelier', N'İstanbul')
INSERT [dbo].[WorkPlaces] ([WorkPlaceID], [WorkPlaceName], [WorkPlaceCity]) VALUES (3, N'Karaağaç Hotelier', N'Edirne')
INSERT [dbo].[WorkPlaces] ([WorkPlaceID], [WorkPlaceName], [WorkPlaceCity]) VALUES (4, N'Havsa Hotelier', N'Edirne')
INSERT [dbo].[WorkPlaces] ([WorkPlaceID], [WorkPlaceName], [WorkPlaceCity]) VALUES (5, N'Datça Butique Hotelier', N'Muğla')
SET IDENTITY_INSERT [dbo].[WorkPlaces] OFF
GO
SET IDENTITY_INSERT [dbo].[AspNetUsers] ON 

INSERT [dbo].[AspNetUsers] ([Id], [Name], [Surname], [City], [Country], [Gender], [ImageUrl], [WorkDepartment], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [WorkPlaceID]) VALUES (1, N'Damla', N'Taşkın', N'Şanlıurfa', N'Türkiye', N'Kadın', N'/adminweb/images/avatar/4.jpg', N'Ortaköy Hotelier', N'damlataskin', N'DAMLATASKIN', N'tbetul@gmail.com', N'TBETUL@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAEL1nmUesLCApze10k047OnY1g38bp0aMc9rcKBEzIaA6bjilUR89FaTaA1k0VJqP/A==', N'HMQYL77W47IUHOOU5QJZEWT3HMVJMU5V', N'e0d087d6-7ec4-4458-8672-1b15bbca4056', NULL, 0, 0, NULL, 0, 0, 1)
INSERT [dbo].[AspNetUsers] ([Id], [Name], [Surname], [City], [Country], [Gender], [ImageUrl], [WorkDepartment], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [WorkPlaceID]) VALUES (2, N'Yavuz', N'Yıldırım', N'Ağrı', N'Türkiye', N'Erkek', N'/adminweb/images/avatar/1.jpg', N'Beşiktaş Hotelier', N'yavuz123', N'YAVUZ123', N'yavuz@gmail.com', N'YAVUZ@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAED7PH7rdKRqPXsbNt26uTZpTUZRCW21jgbq6zsgyPAaO8NUzSybWoV0vxFV67R+FQg==', N'PAJMP4XQCFIS7YFT37L4TYMZP6IPKQYM', N'2dea7088-d390-4d6d-9078-860f81240bbe', NULL, 0, 0, NULL, 1, 0, 2)
INSERT [dbo].[AspNetUsers] ([Id], [Name], [Surname], [City], [Country], [Gender], [ImageUrl], [WorkDepartment], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [WorkPlaceID]) VALUES (3, N'Mehmet', N'Çınar', N'Adana', N'Türkiye', N'Erkek', N'/adminweb/images/avatar/2.jpg', N'Karaağaç Hotelier', N'memo123', N'MEMO123', N'mehmet123@gmail.com', N'MEHMET123@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAEMpNbt88JnlUwzyuAqbD1wdFgJKXkge7Pawe9N5uHwIR9TX3ukRetmjezWlxU85InA==', N'ZMYOYNSW7ZGKXUPBEJAX6S5JX4UUG4DB', N'ee490a81-14ef-4f57-9473-04b5006537d9', NULL, 0, 0, NULL, 0, 0, 3)
INSERT [dbo].[AspNetUsers] ([Id], [Name], [Surname], [City], [Country], [Gender], [ImageUrl], [WorkDepartment], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [WorkPlaceID]) VALUES (5, N'Gece', N'Işık', N'İstanbul', N'Türkiye', N'Kadın', N'/adminweb/images/avatar/6.jpg', N'Datça Butique Hotelier', N'sadsad1', N'SADSAD1', N'sadsad@gmail.com', N'SADSAD@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAEKZuCQeDD8D9/RwrdfJqntFFtvZx+bseFMaNxvj5t6wJWRAJ39+okgb3w9AT8wX5ow==', N'L7IUX2BCB5I7R5QZOFZ7AWFR3PQT7KBA', N'1debf7ef-bb32-4030-9c22-0339a20ec46e', NULL, 0, 0, NULL, 1, 0, 5)
SET IDENTITY_INSERT [dbo].[AspNetUsers] OFF
GO
SET IDENTITY_INSERT [dbo].[AspNetRoles] ON 

INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (2, N'Admin', N'ADMIN', NULL)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (3, N'Çalışan', N'ÇALıŞAN', NULL)
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (4, N'Üye', N'ÜYE', NULL)
SET IDENTITY_INSERT [dbo].[AspNetRoles] OFF
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (1, 2)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (2, 2)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (5, 2)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (1, 3)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (3, 3)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (5, 3)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (1, 4)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (3, 4)
GO
SET IDENTITY_INSERT [dbo].[MessageCategories] ON 

INSERT [dbo].[MessageCategories] ([MessageCategoryID], [MessageCategoryName]) VALUES (1, N'Teşekkür')
INSERT [dbo].[MessageCategories] ([MessageCategoryID], [MessageCategoryName]) VALUES (2, N'Şikayet')
INSERT [dbo].[MessageCategories] ([MessageCategoryID], [MessageCategoryName]) VALUES (3, N'Öneri')
INSERT [dbo].[MessageCategories] ([MessageCategoryID], [MessageCategoryName]) VALUES (4, N'Talep')
INSERT [dbo].[MessageCategories] ([MessageCategoryID], [MessageCategoryName]) VALUES (5, N'İş Görüşmesi')
INSERT [dbo].[MessageCategories] ([MessageCategoryID], [MessageCategoryName]) VALUES (6, N'(Belirtiniz - Diğer)')
SET IDENTITY_INSERT [dbo].[MessageCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([ContactID], [Name], [Mail], [Subject], [Message], [Date], [MessageCategoryID]) VALUES (1, N'Mehmet Çınar', N'mehmet123@gmail.com', N'Çevre Düzenlemesi', N'Yeşil alanların artırılması ve doğaya uygun çevre düzenlemeleri yapılması için destek talep ediyoruz.', CAST(N'2023-12-30T15:02:06.0000000' AS DateTime2), 4)
SET IDENTITY_INSERT [dbo].[Contacts] OFF
GO
SET IDENTITY_INSERT [dbo].[Abouts] ON 

INSERT [dbo].[Abouts] ([AboutID], [TitleFirst], [TitleSecond], [Content], [RoomCount], [StaffCount], [ClientCount]) VALUES (1, N'Hotelier''aaa', N'HOŞGELDİNİZ !', N'Sahilimizde altın kumlar, güneşin sıcaklığı ve nefis kahvaltılarla huzurlu bir tatilin kapılarını aralayın. Doğa ile iç içe unutulmaz anlar için sizi bekliyoruz.', 3406, 6680, 16561)
SET IDENTITY_INSERT [dbo].[Abouts] OFF
GO
SET IDENTITY_INSERT [dbo].[Bookings] ON 

INSERT [dbo].[Bookings] ([BookingID], [Name], [Mail], [Checkin], [CheckOut], [AdultCount], [ChildCount], [RoomCount], [SpecialRequest], [Description], [Status], [City], [Country]) VALUES (1, N'Ahmet Işık', N'ayavuzisik@gmail.com', CAST(N'2024-01-23T00:00:00.0000000' AS DateTime2), CAST(N'2024-02-23T00:00:00.0000000' AS DateTime2), N'1', N'0', N'1', N'string', N'string', N'Rezervasyon Beklemede', N'Edirne', N'Türkiye')
INSERT [dbo].[Bookings] ([BookingID], [Name], [Mail], [Checkin], [CheckOut], [AdultCount], [ChildCount], [RoomCount], [SpecialRequest], [Description], [Status], [City], [Country]) VALUES (2, N'Damla Taskin', N'tbetuldamla@gmail.com', CAST(N'2023-04-03T00:00:00.0000000' AS DateTime2), CAST(N'2023-05-04T00:00:00.0000000' AS DateTime2), N'2', N'2', N'3', N'loorajkıpsrfasıokpljdskşgdjksagdslogsd ', N'aaa', N'Onaylandı', N'Gaziantep', N'Türkiye')
INSERT [dbo].[Bookings] ([BookingID], [Name], [Mail], [Checkin], [CheckOut], [AdultCount], [ChildCount], [RoomCount], [SpecialRequest], [Description], [Status], [City], [Country]) VALUES (3, N'Ferhat Adıkti', N'fermer@gmail.com', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'2', N'2', N'3', N'asdasdsada', N'aaa', N'İptal Edildi', N'Muğla', N'Türkiye')
INSERT [dbo].[Bookings] ([BookingID], [Name], [Mail], [Checkin], [CheckOut], [AdultCount], [ChildCount], [RoomCount], [SpecialRequest], [Description], [Status], [City], [Country]) VALUES (4, N'Ferhat Adıkti', N'fermer@gmail.com', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'3', N'3', N'3', N'jghjhgjg', N'aaa', N'Rezervasyon Beklemede', N'İstanbul', N'Türkiye')
INSERT [dbo].[Bookings] ([BookingID], [Name], [Mail], [Checkin], [CheckOut], [AdultCount], [ChildCount], [RoomCount], [SpecialRequest], [Description], [Status], [City], [Country]) VALUES (5, N'Umut Özbilek', N'nessaikor@gmail.com', CAST(N'2023-12-27T06:14:00.0000000' AS DateTime2), CAST(N'2023-12-30T06:14:00.0000000' AS DateTime2), N'2', N'1', N'2', N'askfhujsafasjfdjsad', N'aaa', N'Onay Bekliyor', N'Adana', N'Türkiye')
INSERT [dbo].[Bookings] ([BookingID], [Name], [Mail], [Checkin], [CheckOut], [AdultCount], [ChildCount], [RoomCount], [SpecialRequest], [Description], [Status], [City], [Country]) VALUES (6, N'Ferhat boş', N'betuldamla@gmail.com', CAST(N'2023-12-06T11:45:00.0000000' AS DateTime2), CAST(N'2023-12-13T06:48:00.0000000' AS DateTime2), N'2', N'1', N'1', N'alalala', N'string', N'İptal Edildi', N'Rize', N'Türkiye')
SET IDENTITY_INSERT [dbo].[Bookings] OFF
GO
SET IDENTITY_INSERT [dbo].[Cities] ON 

INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (1, N'Adana')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (2, N'Adıyaman')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (3, N'Afyonkarahisar')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (4, N'Ağrı')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (5, N'Amasya')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (6, N'Ankara')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (7, N'Antalya')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (8, N'Artvin')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (9, N'Aydın')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (10, N'Balıkesir')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (11, N'Bilecik')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (12, N'Bingöl')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (13, N'Bitlis')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (14, N'Bolu')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (15, N'Burdur')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (16, N'Bursa')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (17, N'Çanakkale')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (18, N'Çankırı')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (19, N'Çorum')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (20, N'Denizli')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (21, N'Diyarbakır')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (22, N'Edirne')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (23, N'Elazığ')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (24, N'Erzincan')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (25, N'Erzurum')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (26, N'Eskişehir')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (27, N'Gaziantep')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (28, N'Giresun')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (29, N'Gümüşhane')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (30, N'Hakkâri')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (31, N'Hatay')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (32, N'Isparta')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (33, N'Mersin')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (34, N'İstanbul')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (35, N'İzmir')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (36, N'Kars')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (37, N'Kastamonu')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (38, N'Kayseri')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (39, N'Kırklareli')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (40, N'Kırşehir')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (41, N'Kocaeli')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (42, N'Konya')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (43, N'Kütahya')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (44, N'Malatya')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (45, N'Manisa')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (46, N'Kahramanmaraş')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (47, N'Mardin')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (48, N'Muğla')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (49, N'Muş')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (50, N'Nevşehir')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (51, N'Niğde')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (52, N'Ordu')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (53, N'Rize')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (54, N'Sakarya')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (55, N'Samsun')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (56, N'Siirt')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (57, N'Sinop')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (58, N'Sivas')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (59, N'Tekirdağ')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (60, N'Tokat')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (61, N'Trabzon')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (62, N'Tunceli')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (63, N'Şanlıurfa')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (64, N'Uşak')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (65, N'Van')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (66, N'Yozgat')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (67, N'Zonguldak')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (68, N'Aksaray')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (69, N'Bayburt')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (70, N'Karaman')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (71, N'Kırıkkale')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (72, N'Batman')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (73, N'Şırnak')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (74, N'Bartın')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (75, N'Ardahan')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (76, N'Iğdır')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (77, N'Yalova')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (78, N'Karabük')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (79, N'Kilis')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (80, N'Osmaniye')
INSERT [dbo].[Cities] ([CityID], [CityName]) VALUES (81, N'Düzce')
SET IDENTITY_INSERT [dbo].[Cities] OFF
GO
SET IDENTITY_INSERT [dbo].[Guests] ON 

INSERT [dbo].[Guests] ([GuestID], [Name], [Surname], [City]) VALUES (1, N'Yavuz', N'Işık', N'Edirne')
INSERT [dbo].[Guests] ([GuestID], [Name], [Surname], [City]) VALUES (2, N'Levent', N'Işık', N'Edirne')
INSERT [dbo].[Guests] ([GuestID], [Name], [Surname], [City]) VALUES (3, N'Emel', N'Işık', N'Edirne')
INSERT [dbo].[Guests] ([GuestID], [Name], [Surname], [City]) VALUES (4, N'Umut', N'Özbilek', N'İstanbul')
INSERT [dbo].[Guests] ([GuestID], [Name], [Surname], [City]) VALUES (5, N'Zeynep', N'Özbilek', N'İstanbul')
INSERT [dbo].[Guests] ([GuestID], [Name], [Surname], [City]) VALUES (6, N'Elif', N'Zünbül', N'Çorlu')
INSERT [dbo].[Guests] ([GuestID], [Name], [Surname], [City]) VALUES (7, N'Mert', N'Kılıç', N'Tekirdağ')
INSERT [dbo].[Guests] ([GuestID], [Name], [Surname], [City]) VALUES (9, N'Oğuz', N'Kırat', N'Edirne')
SET IDENTITY_INSERT [dbo].[Guests] OFF
GO
SET IDENTITY_INSERT [dbo].[Rooms] ON 

INSERT [dbo].[Rooms] ([RoomID], [RoomNumber], [RoomImage], [Price], [Wifi], [RoomTitle], [BedCount], [BathCount], [Description]) VALUES (1, N'101', N'/hotel-html-template/img/room-1.jpg', 3500, N'Var', N'Tek Kişilik Oda', N'1', N'2', N'Enfes doğa manzaralarına uyan, sevdiklerinizle paylaşacağınız konforlu odalarımızda huzur dolu bir tatil sizi bekliyor.')
INSERT [dbo].[Rooms] ([RoomID], [RoomNumber], [RoomImage], [Price], [Wifi], [RoomTitle], [BedCount], [BathCount], [Description]) VALUES (2, N'102', N'/hotel-html-template/img/room-2.jpg', 2400, N'Var', N'Çift Kişilik Oda', N'1', N'2', N'Doğanın kucağında, sevdiklerinizle geçireceğiniz özel anlar için tasarlanan odalarımızda konfor ve huzur bir araya geliyor..')
INSERT [dbo].[Rooms] ([RoomID], [RoomNumber], [RoomImage], [Price], [Wifi], [RoomTitle], [BedCount], [BathCount], [Description]) VALUES (3, N'103', N'/hotel-html-template/img/room-3.jpg', 6500, N'Var', N'Aile Odası', N'2', N'3', N'Ailenizle birlikte unutulmaz anlar yaşayacağınız, doğayla iç içe, konforlu odalarımızda sıcak bir atmosfer sizi bekliyor.')
INSERT [dbo].[Rooms] ([RoomID], [RoomNumber], [RoomImage], [Price], [Wifi], [RoomTitle], [BedCount], [BathCount], [Description]) VALUES (4, N'104', N'/hotel-html-template/img/room-1.jpg', 4500, N'Var', N'Tek Kişilik Oda', N'1', N'2', N'Enfes doğa manzaralarına uyan, sevdiklerinizle paylaşacağınız konforlu odalarımızda huzur dolu bir tatil sizi bekliyor.')
INSERT [dbo].[Rooms] ([RoomID], [RoomNumber], [RoomImage], [Price], [Wifi], [RoomTitle], [BedCount], [BathCount], [Description]) VALUES (5, N'105', N'/hotel-html-template/img/room-2.jpg', 2200, N'Var', N'Çift Kişilik Oda', N'1', N'2', N'Doğanın kucağında, sevdiklerinizle geçireceğiniz özel anlar için tasarlanan odalarımızda konfor ve huzur bir araya geliyor..')
INSERT [dbo].[Rooms] ([RoomID], [RoomNumber], [RoomImage], [Price], [Wifi], [RoomTitle], [BedCount], [BathCount], [Description]) VALUES (6, N'106', N'/hotel-html-template/img/room-3.jpg', 5700, N'Var', N'Aile Odası', N'2', N'3', N'Ailenizle birlikte unutulmaz anlar yaşayacağınız, doğayla iç içe, konforlu odalarımızda sıcak bir atmosfer sizi bekliyor.')
SET IDENTITY_INSERT [dbo].[Rooms] OFF
GO
SET IDENTITY_INSERT [dbo].[SendMessages] ON 

INSERT [dbo].[SendMessages] ([SendMessageID], [ReceiverName], [ReceiverMail], [SenderName], [SenderMail], [Title], [Content], [Date]) VALUES (1, N'Mehmet Yazıcı', N'mehmet12@gmail.com', N'admin', N'admin@gmail.com', N'Et ve Süt Ürünleri', N'Uzun zaman oldu. Ürünlerimiz kontrol vakti geldi diye düşünüyorum.', CAST(N'2023-12-26T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[SendMessages] OFF
GO
SET IDENTITY_INSERT [dbo].[Services] ON 

INSERT [dbo].[Services] ([ServiceID], [ServiceIcon], [ServiceTitle], [Description]) VALUES (1, N'fa fa-hotel fa-2x text-primary', N'Odalar ve Daireler', N'Rahatlığın yeni tanımı. Şehri keşfedin, sonra konforlu odalarımızda dinlenin. Mükemmel konaklama sizi bekliyor!')
INSERT [dbo].[Services] ([ServiceID], [ServiceIcon], [ServiceTitle], [Description]) VALUES (2, N'fa fa-utensils fa-2x text-primary', N'Yemek ve Restorant', N'Lezzetin zirvesine çıkın. Şeflerimizin elinden çıkan enfes tatlar, sizin için özel restoranlarımızda.')
INSERT [dbo].[Services] ([ServiceID], [ServiceIcon], [ServiceTitle], [Description]) VALUES (3, N'fa fa-spa fa-2x text-primary', N'Spa ve Fitness', N'Zindeliğe ve rahatlamaya davetlisiniz. Spa ve fitness olanaklarımızla yenilenin, enerjinizi geri kazanın.')
INSERT [dbo].[Services] ([ServiceID], [ServiceIcon], [ServiceTitle], [Description]) VALUES (6, N'fa fa-swimmer fa-2x text-primary', N'Spor ve Oyunlar', N'Aktif yaşam sizi bekliyor. Spor ve oyun alanlarımızda keyifli anlar yaşayın, eğlencenin tadını çıkarın.')
INSERT [dbo].[Services] ([ServiceID], [ServiceIcon], [ServiceTitle], [Description]) VALUES (7, N'fa fa-glass-cheers fa-2x text-primary', N'Etkinlikler ve Parti', N'Eğlenceye hazır olun! Özel etkinlikler ve partilerle unutulmaz anlara tanıklık edin. Kutlamaya başlayın!')
INSERT [dbo].[Services] ([ServiceID], [ServiceIcon], [ServiceTitle], [Description]) VALUES (8, N'fa fa-dumbbell fa-2x text-primary', N'Gym ve Yoga', N'Sağlıklı yaşam bir adım öteye. Modern spor salonumuz ve yoga aktivitelerimizle zinde kalın, ruhunuzu dinlendirin.')
SET IDENTITY_INSERT [dbo].[Services] OFF
GO
SET IDENTITY_INSERT [dbo].[Staffs] ON 

INSERT [dbo].[Staffs] ([StaffID], [Name], [StaffTitle], [SocialMediaFirst], [SocialMediaSecond], [SocialMediaThird]) VALUES (1, N'Ahmet Yavuz Işık', N'Otel Müdürü', N'/hotel-html-template/img/team-1.jpg', N'string', N'string')
INSERT [dbo].[Staffs] ([StaffID], [Name], [StaffTitle], [SocialMediaFirst], [SocialMediaSecond], [SocialMediaThird]) VALUES (2, N'Umut Özbilek', N'Dış İlişkiler', N'/hotel-html-template/img/team-2.jpg', N'yok', N'yok')
INSERT [dbo].[Staffs] ([StaffID], [Name], [StaffTitle], [SocialMediaFirst], [SocialMediaSecond], [SocialMediaThird]) VALUES (3, N'Mert Kılıç', N'Resepsiyonist', N'/hotel-html-template/img/team-3.jpg', N'string', N'string')
INSERT [dbo].[Staffs] ([StaffID], [Name], [StaffTitle], [SocialMediaFirst], [SocialMediaSecond], [SocialMediaThird]) VALUES (9, N'Ferhat Toprak', N'Danışman', N'/hotel-html-template/img/team-4.jpg', N'var', N'yok')
SET IDENTITY_INSERT [dbo].[Staffs] OFF
GO
SET IDENTITY_INSERT [dbo].[Subscribers] ON 

INSERT [dbo].[Subscribers] ([SubscriberID], [SubscriberMail]) VALUES (1, N'tbetuldamla@gmail.com')
INSERT [dbo].[Subscribers] ([SubscriberID], [SubscriberMail]) VALUES (2, N'ferhatgg@gmail.com')
SET IDENTITY_INSERT [dbo].[Subscribers] OFF
GO
SET IDENTITY_INSERT [dbo].[Testimonials] ON 

INSERT [dbo].[Testimonials] ([TestimonialID], [Name], [TestimonialTitle], [Description], [TestimonialImage]) VALUES (1, N'Ayşe Yıldırım', N'Zincir Market CEO''su', N'Lüks ve konforun zirvesi! İş gezilerimde tercihim, mükemmel hizmet!', N'/hotel-html-template/img/testimonial-1.jpg')
INSERT [dbo].[Testimonials] ([TestimonialID], [Name], [TestimonialTitle], [Description], [TestimonialImage]) VALUES (2, N'Erhan Gündüz', N'Şirket IT Müdürü', N'Teknoloji ve konfor harmanı. İş seyahatlerimde vazgeçilmezim!', N'/hotel-html-template/img/testimonial-2.jpg')
INSERT [dbo].[Testimonials] ([TestimonialID], [Name], [TestimonialTitle], [Description], [TestimonialImage]) VALUES (3, N'Kıvanç Süren', N'Mağaza Yöneticisi', N'Harika bir atmosfer! İş seyahatlerimdeki ilk tercihim.', N'/hotel-html-template/img/testimonial-3.jpg')
INSERT [dbo].[Testimonials] ([TestimonialID], [Name], [TestimonialTitle], [Description], [TestimonialImage]) VALUES (4, N'Elif Zünbül', N'Hastane Yönetim Sorumlusu', N'Huzur dolu bir konaklama! İş yoğunluğunda aradığım rahatlık.', N'/hotel-html-template/img/testimonial-4.jpg')
SET IDENTITY_INSERT [dbo].[Testimonials] OFF
GO
-------------------------------------------------------------------------------------------------------------- SCRİPTİ ÇALIŞTIRDIKTAN SONRA BİR QUERY AÇIP AŞŞAĞIDAKİ TRİGGER KODLARINI KOPYALAYIP ÇALIŞTIRIN LÜTFEN--------------------------------------------------------------------------
Create Trigger RoomDecrease
on Rooms
After Delete
As
Update Abouts Set RoomCount = RoomCount-1

Create Trigger RoomIncrease
on Rooms
After Insert
As
Update Abouts Set RoomCount = RoomCount+1

Create Trigger StaffDecrease
on Staffs
After Delete
As
Update Abouts Set StaffCount = StaffCount-1

Create Trigger StaffIncrease
on Staffs
After Insert
As
Update Abouts Set StaffCount = StaffCount+1

Create Trigger GuestDecrease
on Guests
After Delete
As
Update Abouts Set ClientCount = ClientCount-1

Create Trigger GuestIncrease
on Guests
After Insert
As
Update Abouts Set ClientCount = ClientCount+1

