using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Diseased : Modifier
    {
        public Diseased(PlayerControl player) : base(player)
        {
            Name = "病人";
            TaskText = () => "击杀你的凶手技能冷却时间变长";
            Color = Patches.Colors.Diseased;
            ModifierType = ModifierEnum.Diseased;
        }
    }
}