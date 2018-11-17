using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AetherCurrents.Database.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Achievement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Category = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 55, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: false),
                    Points = table.Column<byte>(nullable: false),
                    Title = table.Column<short>(nullable: true),
                    Item = table.Column<string>(maxLength: 50, nullable: false),
                    Icon = table.Column<string>(maxLength: 50, nullable: true),
                    Type = table.Column<byte>(nullable: false),
                    DataI = table.Column<int>(nullable: false),
                    DataII = table.Column<int>(nullable: false),
                    DataIII = table.Column<int>(nullable: false),
                    DataIV = table.Column<int>(nullable: false),
                    DataV = table.Column<int>(nullable: false),
                    DataVI = table.Column<int>(nullable: false),
                    DataVII = table.Column<int>(nullable: false),
                    DataVIII = table.Column<int>(nullable: false),
                    DataIX = table.Column<int>(nullable: false),
                    Order = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Achievement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AchievementCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Kind = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsSeasonal = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AchievementCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AchievementKind",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AchievementKind", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Action",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Icon = table.Column<string>(maxLength: 25, nullable: true),
                    Category = table.Column<byte>(nullable: true),
                    TimelineUse = table.Column<short>(nullable: true),
                    TimelineHit = table.Column<short>(nullable: true),
                    ClassJob = table.Column<byte>(nullable: true),
                    ClassJobLevel = table.Column<int>(nullable: true),
                    IsRoleAction = table.Column<bool>(nullable: true),
                    Range = table.Column<int>(nullable: true),
                    CanTargetSelf = table.Column<bool>(nullable: true),
                    CanTargetParty = table.Column<bool>(nullable: true),
                    CanTargetFriendly = table.Column<bool>(nullable: true),
                    CanTargetHostile = table.Column<bool>(nullable: true),
                    CanTargetArea = table.Column<bool>(nullable: true),
                    CanTargetDead = table.Column<bool>(nullable: true),
                    CastType = table.Column<byte>(nullable: true),
                    EffectRange = table.Column<byte>(nullable: true),
                    XAxisModifier = table.Column<byte>(nullable: true),
                    CostType = table.Column<byte>(nullable: true),
                    Cost = table.Column<int>(nullable: true),
                    Combo = table.Column<short>(nullable: true),
                    PreservesCombo = table.Column<bool>(nullable: true),
                    Cast = table.Column<short>(nullable: true),
                    Recast = table.Column<short>(nullable: true),
                    CooldownGroup = table.Column<byte>(nullable: true),
                    AttackType = table.Column<byte>(nullable: true),
                    Aspect = table.Column<byte>(nullable: true),
                    ProcStatus = table.Column<byte>(nullable: true),
                    StatusGainSelf = table.Column<short>(nullable: true),
                    Data = table.Column<int>(nullable: true),
                    ClassJobCategory = table.Column<byte>(nullable: true),
                    AffectsPosition = table.Column<bool>(nullable: true),
                    Omen = table.Column<byte>(nullable: true),
                    IsPvP = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Action", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActionCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActionComboRoute",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Action0 = table.Column<short>(nullable: false),
                    Action1 = table.Column<short>(nullable: false),
                    Action2 = table.Column<short>(nullable: false),
                    Action3 = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionComboRoute", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActionComboRouteTransient",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 1500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionComboRouteTransient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FishingSpot",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    GatheringLevel = table.Column<byte>(nullable: false),
                    BigFishOnReach = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    BigFishOnEnd = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    FishingSpotCategory = table.Column<byte>(nullable: false),
                    TerritoryType = table.Column<short>(nullable: false),
                    X = table.Column<short>(nullable: false),
                    Z = table.Column<short>(nullable: false),
                    Radius = table.Column<short>(nullable: false),
                    PlaceName = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishingSpot", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FishParameter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Text = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Item = table.Column<int>(nullable: false),
                    GatheringItemLevel = table.Column<short>(nullable: false),
                    TerritoryType = table.Column<int>(nullable: false),
                    IsFish = table.Column<bool>(nullable: false),
                    GatheringSubCategory = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishParameter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GatheringType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    IconMain = table.Column<string>(maxLength: 30, nullable: false),
                    IconOff = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GatheringType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Singular = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Plural = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    StartsWithVowel = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 1200, nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Icon = table.Column<string>(maxLength: 25, nullable: true),
                    LevelItem = table.Column<short>(nullable: false),
                    Rarity = table.Column<byte>(nullable: false),
                    FilterGroup = table.Column<byte>(nullable: false),
                    Stain = table.Column<int>(nullable: false),
                    ItemUICategory = table.Column<int>(nullable: false),
                    ItemSearchCategory = table.Column<byte>(nullable: false),
                    EquipSlotCategory = table.Column<byte>(nullable: false),
                    StackSize = table.Column<int>(nullable: false),
                    IsUnique = table.Column<bool>(nullable: false),
                    IsUntradable = table.Column<bool>(nullable: false),
                    IsIndisposable = table.Column<bool>(nullable: false),
                    PriceMid = table.Column<int>(nullable: false),
                    PriceLow = table.Column<int>(nullable: false),
                    CanBeHq = table.Column<bool>(nullable: false),
                    IsDyeable = table.Column<bool>(nullable: false),
                    IsCrestWorthy = table.Column<bool>(nullable: false),
                    ItemAction = table.Column<short>(nullable: false),
                    CooldownSeconds = table.Column<short>(nullable: false),
                    ClassJobRepair = table.Column<byte>(nullable: false),
                    ItemRepair = table.Column<int>(nullable: false),
                    ItemGlamour = table.Column<int>(nullable: false),
                    Salvage = table.Column<short>(nullable: false),
                    IsCollectable = table.Column<bool>(nullable: false),
                    AetherialReduce = table.Column<short>(nullable: false),
                    LevelEquip = table.Column<byte>(nullable: false),
                    EquipRestriction = table.Column<byte>(nullable: false),
                    ClassJobCategory = table.Column<byte>(nullable: false),
                    GrandCompany = table.Column<byte>(nullable: false),
                    ItemSeries = table.Column<byte>(nullable: false),
                    BaseParamModifier = table.Column<byte>(nullable: false),
                    ClassJobUse = table.Column<byte>(nullable: false),
                    DamagePhysical = table.Column<short>(nullable: false),
                    DamageMagical = table.Column<short>(nullable: false),
                    DelayMiliseconds = table.Column<short>(nullable: false),
                    BlockRate = table.Column<short>(nullable: false),
                    Block = table.Column<short>(nullable: false),
                    DefensePhysical = table.Column<short>(nullable: false),
                    DefenseMagical = table.Column<short>(nullable: false),
                    ItemSpecialBonus = table.Column<byte>(nullable: false),
                    ItemSpecialBonusParam = table.Column<byte>(nullable: false),
                    MaterializeType = table.Column<byte>(nullable: false),
                    MateriaSlotCount = table.Column<byte>(nullable: false),
                    IsAdvancedMeldingPermitted = table.Column<bool>(nullable: false),
                    IsPvp = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JournalCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
                    JournalSectionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JournalGenre",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Icon = table.Column<string>(maxLength: 25, nullable: false),
                    JournalCategory = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalGenre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JournalSection",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalSection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Map",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    SmallMap = table.Column<string>(maxLength: 35, nullable: false),
                    MediumMap = table.Column<string>(maxLength: 35, nullable: false),
                    Hierarchy = table.Column<byte>(nullable: false),
                    MapMarkerRange = table.Column<short>(nullable: false),
                    MapId = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    SizeFactor = table.Column<short>(nullable: false),
                    OffsetX = table.Column<short>(nullable: false),
                    OffsetY = table.Column<short>(nullable: false),
                    PlaceNameRegion = table.Column<short>(nullable: false),
                    PlaceName = table.Column<short>(nullable: false),
                    PlaceNameSub = table.Column<short>(nullable: false),
                    DiscoveryIndex = table.Column<short>(nullable: false),
                    TerritoryType = table.Column<short>(nullable: false),
                    DiscoveryArrayByte = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Map", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orchestrion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 205, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orchestrion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrchestrionCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrchestrionCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrchestrionPath",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    FilePath = table.Column<string>(unicode: false, maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrchestrionPath", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrchestrionUiparam",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Category = table.Column<byte>(nullable: false),
                    PositionInCategory = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrchestrionUiparam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaceName",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    NameNoArticle = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceName", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Quest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    QuestId = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    Expansion = table.Column<byte>(nullable: false),
                    QuestLevelOffset = table.Column<byte>(nullable: false),
                    PreviousQuestJoin = table.Column<byte>(nullable: false),
                    QuestLockJoin = table.Column<byte>(nullable: false),
                    ClassJobUnlock = table.Column<byte>(nullable: false),
                    GrandCompany = table.Column<byte>(nullable: false),
                    GrandCompanyRank = table.Column<byte>(nullable: false),
                    InstanceContentJoin = table.Column<byte>(nullable: false),
                    BellStart = table.Column<short>(nullable: false),
                    BellEnd = table.Column<short>(nullable: false),
                    BeastTribe = table.Column<byte>(nullable: false),
                    BeastReputationRank = table.Column<byte>(nullable: false),
                    MountRequired = table.Column<int>(nullable: true),
                    IsHouseRequired = table.Column<bool>(nullable: false),
                    ENpcResidentStart = table.Column<int>(nullable: false),
                    ENpcResidentEnd = table.Column<int>(nullable: false),
                    IsRepeatable = table.Column<bool>(nullable: false),
                    RepeatIntervalType = table.Column<byte>(nullable: false),
                    ClassJobRequired = table.Column<byte>(nullable: false),
                    ExpFactor = table.Column<int>(nullable: false),
                    GilReward = table.Column<int>(nullable: false),
                    GrandCompanySeals = table.Column<short>(nullable: false),
                    ItemRewardType = table.Column<byte>(nullable: false),
                    InstanceContentUnlock = table.Column<int>(nullable: false),
                    TomestoneReward = table.Column<byte>(nullable: false),
                    TomestoneRewardCount = table.Column<byte>(nullable: false),
                    ReputationReward = table.Column<byte>(nullable: false),
                    PlaceName = table.Column<short>(nullable: true),
                    JournalGenre = table.Column<short>(nullable: false),
                    Icon = table.Column<string>(maxLength: 25, nullable: false),
                    IconSpecial = table.Column<string>(maxLength: 25, nullable: false),
                    EventIconType = table.Column<short>(nullable: false),
                    SortKey = table.Column<short>(nullable: false),
                    ClassJobLevelUnlock = table.Column<int>(nullable: false),
                    ClassJobLevelComplete = table.Column<int>(nullable: false),
                    ClassJobCategoryUnlock = table.Column<short>(nullable: false),
                    ClassJobCategoryComplete = table.Column<short>(nullable: false),
                    QuestStatus = table.Column<byte>(nullable: false, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SheetFullName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    QuestTextId = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    DetailKey = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    DetailDescription = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestDetail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpearfishingEcology",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    ShadowsDescription = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    IntensifyDescription = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    ShapeDescription = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    NearbyDescription = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpearfishingEcology", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpearfishingItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Item = table.Column<int>(nullable: false),
                    GatheringItemLevel = table.Column<short>(nullable: false),
                    TerritoryType = table.Column<short>(nullable: false),
                    IsVisible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpearfishingItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpearfishingNotebook",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    GatheringLevel = table.Column<byte>(nullable: false),
                    TerritoryType = table.Column<int>(nullable: false),
                    X = table.Column<short>(nullable: false),
                    Y = table.Column<short>(nullable: false),
                    Radius = table.Column<short>(nullable: false),
                    PlaceName = table.Column<short>(nullable: false),
                    GatheringPointBase = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpearfishingNotebook", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TerritoryType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Bg = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PlaceNameRegion = table.Column<short>(nullable: false),
                    PlaceNameZone = table.Column<short>(nullable: false),
                    PlaceName = table.Column<short>(nullable: false),
                    Map = table.Column<short>(nullable: false),
                    TerritoryIntendedUse = table.Column<byte>(nullable: false),
                    WeatherRate = table.Column<byte>(nullable: false),
                    ArrayEventHandler = table.Column<int>(nullable: false),
                    Aetheryte = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TerritoryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TripleTriadCard",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    StartsWithVowel = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripleTriadCard", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TripleTriadCardRarity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Stars = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripleTriadCardRarity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TripleTriadCardResident",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Top = table.Column<byte>(nullable: false),
                    Bottom = table.Column<byte>(nullable: false),
                    Left = table.Column<byte>(nullable: false),
                    Right = table.Column<byte>(nullable: false),
                    Rarity = table.Column<byte>(nullable: false),
                    Type = table.Column<byte>(nullable: false),
                    SaleValue = table.Column<int>(nullable: false),
                    SortKey = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripleTriadCardResident", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TripleTriadCardType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripleTriadCardType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TripleTriadCompetition",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripleTriadCompetition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TripleTriadRule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripleTriadRule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FishingSpotItem",
                columns: table => new
                {
                    FishingSpotId = table.Column<int>(nullable: false),
                    Sequence = table.Column<int>(nullable: false),
                    Item = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FishingSpotItem", x => new { x.FishingSpotId, x.Sequence });
                    table.ForeignKey(
                        name: "FK_FishingSpot",
                        column: x => x.FishingSpotId,
                        principalTable: "FishingSpot",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Achievement");

            migrationBuilder.DropTable(
                name: "AchievementCategory");

            migrationBuilder.DropTable(
                name: "AchievementKind");

            migrationBuilder.DropTable(
                name: "Action");

            migrationBuilder.DropTable(
                name: "ActionCategory");

            migrationBuilder.DropTable(
                name: "ActionComboRoute");

            migrationBuilder.DropTable(
                name: "ActionComboRouteTransient");

            migrationBuilder.DropTable(
                name: "FishingSpotItem");

            migrationBuilder.DropTable(
                name: "FishParameter");

            migrationBuilder.DropTable(
                name: "GatheringType");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "JournalCategory");

            migrationBuilder.DropTable(
                name: "JournalGenre");

            migrationBuilder.DropTable(
                name: "JournalSection");

            migrationBuilder.DropTable(
                name: "Map");

            migrationBuilder.DropTable(
                name: "Orchestrion");

            migrationBuilder.DropTable(
                name: "OrchestrionCategory");

            migrationBuilder.DropTable(
                name: "OrchestrionPath");

            migrationBuilder.DropTable(
                name: "OrchestrionUiparam");

            migrationBuilder.DropTable(
                name: "PlaceName");

            migrationBuilder.DropTable(
                name: "Quest");

            migrationBuilder.DropTable(
                name: "QuestDetail");

            migrationBuilder.DropTable(
                name: "SpearfishingEcology");

            migrationBuilder.DropTable(
                name: "SpearfishingItem");

            migrationBuilder.DropTable(
                name: "SpearfishingNotebook");

            migrationBuilder.DropTable(
                name: "TerritoryType");

            migrationBuilder.DropTable(
                name: "TripleTriadCard");

            migrationBuilder.DropTable(
                name: "TripleTriadCardRarity");

            migrationBuilder.DropTable(
                name: "TripleTriadCardResident");

            migrationBuilder.DropTable(
                name: "TripleTriadCardType");

            migrationBuilder.DropTable(
                name: "TripleTriadCompetition");

            migrationBuilder.DropTable(
                name: "TripleTriadRule");

            migrationBuilder.DropTable(
                name: "FishingSpot");
        }
    }
}
