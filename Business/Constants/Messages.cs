using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string StartWithA = "Ürün adı A ile başlamalı";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 20 ürün olabilir";
        public static string ProductNameAlreadyExists = "Aynı isimde birden fazla ürün eklenemez";
        public static string CategoryLimitExceded = "Kategori sayısı 15'ten fazlaysa ürün eklenemez";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten bulunmakta";
        public static string AccessTokenCreated = "Access Token oluşturuldu";
    }
}
