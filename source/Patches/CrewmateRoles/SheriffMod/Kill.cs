﻿using System;
using HarmonyLib;
using Hazel;
using TownOfUs.CrewmateRoles.MedicMod;
using TownOfUs.Extensions;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs.CrewmateRoles.SheriffMod
{
    [HarmonyPatch(typeof(KillButton), nameof(KillButton.DoClick))]
    public static class Kill
    {
        [HarmonyPriority(Priority.First)]
        private static bool Prefix(KillButton __instance)
        {
            if (__instance != DestroyableSingleton<HudManager>.Instance.KillButton) return true;
            var flag = PlayerControl.LocalPlayer.Is(RoleEnum.警长);
            if (!flag) return true;
            var role = Role.GetRole<Sheriff>(PlayerControl.LocalPlayer);
            if (!PlayerControl.LocalPlayer.CanMove) return false;
            if (PlayerControl.LocalPlayer.Data.IsDead) return false;
            var flag2 = role.SheriffKillTimer() == 0f;
            if (!flag2) return false;
            if (!__instance.enabled || role.ClosestPlayer == null) return false;
            var distBetweenPlayers = Utils.GetDistBetweenPlayers(PlayerControl.LocalPlayer, role.ClosestPlayer);
            var flag3 = distBetweenPlayers < GameOptionsData.KillDistances[PlayerControl.GameOptions.KillDistance];
            if (!flag3) return false;

            var flag4 = role.ClosestPlayer.Data.IsImpostor() ||
                        role.ClosestPlayer.Is(RoleEnum.小丑) && CustomGameOptions.SheriffKillsJester ||
                        role.ClosestPlayer.Is(RoleEnum.混沌) && CustomGameOptions.SheriffKillsGlitch ||
                        role.ClosestPlayer.Is(RoleEnum.天启) && CustomGameOptions.SheriffKillsGlitch ||
                        role.ClosestPlayer.Is(RoleEnum.行刑者) && CustomGameOptions.SheriffKillsExecutioner ||
                        role.ClosestPlayer.Is(RoleEnum.纵火狂) && CustomGameOptions.SheriffKillsArsonist ||
                        role.ClosestPlayer.Is(RoleEnum.月下狼人) && CustomGameOptions.SheriffKillsWerewolf ||
                        role.ClosestPlayer.Is(RoleEnum.瘟疫之源) && CustomGameOptions.SheriffKillsPlaguebearer;

            if (role.ClosestPlayer.Is(RoleEnum.万疫之神))
            {
                Utils.RpcMurderPlayer(role.ClosestPlayer, PlayerControl.LocalPlayer);
                return false;
            }
            if (role.ClosestPlayer.IsInfected() || role.Player.IsInfected())
            {
                foreach (var pb in Role.GetRoles(RoleEnum.瘟疫之源)) ((Plaguebearer)pb).RpcSpreadInfection(role.ClosestPlayer, role.Player);
            }
            if (role.ClosestPlayer.IsOnAlert())
            {
                if (role.ClosestPlayer.IsShielded())
                {
                    var medic = role.ClosestPlayer.GetMedic().Player.PlayerId;
                    var writer1 = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId,
                        (byte)CustomRPC.AttemptSound, SendOption.Reliable, -1);
                    writer1.Write(medic);
                    writer1.Write(role.ClosestPlayer.PlayerId);
                    AmongUsClient.Instance.FinishRpcImmediately(writer1);

                    if (CustomGameOptions.ShieldBreaks) role.LastKilled = DateTime.UtcNow;

                    StopKill.BreakShield(medic, role.ClosestPlayer.PlayerId, CustomGameOptions.ShieldBreaks);

                    Utils.RpcMurderPlayer(role.ClosestPlayer, PlayerControl.LocalPlayer);
                }
                else if (role.Player.IsShielded())
                {
                    var medic = role.Player.GetMedic().Player.PlayerId;
                    var writer1 = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId,
                        (byte)CustomRPC.AttemptSound, SendOption.Reliable, -1);
                    writer1.Write(medic);
                    writer1.Write(role.Player.PlayerId);
                    AmongUsClient.Instance.FinishRpcImmediately(writer1);
                    if (CustomGameOptions.ShieldBreaks) role.LastKilled = DateTime.UtcNow;
                    StopKill.BreakShield(medic, role.Player.PlayerId, CustomGameOptions.ShieldBreaks);
                    Utils.RpcMurderPlayer(PlayerControl.LocalPlayer, PlayerControl.LocalPlayer);
                    if (CustomGameOptions.SheriffKillOther && !role.ClosestPlayer.IsProtected() && CustomGameOptions.KilledOnAlert)
                        Utils.RpcMurderPlayer(PlayerControl.LocalPlayer, role.ClosestPlayer);
                }
                else
                {
                    Utils.RpcMurderPlayer(role.ClosestPlayer, PlayerControl.LocalPlayer);
                    if (CustomGameOptions.KilledOnAlert && CustomGameOptions.SheriffKillOther)
                    {
                        Utils.RpcMurderPlayer(PlayerControl.LocalPlayer, role.ClosestPlayer);
                    }
                }

                return false;
            }
            else if (role.ClosestPlayer.IsShielded())
            {
                var medic = role.ClosestPlayer.GetMedic().Player.PlayerId;
                var writer1 = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId,
                    (byte) CustomRPC.AttemptSound, SendOption.Reliable, -1);
                writer1.Write(medic);
                writer1.Write(role.ClosestPlayer.PlayerId);
                AmongUsClient.Instance.FinishRpcImmediately(writer1);

                if (CustomGameOptions.ShieldBreaks) role.LastKilled = DateTime.UtcNow;

                StopKill.BreakShield(medic, role.ClosestPlayer.PlayerId, CustomGameOptions.ShieldBreaks);

                return false;
            }
            else if (role.ClosestPlayer.IsVesting())
            {
                Utils.RpcMurderPlayer(PlayerControl.LocalPlayer, PlayerControl.LocalPlayer);

                return false;
            }
            else if (role.ClosestPlayer.IsProtected())
            {
                if (!flag4)
                {
                    Utils.RpcMurderPlayer(PlayerControl.LocalPlayer, PlayerControl.LocalPlayer);
                }
                role.LastKilled.AddSeconds(CustomGameOptions.ProtectKCReset);
                return false;
            }

            if (!flag4)
            {
                if (CustomGameOptions.SheriffKillOther)
                    Utils.RpcMurderPlayer(PlayerControl.LocalPlayer, role.ClosestPlayer);
                Utils.RpcMurderPlayer(PlayerControl.LocalPlayer, PlayerControl.LocalPlayer);
            }
            else
            {
                Utils.RpcMurderPlayer(PlayerControl.LocalPlayer, role.ClosestPlayer);
                role.LastKilled = DateTime.UtcNow;
            }
            return false;
        }
    }
}
