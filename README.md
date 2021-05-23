# NLayerWebAPI Adım adım MVC Web - Api haberleşmesi

.NET CORE MVC VE WEB APİ MİMARİ PROJESİ

http durum cevapları

•	100-Bilgi mesajı

•	200-Başarı mesajı

•	300-Yönlendirme mesajı

•	400-Hata mesajı

•	500-Server hatası

En çok kullanılanlar

•	200 ok

•	201 Created

•	204 NoContent  ==  istek başarılı ama geriye bir şey dönmüyor

•	400 BadRequest == Client’ın kötü bir istek yaptığıdır.

•	401 Unauthorize  == Sayfa yetkisi eksikliği

•	403 Forbid == isteği yapan kişi belli ama istediği endPointe yetkisi yok

•	404 NotFound == Bulunamadı

•	500 internal server error == Serverde bir hata olursa (Veri tabanına bağlanamadı gibi)

Doğru  EndPoint URl  Yapısı
Get: http://myapi.com/categories/2/products

Projenin oluşturulması
1.	Asp .Net Core Web Api
2.	Katmanlar için add Class Library
3.	Core – Data – Service
4.	Core > Entites > Product, Category
5.	Core > Repository > IRepository 
6.	Core > Service > IService (Product, Category’e özgü veri tabanı harici metodlar için)
7.	Core > UnitOfWorks > IUnitOfWorks (dataBase işlemlerini buraya bırakıyoruz)
8.	Data > AppDbContext (EntityFramaworkCore)
9.	Data >  Configuration > ProductConfiguration, CategoryConfiguration (entity Property)
10.	Data > Seed > ProductSeed, CategorySeed
11.	Data > Repositories > Repository , ProductRepository, CategoryRepository
12.	Data > UnitOfWorks > UnitofWork
13.	AppsetingsJson connection string
14.	Stratup.cs Güncellemesi
15.	Add-migration // Update-DataBase
16.	Service > Service > Service ,ProductService, CategoryService
17.	Startup.cs güncellenmesi
18.	API > Controller > CategoryController, ProductController
19.	DTO client’a göstermek istediklerimizi yazarız
20.	API > DTO’s > CategoryDTO, ProductDTO
21.	API > AutoMapper paketi
22.	Startup.cs güncelle
23.	API > Mapping > MapProfile
24.	Validation filtre > DTO’s
25.	API > Filters > ValidationFilter
26.	API > FIlters > NotFoundFilter
27.	Startup.cs güncelle
28.	Global Hata ayıklama 
29.	Apı > Extension >UseCustomExceptionHandler
30.	Startup.cs guncell 
31.	MVC Web oluşturduk 
32.	Startup.cs güncellendi
33.	Layout a script eklendi validation
34.	Dto ve mapping kopyalandı
35.	Controller yazıldı
36.	Hata kontrolleri  Filters eklendi güncellendi
37.	Home controller error güncellendi 
38.	Shared error.view güncellendi
39.	Startup.cs güncellendi
40.	API VE MVC HABERLEŞME
41.	httpClient sınıfı
42.	web appsettigs.json güncellendi (baseurl)
43.	Web > ApiService > CategoryApiService
44.	CategoryService’de metotlarımızı yazdık
45.	Web projemiz artık direk API ile haberleşiyor
46.	Web’de gereksiz serviceleri kaldırdık

