namespace TownOfUs.Roles
{
    public class Spy : Role
    {
        public Spy(PlayerControl player) : base(player)
        {
            Name = "�ع�";
            ImpostorText = () => "������������";
            TaskText = () => "��ʱ�鿴�����ͼ���ĵ�ͼ";
            Color = Patches.Colors.Spy;
            RoleType = RoleEnum.�ع�;
            AddToRoleHistory(RoleType);
        }
    }
}