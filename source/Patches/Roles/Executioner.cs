using Il2CppSystem.Collections.Generic;
using TownOfUs.Extensions;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Executioner : Role
    {
        public PlayerControl target;
        public bool TargetVotedOut;

        public Executioner(PlayerControl player) : base(player)
        {
            Name = "������";
            ImpostorText = () =>
                target == null ? "���...��û������Ŀ��..." : $"�� {target.name} Ͷ��ȥ";
            TaskText = () =>
                target == null
                    ? "���...��û������Ŀ��..."
                    : $"�� {target.name} Ͷ��ȥ!\n������:";
            Color = Patches.Colors.Executioner;
            RoleType = RoleEnum.������;
            AddToRoleHistory(RoleType);
            Faction = Faction.Neutral;
            Scale = 1.4f;
        }

        protected override void IntroPrefix(IntroCutscene._ShowTeam_d__21 __instance)
        {
            var exeTeam = new List<PlayerControl>();
            exeTeam.Add(PlayerControl.LocalPlayer);
            __instance.teamToShow = exeTeam;
        }

        internal override bool EABBNOODFGL(ShipStatus __instance)
        {
            if (Player.Data.IsDead) return true;
            if (!TargetVotedOut || !target.Data.IsDead) return true;
            Utils.EndGame();
            return false;
        }

        public void Wins()
        {
            if (Player.Data.IsDead || Player.Data.Disconnected) return;
            TargetVotedOut = true;
        }

        public void Loses()
        {
            LostByRPC = true;
        }
    }
}