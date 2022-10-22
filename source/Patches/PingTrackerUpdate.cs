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
                "<color=#00FF00FF>���ǵ�С�� " + TownOfUs.VersionString + "</color>\n" +
                "<size=80%>����:<color=#FF0000>�ĸ�����������</color></size>\n" +
                "<size=80%>amonguscn.club</size>\n" +
                "<size=80%>��������/�޸�/��ɫ:<color=#FF0000>sand</color></size>\n" +
                $"�ӳ�: {AmongUsClient.Instance.Ping}����\n" +
                "����:<color=#00FFFF>����LX</color>��<color=#1a75ff>�������ս</color>\n" +
                (!MeetingHud.Instance
                    ? "Mod����: <color=#00FF00FF>Donners��Term��-H �� MyDragonBreath</color>\n" : "") +
                (AmongUsClient.Instance.GameState != InnerNet.InnerNetClient.GameStates.Started
                    ? "Modǰ����: <color=#00FF00FF>Slushiegoose �� Polus.gg</color>" : "");
        }
    }
}
