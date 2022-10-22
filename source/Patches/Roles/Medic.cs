using System.Collections.Generic;
using UnityEngine;

namespace TownOfUs.Roles
{
    public class Medic : Role
    {
        public readonly List<GameObject> Buttons = new List<GameObject>();
        public Dictionary<int, string> LightDarkColors = new Dictionary<int, string>();
        public Medic(PlayerControl player) : base(player)
        {
            Name = "��ҽ";
            ImpostorText = () => "���������ε���һ������";
            TaskText = () => "ͨ��������������Ա";
            Color = Patches.Colors.Medic;
            RoleType = RoleEnum.��ҽ;
            AddToRoleHistory(RoleType);
            ShieldedPlayer = null;

            LightDarkColors.Add(0, "��"); //Red
            LightDarkColors.Add(1, "��"); //Blue
            LightDarkColors.Add(2, "��"); //Green
            LightDarkColors.Add(3, "ǳ"); //Pink
            LightDarkColors.Add(4, "ǳ"); //Orange
            LightDarkColors.Add(5, "ǳ"); //Yellow
            LightDarkColors.Add(6, "��"); //Black
            LightDarkColors.Add(7, "ǳ"); //White
            LightDarkColors.Add(8, "��"); //Purple
            LightDarkColors.Add(9, "��"); //Brown
            LightDarkColors.Add(10, "ǳ"); //Cyan
            LightDarkColors.Add(11, "ǳ"); //Lime
            LightDarkColors.Add(12, "��"); //Maroon
            LightDarkColors.Add(13, "ǳ"); //Rose
            LightDarkColors.Add(14, "ǳ"); //Banana
            LightDarkColors.Add(15, "��"); //Grey
            LightDarkColors.Add(16, "��"); //Tan
            LightDarkColors.Add(17, "ǳ"); //Coral
            LightDarkColors.Add(18, "��"); //Watermelon
            LightDarkColors.Add(19, "��"); //Chocolate
            LightDarkColors.Add(20, "ǳ"); //Sky Blue
            LightDarkColors.Add(21, "��"); //Biege
            LightDarkColors.Add(22, "ǳ"); //Hot Pink
            LightDarkColors.Add(23, "ǳ"); //Turquoise
            LightDarkColors.Add(24, "ǳ"); //Lilac
            LightDarkColors.Add(25, "��"); //Olive
            LightDarkColors.Add(26, "ǳ"); //Azure
            LightDarkColors.Add(27, "ǳ"); //Rainbow
        }

        public PlayerControl ClosestPlayer;
        public bool UsedAbility { get; set; } = false;
        public PlayerControl ShieldedPlayer { get; set; }
        public PlayerControl exShielded { get; set; }
    }
}