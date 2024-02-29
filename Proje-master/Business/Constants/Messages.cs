using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
  public static  class Messages
    {
        //Çok destekli yapıya getirebeiliriz.
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public  static string  MaintenanceTime="sistem bakımda";
        public  static string ProductListed="ürünler listelendi";
        public  static string ProductCountOfCategoryError="ürün sayısı kategori için fazla";
        public static string ProductNameAlreadyExists="Bu adda zaten ürün bulunmaktadır";
        public static string CategoryLimitExceded="Kategori limit aşıldı için yeni ürün eklenemiyor";
        public static string CategoryListed="Kategoriler listelendi";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserRegistered="Kayıt oldu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Şifre  hatalı";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated="Token oluşturuldu";
       public  static string ProductUpdated="ürün güncellendi";
    }
}
