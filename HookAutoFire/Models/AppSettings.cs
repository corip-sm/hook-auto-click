namespace HookAutoFire.Models
{
    public class AppSettings
    {
        // 마우스 자동 클릭 간격 (밀리초)
        public int MouseInterval { get; set; } = 1;
        
        // 키보드 자동 입력 간격 (밀리초) - 마우스보다 널널하게
        public int KeyboardInterval { get; set; } = 100;
        
        // 키보드 DOWN 후 레이턴시 (밀리초)
        public int KeyboardDownLatency { get; set; } = 55;
        
        // 키보드 UP 후 레이턴시 (밀리초)
        public int KeyboardUpLatency { get; set; } = 55;
        
        // UI 업데이트 간격 (밀리초)
        public int UIUpdateInterval { get; set; } = 100;

        // 기본값으로 리셋
        public void SetDefaults()
        {
            MouseInterval = 1;
            KeyboardInterval = 100;
            KeyboardDownLatency = 55;
            KeyboardUpLatency = 55;
            UIUpdateInterval = 100;
        }

        // 값 유효성 검사
        public void ValidateValues()
        {
            // 최소값 제한
            if (MouseInterval < 1) MouseInterval = 1;
            if (KeyboardInterval < 1) KeyboardInterval = 1;
            if (KeyboardDownLatency < 1) KeyboardDownLatency = 1;
            if (KeyboardUpLatency < 1) KeyboardUpLatency = 1;
            if (UIUpdateInterval < 50) UIUpdateInterval = 50;
            
            // 최대값 제한
            if (MouseInterval > 1000) MouseInterval = 1000;
            if (KeyboardInterval > 1000) KeyboardInterval = 1000;
            if (KeyboardDownLatency > 200) KeyboardDownLatency = 200;
            if (KeyboardUpLatency > 200) KeyboardUpLatency = 200;
            if (UIUpdateInterval > 1000) UIUpdateInterval = 1000;
        }
    }
}