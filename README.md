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

# 🔑 **Login Paneli**


# 🚫 **404 Sayfası**

