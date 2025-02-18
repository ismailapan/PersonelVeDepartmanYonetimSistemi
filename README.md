Personel ve Departman Yönetim Sistemi
Bu proje, bir Personel ve Departman Yönetim Sistemi'dir. Kullanıcılar, personel ekleme, silme, güncelleme ve listeleme işlemlerini yapabilir. Ayrıca departman bilgilerini yönetebilir ve iş tanımları ekleyebilir.

📌 Özellikler

Personel İşlemleri

Personel ekleme, güncelleme, silme

Personel listesi görüntüleme

Departman İşlemleri

Departman ekleme, güncelleme, silme

İş tanımı ekleme

Departman listesi görüntüleme

Kapsülleme (Encapsulation) kullanılarak veri güvenliği sağlanmıştır.

N Katmanlı Mimari (Entity, Data Access, Logic Layer, UI) kullanılmıştır.

SQL Server veritabanı ile çalışmaktadır.

🛠 Kullanılan Teknolojiler

C# (Windows Forms - WinForms)

Microsoft SQL Server

ADO.NET

N-Katmanlı Mimari (Entity, DataAccess, Logic, UI)

Veritabanını oluşturun:

TBLPERSONEL ve TBLDEPARTMENT tablolarını oluşturun.

Aşağıdaki SQL sorgularını çalıştırarak tabloları ekleyebilirsiniz:
![image](https://github.com/user-attachments/assets/1e056490-eb96-4b59-984f-03911e46ed6d)
Veritabanı bağlantısını güncelleyin:

Baglanti.cs dosyasında SQL bağlantı dizesini kendi veritabanınıza göre değiştirin.
//public static SqlConnection bgl = new SqlConnection("Server=SUNUCU_ADI;Database=DB_ADI;Integrated Security=True;");
Projeyi çalıştırın:

Visual Studio'da PersonelYonetim.sln dosyasını açın.

F5 tuşuna basarak uygulamayı çalıştırın.

Personel Yönetim Paneli
![image](https://github.com/user-attachments/assets/a1aa36e5-6670-4de2-81e8-dcc996cb257f)
![image](https://github.com/user-attachments/assets/502cd41c-4c12-4c15-9a8c-52b0a3a95477)

Departman Yönetim Paneli
![image](https://github.com/user-attachments/assets/d5876e4b-ed91-4874-9152-c52f5ec2070e)

📌 Katmanlar ve Yapı

Projede N Katmanlı Mimari kullanılmıştır. Yapı şu şekildedir:

EntityLayer:

EntityPersonel.cs ve EntityDepartment.cs sınıfları bulunmaktadır.

Bu sınıflar veritabanı tablolarına karşılık gelen nesneleri tanımlar.

DataAccessLayer (DAL):

DALPersonel.cs ve DALDepart.cs dosyaları veritabanı işlemlerini gerçekleştirir.

CRUD işlemleri için ADO.NET kullanılmıştır.

LogicLayer (LL):

LogicPersonel.cs ve LogicDepart.cs dosyaları iş mantığını yönetir.

Veri doğrulama ve iş kuralları burada uygulanır.

UI (User Interface - Windows Forms):

FrmPersonel.cs ve FrmDepart.cs dosyaları kullanıcı arayüzünü yönetir.

DataGridView ile veri listeleme işlemleri gerçekleştirilir.


