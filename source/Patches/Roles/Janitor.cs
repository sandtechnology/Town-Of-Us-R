namespace TownOfUs.Roles
{
    public class Janitor : Role
    {
        public KillButton _cleanButton;

        public Janitor(PlayerControl player) : base(player)
        {
            Name = "������";
            ImpostorText = () => "�غ��Լ� ��������";
            TaskText = () => "����ʬ�壬��ֹ���Ǳ�����";
            Color = Patches.Colors.Impostor;
            RoleType = RoleEnum.������;
            AddToRoleHistory(RoleType);
            Faction = Faction.Impostors;
        }

        public DeadBody CurrentTarget { get; set; }

        public KillButton CleanButton
        {
            get => _cleanButton;
            set
            {
                _cleanButton = value;
                ExtraButtons.Clear();
                ExtraButtons.Add(value);
            }
        }
    }
}