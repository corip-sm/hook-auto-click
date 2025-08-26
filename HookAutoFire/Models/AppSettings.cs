namespace HookAutoFire.Models
{
    public class AppSettings
    {
        // 마우스 자동 클릭 간격 (밀리초)
        public int MouseInterval { get; set; } = 1;
        
        // 마우스 DOWN 후 레이턴시 (밀리초)
        public int MouseDownLatency { get; set; } = 1;
        
        // 마우스 UP 후 레이턴시 (밀리초)  
        public int MouseUpLatency { get; set; } = 1;
        
        // 키보드 자동 입력 간격 (밀리초)
        public int KeyboardInterval { get; set; } = 1;
        
        // 키보드 DOWN 후 레이턴시 (밀리초)
        public int KeyboardDownLatency { get; set; } = 1;
        
        // 키보드 UP 후 레이턴시 (밀리초)
        public int KeyboardUpLatency { get; set; } = 1;
        
        // UI 업데이트 간격 (밀리초)
        public int UIUpdateInterval { get; set; } = 100;

        // 기본값으로 리셋
        public void SetDefaults()
        {
            MouseInterval = 1;
            MouseDownLatency = 1;
            MouseUpLatency = 1;
            KeyboardInterval = 1;
            KeyboardDownLatency = 1;
            KeyboardUpLatency = 1;
            UIUpdateInterval = 100;
        }

        // 값 유효성 검사
        public void ValidateValues()
        {
            // 최소값 제한
            if (MouseInterval < 1) MouseInterval = 1;
            if (MouseDownLatency < 0) MouseDownLatency = 0;
            if (MouseUpLatency < 0) MouseUpLatency = 0;
            if (KeyboardInterval < 1) KeyboardInterval = 1;
            if (KeyboardDownLatency < 1) KeyboardDownLatency = 1;
            if (KeyboardUpLatency < 1) KeyboardUpLatency = 1;
            if (UIUpdateInterval < 50) UIUpdateInterval = 50;
            
            // 최대값 제한
            if (MouseInterval > 1000) MouseInterval = 1000;
            if (MouseDownLatency > 100) MouseDownLatency = 100;
            if (MouseUpLatency > 100) MouseUpLatency = 100;
            if (KeyboardInterval > 1000) KeyboardInterval = 1000;
            if (KeyboardDownLatency > 200) KeyboardDownLatency = 200;
            if (KeyboardUpLatency > 200) KeyboardUpLatency = 200;
            if (UIUpdateInterval > 1000) UIUpdateInterval = 1000;
        }
    }
}