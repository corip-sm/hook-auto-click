namespace HookAutoFire.Models
{
    public class AppSettings
    {
        // 마우스 자동 클릭 간격 (밀리초)
        public int MouseInterval { get; set; } = 1;
        
        // 키보드 자동 입력 간격 (밀리초) - 마우스보다 널널하게
        public int KeyboardInterval { get; set; } = 100;
        
        // UI 업데이트 간격 (밀리초)
        public int UIUpdateInterval { get; set; } = 100;

        // 기본값으로 리셋
        public void SetDefaults()
        {
            MouseInterval = 1;
            KeyboardInterval = 100;
            UIUpdateInterval = 100;
        }

        // 값 유효성 검사
        public void ValidateValues()
        {
            // 최소값 제한
            if (MouseInterval < 1) MouseInterval = 1;
            if (KeyboardInterval < 1) KeyboardInterval = 1;
            if (UIUpdateInterval < 50) UIUpdateInterval = 50;
            
            // 최대값 제한
            if (MouseInterval > 1000) MouseInterval = 1000;
            if (KeyboardInterval > 1000) KeyboardInterval = 1000;
            if (UIUpdateInterval > 1000) UIUpdateInterval = 1000;
        }
    }
}