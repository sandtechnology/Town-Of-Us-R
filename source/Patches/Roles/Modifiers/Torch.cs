using UnityEngine;

namespace TownOfUs.Roles.Modifiers
{
    public class Torch : Modifier
    {
        public Torch(PlayerControl player) : base(player)
        {
            Name = "���";
            TaskText = () => "��Ұ���ܺڰ�Ӱ��";
            Color = Patches.Colors.Torch;
            ModifierType = ModifierEnum.Torch;
        }
    }
}