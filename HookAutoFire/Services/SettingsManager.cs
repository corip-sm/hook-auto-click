using System;
using System.IO;
using HookAutoFire.Models;

namespace HookAutoFire.Services
{
    public class SettingsManager
    {
        private readonly IniFileManager iniManager;
        private readonly string settingsPath;
        private const string SECTION_INTERVALS = "Intervals";

        public AppSettings CurrentSettings { get; private set; }

        public SettingsManager()
        {
            // 실행 파일과 같은 디렉토리에 settings.ini 생성
            settingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.ini");
            iniManager = new IniFileManager(settingsPath);
            CurrentSettings = new AppSettings();
        }

        public void LoadSettings()
        {
            try
            {
                CurrentSettings.MouseInterval = iniManager.ReadInt(SECTION_INTERVALS, "MouseInterval", 1);
                CurrentSettings.KeyboardInterval = iniManager.ReadInt(SECTION_INTERVALS, "KeyboardInterval", 10);
                CurrentSettings.KeyboardDownLatency = iniManager.ReadInt(SECTION_INTERVALS, "KeyboardDownLatency", 55);
                CurrentSettings.KeyboardUpLatency = iniManager.ReadInt(SECTION_INTERVALS, "KeyboardUpLatency", 55);
                CurrentSettings.UIUpdateInterval = iniManager.ReadInt(SECTION_INTERVALS, "UIUpdateInterval", 100);

                // 값 유효성 검사
                CurrentSettings.ValidateValues();
            }
            catch (Exception)
            {
                // 로드 실패 시 기본값 사용
                CurrentSettings.SetDefaults();
            }
        }

        public void SaveSettings()
        {
            try
            {
                // 저장 전 유효성 검사
                CurrentSettings.ValidateValues();

                iniManager.WriteInt(SECTION_INTERVALS, "MouseInterval", CurrentSettings.MouseInterval);
                iniManager.WriteInt(SECTION_INTERVALS, "KeyboardInterval", CurrentSettings.KeyboardInterval);
                iniManager.WriteInt(SECTION_INTERVALS, "KeyboardDownLatency", CurrentSettings.KeyboardDownLatency);
                iniManager.WriteInt(SECTION_INTERVALS, "KeyboardUpLatency", CurrentSettings.KeyboardUpLatency);
                iniManager.WriteInt(SECTION_INTERVALS, "UIUpdateInterval", CurrentSettings.UIUpdateInterval);
            }
            catch (Exception)
            {
                // 저장 실패는 무시 (사용자에게 알리지 않음)
            }
        }

        public void ResetToDefaults()
        {
            CurrentSettings.SetDefaults();
            SaveSettings();
        }

        public string GetSettingsFilePath()
        {
            return settingsPath;
        }
    }
}