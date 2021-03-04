//Created By Engin Yenice
//enginyenice2626@gmail.com

namespace Business.Constants
{
    public static class Messages
    {
        public static string EmptyMessage = "Empty Message";
        public static string AddUser = "Kullanıcı eklendi";
        public static string UpdateUser = "Kullanıcı düzenlendi";
        public static string DeleteUser = "Kullanıcı silindi";
        public static string GetAllErrorUser = "Kullanıcılar getirilemedi";
        public static string GetAllSuccessUser = "Kullanıcılar getirildi";
        public static string GetByEmailErrorUser = "Girilen Email adresine ait kullanıcı getirilemedi";
        public static string GetByEmailSuccessUser = "Girilen Email adresine ait kullanıcı getirildi";
        public static string UserAvailable = "Böyle bir kullanıcı mevcut";
        public static string UserNotFound = "Böyle bir kullanıcı bulunamadı";
        public static string WrongPassword = "Hatalı şifre girildi";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserRegistered = "Kayıt başarılı";
        public static string AccessTokenCreated = "AccessToken oluşturuldu";
        public static string AuthorizationDenied = "Yetki hatası";
    }
}