# Nike E-Ticaret Projesi - Kurulum Rehberi

## 📋 Proje Hakkında
MEB 11. Sınıf "Web Tabanlı Uygulama Geliştirme" dersi için ASP.NET Core 5.0 MVC mimarisi kullanan Nike E-Ticaret web sitesi.

---

## ⚙️ Sistem Gereksinimleri
- ✅ ASP.NET Core 5.0 SDK
- ✅ Visual Studio 2019+ veya VS Code
- ✅ Git

---

## 🚀 Kurulum Adımları

### 1. Repository'yi Klonlayın
```bash
git clone https://github.com/kl4kk0-web/NikeDb.git
cd NikeDb
```

### 2. Bağımlılıkları Yükleyin
```bash
dotnet restore
```

### 3. Projeyi Çalıştırın
```bash
dotnet run
```

Çıktı:
```
info: Microsoft.Hosting.Lifetime[0]
      Now listening on: https://localhost:5001
      Now listening on: http://localhost:5000
```

### 4. Tarayıcıda Açın
```
https://localhost:5001
```

---

## 📁 Proje Yapısı

```
NikeDb/
├── Controllers/
│   └── HomeController.cs          # İş mantığı
├── Models/
│   ├── Ayakkabi.cs               # Ürün modeli
│   ├── Kullanici.cs              # Kullanıcı modeli
│   └── UygulamaDbContext.cs      # DbContext (Veritabanı köprüsü)
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml          # Anasayfa (Ürün Listesi)
│   │   ├── UrunDetay.cshtml      # Ürün Detay Sayfası
│   │   └── Giris.cshtml          # Giriş Sayfası
│   └── Shared/
│       └── _Layout.cshtml         # Master Sayfa (Bootstrap)
├── Program.cs                     # Uygulama konfigürasyonu
├── appsettings.json              # Veritabanı bağlantısı
└── NikeDb.csproj                # Proje dosyası
```

---

## 📊 Veritabanı

### Tablolar

**1. Ayakkabilar Tablosu**
| Kolon | Tür | Açıklama |
|-------|-----|----------|
| Id | int | Birincil Anahtar |
| Isim | string | Ürün Adı |
| Fiyat | decimal | Fiyat |
| Kategori | string | Ürün Kategorisi |
| Aciklama | string | Ürün Açıklaması |
| ResimUrl | string | Ürün Resmi URL'si |

**2. Kullanicilar Tablosu**
| Kolon | Tür | Açıklama |
|-------|-----|----------|
| Id | int | Birincil Anahtar |
| Eposta | string | E-posta Adresi |
| Sifre | string | Şifre |

---

## 🧪 Test Kullanıcıları

### Giriş Bilgileri:
```
E-posta: test@nike.com
Şifre: 123456
```

veya

```
E-posta: kullanici@nike.com
Şifre: password123
```

---

## 🎯 Sayfalar ve İşlevleri

### 1. Anasayfa (Index)
- ✅ Tüm ayakkabıları kartlar halinde listeler
- ✅ Bootstrap Cards kullanımı
- ✅ @foreach döngüsü (MEB uyumlu)
- ✅ "Detayları Gör" butonu

### 2. Ürün Detay Sayfası
- ✅ ID parametresi ile ürün arama
- ✅ Find() metodu ile veritabanı sorgusu
- ✅ Detay bilgileri, fiyat, açıklama gösterimi
- ✅ Beden seçimi dropdown
- ✅ Responsive tasarım

### 3. Giriş Sayfası
- ✅ E-posta ve şifre forması
- ✅ @Html.AntiForgeryToken() güvenliği
- ✅ [HttpPost] + [ValidateAntiForgeryToken] kuralları
- ✅ Veritabanı doğrulaması
- ✅ Session yönetimi

---

## 🔐 Güvenlik Özellikleri

✅ CSRF Koruması (@Html.AntiForgeryToken())
✅ ValidateAntiForgeryToken Attribute
✅ Session Yönetimi
✅ Şifre Doğrulaması
✅ Bootstrap ile Responsive Tasarım

---

## 📝 MEB Uyumlu Kodlama Standartları

✅ Model Binding ve Validation
✅ Dependency Injection
✅ Tag Helpers (asp-controller, asp-action, asp-route-id)
✅ @foreach Döngü Yapısı
✅ View Bag kullanımı
✅ DbContext ve Entity Framework Core
✅ [HttpGet] ve [HttpPost] Attributes

---

## 💻 Geliştirme

### Yeni Ürün Ekleme
Program.cs içindeki `Ayakkabilar.AddRange()` bölümüne yeni Ayakkabi nesnesi ekleyin.

### Veritabanını Sıfırlama
NikeDb.db dosyasını silin, projeyi yeniden çalıştırın (otomatik oluşturulacaktır).

### İlave Sayfalar Ekleme
1. HomeController.cs içine yeni action method ekleyin
2. Views/Home/ klasörüne .cshtml dosyası ekleyin
3. _Layout.cshtml'de navigasyon linki oluşturun

---

## 📚 Kaynaklar

- [ASP.NET Core Dokümantasyonu](https://docs.microsoft.com/en-us/aspnet/core/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [Bootstrap 5](https://getbootstrap.com/)
- [Razor Syntax](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/razor)

---

## ❓ Sıkça Sorulan Sorular

**S: Veritabanında değişiklikler yaparsam ne olur?**
A: NikeDb.db dosyasını silin, projeyi yeniden çalıştırın.

**S: Giriş yapmak için hangi bilgileri kullanacağım?**
A: test@nike.com / 123456 veya kullanici@nike.com / password123

**S: Tag Helpers nedir?**
A: MEB müfredatında öğretilen asp-controller, asp-action gibi HTML helper'lar.

---

## 📞 İletişim
Proje: MEB 11. Sınıf Web Tabanlı Uygulama Geliştirme Ödevi
Tarih: 2026
