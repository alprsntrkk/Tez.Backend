using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarı ile eklendi.";
        public static string ProductDeleted = "Ürün başarı ile silindi";
        public static string ProductUpdated = "Ürün başarı ile güncellendi.";

        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfullLogin="Giriş başarılı.";
        public static string UserAlreadyExists="Bu kullanıcı zaten mevcut.";
        public static string UserRegistered="Kullanıcı başarı ile kayıt edildi.";
        public static string AccessTokenCreated = "Access Token başarı ile oluşturuldu.";
    }
}
