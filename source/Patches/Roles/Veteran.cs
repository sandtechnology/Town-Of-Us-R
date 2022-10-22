using System;
using UnityEngine;
using TMPro;

namespace TownOfUs.Roles
{
    public class Veteran : Role
    {
        public bool Enabled;
        public DateTime LastAlerted;
        public float TimeRemaining;

        public int UsesLeft;
        public TextMeshPro UsesText;

        public bool ButtonUsable => UsesLeft != 0;

        public Veteran(PlayerControl player) : base(player)
        {
            Name = "�ϱ�";
            ImpostorText = () => "����������ʱ�̾���";
            TaskText = () => "ʹ�þ�����ɱ�����㻥������";
            Color = Patches.Colors.Veteran;
            LastAlerted = DateTime.UtcNow;
            RoleType = RoleEnum.�ϱ�;
            AddToRoleHistory(RoleType);

            UsesLeft = CustomGameOptions.MaxAlerts;
        }

        public bool OnAlert => TimeRemaining > 0f;

        public float AlertTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastAlerted;
            ;
            var num = CustomGameOptions.AlertCd * 1000f;
            var flag2 = num - (float) timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float) timeSpan.TotalMilliseconds) / 1000f;
        }

        public void Alert()
        {
            Enabled = true;
            TimeRemaining -= Time.deltaTime;
        }


        public void UnAlert()
        {
            Enabled = false;
            LastAlerted = DateTime.UtcNow;
        }
    }
}