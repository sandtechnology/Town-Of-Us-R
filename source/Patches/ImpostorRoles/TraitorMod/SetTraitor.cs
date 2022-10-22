using HarmonyLib;
using Hazel;
using TownOfUs.Roles;
using System.Linq;
using TownOfUs.CrewmateRoles.InvestigatorMod;
using TownOfUs.CrewmateRoles.SnitchMod;
using TownOfUs.Extensions;
using UnityEngine;
using Reactor;

namespace TownOfUs.ImpostorRoles.TraitorMod
{
    [HarmonyPatch(typeof(AirshipExileController), nameof(AirshipExileController.WrapUpAndSpawn))]
    public static class AirshipExileController_WrapUpAndSpawn
    {
        public static void Postfix(AirshipExileController __instance) => SetTraitor.ExileControllerPostfix(__instance);
    }
    
    [HarmonyPatch(typeof(ExileController), nameof(ExileController.WrapUp))]
    public class SetTraitor
    {
        public static PlayerControl WillBeTraitor;
        public static Sprite Sprite => TownOfUs.Arrow;

        public static void ExileControllerPostfix(ExileController __instance)
        {
            var exiled = __instance.exiled?.Object;
            var alives = PlayerControl.AllPlayerControls.ToArray()
                    .Where(x => !x.Data.IsDead && !x.Data.Disconnected).ToList();
            foreach (var player in alives)
            {
                if (player.Data.IsImpostor() || ((player.Is(RoleEnum.����) || player.Is(RoleEnum.����)
                    || player.Is(RoleEnum.�ݻ��) || player.Is(RoleEnum.����֮Դ) || player.Is(RoleEnum.����֮��)
                    || player.Is(RoleEnum.��������)) && CustomGameOptions.NeutralKillingStopsTraitor))
                {
                    return;
                }
            }
            if (PlayerControl.LocalPlayer.Data.IsDead || exiled == PlayerControl.LocalPlayer) return;
            if (alives.Count < CustomGameOptions.LatestSpawn) return;
            if (PlayerControl.LocalPlayer != WillBeTraitor) return;

            if (!PlayerControl.LocalPlayer.Is(RoleEnum.������))
            {
                if (PlayerControl.LocalPlayer.Is(RoleEnum.������))
                {
                    var snitchRole = Role.GetRole<Snitch>(PlayerControl.LocalPlayer);
                    snitchRole.ImpArrows.DestroyAll();
                    snitchRole.SnitchArrows.Values.DestroyAll();
                    snitchRole.SnitchArrows.Clear();
                    CompleteTask.Postfix(PlayerControl.LocalPlayer);
                }

                if (PlayerControl.LocalPlayer.Is(RoleEnum.����Ա)) Footprint.DestroyAll(Role.GetRole<Investigator>(PlayerControl.LocalPlayer));

                if (PlayerControl.LocalPlayer.Is(RoleEnum.ʱ������))
                {
                    var timeLordRole = Role.GetRole<TimeLord>(PlayerControl.LocalPlayer);
                    Object.Destroy(timeLordRole.UsesText);
                }

                if (PlayerControl.LocalPlayer.Is(RoleEnum.׷����))
                {
                    var trackerRole = Role.GetRole<Tracker>(PlayerControl.LocalPlayer);
                    trackerRole.TrackerArrows.Values.DestroyAll();
                    trackerRole.TrackerArrows.Clear();
                    Object.Destroy(trackerRole.UsesText);
                }

                if (PlayerControl.LocalPlayer.Is(RoleEnum.����ʦ))
                {
                    var transporterRole = Role.GetRole<Transporter>(PlayerControl.LocalPlayer);
                    Object.Destroy(transporterRole.UsesText);
                }

                if (PlayerControl.LocalPlayer.Is(RoleEnum.�ϱ�))
                {
                    var veteranRole = Role.GetRole<Veteran>(PlayerControl.LocalPlayer);
                    Object.Destroy(veteranRole.UsesText);
                }

                if (PlayerControl.LocalPlayer.Is(RoleEnum.�л�ʦ))
                {
                    var medRole = Role.GetRole<Medium>(PlayerControl.LocalPlayer);
                    medRole.MediatedPlayers.Values.DestroyAll();
                    medRole.MediatedPlayers.Clear();
                }

                if (PlayerControl.LocalPlayer.Is(RoleEnum.����ʦ))
                {
                    var trapperRole = Role.GetRole<Trapper>(PlayerControl.LocalPlayer);
                    Object.Destroy(trapperRole.UsesText);
                }

                var oldRole = Role.GetRole(PlayerControl.LocalPlayer).RoleType;
                Role.RoleDictionary.Remove(PlayerControl.LocalPlayer.PlayerId);
                var role = new Traitor(PlayerControl.LocalPlayer);
                role.formerRole = oldRole;
                role.RegenTask();

                var writer = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId,
                    (byte) CustomRPC.TraitorSpawn, SendOption.Reliable, -1);
                AmongUsClient.Instance.FinishRpcImmediately(writer);

                TurnImp(PlayerControl.LocalPlayer);
            }
        }

