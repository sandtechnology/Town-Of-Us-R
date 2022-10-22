using HarmonyLib;
using UnityEngine;

namespace TownOfUs
{
    //[HarmonyPriority(Priority.VeryHigh)] // to show this message first, or be overrided if any plugins do
    [HarmonyPatch(typeof(PingTracker), nameof(PingTracker.Update))]
    public static class PingTracker_Update
    {

        [HarmonyPostfix]
        public static void Postfix(PingTracker __instance)
        {
            var position = __instance.GetComponent<AspectPosition>();
            position.DistanceFromEdge = new Vector3(3.6f, 0.1f, 0);
            position.AdjustPosition();

            __instance.text.text =
                "<color=#00FF00FF>我们的小镇 " + TownOfUs.VersionString + "</color>\n" +
                "<size=80%>汉化:<color=#FF0000>四个憨批汉化组</color></size>\n" +
                "<size=80%>amonguscn.club</size>\n" +
                "<size=80%>后续适配/修复/润色:<color=#FF0000>sand</color></size>\n" +
                $"延迟: {AmongUsClient.Instance.Ping}毫秒\n" +
                "翻译:<color=#00FFFF>凌霄LX</color>、<color=#1a75ff>兰博玩对战</color>\n" +
                (!MeetingHud.Instance
                    ? "Mod作者: <color=#00FF00FF>Donners、Term、-H 和 MyDragonBreath</color>\n" : "") +
                (AmongUsClient.Instance.GameState != InnerNet.InnerNetClient.GameStates.Started
                    ? "Mod前作者: <color=#00FF00FF>Slushiegoose 和 Polus.gg</color>" : "");
        }
    }
}
