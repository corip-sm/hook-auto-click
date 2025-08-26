using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace HookAutoFire.Services
{
    public class IniFileManager
    {
        private readonly string filePath;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public IniFileManager(string iniPath)
        {
            filePath = Path.GetFullPath(iniPath);
        }

        public void WriteValue(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, filePath);
        }

        public string ReadValue(string section, string key, string defaultValue = "")
        {
            var temp = new StringBuilder(255);
            GetPrivateProfileString(section, key, defaultValue, temp, 255, filePath);
            return temp.ToString();
        }

        public int ReadInt(string section, string key, int defaultValue = 0)
        {
            string value = ReadValue(section, key, defaultValue.ToString());
            return int.TryParse(value, out int result) ? result : defaultValue;
        }

        public void WriteInt(string section, string key, int value)
        {
            WriteValue(section, key, value.ToString());
        }

        public bool ReadBool(string section, string key, bool defaultValue = false)
        {
            string value = ReadValue(section, key, defaultValue.ToString());
            return bool.TryParse(value, out bool result) ? result : defaultValue;
        }

        public void WriteBool(string section, string key, bool value)
        {
            WriteValue(section, key, value.ToString());
        }
    }
}