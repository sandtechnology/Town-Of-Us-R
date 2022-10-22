namespace TownOfUs.Roles
{
    public class Altruist : Role
    {
        public bool CurrentlyReviving;
        public DeadBody CurrentTarget;

        public bool ReviveUsed;
        
        public Altruist(PlayerControl player) : base(player)
        {
            Name = "ѳ����";
            ImpostorText = () => "�Ἲ���˺�����";
            TaskText = () => "�����Լ�����ȡ���˵�����";
            Color = Patches.Colors.Altruist;
            RoleType = RoleEnum.ѳ����;
            AddToRoleHistory(RoleType);
        }
    }
}