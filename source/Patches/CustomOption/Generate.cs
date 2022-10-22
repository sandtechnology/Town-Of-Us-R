using System;

namespace TownOfUs.CustomOption
{
    public class Generate
    {
        public static CustomHeaderOption CrewInvestigativeRoles;
        public static CustomNumberOption DetectiveOn;
        public static CustomNumberOption HaunterOn;
        public static CustomNumberOption InvestigatorOn;
        public static CustomNumberOption MysticOn;
        public static CustomNumberOption SeerOn;
        public static CustomNumberOption SnitchOn;
        public static CustomNumberOption SpyOn;
        public static CustomNumberOption TrackerOn;
        public static CustomNumberOption TrapperOn;

        public static CustomHeaderOption CrewProtectiveRoles;
        public static CustomNumberOption AltruistOn;
        public static CustomNumberOption MedicOn;

        public static CustomHeaderOption CrewKillingRoles;
        public static CustomNumberOption SheriffOn;
        public static CustomNumberOption VeteranOn;
        public static CustomNumberOption VigilanteOn;

        public static CustomHeaderOption CrewSupportRoles;
        public static CustomNumberOption EngineerOn;
        public static CustomNumberOption MayorOn;
        public static CustomNumberOption MediumOn;
        public static CustomNumberOption SwapperOn;
        public static CustomNumberOption TimeLordOn;
        public static CustomNumberOption TransporterOn;

        public static CustomHeaderOption NeutralBenignRoles;
        public static CustomNumberOption AmnesiacOn;
        public static CustomNumberOption GuardianAngelOn;
        public static CustomNumberOption SurvivorOn;

        public static CustomHeaderOption NeutralEvilRoles;
        public static CustomNumberOption ExecutionerOn;
        public static CustomNumberOption JesterOn;
        public static CustomNumberOption PhantomOn;

        public static CustomHeaderOption NeutralKillingRoles;
        public static CustomNumberOption ArsonistOn;
        public static CustomNumberOption PlaguebearerOn;
        public static CustomNumberOption GlitchOn;
        public static CustomNumberOption WerewolfOn;

        public static CustomHeaderOption ImpostorConcealingRoles;
        public static CustomNumberOption MorphlingOn;
        public static CustomNumberOption SwooperOn;
        public static CustomNumberOption GrenadierOn;

        public static CustomHeaderOption ImpostorKillingRoles;
        public static CustomNumberOption PoisonerOn;
        public static CustomNumberOption TraitorOn;
        public static CustomNumberOption UnderdogOn;

        public static CustomHeaderOption ImpostorSupportRoles;
        public static CustomNumberOption BlackmailerOn;
        public static CustomNumberOption JanitorOn;
        public static CustomNumberOption MinerOn;
        public static CustomNumberOption UndertakerOn;

        public static CustomHeaderOption CrewmateModifiers;
        public static CustomNumberOption BaitOn;
        public static CustomNumberOption DiseasedOn;
        public static CustomNumberOption TorchOn;

        public static CustomHeaderOption GlobalModifiers;
        public static CustomNumberOption BlindOn;
        public static CustomNumberOption ButtonBarryOn;
        public static CustomNumberOption FlashOn;
        public static CustomNumberOption GiantOn;
        public static CustomNumberOption LoversOn;
        public static CustomNumberOption SleuthOn;
        public static CustomNumberOption TiebreakerOn;

        public static CustomHeaderOption MapSettings;
        public static CustomToggleOption RandomMapEnabled;
        public static CustomNumberOption RandomMapSkeld;
        public static CustomNumberOption RandomMapMira;
        public static CustomNumberOption RandomMapPolus;
        public static CustomNumberOption RandomMapAirship;
        public static CustomNumberOption RandomMapSubmerged;
        public static CustomToggleOption AutoAdjustSettings;
        public static CustomToggleOption SmallMapHalfVision;
        public static CustomNumberOption SmallMapDecreasedCooldown;
        public static CustomNumberOption LargeMapIncreasedCooldown;
        public static CustomNumberOption SmallMapIncreasedShortTasks;
        public static CustomNumberOption SmallMapIncreasedLongTasks;
        public static CustomNumberOption LargeMapDecreasedShortTasks;
        public static CustomNumberOption LargeMapDecreasedLongTasks;

        public static CustomHeaderOption CustomGameSettings;
        public static CustomToggleOption ColourblindComms;
        public static CustomToggleOption ImpostorSeeRoles;
        public static CustomToggleOption DeadSeeRoles;
        public static CustomToggleOption DisableLevels;
        public static CustomToggleOption WhiteNameplates;
        public static CustomNumberOption VanillaGame;
        public static CustomNumberOption InitialCooldowns;
        public static CustomToggleOption ParallelMedScans;
        public static CustomStringOption SkipButtonDisable;

        public static CustomHeaderOption BetterPolusSettings;
        public static CustomToggleOption VentImprovements;
        public static CustomToggleOption VitalsLab;
        public static CustomToggleOption ColdTempDeathValley;
        public static CustomToggleOption WifiChartCourseSwap;

        public static CustomHeaderOption GameModeSettings;
        public static CustomStringOption GameMode;

        public static CustomHeaderOption ClassicSettings;
        public static CustomNumberOption MinNeutralNonKillingRoles;
        public static CustomNumberOption MaxNeutralNonKillingRoles;
        public static CustomNumberOption MinNeutralKillingRoles;
        public static CustomNumberOption MaxNeutralKillingRoles;

        public static CustomHeaderOption AllAnySettings;
        public static CustomToggleOption RandomNumberImps;

        public static CustomHeaderOption KillingOnlySettings;
        public static CustomNumberOption NeutralRoles;
        public static CustomNumberOption VeteranCount;
        public static CustomNumberOption VigilanteCount;
        public static CustomToggleOption AddArsonist;
        public static CustomToggleOption AddPlaguebearer;

        public static CustomHeaderOption TaskTrackingSettings;
        public static CustomToggleOption SeeTasksDuringRound;
        public static CustomToggleOption SeeTasksDuringMeeting;
        public static CustomToggleOption SeeTasksWhenDead;

        public static CustomHeaderOption Mayor;
        public static CustomNumberOption MayorVoteBank;
        public static CustomToggleOption MayorAnonymous;

        public static CustomHeaderOption Sheriff;
        public static CustomToggleOption SheriffKillOther;
        public static CustomToggleOption SheriffKillsJester;
        public static CustomToggleOption SheriffKillsGlitch;
        public static CustomToggleOption SheriffKillsExecutioner;
        public static CustomToggleOption SheriffKillsArsonist;
        public static CustomToggleOption SheriffKillsWerewolf;
        public static CustomToggleOption SheriffKillsPlaguebearer;
        public static CustomNumberOption SheriffKillCd;
        public static CustomToggleOption SheriffBodyReport;


