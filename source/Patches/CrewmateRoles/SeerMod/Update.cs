using System.Linq;
using HarmonyLib;
using TownOfUs.Extensions;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs.CrewmateRoles.SeerMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public class Update
    {
        public static string NameText(PlayerControl player, string str = "", bool meeting = false)
        {
            if (CamouflageUnCamouflage.IsCamoed)
            {
                if (meeting) return player.name + str;

                return "";
            }

            return player.name + str;
        }

        private static void UpdateMeeting(MeetingHud __instance, Seer seer)
        {
            foreach (var player in PlayerControl.AllPlayerControls)
            {
                if (!seer.Investigated.Contains(player.PlayerId)) continue;
                foreach (var state in __instance.playerStates)
                {
                    if (player.PlayerId != state.TargetPlayerId) continue;
                    var roleType = Utils.GetRole(player);
                    switch (roleType)
                    {
                        default:
                            if ((player.Is(Faction.Crewmates) && !(player.Is(RoleEnum.����) || player.Is(RoleEnum.�ϱ�) || player.Is(RoleEnum.����))) ||
                            ((player.Is(RoleEnum.����) || player.Is(RoleEnum.�ϱ�) || player.Is(RoleEnum.����)) && !CustomGameOptions.CrewKillingRed) ||
                            ((player.Is(RoleEnum.ʧ����) || player.Is(RoleEnum.�Ҵ���) || player.Is(RoleEnum.�ػ���ʹ)) && !CustomGameOptions.NeutBenignRed) ||
                            ((player.Is(RoleEnum.������) || player.Is(RoleEnum.С��) || player.Is(RoleEnum.��Ӱ)) && !CustomGameOptions.NeutEvilRed) ||
                            ((player.Is(RoleEnum.�ݻ��) || player.Is(RoleEnum.����) || player.Is(RoleEnum.����) ||
                            player.Is(RoleEnum.����֮Դ) || player.Is(RoleEnum.����֮��) || player.Is(RoleEnum.��������)) && !CustomGameOptions.NeutKillingRed))
                            {
                                state.NameText.color = Color.green;
                            }
                            else if (player.Is(RoleEnum.������) && CustomGameOptions.TraitorColourSwap)
                            {
                                foreach (var role in Role.GetRoles(RoleEnum.������))
                                {
                                    var traitor = (Traitor)role;
                                    if (traitor.formerRole == RoleEnum.���� || traitor.formerRole == RoleEnum.���� ||
                                        traitor.formerRole == RoleEnum.�ϱ�) state.NameText.color = Color.red;
                                    else state.NameText.color = Color.green;
                                }
                            }
                            else
                            {
                                state.NameText.color = Color.red;
                            }
                            break;
                    }
                }
            }
        }

        [HarmonyPriority(Priority.Last)]
        private static void Postfix(HudManager __instance)

        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (PlayerControl.LocalPlayer.Data.IsDead) return;

            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Ԥ�Լ�)) return;
            var seer = Role.GetRole<Seer>(PlayerControl.LocalPlayer);
            if (MeetingHud.Instance != null) UpdateMeeting(MeetingHud.Instance, seer);


            foreach (var player in PlayerControl.AllPlayerControls)
            {
                if (!seer.Investigated.Contains(player.PlayerId)) continue;
                var roleType = Utils.GetRole(player);
                player.nameText().transform.localPosition = new Vector3(0f, 2f, -0.5f);
                switch (roleType)
                {
                    default:
                        if ((player.Is(Faction.Crewmates) && !(player.Is(RoleEnum.����) || player.Is(RoleEnum.�ϱ�) || player.Is(RoleEnum.����))) ||
                            ((player.Is(RoleEnum.����) || player.Is(RoleEnum.�ϱ�) || player.Is(RoleEnum.����)) && !CustomGameOptions.CrewKillingRed) ||
                            ((player.Is(RoleEnum.ʧ����) || player.Is(RoleEnum.�Ҵ���) || player.Is(RoleEnum.�ػ���ʹ)) && !CustomGameOptions.NeutBenignRed) ||
                            ((player.Is(RoleEnum.������) || player.Is(RoleEnum.С��) || player.Is(RoleEnum.��Ӱ)) && !CustomGameOptions.NeutEvilRed) ||
                            ((player.Is(RoleEnum.�ݻ��) || player.Is(RoleEnum.����) || player.Is(RoleEnum.����) ||
                            player.Is(RoleEnum.����֮Դ) || player.Is(RoleEnum.����֮��) || player.Is(RoleEnum.��������)) && !CustomGameOptions.NeutKillingRed))
                        {
                            player.nameText().color = Color.green;
                        }
                        else if (player.Is(RoleEnum.������) && CustomGameOptions.TraitorColourSwap)
                        {
                            foreach (var role in Role.GetRoles(RoleEnum.������))
                            {
                                var traitor = (Traitor)role;
                                if (traitor.formerRole == RoleEnum.���� || traitor.formerRole == RoleEnum.���� ||
                                    traitor.formerRole == RoleEnum.�ϱ�) player.nameText().color = Color.red;
                                else player.nameText().color = Color.green;
                            }
                        }
                        else
                        {
                            player.nameText().color = Color.red;
                        }
                        break;
                }
            }
        }
    }
}