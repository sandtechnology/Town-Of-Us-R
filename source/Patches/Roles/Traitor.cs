using System.Linq;

namespace TownOfUs.Roles
{
    public class Traitor : Role
    {
        public RoleEnum formerRole = new RoleEnum();
        public Traitor(PlayerControl player) : base(player)
        {
            Name = "������";
            ImpostorText = () => "";
            TaskText = () => "�㱳���˴�Ա��!";
            Color = Patches.Colors.Impostor;
            RoleType = RoleEnum.������;
            AddToRoleHistory(RoleType);
            Faction = Faction.Impostors;
        }
    }
}