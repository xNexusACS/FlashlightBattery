using Exiled.API.Features;
using System;
using ServerHandler = Exiled.Events.Handlers.Server;
using PlayerHandler = Exiled.Events.Handlers.Player;

namespace FlashlightBattery
{
    public class MainClass : Plugin<Config>
    {
        public static MainClass singleton;

        public override string Name => "FlashlightBattery";
        public override string Prefix => "flashlight_battery";
        public override string Author => "xNexus-ACS";
        public override Version Version { get; } = new Version(0, 1, 0);
        public override Version RequiredExiledVersion { get; } = new Version(5, 2, 1);

        public EventHandlers ev;

        public override void OnEnabled()
        {
            singleton = this;
            ev = new EventHandlers();

            ServerHandler.RestartingRound += ev.OnRestartingRound;
            PlayerHandler.ChangingItem += ev.OnChangingItem;
            PlayerHandler.TogglingFlashlight += ev.OnToggleFlashlight;
            PlayerHandler.DroppingItem += ev.OnDroppingItem;
            PlayerHandler.PickingUpItem += ev.OnPickingUpItem;
            PlayerHandler.Spawning += ev.OnSpawn;
            
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            ServerHandler.RestartingRound -= ev.OnRestartingRound;
            PlayerHandler.ChangingItem -= ev.OnChangingItem;
            PlayerHandler.TogglingFlashlight -= ev.OnToggleFlashlight;
            PlayerHandler.DroppingItem -= ev.OnDroppingItem;
            PlayerHandler.PickingUpItem -= ev.OnPickingUpItem;
            PlayerHandler.Spawning -= ev.OnSpawn;
            
            singleton = null;
            ev = null;
            base.OnDisabled();
        }
    }
}