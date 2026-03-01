# Kırtasiye Otomasyonu

Kırtasiye Otomasyonu, bir kırtasiye işletmesinde ürün, stok, satış ve müşteri işlemlerini yönetmek amacıyla geliştirilmiş bir masaüstü uygulamasıdır. Proje **C# Windows Forms** kullanılarak geliştirilmiş olup veritabanı işlemleri **SQL Server** ile gerçekleştirilmiştir.

Uygulama üzerinden kullanıcılar sisteme giriş yapabilir, ürünleri listeleyebilir, yeni ürün ekleyebilir ve mevcut ürünleri güncelleyebilir. Ürünlerin stok miktarları sistem üzerinden takip edilir ve stok seviyesine göre kontrol sağlanabilir.

Satış işlemleri bölümünde kullanıcılar müşteri seçerek ürün satışı gerçekleştirebilir. Seçilen ürünler listeye eklenir ve toplam tutar otomatik olarak hesaplanır. Yapılan satışlar veritabanına kaydedilerek raporlama ekranında görüntülenebilir.

Sistem içerisinde kategori, müşteri, tedarikçi ve çalışan yönetimi yapılabilmektedir. Ayrıca satışlara ait toplam satış tutarı, maliyet ve kâr oranı gibi bilgiler rapor ekranında görüntülenebilir.

---

## Özellikler

- Kullanıcı giriş sistemi
- Ürün ekleme, güncelleme ve silme
- Stok takip sistemi
- Ürün resimlerinin görüntülenmesi
- Kategori yönetimi
- Müşteri yönetimi
- Tedarikçi yönetimi
- Çalışan yönetimi
- Satış işlemleri
- Sipariş detaylarının görüntülenmesi
- Toplam tutar hesaplama
- Satış raporlama sistemi
- Tarihe göre rapor filtreleme

---

## Kullanılan Teknolojiler

- C#
- .NET Windows Forms
- SQL Server
- System.Data.SqlClient
- Git & GitHub

---

## Kurulum

Projeyi çalıştırmak için:

1. Projeyi indir veya klonla
2. SQL Server’da **KIRTASIYE_YONETIM_DB** veritabanını oluştur
3. Proje içindeki connection string ayarını kendi SQL Server adınıza göre düzenleyin:


## Mimari Not

Bu proje eğitim amacıyla geliştirilmiştir. Uygulamada işlemlerin büyük bölümü Form sınıfları içinde yazılmıştır, bu nedenle proje tam olarak OOP ve katmanlı mimariye uygun değildir. İleride proje OOP yapısına uygun şekilde geliştirilebilir.

## Ekran Görüntüleri

### Kullanıcı Giriş Ekranı   [Giriş ekran görüntüsünü aç](giris.png)
---

### Ürün ve Stok Yönetimi  [Ürün ekran görüntüsünü aç](urunler.png)
---

### Satış İşlemleri  [Satış ekran görüntüsünü aç](siparis.png)
---

### Raporlama Sistemi  [Rapor ekran görüntüsünü aç](rapor.png)
