using System.Collections.Generic;
using TownOfUs.CrewmateRoles.InvestigatorMod;

namespace TownOfUs.Roles
{
    public class Investigator : Role
    {
        public readonly List<Footprint> AllPrints = new List<Footprint>();


        public Investigator(PlayerControl player) : base(player)
        {
            Name = "����Ա";
            ImpostorText = () => "����ֻ��һ��!";
            TaskText = () => "����Կ��������˵��㼣��";
            Color = Patches.Colors.Investigator;
            RoleType = RoleEnum.����Ա;
            AddToRoleHistory(RoleType);
            Scale = 1.4f;
        }
    }
}