using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class ButtonBarry : Modifier
    {
        public KillButton ButtonButton;

        public bool ButtonUsed;

        public ButtonBarry(PlayerControl player) : base(player)
        {
            Name = "ִť��";
            TaskText = () => "��ʱ��ؿ����ٿ�����!";
            Color = Patches.Colors.ButtonBarry;
            ModifierType = ModifierEnum.ButtonBarry;
        }
    }
}