        public static CustomHeaderOption Engineer;
        public static CustomStringOption EngineerPer;

        public static CustomHeaderOption Investigator;
        public static CustomNumberOption FootprintSize;
        public static CustomNumberOption FootprintInterval;
        public static CustomNumberOption FootprintDuration;
        public static CustomToggleOption AnonymousFootPrint;
        public static CustomToggleOption VentFootprintVisible;

        public static CustomHeaderOption TimeLord;
        public static CustomToggleOption RewindRevive;
        public static CustomNumberOption RewindDuration;
        public static CustomNumberOption RewindCooldown;
        public static CustomNumberOption RewindMaxUses;
        public static CustomToggleOption TimeLordVitals;

        public static CustomHeaderOption Medic;
        public static CustomStringOption ShowShielded;
        public static CustomStringOption WhoGetsNotification;
        public static CustomToggleOption ShieldBreaks;
        public static CustomToggleOption MedicReportSwitch;
        public static CustomNumberOption MedicReportNameDuration;
        public static CustomNumberOption MedicReportColorDuration;

        public static CustomHeaderOption Seer;
        public static CustomNumberOption SeerCooldown;
        public static CustomToggleOption CrewKillingRed;
        public static CustomToggleOption NeutBenignRed;
        public static CustomToggleOption NeutEvilRed;
        public static CustomToggleOption NeutKillingRed;
        public static CustomToggleOption TraitorColourSwap;

        public static CustomHeaderOption Swapper;
        public static CustomToggleOption SwapperButton;

        public static CustomHeaderOption Transporter;
        public static CustomNumberOption TransportCooldown;
        public static CustomNumberOption TransportMaxUses;
        public static CustomToggleOption TransporterVitals;

        public static CustomHeaderOption Jester;
        public static CustomToggleOption JesterButton;
        public static CustomToggleOption JesterVent;

        public static CustomHeaderOption TheGlitch;
        public static CustomNumberOption MimicCooldownOption;
        public static CustomNumberOption MimicDurationOption;
        public static CustomNumberOption HackCooldownOption;
        public static CustomNumberOption HackDurationOption;
        public static CustomNumberOption GlitchKillCooldownOption;
        public static CustomStringOption GlitchHackDistanceOption;
        public static CustomToggleOption GlitchVent;

        public static CustomHeaderOption Morphling;
        public static CustomNumberOption MorphlingCooldown;
        public static CustomNumberOption MorphlingDuration;
        public static CustomToggleOption MorphlingVent;

        public static CustomHeaderOption Executioner;
        public static CustomStringOption OnTargetDead;
        public static CustomToggleOption ExecutionerButton;

        public static CustomHeaderOption Phantom;
        public static CustomNumberOption PhantomTasksRemaining;

        public static CustomHeaderOption Snitch;
        public static CustomToggleOption SnitchOnLaunch;
        public static CustomToggleOption SnitchSeesNeutrals;
        public static CustomNumberOption SnitchTasksRemaining;
        public static CustomToggleOption SnitchSeesImpInMeeting;
        public static CustomToggleOption SnitchSeesTraitor;

        public static CustomHeaderOption Altruist;
        public static CustomNumberOption ReviveDuration;
        public static CustomToggleOption AltruistTargetBody;

        public static CustomHeaderOption Miner;
        public static CustomNumberOption MineCooldown;

        public static CustomHeaderOption Swooper;
        public static CustomNumberOption SwoopCooldown;
        public static CustomNumberOption SwoopDuration;
        public static CustomToggleOption SwooperVent;

        public static CustomHeaderOption Arsonist;
        public static CustomNumberOption DouseCooldown;
        public static CustomNumberOption MaxDoused;

        public static CustomHeaderOption Undertaker;
        public static CustomNumberOption DragCooldown;
        public static CustomToggleOption UndertakerVent;
        public static CustomToggleOption UndertakerVentWithBody;

        public static CustomHeaderOption Assassin;
        public static CustomNumberOption NumberOfImpostorAssassins;
        public static CustomNumberOption NumberOfNeutralAssassins;
        public static CustomToggleOption AmneTurnImpAssassin;
        public static CustomToggleOption AmneTurnNeutAssassin;
        public static CustomToggleOption TraitorCanAssassin;
        public static CustomNumberOption AssassinKills;
        public static CustomToggleOption AssassinMultiKill;
        public static CustomToggleOption AssassinCrewmateGuess;
        public static CustomToggleOption AssassinSnitchViaCrewmate;
        public static CustomToggleOption AssassinGuessNeutralBenign;
        public static CustomToggleOption AssassinGuessNeutralEvil;
        public static CustomToggleOption AssassinGuessNeutralKilling;
        public static CustomToggleOption AssassinGuessImpostors;
        public static CustomToggleOption AssassinGuessModifiers;
        public static CustomToggleOption AssassinGuessLovers;
        public static CustomToggleOption AssassinateAfterVoting;

        public static CustomHeaderOption Underdog;
        public static CustomNumberOption UnderdogKillBonus;
        public static CustomToggleOption UnderdogIncreasedKC;

        public static CustomHeaderOption Vigilante;
        public static CustomNumberOption VigilanteKills;
        public static CustomToggleOption VigilanteMultiKill;
        public static CustomToggleOption VigilanteGuessNeutralBenign;
        public static CustomToggleOption VigilanteGuessNeutralEvil;
        public static CustomToggleOption VigilanteGuessNeutralKilling;
        public static CustomToggleOption VigilanteGuessLovers;
        public static CustomToggleOption VigilanteAfterVoting;

        public static CustomHeaderOption Haunter;
        public static CustomNumberOption HaunterTasksRemainingClicked;
        public static CustomNumberOption HaunterTasksRemainingAlert;
        public static CustomToggleOption HaunterRevealsNeutrals;
        public static CustomStringOption HaunterCanBeClickedBy;

        public static CustomHeaderOption Grenadier;
        public static CustomNumberOption GrenadeCooldown;
        public static CustomNumberOption GrenadeDuration;
        public static CustomToggleOption GrenadierIndicators;
        public static CustomToggleOption GrenadierVent;
        public static CustomNumberOption FlashRadius;

        public static CustomHeaderOption Veteran;
        public static CustomToggleOption KilledOnAlert;
        public static CustomNumberOption AlertCooldown;
        public static CustomNumberOption AlertDuration;
        public static CustomNumberOption MaxAlerts;

        public static CustomHeaderOption Tracker;
        public static CustomNumberOption UpdateInterval;
        public static CustomNumberOption TrackCooldown;
        public static CustomToggleOption ResetOnNewRound;
        public static CustomNumberOption MaxTracks;

