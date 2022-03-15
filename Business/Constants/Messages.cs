using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Ürün eklendi";
        public static string CarDeleted = "Araç silindi";
        public static string CarUpdated = "Araç güncellendi";
        public static string CarNameInvalid = "Araç adı geçersiz";
        public static string CarsListed = "Araçlar listelendi";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandNameInvalid = "Marka geçersiz";
        public static string BrandsListed = "Markalar listelendi";        

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorNameInvalid = "Renk adı geçersiz";
        public static string ColorsListed = "Renkler listelendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserNameInvalid = "Kullanıcı adı geçersiz";
        public static string UsersListed = "Kullanıcılar listelendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerNameInvalid = "Müşteri adı geçersiz";
        public static string CustomersListed = "Müşteriler listelendi";

        public static string RentalAdded = "Kiralama işlemi eklendi";
        public static string RentalDeleted = "Kiralama işlemi silindi";
        public static string RentalUpdated = "Kiralama işlemi güncellendi";
        public static string RentalInvalid = "Kiralama işlemi için aracın teslim edilmiş olması gerekmektedir.";
        public static string RentalsListed = "Kiralama işlemleri listelendi";
        
        public static string ImageAdded = "Fotoğraf eklendi";
        public static string ImageDeleted = "Fotoğraf silindi";
        public static string ImageUpdated = "Fotoğraf güncellendi";
        public static string ImagesListed = "Fotoğraflar listelendi";

        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarImageLimitExceeded = "Bu araç için daha fazla fotoğraf ekleyemezsiniz";
        public static string AuthorizationDenied = "Gerekli yetkiye sahip değilsiniz";
        public static string UserRegistered = "Kayıt işlemi başarılı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatalı";
        public static string SuccessfulLogin = " Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Erişim tokeni oluşturuldu";
    }
}
