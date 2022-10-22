using System.Collections.Generic;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Swapper : Role
    {
        public readonly List<GameObject> Buttons = new List<GameObject>();

        public readonly List<bool> ListOfActives = new List<bool>();


        public Swapper(PlayerControl player) : base(player)
        {
            Name = "��Ʊʦ";
            ImpostorText = () => "�ҵĺ������ܸ�Ŷ";
            TaskText = () => "����ʱ���Խ������˵�ͶƱ!";
            Color = Patches.Colors.Swapper;
            RoleType = RoleEnum.��Ʊʦ;
            AddToRoleHistory(RoleType);
        }
    }
}