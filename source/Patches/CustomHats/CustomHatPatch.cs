using System;
using System.Collections.Generic;
using System.Linq;
using AmongUs.Data;
using HarmonyLib;
using Reactor;
using Reactor.Extensions;
using TMPro;
using UnityEngine;
using Object = UnityEngine.Object;

namespace TownOfUs.Patches.CustomHats
{
    [HarmonyPatch(typeof(HatsTab), nameof(HatsTab.OnEnable))]
    public static class HatsTab_OnEnable
    {
        public static bool Prefix(HatsTab __instance)
        {    
            var allHats = DestroyableSingleton<HatManager>.Instance.GetUnlockedHats();
            var hatGroups = new SortedList<string, List<HatData>>(
                new PaddedComparer<string>("Vanilla", "")
            );
            foreach (var hat in allHats)
            {
                if (!hatGroups.ContainsKey(hat.StoreName))
                    hatGroups[hat.StoreName] = new List<HatData>();
                hatGroups[hat.StoreName].Add(hat);
            }

            foreach (ColorChip instanceColorChip in __instance.ColorChips)
                instanceColorChip.gameObject.Destroy();
            __instance.ColorChips.Clear();
            var groupNameText = __instance.GetComponentInChildren<TextMeshPro>(false);
            int hatIdx = 0;
            foreach ((string groupName, List<HatData> hats) in hatGroups)
            {
                var text = Object.Instantiate(groupNameText, __instance.scroller.Inner);
                text.gameObject.transform.localScale = Vector3.one;
                text.GetComponent<TextTranslatorTMP>().Destroy();
                text.text = groupName;
                text.alignment = TextAlignmentOptions.Center;
                text.fontSize = 3f;
                text.fontSizeMax = 3f;
                text.fontSizeMin = 0f;

                hatIdx = (hatIdx + 4) / 5 * 5;

                float xLerp = __instance.XRange.Lerp(0.5f);
                float yLerp = __instance.YStart - (hatIdx / __instance.NumPerRow) * __instance.YOffset;
                text.transform.localPosition = new Vector3(xLerp, yLerp, -1f);
                hatIdx += 5;
                foreach (var hat in hats.OrderBy(HatManager.Instance.allHats.IndexOf))
                {
                    float num = __instance.XRange.Lerp(hatIdx % __instance.NumPerRow / (__instance.NumPerRow - 1f));
                    float num2 = __instance.YStart - hatIdx / __instance.NumPerRow * __instance.YOffset;
                    ColorChip colorChip = Object.Instantiate(__instance.ColorTabPrefab, __instance.scroller.Inner);
                    colorChip.transform.localPosition = new Vector3(num, num2, -1f);
                    colorChip.Button.OnMouseOver.AddListener((Action)(() => __instance.SelectHat(hat)));
                    colorChip.Button.OnMouseOut.AddListener((Action)(() => { 
                        __instance.SelectHat(DestroyableSingleton<HatManager>.Instance.GetHatById(DataManager.Player.Customization.Hat));
                        //__instance.currentHatIsEquipped = true;
                        }));
                    colorChip.Button.OnClick.AddListener((Action)(() => __instance.ClickEquip()));
                    colorChip.Inner.SetHat(hat, __instance.HasLocalPlayer() ? PlayerControl.LocalPlayer.Data.DefaultOutfit.ColorId : DataManager.Player.Customization.colorID);
                    colorChip.Inner.transform.localPosition = hat.ChipOffset + new Vector2(0f, -0.3f);
                    if (SubmergedCompatibility.Loaded)
                    {
                        colorChip.gameObject.transform.Find("HatParent").transform.localPosition = new Vector3(-0.1f, 0.05f, -2);
                    }
                    colorChip.Tag = hat;
                    __instance.ColorChips.Add(colorChip);
                    hatIdx += 1;
                }

            }

            __instance.scroller.ContentYBounds.max = -(__instance.YStart - (hatIdx + 1) / __instance.NumPerRow * __instance.YOffset) - 3f;

            __instance.currentHat = DestroyableSingleton<HatManager>.Instance.GetHatById(DataManager.Player.Customization.Hat);
            __instance.currentHatIsEquipped = true;

            //Hat name update workaround
            __instance.SelectHat(DestroyableSingleton<HatManager>.Instance.AllHats[0]);
            __instance.SelectHat(DestroyableSingleton<HatManager>.Instance.AllHats[1]);
            __instance.SelectHat(DestroyableSingleton<HatManager>.Instance.AllHats[0]);
            __instance.SelectHat(DestroyableSingleton<HatManager>.Instance.GetHatById(DataManager.Player.Customization.Hat));
            return false;
        }
    }
}
