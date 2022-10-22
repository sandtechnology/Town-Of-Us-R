using UnityEngine;

namespace TownOfUs.Roles
{
    public class Engineer : Role
    {
        public Engineer(PlayerControl player) : base(player)
        {
            Name = "����ʦ";
            ImpostorText = () => "ά�����ϵ���Ҫ�豸";
            TaskText = () => "��ʱ�����ϵ��豸�ƻ�";
            Color = Patches.Colors.Engineer;
            RoleType = RoleEnum.����ʦ;
            AddToRoleHistory(RoleType);
        }

        public bool UsedThisRound { get; set; } = false;
    }
}