using System;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Sheriff : Role
    {
        public Sheriff(PlayerControl player) : base(player)
        {
            Name = "����";
            ImpostorText = () => "�����Ʋ�!";
            TaskText = () => "��ɱαװ�ߣ������ɱ��Ա��";
            Color = Patches.Colors.Sheriff;
            LastKilled = DateTime.UtcNow;
            RoleType = RoleEnum.����;
            AddToRoleHistory(RoleType);
        }

        public PlayerControl ClosestPlayer;
        public DateTime LastKilled { get; set; }
        public bool FirstRound { get; set; } = false;

        public float SheriffKillTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastKilled;
            var num = CustomGameOptions.SheriffKillCd * 1000f;
            var flag2 = num - (float) timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float) timeSpan.TotalMilliseconds) / 1000f;
        }
    }
}