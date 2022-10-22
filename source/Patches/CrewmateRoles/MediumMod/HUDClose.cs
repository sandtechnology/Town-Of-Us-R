using System;
using HarmonyLib;
using TownOfUs.Roles;
using Object = UnityEngine.Object;
using TownOfUs.Extensions;

namespace TownOfUs.CrewmateRoles.MediumMod
{
    [HarmonyPatch(typeof(Object), nameof(Object.Destroy), typeof(Object))]
    public static class HUDClose
    {
        public static void Postfix(Object obj)
        {
            if (ExileController.Instance == null || obj != ExileController.Instance.gameObject) return;
            foreach (var role in Role.GetRoles(RoleEnum.�л�ʦ))
            {
                var medium = (Medium) role;
                medium.LastMediated = DateTime.UtcNow;
                medium.MediatedPlayers.Values.DestroyAll();
                medium.MediatedPlayers.Clear();
            }
        }
    }
}