        public static CustomHeaderOption Trapper;
        public static CustomNumberOption TrapCooldown;
        public static CustomToggleOption TrapsRemoveOnNewRound;
        public static CustomNumberOption MaxTraps;
        public static CustomNumberOption MinAmountOfTimeInTrap;
        public static CustomNumberOption TrapSize;
        public static CustomNumberOption MinAmountOfPlayersInTrap;

        public static CustomHeaderOption Poisoner;
        public static CustomNumberOption PoisonCooldown;
        public static CustomNumberOption PoisonDuration;
        public static CustomToggleOption PoisonerVent;

        public static CustomHeaderOption Traitor;
        public static CustomNumberOption LatestSpawn;
        public static CustomToggleOption NeutralKillingStopsTraitor;

        public static CustomHeaderOption Amnesiac;
        public static CustomToggleOption RememberArrows;
        public static CustomNumberOption RememberArrowDelay;

        public static CustomHeaderOption Medium;
        public static CustomNumberOption MediateCooldown;
        public static CustomToggleOption ShowMediatePlayer;
        public static CustomToggleOption ShowMediumToDead;
        public static CustomStringOption DeadRevealed;

        public static CustomHeaderOption Survivor;
        public static CustomNumberOption VestCd;
        public static CustomNumberOption VestDuration;
        public static CustomNumberOption VestKCReset;
        public static CustomNumberOption MaxVests;

        public static CustomHeaderOption GuardianAngel;
        public static CustomNumberOption ProtectCd;
        public static CustomNumberOption ProtectDuration;
        public static CustomNumberOption ProtectKCReset;
        public static CustomNumberOption MaxProtects;
        public static CustomStringOption ShowProtect;
        public static CustomStringOption GaOnTargetDeath;
        public static CustomToggleOption GATargetKnows;
        public static CustomToggleOption GAKnowsTargetRole;

        public static CustomHeaderOption Mystic;
        public static CustomNumberOption MysticArrowDuration;

        public static CustomHeaderOption Blackmailer;
        public static CustomNumberOption BlackmailCooldown;

        public static CustomHeaderOption Plaguebearer;
        public static CustomNumberOption InfectCooldown;
        public static CustomNumberOption PestKillCooldown;
        public static CustomToggleOption PestVent;

        public static CustomHeaderOption Werewolf;
        public static CustomNumberOption RampageCooldown;
        public static CustomNumberOption RampageDuration;
        public static CustomNumberOption RampageKillCooldown;
        public static CustomToggleOption WerewolfVent;

        public static CustomHeaderOption Detective;
        public static CustomNumberOption InitialExamineCooldown;
        public static CustomNumberOption ExamineCooldown;
        public static CustomNumberOption RecentKill;
        public static CustomToggleOption DetectiveReportOn;
        public static CustomNumberOption DetectiveRoleDuration;
        public static CustomNumberOption DetectiveFactionDuration;

        public static CustomHeaderOption Giant;
        public static CustomNumberOption GiantSlow;

        public static CustomHeaderOption Flash;
        public static CustomNumberOption FlashSpeed;

        public static CustomHeaderOption Diseased;
        public static CustomNumberOption DiseasedKillMultiplier;

        public static CustomHeaderOption Bait;
        public static CustomNumberOption BaitMinDelay;
        public static CustomNumberOption BaitMaxDelay;

        public static CustomHeaderOption Lovers;
        public static CustomToggleOption BothLoversDie;
        public static CustomNumberOption LovingImpPercent;
        public static CustomToggleOption NeutralLovers;

        public static Func<object, string> PercentFormat { get; } = value => $"{value:0}%";
        private static Func<object, string> CooldownFormat { get; } = value => $"{value:0.0#}��";
        private static Func<object, string> MultiplierFormat { get; } = value => $"{value:0.0#}��";


        public static void GenerateAll()
        {
            var num = 0;

            Patches.ExportButton = new Export(num++);
            Patches.ImportButton = new Import(num++);


            CrewInvestigativeRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "��Ա �� �鱨��");
            DetectiveOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#4D4DFFFF>��дʦ</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            HaunterOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#D3D3D3FF>ԩ��</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            InvestigatorOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#00B3B3FF>����Ա</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MysticOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#4D99E6FF>��ý</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SeerOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#FFCC80FF>Ԥ�Լ�</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SnitchOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#D4AF37FF>������</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SpyOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#CCA3CCFF>�ع�</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TrackerOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#009900FF>׷����</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TrapperOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#A7D1B3FF>����ʦ</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewKillingRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "��Ա �� ��ɱ��");
            SheriffOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#FFFF00FF>����</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            VeteranOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#998040FF>�ϱ�</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            VigilanteOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#FFFF99FF>����</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewProtectiveRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "��Ա �� ������");
            AltruistOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#660000FF>ѳ����</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MedicOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#006600FF>��ҽ</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewSupportRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "��Ա �� ������");
            EngineerOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#FFA60AFF>����ʦ</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MayorOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#704FA8FF>�г�</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MediumOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#A680FFFF>�л�ʦ</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SwapperOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#66E666FF>��Ʊʦ</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TimeLordOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#0000FFFF>ʱ������</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TransporterOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#00EEFFFF>����ʦ</color>", 0f, 0f, 100f, 10f,
                PercentFormat);


            NeutralBenignRoles = new CustomHeaderOption(num++, MultiMenu.neutral, "������Ӫ �� ����");
            AmnesiacOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#80B2FFFF>ʧ����</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GuardianAngelOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#B3FFFFFF>�ػ���ʹ</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SurvivorOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#FFE64DFF>�Ҵ���</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            NeutralEvilRoles = new CustomHeaderOption(num++, MultiMenu.neutral, "������Ӫ �� ɱ��");
            ExecutionerOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#8C4005FF>������</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            JesterOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#FFBFCCFF>С��</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            PhantomOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#662962FF>��Ӱ</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            NeutralKillingRoles = new CustomHeaderOption(num++, MultiMenu.neutral, "������Ӫ �� ɱ��");
            ArsonistOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#FF4D00FF>�ݻ��</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            PlaguebearerOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#E6FFB3FF>����֮Դ</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GlitchOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#00FF00FF>����</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            WerewolfOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#A86629FF>��������</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorConcealingRoles = new CustomHeaderOption(num++, MultiMenu.imposter, "αװ�� �� ������");
            GrenadierOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>������</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MorphlingOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>������</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SwooperOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>������</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorKillingRoles = new CustomHeaderOption(num++, MultiMenu.imposter, "αװ�� �� ��ɱ��");
            PoisonerOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>������ʦ</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TraitorOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>������</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            UnderdogOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>Ǳ����</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorSupportRoles = new CustomHeaderOption(num++, MultiMenu.imposter, "αװ�� �� ������");
            BlackmailerOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>������</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            JanitorOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>������</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MinerOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>�ܵ���</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            UndertakerOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>������</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewmateModifiers = new CustomHeaderOption(num++, MultiMenu.modifiers, "��Ա �� ����ְҵ");
            BaitOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#00B3B3FF>�ն�</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            DiseasedOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#808080FF>����</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TorchOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FFFF99FF>���</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            GlobalModifiers = new CustomHeaderOption(num++, MultiMenu.modifiers, "ȫ�� �� ����ְҵ");
            BlindOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#AAAAAAFF>��С��</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            ButtonBarryOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#E600FFFF>ִť��</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            FlashOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FF8080FF>������</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GiantOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FFB34DFF>����</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            LoversOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FF66CCFF>����</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SleuthOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#803333FF>��Ĺ��</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TiebreakerOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#99E699FF>��ƽ��</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            GameModeSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "�Զ�����Ϸ����");
            GameMode = new CustomStringOption(num++, MultiMenu.main, "��Ϸģʽ", new[] { "����", "ȫ�����", "����ɱ" });

            ClassicSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "����ģʽ����");
            MinNeutralNonKillingRoles =
                new CustomNumberOption(num++, MultiMenu.main, "���ٶ�����Ӫ�޻�ɱ����ְҵ����", 1f, 0f, 5f, 1f);
            MaxNeutralNonKillingRoles =
                new CustomNumberOption(num++, MultiMenu.main, "��������Ӫ�޻�ɱ����ְҵ����", 1f, 0f, 5f, 1f);
            MinNeutralKillingRoles =
                new CustomNumberOption(num++, MultiMenu.main, "���ٶ�����Ӫ����ɱ����ְҵ����", 1f, 0f, 4f, 1f);
            MaxNeutralKillingRoles =
                new CustomNumberOption(num++, MultiMenu.main, "��������Ӫ����ɱ����ְҵ����", 1f, 0f, 4f, 1f);

            AllAnySettings =
                new CustomHeaderOption(num++, MultiMenu.main, "ȫ�����ģʽ����");
            RandomNumberImps = new CustomToggleOption(num++, MultiMenu.main, "���αװ������", true);

            KillingOnlySettings =
                new CustomHeaderOption(num++, MultiMenu.main, "����ɱģʽ����");
            NeutralRoles =
                new CustomNumberOption(num++, MultiMenu.main, "������Ӫ", 1f, 0f, 5f, 1f);
            VeteranCount =
                new CustomNumberOption(num++, MultiMenu.main, "�ϱ�����", 1f, 0f, 5f, 1f);
            VigilanteCount =
                new CustomNumberOption(num++, MultiMenu.main, "��������", 1f, 0f, 5f, 1f);
            AddArsonist = new CustomToggleOption(num++, MultiMenu.main, "��� �ݻ��", true);
            AddPlaguebearer = new CustomToggleOption(num++, MultiMenu.main, "��� ����֮Դ", true);

            MapSettings = new CustomHeaderOption(num++, MultiMenu.main, "��ͼ����");
            RandomMapEnabled = new CustomToggleOption(num++, MultiMenu.main, "�����ͼ", false);
            RandomMapSkeld = new CustomNumberOption(num++, MultiMenu.main, "���ý� ����", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapMira = new CustomNumberOption(num++, MultiMenu.main, "�����ܲ� ����", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapPolus = new CustomNumberOption(num++, MultiMenu.main, "��³˹ ����", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapAirship = new CustomNumberOption(num++, MultiMenu.main, "��ͧ ����", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapSubmerged = new CustomNumberOption(num++, MultiMenu.main, "Ǳˮͧ ����", 0f, 0f, 100f, 10f, PercentFormat);
            AutoAdjustSettings = new CustomToggleOption(num++, MultiMenu.main, "�Զ���������", false);
            SmallMapHalfVision = new CustomToggleOption(num++, MultiMenu.main, "���ý��������ܲ���Ұ����", false);
            SmallMapDecreasedCooldown =
                new CustomNumberOption(num++, MultiMenu.main, "�����ܲ���ȴʱ�����", 0f, 0f, 15f, 2.5f, CooldownFormat);
            LargeMapIncreasedCooldown =
                new CustomNumberOption(num++, MultiMenu.main, "��ͧ��Ǳˮͧ��ȴʱ������", 0f, 0f, 15f, 2.5f, CooldownFormat);
            SmallMapIncreasedShortTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "���ý��������ܲ�����������", 0, 0, 5, 1);
            SmallMapIncreasedLongTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "���ý��������ܲ�����������", 0, 0, 3, 1);
            LargeMapDecreasedShortTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "��ͧ��Ǳˮͧ���������", 0, 0, 5, 1);
            LargeMapDecreasedLongTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "��ͧ��Ǳˮͧ���������", 0, 0, 3, 1);

            BetterPolusSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "��³˹�Ż�����");
            VentImprovements = new CustomToggleOption(num++, MultiMenu.main, "�Ż���³˹ͨ��ڷֲ�", false);
            VitalsLab = new CustomToggleOption(num++, MultiMenu.main, "�������װ��ת�Ƶ�ʵ����", false);
            ColdTempDeathValley = new CustomToggleOption(num++, MultiMenu.main, "�¶ȵ���װ��(����)�ƶ����ⲿ", false);
            WifiChartCourseSwap =
                new CustomToggleOption(num++, MultiMenu.main, "����WIFI�뵼��λ�ý���", false);

            CustomGameSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "�Զ�����Ϸ����");
            ColourblindComms = new CustomToggleOption(num++, MultiMenu.main, "ͨѶ�ƻ�ʱ��������Ч��", false);
            ImpostorSeeRoles = new CustomToggleOption(num++, MultiMenu.main, "αװ�߿ɼ�����ְҵ", false);
            DeadSeeRoles =
                new CustomToggleOption(num++, MultiMenu.main, "�����Կ�����ҵ�ְҵ/ͶƱ", false);
            VanillaGame = new CustomNumberOption(num++, MultiMenu.main, "�������ԭ����Ϸ�ĸ���", 0f, 0f, 100f, 5f,
                PercentFormat);
            InitialCooldowns =
                new CustomNumberOption(num++, MultiMenu.main, "��Ϸ������ȴʱ��", 10, 10, 30, 2.5f, CooldownFormat);
            ParallelMedScans = new CustomToggleOption(num++, MultiMenu.main, "��ͬʱ����ɨ������ȡ����ˮ����Ч����", false);
            SkipButtonDisable = new CustomStringOption(num++, MultiMenu.main, "�����������鰴ť", new[] { "�ر�", "����������", "����" });
            DisableLevels = new CustomToggleOption(num++, MultiMenu.main, "���صȼ�ͼ��", false);
            WhiteNameplates = new CustomToggleOption(num++, MultiMenu.main, "�����������װ��", false);

            TaskTrackingSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "����׷������");
            SeeTasksDuringRound = new CustomToggleOption(num++, MultiMenu.main, "�Ծ�����ʾ����׷��", false);
            SeeTasksDuringMeeting = new CustomToggleOption(num++, MultiMenu.main, "��������ʾ����׷��", false);
            SeeTasksWhenDead = new CustomToggleOption(num++, MultiMenu.main, "��������ʾ����׷��", true);

            Assassin = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>�̿�����</color>");
            NumberOfImpostorAssassins = new CustomNumberOption(num++, MultiMenu.imposter, "αװ�ߴ̿�����������", 1, 0, 4, 1);
            NumberOfNeutralAssassins = new CustomNumberOption(num++, MultiMenu.imposter, "������Ӫ�̿�����������", 1, 0, 5, 1);
            AmneTurnImpAssassin = new CustomToggleOption(num++, MultiMenu.imposter, "ʧ���߱�Ϊαװ����Ӫʱ��ô̿�����", false);
            AmneTurnNeutAssassin = new CustomToggleOption(num++, MultiMenu.imposter, "ʧ���߱�Ϊɱ���Ͷ�����Ӫʱ��ô̿�����", false);
            TraitorCanAssassin = new CustomToggleOption(num++, MultiMenu.imposter, "�����߿ɻ�ô̿�����", false);
            AssassinKills = new CustomNumberOption(num++, MultiMenu.imposter, "�̿Ϳɲ²����", 1, 1, 15, 1);
            AssassinMultiKill = new CustomToggleOption(num++, MultiMenu.imposter, "�̿Ϳ���һ�λ����ж�β²�", false);
            AssassinCrewmateGuess = new CustomToggleOption(num++, MultiMenu.imposter, "�̿Ϳ�ʹ����ͨ��Աѡ��²�", false);
            AssassinSnitchViaCrewmate = new CustomToggleOption(num++, MultiMenu.imposter, "�̿Ϳ�ʹ����ͨ��Աѡ��²������", false);
            AssassinGuessNeutralBenign = new CustomToggleOption(num++, MultiMenu.imposter, "�̿Ϳɲ²�����������Ӫ", false);
            AssassinGuessNeutralEvil = new CustomToggleOption(num++, MultiMenu.imposter, "�̿Ϳɲ²�а�������Ӫ", false);
            AssassinGuessNeutralKilling = new CustomToggleOption(num++, MultiMenu.imposter, "�̿Ϳɲ²�ɱ�ֶ�����Ӫ", false);
            AssassinGuessImpostors = new CustomToggleOption(num++, MultiMenu.imposter, "�̿Ϳɲ²�αװ��ְҵ", false);
            AssassinGuessModifiers = new CustomToggleOption(num++, MultiMenu.imposter, "�̿Ϳɲ²⴬Ա����ְҵ", false);
            AssassinGuessLovers = new CustomToggleOption(num++, MultiMenu.imposter, "�̿Ϳɲ²�����", false);
            AssassinateAfterVoting = new CustomToggleOption(num++, MultiMenu.imposter, "�̿���ͶƱ����Ȼ���Բ²�", false);

            Detective =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#4D4DFFFF>��дʦ</color>");
            InitialExamineCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "��֤���ּ��ܳ�ʼ��ȴʱ��", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ExamineCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "��֤���ּ�����ȴʱ��", 10f, 1f, 15f, 1f, CooldownFormat);
            RecentKill =
                new CustomNumberOption(num++, MultiMenu.crewmate, "��ҵ�Ѫ������ʱ��", 25f, 10f, 60f, 2.5f, CooldownFormat);
            DetectiveReportOn = new CustomToggleOption(num++, MultiMenu.crewmate, "�ɲ鿴��д����", true);
            DetectiveRoleDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "�����ʱ�� ���� ��д�������ְҵ", 15, 0, 60, 2.5f,
                    CooldownFormat);
            DetectiveFactionDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "�����ʱ�� ���� ��д���������Ӫ", 30, 0, 120, 2.5f,
                    CooldownFormat);

            Haunter =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#d3d3d3FF>ԩ��</color>");
            HaunterTasksRemainingClicked =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "ԩ��ɿ�ʼ�������ʣ��������", 5, 1, 10, 1);
            HaunterTasksRemainingAlert =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "������¶�˷��;�����ʣ��������", 1, 1, 5, 1);
            HaunterRevealsNeutrals = new CustomToggleOption(num++, MultiMenu.crewmate, "ԩ��ɽ�¶������Ӫְҵ", false);
            HaunterCanBeClickedBy = new CustomStringOption(num++, MultiMenu.crewmate, "˭���Ե��ԩ��", new[] { "������", "��Ա����", "��αװ��" });

            Investigator =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#00B3B3FF>����Ա</color>");
            FootprintSize = new CustomNumberOption(num++, MultiMenu.crewmate, "��ӡ�ߴ�", 4f, 1f, 10f, 1f);
            FootprintInterval =
                new CustomNumberOption(num++, MultiMenu.crewmate, "��ӡ���ʱ��", 0.1f, 0.05f, 1f, 0.05f, CooldownFormat);
            FootprintDuration = new CustomNumberOption(num++, MultiMenu.crewmate, "��ӡ����ʱ��", 10f, 1f, 10f, 0.5f, CooldownFormat);
            AnonymousFootPrint = new CustomToggleOption(num++, MultiMenu.crewmate, "������ӡ", false);
            VentFootprintVisible = new CustomToggleOption(num++, MultiMenu.crewmate, "ͨ��ܵ��ɼ���ӡ", false);

            Mystic =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#4D99E6FF>��ý</color>");
            MysticArrowDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "ָ��ʬ���ͷ����ʱ��", 0.1f, 0f, 1f, 0.05f, CooldownFormat);

            Seer =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFCC80FF>Ԥ�Լ�</color>");
            SeerCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Ԥ�Լ�����ȴʱ��", 25f, 10f, 60f, 2.5f, CooldownFormat);
            CrewKillingRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "��ɱ�ʹ�Ա��ʾ����", false);
            NeutBenignRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "����������Ӫ��ʾ����", false);
            NeutEvilRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "а�������Ӫ��ʾ����", false);
            NeutKillingRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "ɱ�ֶ�����Ӫ��ʾ����", false);
            TraitorColourSwap =
                new CustomToggleOption(num++, MultiMenu.crewmate, "�����߲��任��ɫ", false);

            Snitch = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#D4AF37FF>������</color>");
            SnitchOnLaunch =
                new CustomToggleOption(num++, MultiMenu.crewmate, "�����߿��־���ʾ����ְҵ", false);
            SnitchSeesNeutrals = new CustomToggleOption(num++, MultiMenu.crewmate, "�����߿ɿ���������Ӫְҵ", false);
            SnitchTasksRemaining =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "���汻��¶��ʱ��ʣ������", 1, 1, 5, 1);
            SnitchSeesImpInMeeting = new CustomToggleOption(num++, MultiMenu.crewmate, "�������ڻ����пɿ�������¶��ְҵ", true);
            SnitchSeesTraitor = new CustomToggleOption(num++, MultiMenu.crewmate, "�����߿��Կ���������", true);

            Tracker =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#009900FF>׷����</color>");
            UpdateInterval =
                new CustomNumberOption(num++, MultiMenu.crewmate, "׷�ټ�ͷ���¼��", 5f, 0.5f, 15f, 0.5f, CooldownFormat);
            TrackCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "׷����ȴ", 25f, 10f, 40f, 2.5f, CooldownFormat);
            ResetOnNewRound = new CustomToggleOption(num++, MultiMenu.crewmate, "���������׷�ټ�ͷ", false);
            MaxTracks = new CustomNumberOption(num++, MultiMenu.crewmate, "ÿ�����׷������", 5, 1, 15, 1);

            Trapper =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#A7D1B3FF>����ʦ</color>");
            MinAmountOfTimeInTrap =
                new CustomNumberOption(num++, MultiMenu.crewmate, "�������¼������ͣ��ʱ��", 1f, 0f, 15f, 0.5f, CooldownFormat);
            TrapCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "���������ȴ", 25f, 10f, 40f, 2.5f, CooldownFormat);
            TrapsRemoveOnNewRound =
                new CustomToggleOption(num++, MultiMenu.crewmate, "ÿ�ֽ������Ƴ�����", true);
            MaxTraps =
                new CustomNumberOption(num++, MultiMenu.crewmate, "��������������", 5, 1, 15, 1);
            TrapSize =
                new CustomNumberOption(num++, MultiMenu.crewmate, "����ߴ�", 1f, 0.5f, 5f, 0.5f, MultiplierFormat);
            MinAmountOfPlayersInTrap =
                new CustomNumberOption(num++, MultiMenu.crewmate, "���������������������", 3, 1, 5, 1);

            Sheriff =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFFF00FF>����</color>");
            SheriffKillOther =
                new CustomToggleOption(num++, MultiMenu.crewmate, "������ɱ��Է�Ҳ������", false);
            SheriffKillsJester =
                new CustomToggleOption(num++, MultiMenu.crewmate, "�����ɻ�ɱС��", false);
            SheriffKillsGlitch =
                new CustomToggleOption(num++, MultiMenu.crewmate, "�����ɻ�ɱ����", false);
            SheriffKillsExecutioner =
                new CustomToggleOption(num++, MultiMenu.crewmate, "�����ɻ�ɱ������", false);
            SheriffKillsArsonist =
                new CustomToggleOption(num++, MultiMenu.crewmate, "�����ɻ�ɱ�ݻ��", false);
            SheriffKillsWerewolf =
                new CustomToggleOption(num++, MultiMenu.crewmate, "�����ɻ�ɱ��������", false);
            SheriffKillsPlaguebearer =
                new CustomToggleOption(num++, MultiMenu.crewmate, "�����ɻ�ɱ����֮Դ", false);
            SheriffKillCd =
                new CustomNumberOption(num++, MultiMenu.crewmate, "������ɱ��ȴ", 25f, 10f, 40f, 2.5f, CooldownFormat);
            SheriffBodyReport = new CustomToggleOption(num++, MultiMenu.crewmate, "�������Ա���������ɱ����");

            Veteran =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#998040FF>�ϱ�</color>");
            KilledOnAlert =
                new CustomToggleOption(num++, MultiMenu.crewmate, "���ھ���ʱ����ɱ", false);
            AlertCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "���似����ȴ", 25, 10, 60, 2.5f, CooldownFormat);
            AlertDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "�������ʱ��", 10, 5, 15, 1f, CooldownFormat);
            MaxAlerts = new CustomNumberOption(num++, MultiMenu.crewmate, "���ɾ������", 5, 1, 15, 1);

            Vigilante = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFFF99FF>����</color>");
            VigilanteKills = new CustomNumberOption(num++, MultiMenu.crewmate, "�������ɲ²����", 1, 1, 15, 1);
            VigilanteMultiKill = new CustomToggleOption(num++, MultiMenu.crewmate, "ͬһ�ֻ������Ϳɶ�β²�", false);
            VigilanteGuessNeutralBenign = new CustomToggleOption(num++, MultiMenu.crewmate, "���Ϳɲ²�����������Ӫ", false);
            VigilanteGuessNeutralEvil = new CustomToggleOption(num++, MultiMenu.crewmate, "���Ϳɲ²�а�������Ӫ", false);
            VigilanteGuessNeutralKilling = new CustomToggleOption(num++, MultiMenu.crewmate, "���Ϳɲ²�ɱ�ֶ�����Ӫ", false);
            VigilanteGuessLovers = new CustomToggleOption(num++, MultiMenu.crewmate, "���Ϳɲ²�����", false);
            VigilanteAfterVoting = new CustomToggleOption(num++, MultiMenu.crewmate, "������ͶƱ����Ȼ���Բ²�", false);

            Altruist = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#660000FF>ѳ����</color>");
            ReviveDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "ѳ���߸���ʱ��", 10, 1, 15, 1f, CooldownFormat);
            AltruistTargetBody =
                new CustomToggleOption(num++, MultiMenu.crewmate, "��ʼ����ʱĿ��ʬ����ʧ", false);

            Medic =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#006600FF>��ҽ</color>");
            ShowShielded =
                new CustomStringOption(num++, MultiMenu.crewmate, "�ɿ�����ұ�����Ч������",
                    new[] { "��������", "��ҽ", "��ҽ�ͱ�������", "������" });
            WhoGetsNotification =
                new CustomStringOption(num++, MultiMenu.crewmate, "�ɿ�����ɱ���Ե���",
                    new[] { "��ҽ", "��������", "������", "���ɼ�" });
            ShieldBreaks = new CustomToggleOption(num++, MultiMenu.crewmate, "��ɱ���Ժ󻤶�����", false);
            MedicReportSwitch = new CustomToggleOption(num++, MultiMenu.crewmate, "��ʾʬ�챨��");
            MedicReportNameDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "�����ʱ�� ���� ʬ�챨����ʾ��������", 0, 0, 60, 2.5f,
                    CooldownFormat);
            MedicReportColorDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "�����ʱ�� ���� ʬ�챨����ʾ������ɫ����", 15, 0, 120, 2.5f,
                    CooldownFormat);

            Engineer =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFA60AFF>����ʦ</color>");
            EngineerPer =
                new CustomStringOption(num++, MultiMenu.crewmate, "����ʦ���޸�����", new[] { "ÿ��һ��", "��Ϸ�н�һ��" });

            Mayor =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#704FA8FF>�г�</color>");
            MayorVoteBank =
                new CustomNumberOption(num++, MultiMenu.crewmate, "�г���ʼƱ��", 1, 1, 5, 1);
            MayorAnonymous =
                new CustomToggleOption(num++, MultiMenu.crewmate, "�г�ͶƱ����", false);

            Medium =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#A680FFFF>�л�ʦ</color>");
            MediateCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "�л꼼����ȴ", 10f, 1f, 15f, 1f, CooldownFormat);
            ShowMediatePlayer =
                new CustomToggleOption(num++, MultiMenu.crewmate, "��ʾ�л�Ŀ�����", true);
            ShowMediumToDead =
                new CustomToggleOption(num++, MultiMenu.crewmate, "���л�Ŀ����ʾ�л�ʦλ��", true);
            DeadRevealed =
                new CustomStringOption(num++, MultiMenu.crewmate, "�ɱ��л�ʦ��������귶Χ", new[] { "������������", "����������", "ȫ������" });

            Swapper =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#66E666FF>��Ʊʦ</color>");
            SwapperButton =
                new CustomToggleOption(num++, MultiMenu.crewmate, "��Ʊʦ���ٿ���������", true);

            TimeLord =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#0000FFFF>ʱ������</color>");
            RewindRevive = new CustomToggleOption(num++, MultiMenu.crewmate, "���ݿɸ�������", false);
            RewindDuration = new CustomNumberOption(num++, MultiMenu.crewmate, "���ݳ���ʱ��", 2f, 2f, 5f, 0.5f, CooldownFormat);
            RewindCooldown = new CustomNumberOption(num++, MultiMenu.crewmate, "������ȴ", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RewindMaxUses =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "�����ݴ���", 5, 1, 15, 1);
            TimeLordVitals =
                new CustomToggleOption(num++, MultiMenu.crewmate, "ʱ��������ʹ���������", false);

            Transporter =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#00EEFFFF>����ʦ</color>");
            TransportCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "���ͼ�����ȴ", 25f, 10f, 60f, 2.5f, CooldownFormat);
            TransportMaxUses =
                new CustomNumberOption(num++, MultiMenu.crewmate, "���ɴ��ʹ���", 5, 1, 15, 1);
            TransporterVitals =
                new CustomToggleOption(num++, MultiMenu.crewmate, "����ʦ��ʹ���������", false);

            Amnesiac = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#80B2FFFF>ʧ����</color>");
            RememberArrows =
                new CustomToggleOption(num++, MultiMenu.neutral, "ʧ���߻���ʾָ��ʬ��ļ�ͷ", false);
            RememberArrowDelay =
                new CustomNumberOption(num++, MultiMenu.neutral, "����ʬ�������ʾ��ͷ", 5f, 0f, 15f, 1f, CooldownFormat);

            GuardianAngel =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#B3FFFFFF>�ػ���ʹ</color>");
            ProtectCd =
                new CustomNumberOption(num++, MultiMenu.neutral, "�ػ�������ȴ", 25, 10, 60, 2.5f, CooldownFormat);
            ProtectDuration =
                new CustomNumberOption(num++, MultiMenu.neutral, "�ػ�����ʱ��", 10, 5, 15, 1f, CooldownFormat);
            ProtectKCReset =
                new CustomNumberOption(num++, MultiMenu.neutral, "���Ի�ɱ���ػ�����ʱ��ɱ���ܵ���ȴʱ��", 2.5f, 0f, 15f, 0.5f, CooldownFormat);
            MaxProtects =
                new CustomNumberOption(num++, MultiMenu.neutral, "����ػ�����", 5, 1, 15, 1);
            ShowProtect =
                new CustomStringOption(num++, MultiMenu.neutral, "�ɼ����ػ�Ч������",
                    new[] { "���ػ���", "�ػ���ʹ", "�ػ�˫��", "������" });
            GaOnTargetDeath = new CustomStringOption(num++, MultiMenu.neutral, "���ػ����������ػ���ʹ���Ϊ",
                new[] { "��Ա", "ʧ����", "�Ҵ���", "С��" });
            GATargetKnows =
                new CustomToggleOption(num++, MultiMenu.neutral, "���ػ���֪���ػ���ʹ�Ĵ���", false);
            GAKnowsTargetRole =
                new CustomToggleOption(num++, MultiMenu.neutral, "�ػ���ʹ֪�����ػ���ְҵ", false);

            Survivor =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#FFE64DFF>�Ҵ���</color>");
            VestCd =
                new CustomNumberOption(num++, MultiMenu.neutral, "��������ȴ", 25, 10, 60, 2.5f, CooldownFormat);
            VestDuration =
                new CustomNumberOption(num++, MultiMenu.neutral, "�����³���ʱ��", 10, 5, 15, 1f, CooldownFormat);
            VestKCReset =
                new CustomNumberOption(num++, MultiMenu.neutral, "�����³���ʱ���ڳ��Ի�ɱʱ��ɱ���ܵ���ȴʱ��", 2.5f, 0f, 15f, 0.5f, CooldownFormat);
            MaxVests =
                new CustomNumberOption(num++, MultiMenu.neutral, "���������ʹ�ô���", 5, 1, 15, 1);

            Executioner =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#8C4005FF>������</color>");
            OnTargetDead = new CustomStringOption(num++, MultiMenu.neutral, "Ŀ��������������ְҵ���Ϊ",
                new[] { "��Ա", "ʧ����", "�Ҵ���", "С��" });
            ExecutionerButton =
                new CustomToggleOption(num++, MultiMenu.neutral, "�����߿��ٿ���������", true);

            Jester =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#FFBFCCFF>С��</color>");
            JesterButton =
                new CustomToggleOption(num++, MultiMenu.neutral, "С����ٿ���������", true);
            JesterVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "С���ʹ��ͨ��ܵ�", false);

            Phantom =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#662962FF>��Ӱ</color>");
            PhantomTasksRemaining =
                 new CustomNumberOption(num++, MultiMenu.neutral, "��Ӱ�ɿ�ʼ�������ʣ��������", 5, 1, 10, 1);

            Arsonist = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#FF4D00FF>�ݻ��</color>");
            DouseCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "������ȴ", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MaxDoused =
                new CustomNumberOption(num++, MultiMenu.neutral, "�����������ɽ�������", 5, 1, 15, 1);

            Plaguebearer = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#E6FFB3FF>����֮Դ</color>");
            InfectCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "��Ⱦ������ȴ", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PestKillCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "����֮���ɱ��ȴ", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PestVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "����֮���ʹ��ͨ��ܵ�", false);

            TheGlitch =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#00FF00FF>����</color>");
            MimicCooldownOption = new CustomNumberOption(num++, MultiMenu.neutral, "���μ�����ȴ", 25f, 10f, 120f, 2.5f, CooldownFormat);
            MimicDurationOption = new CustomNumberOption(num++, MultiMenu.neutral, "���γ���ʱ��", 10f, 1f, 30f, 1f, CooldownFormat);
            HackCooldownOption = new CustomNumberOption(num++, MultiMenu.neutral, "���뼼����ȴ", 25f, 10f, 120f, 2.5f, CooldownFormat);
            HackDurationOption = new CustomNumberOption(num++, MultiMenu.neutral, "�������ʱ��", 10f, 1f, 30f, 1f, CooldownFormat);
            GlitchKillCooldownOption =
                new CustomNumberOption(num++, MultiMenu.neutral, "�����ɱ��ȴ", 25f, 10f, 120f, 2.5f, CooldownFormat);
            GlitchHackDistanceOption =
                new CustomStringOption(num++, MultiMenu.neutral, "���级�����", new[] { "��", "��", "��" });
            GlitchVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "�����ʹ��ͨ��ܵ�", false);

            Werewolf = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#A86629FF>��������</color>");
            RampageCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "���߼�����ȴ", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RampageDuration =
                new CustomNumberOption(num++, MultiMenu.neutral, "���߳���ʱ��", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RampageKillCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "���߻�ɱ��ȴ", 10f, 0.5f, 15f, 0.5f, CooldownFormat);
            WerewolfVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "����ʱ��ʹ��ͨ��ܵ�", false);

            Grenadier =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>������</color>");
            GrenadeCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "���ⵯ��ȴ", 25, 10, 40, 2.5f, CooldownFormat);
            GrenadeDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "���ⵯ����ʱ��", 10, 5, 15, 1f, CooldownFormat);
            FlashRadius =
                new CustomNumberOption(num++, MultiMenu.imposter, "���ⵯ��Χ", 1f, 0.25f, 5f, 0.25f, MultiplierFormat);
            GrenadierIndicators =
                new CustomToggleOption(num++, MultiMenu.imposter, "��ʾ�����ⵯӰ�쵽�����", false);
            GrenadierVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "��������ʹ��ͨ��ܵ�", false);

            Morphling =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>������</color>");
            MorphlingCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "���μ�����ȴʱ��", 25, 10, 40, 2.5f, CooldownFormat);
            MorphlingDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "���μ��ܳ���ʱ��", 10, 5, 15, 1f, CooldownFormat);
            MorphlingVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "�����߿�ʹ��ͨ��ܵ�", false);

            Swooper = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>������</color>");

            SwoopCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "��������ȴʱ��", 25, 10, 40, 2.5f, CooldownFormat);
            SwoopDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "�����ܳ���ʱ��", 10, 5, 15, 1f, CooldownFormat);
            SwooperVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "�����˿�ʹ��ͨ��ܵ�", false);

            Poisoner =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>������ʦ</color>");
            PoisonCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "�¶�������ȴʱ��", 25, 10, 40, 2.5f, CooldownFormat);
            PoisonDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "��ɱ�ӳ�ʱ��", 5, 1, 15, 1f, CooldownFormat);
            PoisonerVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "������ʦ��ʹ��ͨ��ܵ�", false);

            Traitor = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>������</color>");
            LatestSpawn = new CustomNumberOption(num++, MultiMenu.imposter, "���ֱ�������������ٴ���������", 5, 3, 15, 1);
            NeutralKillingStopsTraitor =
                new CustomToggleOption(num++, MultiMenu.imposter, "ɱ�ֶ�����Ӫ���ʱ������ֱ�����", false);

            Underdog = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Ǳ����</color>");
            UnderdogKillBonus = new CustomNumberOption(num++, MultiMenu.imposter, "��ɱ��ȴʱ������/����ֵ", 5, 2.5f, 30, 2.5f, CooldownFormat);
            UnderdogIncreasedKC = new CustomToggleOption(num++, MultiMenu.imposter, "αװ�ߴ��2�˼�����ʱ��ɱ��ȴ����", true);

            Blackmailer = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>������</color>");
            BlackmailCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "�������ܳ�ʼ��ȴʱ��", 10, 1, 15, 1f, CooldownFormat);

            Miner = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>�ܵ���</color>");
            MineCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "�ڶ�������ȴ", 25, 10, 40, 2.5f, CooldownFormat);

            Undertaker = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>������</color>");
            DragCooldown = new CustomNumberOption(num++, MultiMenu.imposter, "��ʬ��ȴʱ��", 25, 10, 40, 2.5f, CooldownFormat);
            UndertakerVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "�����߿�ʹ��ͨ��ܵ�", false);
            UndertakerVentWithBody =
                new CustomToggleOption(num++, MultiMenu.imposter, "�����߿ɽ�ʬ������ͨ��ܵ�", false);

            Bait = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#00B3B3FF>�ն�</color>");
            BaitMinDelay = new CustomNumberOption(num++, MultiMenu.modifiers, "�ն�������С�ӳ�ʱ��", 0f, 0f, 15f, 0.5f, CooldownFormat);
            BaitMaxDelay = new CustomNumberOption(num++, MultiMenu.modifiers, "�ն���������ӳ�ʱ��", 1f, 0f, 15f, 0.5f, CooldownFormat);

            Diseased = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#808080FF>����</color>");
            DiseasedKillMultiplier = new CustomNumberOption(num++, MultiMenu.modifiers, "ɱ�����˺�ɱ�ֵļ�����ȴ����", 3f, 1.5f, 5f, 0.5f, MultiplierFormat);

            Flash = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FF8080FF>������</color>");
            FlashSpeed = new CustomNumberOption(num++, MultiMenu.modifiers, "����������", 1.25f, 1.05f, 2.5f, 0.05f, MultiplierFormat);

            Giant = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FFB34DFF>����</color>");
            GiantSlow = new CustomNumberOption(num++, MultiMenu.modifiers, "��������", 0.75f, 0.5f, 1f, 0.05f, MultiplierFormat);

            Lovers =
                new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FF66CCFF>����</color>");
            BothLoversDie = new CustomToggleOption(num++, MultiMenu.modifiers, "����ͬ������");
            LovingImpPercent = new CustomNumberOption(num++, MultiMenu.modifiers, "αװ���������ɸ���", 20f, 0f, 100f, 10f,
                PercentFormat);
            NeutralLovers = new CustomToggleOption(num++, MultiMenu.modifiers, "������Ӫ�ɳ�Ϊ����");
        }
    }
}