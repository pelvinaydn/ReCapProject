using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = " Eklendi";
        public static string Updated = " Güncellendi";
        public static string Deleted = " Silindi";
        public static string Listed = " Listelendi";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarNotReturned = "This car has already been chosen! Please choose a new car.";
        public static string CarImageLimitError = "Bir arabanın en fazla 5 resmi olabilir!";
        public static string AuthorizationDenied = "Yetkiniz yok";
        internal static string UserRegistered;
        internal static User UserNotFound;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
    }
}
