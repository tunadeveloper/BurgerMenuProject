# ✈️ **Burger Menu Projesi**

---

## 🌟 **Genel Bakış**

Bu proje, bir restoranın ürünlerini tanıtabilmesi ve kolay bir şekilde rezervasyon alabilmesi için ASP.NET MVC 5 ile dinamik olarak geliştirildi.
Müşteriler, aldığı rezervasyon sonucunda onay almak için sistem tarafından bekletilir ve yönetici aksiyon almak için rezervasyon sayfasında işlemlerini gerçekleştirir.

- 👤 Yönetici, müşterilerin rezervasyonlarını "Beklet, Reddet, Onayla" işlemleri ile aksiyon alabilir.
- 📝 Yönetici hesabı olmayan register sayfasından bilgileri doldurarak giriş yapabilir.
- 📩 Yönetici, gelen mesajları görüntüleyebilir ve yeni bir mesaj oluşturabilir.
- 📧 Sisteme abone olan kullanıcıların E-Posta adresleri kolayca kopyalanarak indirim ve fırsatlar ile geri dönüşler sağlanabilir.
- 📊 İstatistikler sayfası ile tüm verilere göz atılabilir.
- 💳 Yönetici, kredi kartlarını sistemde saklayabilir.
- 🔒 Admin paneline sadece authentication olan kullanıcılar erişebilir. Admin paneline erişim sağlamak isteyen bir kullanıcı giriş yapmamışsa, login sayfasına yönlendirilir.
- 🚫 Kullanıcı olmayan bir sayfaya gitmeye çalışırsa, karşısına özelleştirilmiş 404 sayfası çıkar.
- ⚙️ Diğer tüm özelliklerle beraber ise sistemi dinamik olarak yönetebilir.
---

## 🚀 **Özellikler**

- 📥 Abonelik, gelen mesajlar ve rezervasyonların son 5 tanesini görüntülemek için Dashboard sayfası
- 🛠️ Kategori ve ürün ekleme işlemleri
- 📈 Genel durumu öğrenmek için istatistikler sayfası
- 🛠️ CRUD işlemleri (Ekle, Listele, Güncelle, Sil)
- 🌐 Sosyal medya yönlendirmeleri
- ✉️ Kullanıcıların düşünce ve istekleri için iletişim formu
- 💻 Bootstrap ile responsive tasarım
- 📉 Restoran analizi için Grafikler Sayfası
- 💳 Sisteme kayıtlı kredi kartları
- ⚙️ İçerik yönetimi için Ayarlar Sayfası
- 🚫 Özelleştirilmiş 404 sayfası
---

## ⚙️ **Kullanılan Teknolojiler**

- 💻 Web uygulaması yapısı için **ASP.NET MVC 5**
- 🛠️ ORM (Object-Relational Mapping) aracı olarak **Entity Framework**
- 🗄️ Veritabanı olarak **MSSQL Server**
- 🏗️ Veritabanı modellemesi için **Code First** yaklaşımı
- 🔎 Verileri etkin bir şekilde sorgulamak için **LINQ**
- 🎨 Responsive tasarım için **HTML/CSS** ve **Bootstrap**
- 📄 Sayfalar arası geçişleri kolaylaştırmak için **Partial Views**

---

## 👨‍💻 **Context**

```csharp
using BurgerMenuProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BurgerMenuProject.Context
{
    public class BurgerMenuContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Gallery> Gallerys { get; set; }  
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<UserMessage> UserMessages { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
    }
}
```
---

## 🛠️ **Kurulum Adımları**

1. 📥 Depoyu klonlayın:  
   `git clone https://github.com/tunadeveloper/BurgerMenuProject.git`
