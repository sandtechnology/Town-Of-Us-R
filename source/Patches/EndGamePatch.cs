using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Linq;
using Reactor.Extensions;
using TownOfUs.Roles;

namespace TownOfUs.Patches {

    static class AdditionalTempData {
        public static List<PlayerRoleInfo> playerRoles = new List<PlayerRoleInfo>();

        public static void clear() {
            playerRoles.Clear();
        }

        internal class PlayerRoleInfo {
            public string PlayerName { get; set; }
            public string Role {get;set;}
        }
    }


    [HarmonyPatch(typeof(AmongUsClient), nameof(AmongUsClient.OnGameEnd))]
    public class OnGameEndPatch {

        public static void Postfix(AmongUsClient __instance, [HarmonyArgument(0)] EndGameResult endGameResult)
        {
            AdditionalTempData.clear();
            var playerRole = "";
            // Theres a better way of doing this e.g. switch statement or dictionary. But this works for now.
            foreach (var playerControl in PlayerControl.AllPlayerControls)
            {
                playerRole = "";
                foreach (var role in Role.RoleHistory.Where(x => x.Key == playerControl.PlayerId))
                {
                    if (role.Value == RoleEnum.��Ա) {playerRole += "<color=#"+Patches.Colors.Crewmate.ToHtmlStringRGBA()+ ">��Ա</color> > "; }
                    else if (role.Value == RoleEnum.αװ��) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+ ">αװ��</color> > "; }
                    else if (role.Value == RoleEnum.ѳ����) {playerRole += "<color=#"+Patches.Colors.Altruist.ToHtmlStringRGBA()+ ">ѳ����</color> > "; }
                    else if (role.Value == RoleEnum.����ʦ) {playerRole += "<color=#"+Patches.Colors.Engineer.ToHtmlStringRGBA()+ ">����ʦ</color> > "; }
                    else if (role.Value == RoleEnum.����Ա) {playerRole += "<color=#"+Patches.Colors.Investigator.ToHtmlStringRGBA()+ ">����Ա</color> > "; }
                    else if (role.Value == RoleEnum.�г�) {playerRole += "<color=#"+Patches.Colors.Mayor.ToHtmlStringRGBA()+ ">�г�</color> > "; }
                    else if (role.Value == RoleEnum.��ҽ) {playerRole += "<color=#"+Patches.Colors.Medic.ToHtmlStringRGBA()+ ">��ҽ</color> > "; }
                    else if (role.Value == RoleEnum.����) {playerRole += "<color=#"+Patches.Colors.Sheriff.ToHtmlStringRGBA()+ ">����</color> > "; }
                    else if (role.Value == RoleEnum.��Ʊʦ) {playerRole += "<color=#"+Patches.Colors.Swapper.ToHtmlStringRGBA()+ ">��Ʊʦ</color> > "; }
                    else if (role.Value == RoleEnum.ʱ������) {playerRole += "<color=#"+Patches.Colors.TimeLord.ToHtmlStringRGBA()+ ">ʱ������</color> > "; }
                    else if (role.Value == RoleEnum.Ԥ�Լ�) {playerRole += "<color=#"+Patches.Colors.Seer.ToHtmlStringRGBA()+ ">Ԥ�Լ�</color> > "; }
                    else if (role.Value == RoleEnum.������) {playerRole += "<color=#"+Patches.Colors.Snitch.ToHtmlStringRGBA()+ ">������</color> > "; }
                    else if (role.Value == RoleEnum.�ع�) {playerRole += "<color=#"+Patches.Colors.Spy.ToHtmlStringRGBA()+ ">�ع�</color> > "; }
                    else if (role.Value == RoleEnum.����) {playerRole += "<color=#"+Patches.Colors.Vigilante.ToHtmlStringRGBA()+ ">����</color> > "; }
                    else if (role.Value == RoleEnum.�ݻ��) {playerRole += "<color=#"+Patches.Colors.Arsonist.ToHtmlStringRGBA()+ ">�ݻ��</color> > "; }
                    else if (role.Value == RoleEnum.������) {playerRole += "<color=#"+Patches.Colors.Executioner.ToHtmlStringRGBA()+ ">������</color> > "; }
                    else if (role.Value == RoleEnum.����) {playerRole += "<color=#"+Patches.Colors.Glitch.ToHtmlStringRGBA()+ ">����</color> > "; }
                    else if (role.Value == RoleEnum.С��) {playerRole += "<color=#"+Patches.Colors.Jester.ToHtmlStringRGBA()+ ">С��</color> > "; }
                    else if (role.Value == RoleEnum.��Ӱ) {playerRole += "<color=#"+Patches.Colors.Phantom.ToHtmlStringRGBA()+ ">��Ӱ</color> > "; }
                    //else if (role.Value == RoleEnum.Assassin) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">Assassin</color> > ";}
                    //else if (role.Value == RoleEnum.Camouflager) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+">Camouflager</color> > ";}
                    else if (role.Value == RoleEnum.������) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+ ">������</color> > "; }
                    else if (role.Value == RoleEnum.������) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+ ">������</color> > "; }
                    else if (role.Value == RoleEnum.�ܵ���) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+ ">�ܵ���</color> > "; }
                    else if (role.Value == RoleEnum.������) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+ ">������</color> > "; }
                    else if (role.Value == RoleEnum.������) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+ ">������</color> > "; }
                    else if (role.Value == RoleEnum.Ǳ����) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+ ">Ǳ����</color> > "; }
                    else if (role.Value == RoleEnum.������) {playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+ ">������</color> > "; }
                    else if (role.Value == RoleEnum.ԩ��) { playerRole += "<color=#"+Patches.Colors.Haunter.ToHtmlStringRGBA()+ ">ԩ��</color> > "; }
                    else if (role.Value == RoleEnum.������) { playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+ ">������</color> > "; }
                    else if (role.Value == RoleEnum.�ϱ�) { playerRole += "<color=#"+Patches.Colors.Veteran.ToHtmlStringRGBA()+ ">�ϱ�</color> > "; }
                    else if (role.Value == RoleEnum.ʧ����) { playerRole += "<color=#"+Patches.Colors.Amnesiac.ToHtmlStringRGBA()+ ">ʧ����</color> > "; }
                    else if (role.Value == RoleEnum.����) { playerRole += "<color=#"+Patches.Colors.Juggernaut.ToHtmlStringRGBA()+ ">����</color> > "; }
                    else if (role.Value == RoleEnum.׷����) { playerRole += "<color=#"+Patches.Colors.Tracker.ToHtmlStringRGBA()+ ">׷����</color> > "; }
                    else if (role.Value == RoleEnum.������ʦ) { playerRole += "<color=#"+Patches.Colors.Impostor.ToHtmlStringRGBA()+ ">������ʦ</color> > "; }
                    else if (role.Value == RoleEnum.����ʦ) { playerRole += "<color=#" + Patches.Colors.Transporter.ToHtmlStringRGBA() + ">����ʦ</color> > "; }
                    else if (role.Value == RoleEnum.������) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">������</color> > "; }
                    else if (role.Value == RoleEnum.�л�ʦ) { playerRole += "<color=#" + Patches.Colors.Medium.ToHtmlStringRGBA() + ">�л�ʦ</color> > "; }
                    else if (role.Value == RoleEnum.����ʦ) { playerRole += "<color=#" + Patches.Colors.Trapper.ToHtmlStringRGBA() + ">����ʦ</color> > "; }
                    else if (role.Value == RoleEnum.�Ҵ���) { playerRole += "<color=#" + Patches.Colors.Survivor.ToHtmlStringRGBA() + ">�Ҵ���</color> > "; }
                    else if (role.Value == RoleEnum.�ػ���ʹ) { playerRole += "<color=#" + Patches.Colors.GuardianAngel.ToHtmlStringRGBA() + ">�ػ���ʹ</color> > "; }
                    else if (role.Value == RoleEnum.��ý) { playerRole += "<color=#" + Patches.Colors.Mystic.ToHtmlStringRGBA() + ">��ý</color> > "; }
                    else if (role.Value == RoleEnum.������) { playerRole += "<color=#" + Patches.Colors.Impostor.ToHtmlStringRGBA() + ">������</color> > "; }
                    else if (role.Value == RoleEnum.����֮Դ) { playerRole += "<color=#" + Patches.Colors.Plaguebearer.ToHtmlStringRGBA() + ">����֮Դ</color> > "; }
                    else if (role.Value == RoleEnum.����֮��) { playerRole += "<color=#" + Patches.Colors.Pestilence.ToHtmlStringRGBA() + ">����֮��</color> > "; }
                    else if (role.Value == RoleEnum.��������) { playerRole += "<color=#" + Patches.Colors.Werewolf.ToHtmlStringRGBA() + ">��������</color> > "; }
                    else if (role.Value == RoleEnum.��дʦ) { playerRole += "<color=#" + Patches.Colors.Detective.ToHtmlStringRGBA() + ">��дʦ</color> > "; }
                }
                playerRole = playerRole.Remove(playerRole.Length - 3);

                if (playerControl.Is(ModifierEnum.Giant)) {
                    playerRole += " (<color=#" + Patches.Colors.Giant.ToHtmlStringRGBA() + ">����</color>)";
                } else if (playerControl.Is(ModifierEnum.ButtonBarry)) {
                    playerRole += " (<color=#" + Patches.Colors.ButtonBarry.ToHtmlStringRGBA() + ">ִť��</color>)";
                } else if (playerControl.Is(ModifierEnum.Blind)) {
                    playerRole += " (<color=#" + Patches.Colors.Blind.ToHtmlStringRGBA() + ">���</color>)";
                } else if (playerControl.Is(ModifierEnum.Bait)) {
                    playerRole += " (<color=#" + Patches.Colors.Bait.ToHtmlStringRGBA() + ">�ն�</color>)";
                } else if (playerControl.Is(ModifierEnum.Diseased)) {
                    playerRole += " (<color=#" + Patches.Colors.Diseased.ToHtmlStringRGBA() + ">����</color>)";
                } else if (playerControl.Is(ModifierEnum.Flash)) {
                    playerRole += " (<color=#" + Patches.Colors.Flash.ToHtmlStringRGBA() + ">������</color>)";
                } else if (playerControl.Is(ModifierEnum.Tiebreaker)) {
                    playerRole += " (<color=#" + Patches.Colors.Tiebreaker.ToHtmlStringRGBA() + ">��ƽ��</color>)";
                } else if (playerControl.Is(ModifierEnum.Torch)) {
                    playerRole += " (<color=#" + Patches.Colors.Torch.ToHtmlStringRGBA() + ">���</color>)";
                } else if (playerControl.Is(ModifierEnum.Lover)) {
                    playerRole += " (<color=#" + Patches.Colors.Lovers.ToHtmlStringRGBA() + ">����</color>)";
                } else if (playerControl.Is(ModifierEnum.Sleuth)) {
                    playerRole += " (<color=#" + Patches.Colors.Sleuth.ToHtmlStringRGBA() + ">��Ĺ��</color>)";
                }  
                AdditionalTempData.playerRoles.Add(new AdditionalTempData.PlayerRoleInfo() { PlayerName = playerControl.Data.PlayerName, Role = playerRole });
            }
        }
    }

    [HarmonyPatch(typeof(EndGameManager), nameof(EndGameManager.SetEverythingUp))]
    public class EndGameManagerSetUpPatch {
        public static void Postfix(EndGameManager __instance) {
            GameObject bonusText = UnityEngine.Object.Instantiate(__instance.WinText.gameObject);
            bonusText.transform.position = new Vector3(__instance.WinText.transform.position.x, __instance.WinText.transform.position.y - 0.8f, __instance.WinText.transform.position.z);
            bonusText.transform.localScale = new Vector3(0.7f, 0.7f, 1f);
            TMPro.TMP_Text textRenderer = bonusText.GetComponent<TMPro.TMP_Text>();
            textRenderer.text = "";

            var position = Camera.main.ViewportToWorldPoint(new Vector3(0f, 1f, Camera.main.nearClipPlane));
            GameObject roleSummary = UnityEngine.Object.Instantiate(__instance.WinText.gameObject);
            roleSummary.transform.position = new Vector3(__instance.Navigation.ExitButton.transform.position.x + 0.1f, position.y - 0.1f, -14f); 
            roleSummary.transform.localScale = new Vector3(1f, 1f, 1f);

            var roleSummaryText = new StringBuilder();
            roleSummaryText.AppendLine("���ֽ���ͳ��:");
            foreach(var data in AdditionalTempData.playerRoles) {
                var role = string.Join(" ", data.Role);
                roleSummaryText.AppendLine($"{data.PlayerName} - {role}");
            }
            TMPro.TMP_Text roleSummaryTextMesh = roleSummary.GetComponent<TMPro.TMP_Text>();
            roleSummaryTextMesh.alignment = TMPro.TextAlignmentOptions.TopLeft;
            roleSummaryTextMesh.color = Color.white;
            roleSummaryTextMesh.fontSizeMin = 1.5f;
            roleSummaryTextMesh.fontSizeMax = 1.5f;
            roleSummaryTextMesh.fontSize = 1.5f;
             
            var roleSummaryTextMeshRectTransform = roleSummaryTextMesh.GetComponent<RectTransform>();
            roleSummaryTextMeshRectTransform.anchoredPosition = new Vector2(position.x + 3.5f, position.y - 0.1f);
            roleSummaryTextMesh.text = roleSummaryText.ToString();
            AdditionalTempData.clear();
        }
    }
}