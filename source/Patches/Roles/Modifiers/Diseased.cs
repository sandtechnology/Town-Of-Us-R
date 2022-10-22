using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Diseased : Modifier
    {
        public Diseased(PlayerControl player) : base(player)
        {
            Name = "����";
            TaskText = () => "��ɱ������ּ�����ȴʱ��䳤";
            Color = Patches.Colors.Diseased;
            ModifierType = ModifierEnum.Diseased;
        }
    }
}