2. 🖥️ Projeyi Visual Studio'da açın.
3. 🗄️ **MSSQL Server**'ın yüklü ve yapılandırılmış olduğundan emin olun.
4. 📝 `web.config` dosyasındaki bağlantı dizgisini yerel veritabanı ayarlarınıza göre güncelleyin.
5. ▶️ **NuGet Paketlerini Yükleyin**: Projeyi çalıştırmadan önce gerekli NuGet paketlerini yüklemek için aşağıdaki komutu kullanın:
   ```bash
   Update-Package
   
 6. 🛠️ Veritabanını Oluşturun: Code First ile veritabanını oluşturmak için aşağıdaki komutları kullanın:
```bash
Enable-Migrations
Add-Migration InitialCreate
Update-Database
```
7. ▶️ Projeyi Çalıştırın: Projeyi Visual Studio'nun IIS Express'i kullanarak çalıştırın.
---

# 🔑 **Kullanıcı Paneli**

![1](https://github.com/user-attachments/assets/1b0cb6da-9632-4fe3-bd56-6adc3496ac6c)
![2](https://github.com/user-attachments/assets/c9dd2d2b-2e9a-412d-9a55-2d4c846b8538)
![3](https://github.com/user-attachments/assets/c751508c-715d-4f21-9749-77a44b0d46f1)
![4](https://github.com/user-attachments/assets/a182dbc5-b740-47be-9443-6ae92f3f4d4b)
![5](https://github.com/user-attachments/assets/ec40a62e-558c-4eca-941f-521aea9b23e0)
![555](https://github.com/user-attachments/assets/af3c5dbb-3db8-408b-bc2d-c428cd338bb7)
![6](https://github.com/user-attachments/assets/47d25f54-0261-47c3-8a7d-a1e043b8840b)
![7](https://github.com/user-attachments/assets/b7d32506-d9ca-4cd4-95f0-f5bc4c01c636)

# 🔑 **Admin Paneli**

![8](https://github.com/user-attachments/assets/b143dcab-bc6b-4521-8f8a-a3dccdc955b7)
![1212](https://github.com/user-attachments/assets/5860d453-c0ff-4995-ae89-bd007a45da08)
![9](https://github.com/user-attachments/assets/b55b9bbd-acbb-4e1c-9d08-b65e84b4a397)
![10](https://github.com/user-attachments/assets/afc07141-435a-4a02-8a85-e085a8100f5e)
![11](https://github.com/user-attachments/assets/40e636c4-2900-4d67-b43d-302467be215d)
![12](https://github.com/user-attachments/assets/60fd0a98-498f-4e71-a8e0-f89137778863)
![13](https://github.com/user-attachments/assets/141f0f92-9d24-4285-a810-7c3f21626230)
![14](https://github.com/user-attachments/assets/d6e4e5c3-4ac3-45c2-8fa3-b5533d9f3cf3)
![15](https://github.com/user-attachments/assets/3b35facd-3410-4b78-a29c-051b913f3e52)
![16](https://github.com/user-attachments/assets/ab7b672c-3a63-4bbb-bc00-18a5b862672b)
![17](https://github.com/user-attachments/assets/5ea9866a-57fa-46a9-9d67-3e0d8fc7afba)
![18](https://github.com/user-attachments/assets/55142759-923b-4b58-82ef-9bf29c04757c)
![19](https://github.com/user-attachments/assets/006d9d07-8804-4860-9bb7-437008db6f00)
![20](https://github.com/user-attachments/assets/b43410a8-a95a-49a1-b066-604aa4dbd356)
![21](https://github.com/user-attachments/assets/b009b939-9ee9-40cd-aac6-b96b27cb9fe8)
![22](https://github.com/user-attachments/assets/70eb329a-323e-4986-bf9a-9db2c0c71616)

# 🚫 **404 Sayfası**

![404](https://github.com/user-attachments/assets/204b2a35-f9ee-4478-a347-185b485a75af)

# 🔑 **Login Paneli**

![login](https://github.com/user-attachments/assets/3078192c-f182-4bd3-b97a-2bc532e15384)

# 🔑 **Register Paneli**

![register](https://github.com/user-attachments/assets/c3bda667-9fa3-495c-9ddd-5764d856e4ff)


