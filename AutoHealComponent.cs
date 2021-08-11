using JetBrains.Annotations;
using UnityEngine;

namespace Passive_HP_Recovery {
    public class AutoHealComponent : MonoBehaviour {
        [UsedImplicitly]
        public void Update() {
            if (!gameObject.TryGetComponentSafe(out Health healthComponent)) return;

            if (healthComponent.CurrentHP < healthComponent.MaxHP) {
                healthComponent.CurrentHP += 8 * Time.deltaTime;
            }
        }
    }
}