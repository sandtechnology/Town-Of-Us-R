using System.Linq;
using HarmonyLib;
using TownOfUs.Extensions;
using TownOfUs.Roles;
using UnityEngine;

namespace TownOfUs.NeutralRoles.ArsonistMod
{
    [HarmonyPatch(typeof(EndGameManager), nameof(EndGameManager.Start))]
    public class Outro
    {
        public static void Postfix(EndGameManager __instance)
        {
            if (Role.GetRoles(RoleEnum.Ð¡³ó).Any(x => ((Jester)x).VotedOut)) return;
            if (Role.GetRoles(RoleEnum.ÐÐÐÌÕß).Any(x => ((Executioner)x).TargetVotedOut)) return;
            var role = Role.AllRoles.FirstOrDefault(x =>
                x.RoleType == RoleEnum.×Ý»ð¿ñ && ((Arsonist) x).ArsonistWins);
            if (role == null) return;
            PoolablePlayer[] array = Object.FindObjectsOfType<PoolablePlayer>();
            foreach (var player in array) player.NameText().text = role.ColorString + player.NameText().text + "</color>";
            __instance.BackgroundBar.material.color = role.Color;
            var text = Object.Instantiate(__instance.WinText);
            text.text = "×Ý»ð¿ñ»ñÊ¤!";
            text.color = role.Color;
            var pos = __instance.WinText.transform.localPosition;
            pos.y = 1.5f;
            text.transform.position = pos;
            text.text = $"<size=4>{text.text}</size>";
        }
    }
}