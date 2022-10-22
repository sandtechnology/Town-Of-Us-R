using UnityEngine;
using System.Collections.Generic;

namespace TownOfUs.Roles.Modifiers
{
    public class Sleuth : Modifier
    {
        public List<byte> Reported = new List<byte>();
        public Sleuth(PlayerControl player) : base(player)
        {
            Name = "��Ĺ��";
            TaskText = () => "�Լ�����ʬ��ʱ֪�����ߵ�ְҵ";
            Color = Patches.Colors.Sleuth;
            ModifierType = ModifierEnum.Sleuth;
        }
    }
}