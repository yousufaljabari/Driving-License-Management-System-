using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace DVLDPresentationLayer
{
    public static class clsSaveUsernameAndPassword
    {
        private const string KeyPath =
        @"HKEY_CURRENT_USER\Software\DVLD";

        public static bool SaveLoginInfo(string username, string password)
        {
            try
            {
                Registry.SetValue(
                    KeyPath,
                    "Username",
                    username,
                    RegistryValueKind.String);

                Registry.SetValue(
                    KeyPath,
                    "Password",
                    password,
                    RegistryValueKind.String);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool GetLoginInfo(
            ref string username,
            ref string password)
        {
            try
            {
                username = Registry.GetValue(
                    KeyPath,
                    "Username",
                    null) as string;

                password = Registry.GetValue(
                    KeyPath,
                    "Password",
                    null) as string;

                return username != null && password != null;
            }
            catch
            {
                return false;
            }
        }
        public static bool ClearLoginInfo()
        {
            string keyPath =
                @"HKEY_CURRENT_USER\Software\DVLD";

            try
            {
                Registry.SetValue(
                    keyPath,
                    "Username",
                    "",
                    RegistryValueKind.String);

                Registry.SetValue(
                    keyPath,
                    "Password",
                    "",
                    RegistryValueKind.String);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