        public static void TurnImp(PlayerControl player)
        {
            player.Data.Role.TeamType = RoleTeamTypes.Impostor;
            RoleManager.Instance.SetRole(player, RoleTypes.Impostor);
            player.SetKillTimer(PlayerControl.GameOptions.KillCooldown);

            System.Console.WriteLine("���ԣ��Լ��Ƿ�ԭ��ı�����: " + player.Data.Role.IsImpostor);

            foreach (var player2 in PlayerControl.AllPlayerControls)
            {
                if (player2.Data.IsImpostor() && PlayerControl.LocalPlayer.Data.IsImpostor())
                {
                    player2.nameText().color = Patches.Colors.Impostor;
                }
            }

            if (CustomGameOptions.TraitorCanAssassin)
            {
                var writer2 = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId,
                    (byte)CustomRPC.SetAssassin, SendOption.Reliable, -1);
                writer2.Write(player.PlayerId);
                AmongUsClient.Instance.FinishRpcImmediately(writer2);
            }
            
            if (PlayerControl.LocalPlayer.PlayerId == player.PlayerId)
            {
                DestroyableSingleton<HudManager>.Instance.KillButton.gameObject.SetActive(true);
                Coroutines.Start(Utils.FlashCoroutine(Color.red, 3f));
            }

            foreach (var snitch in Role.GetRoles(RoleEnum.������))
            {
                var snitchRole = (Snitch)snitch;
                if (snitchRole.TasksDone && PlayerControl.LocalPlayer.Is(RoleEnum.������) && CustomGameOptions.SnitchSeesTraitor)
                {
                    var gameObj = new GameObject();
                    var arrow = gameObj.AddComponent<ArrowBehaviour>();
                    gameObj.transform.parent = PlayerControl.LocalPlayer.gameObject.transform;
                    var renderer = gameObj.AddComponent<SpriteRenderer>();
                    renderer.sprite = Sprite;
                    arrow.image = renderer;
                    gameObj.layer = 5;
                    snitchRole.SnitchArrows.Add(player.PlayerId, arrow);
                }
                else if (snitchRole.Revealed && PlayerControl.LocalPlayer.Is(RoleEnum.������) && CustomGameOptions.SnitchSeesTraitor)
                {
                    var gameObj = new GameObject();
                    var arrow = gameObj.AddComponent<ArrowBehaviour>();
                    gameObj.transform.parent = PlayerControl.LocalPlayer.gameObject.transform;
                    var renderer = gameObj.AddComponent<SpriteRenderer>();
                    renderer.sprite = Sprite;
                    arrow.image = renderer;
                    gameObj.layer = 5;
                    snitchRole.ImpArrows.Add(arrow);
                }
            }

            foreach (var haunter in Role.GetRoles(RoleEnum.ԩ��))
            {
                var haunterRole = (Haunter)haunter;
                if (haunterRole.Revealed && PlayerControl.LocalPlayer.Is(RoleEnum.������))
                {
                    var gameObj = new GameObject();
                    var arrow = gameObj.AddComponent<ArrowBehaviour>();
                    gameObj.transform.parent = PlayerControl.LocalPlayer.gameObject.transform;
                    var renderer = gameObj.AddComponent<SpriteRenderer>();
                    renderer.sprite = Sprite;
                    arrow.image = renderer;
                    gameObj.layer = 5;
                    haunterRole.ImpArrows.Add(arrow);
                }
            }

            Lights.SetLights();
        }

        public static void Postfix(ExileController __instance) => ExileControllerPostfix(__instance);
    }
}