using System;
using TownOfUs.Roles;

namespace TownOfUs.CrewmateRoles.DetectiveMod
{
    public class BodyReport
    {
        public PlayerControl Killer { get; set; }
        public PlayerControl Reporter { get; set; }
        public PlayerControl Body { get; set; }
        public float KillAge { get; set; }

        public static string ParseBodyReport(BodyReport br)
        {
            if (br.KillAge > CustomGameOptions.DetectiveFactionDuration * 1000)
                return
                    $"侧写报告：这个尸体死亡太久，以至于没有任何有价值的线索了。（{Math.Round(br.KillAge / 1000)}秒前死亡）";

            if (br.Killer.PlayerId == br.Body.PlayerId)
                return
                    $"侧写报告：死者是自杀身亡的！（{Math.Round(br.KillAge / 1000)}前死亡）";

            var role = Role.GetRole(br.Killer);

            if (br.KillAge < CustomGameOptions.DetectiveRoleDuration * 1000)
                return
                    $"侧写报告：凶手的职业似乎是{role.Name}！（{Math.Round(br.KillAge / 1000)}前死亡）";

            if (br.Killer.Is(Faction.Crewmates))
                return
                    $"侧写报告：凶手似乎属于船员阵营！（{Math.Round(br.KillAge / 1000)}前死亡）";

            else if (br.Killer.Is(Faction.Neutral))
                return
                    $"侧写报告：凶手似乎属于独立阵营！（{Math.Round(br.KillAge / 1000)}前死亡）";

            else
                return
                    $"侧写报告：凶手似乎属于伪装者阵营！（{Math.Round(br.KillAge / 1000)}前死亡）";
        }
    }
}
