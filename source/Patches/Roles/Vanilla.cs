using UnityEngine;

namespace TownOfUs.Roles
{
    public class Impostor : Role
    {
        public Impostor(PlayerControl player) : base(player)
        {
            Name = "αװ��";
            Hidden = true;
            Faction = Faction.Impostors;
            RoleType = RoleEnum.αװ��;
            AddToRoleHistory(RoleType);
            Color = Palette.ImpostorRed;
        }
    }

    public class Crewmate : Role
    {
        public Crewmate(PlayerControl player) : base(player)
        {
            Name = "��Ա";
            Hidden = true;
            Faction = Faction.Crewmates;
            RoleType = RoleEnum.��Ա;
            AddToRoleHistory(RoleType);
            Color = Patches.Colors.Crewmate;
        }
    }
}