using Base_Mod;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Passive_HP_Recovery;

[UsedImplicitly]
public class Plugin : BaseGameMod {
    public override void OnGameLoaded(Scene scene) {
        foreach (var player in Resources.FindObjectsOfTypeAll<Player>()) {
            //if (player.TryGetComponentSafe(out Health health)) {
            //    Debug.Log($"Player health: {health.MaxHP}");
            //}
            if (!player.gameObject.HasComponent<AutoHealComponent>()) {
                player.gameObject.AddComponent<AutoHealComponent>();
            }
        }

        base.OnGameLoaded(scene);
    }
}