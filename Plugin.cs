using Base_Mod;
using JetBrains.Annotations;
using UnityEngine;

namespace Passive_HP_Recovery {
    [UsedImplicitly]
    public class Plugin : BaseGameMod {
        protected override string ModName => "Passive-HP-Recovery";

        public override void OnGameLoaded() {
            foreach (var player in Resources.FindObjectsOfTypeAll<Player>()) {
                //if (player.TryGetComponentSafe(out Health health)) {
                //    Debug.Log($"Player health: {health.MaxHP}");
                //}
                if (!player.gameObject.HasComponent<AutoHealComponent>()) {
                    player.gameObject.AddComponent<AutoHealComponent>();
                }
            }

            base.OnGameLoaded();
        }
    }
}