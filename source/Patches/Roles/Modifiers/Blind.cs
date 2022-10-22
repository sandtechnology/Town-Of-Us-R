using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Blind : Modifier
    {
        public Blind(PlayerControl player) : base(player)
        {
            Name = "��С��";
            TaskText = () => "��ı��水ť�޷�����";
            Color = Patches.Colors.Blind;
            ModifierType = ModifierEnum.Blind;
        }
    }
}