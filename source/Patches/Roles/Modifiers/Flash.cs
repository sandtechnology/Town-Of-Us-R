using TownOfUs.Extensions;
using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Flash : Modifier, IVisualAlteration
    {

        public Flash(PlayerControl player) : base(player)
        {
            Name = "…¡µÁœ¿";
            TaskText = () => "ƒ„≥¨ÀŸ¡À£°";
            Color = Patches.Colors.Flash;
            ModifierType = ModifierEnum.Flash;
        }

        public bool TryGetModifiedAppearance(out VisualAppearance appearance)
        {
            appearance = Player.GetDefaultAppearance();
            appearance.SpeedFactor = CustomGameOptions.FlashSpeed;
            return true;
        }
    }
}