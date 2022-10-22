using System;

namespace TownOfUs.Roles
{
    public class Detective : Role
    {
        public PlayerControl ClosestPlayer;
        public DateTime LastExamined { get; set; }

        public Detective(PlayerControl player) : base(player)
        {
            Name = "��дʦ";
            ImpostorText = () => "�������ҵ�ʬ��Ѫ��";
            TaskText = () => "�����ɵ����";
            Color = Patches.Colors.Detective;
            LastExamined = DateTime.UtcNow;
            RoleType = RoleEnum.��дʦ;
            AddToRoleHistory(RoleType);
        }

        public float ExamineTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastExamined;
            var num = CustomGameOptions.ExamineCd * 1000f;
            var flag2 = num - (float) timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float) timeSpan.TotalMilliseconds) / 1000f;
        }
    }
}