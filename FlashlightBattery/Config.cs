using Exiled.API.Interfaces;

namespace FlashlightBattery
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public string FlashlightBatteryHint { get; private set; } = "Flashlight Battery: {percent}%";
        public string FlashlightIsDead { get; private set; } = "The flashlight is out of battery.";
        public int FlashlightBattery { get; set; } = 240;
        public float DeadFlashlightHintTime { get; set; } = 1.5f;
        public int FlashlightHintTextLower { get; set; } = 10;
    }
}