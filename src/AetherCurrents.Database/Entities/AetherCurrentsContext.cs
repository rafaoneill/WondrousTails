using Microsoft.EntityFrameworkCore;

namespace AetherCurrents.Database.Entities
{
    public partial class AetherCurrentsContext : DbContext
    {
        public virtual DbSet<Achievement> Achievement { get; set; }
        public virtual DbSet<AchievementCategory> AchievementCategory { get; set; }
        public virtual DbSet<AchievementKind> AchievementKind { get; set; }
        public virtual DbSet<Action> Action { get; set; }
        public virtual DbSet<ActionCategory> ActionCategory { get; set; }
        public virtual DbSet<ActionComboRoute> ActionComboRoute { get; set; }
        public virtual DbSet<ActionComboRouteTransient> ActionComboRouteTransient { get; set; }
        public virtual DbSet<FishingSpot> FishingSpot { get; set; }
        public virtual DbSet<FishingSpotItem> FishingSpotItem { get; set; }
        public virtual DbSet<FishParameter> FishParameter { get; set; }
        public virtual DbSet<GatheringType> GatheringType { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<JournalCategory> JournalCategory { get; set; }
        public virtual DbSet<JournalGenre> JournalGenre { get; set; }
        public virtual DbSet<JournalSection> JournalSection { get; set; }
        public virtual DbSet<Map> Map { get; set; }
        public virtual DbSet<Orchestrion> Orchestrion { get; set; }
        public virtual DbSet<OrchestrionCategory> OrchestrionCategory { get; set; }
        public virtual DbSet<OrchestrionPath> OrchestrionPath { get; set; }
        public virtual DbSet<OrchestrionUiparam> OrchestrionUiparam { get; set; }
        public virtual DbSet<PlaceName> PlaceName { get; set; }
        public virtual DbSet<Quest> Quest { get; set; }
        public virtual DbSet<QuestDetail> QuestDetail { get; set; }
        public virtual DbSet<SpearfishingEcology> SpearfishingEcology { get; set; }
        public virtual DbSet<SpearfishingItem> SpearfishingItem { get; set; }
        public virtual DbSet<SpearfishingNotebook> SpearfishingNotebook { get; set; }
        public virtual DbSet<TerritoryType> TerritoryType { get; set; }
        public virtual DbSet<TripleTriadCard> TripleTriadCard { get; set; }
        public virtual DbSet<TripleTriadCardRarity> TripleTriadCardRarity { get; set; }
        public virtual DbSet<TripleTriadCardResident> TripleTriadCardResident { get; set; }
        public virtual DbSet<TripleTriadCardType> TripleTriadCardType { get; set; }
        public virtual DbSet<TripleTriadCompetition> TripleTriadCompetition { get; set; }
        public virtual DbSet<TripleTriadRule> TripleTriadRule { get; set; }

        public AetherCurrentsContext(DbContextOptions<AetherCurrentsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Achievement>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DataIi).HasColumnName("DataII");

                entity.Property(e => e.DataIii).HasColumnName("DataIII");

                entity.Property(e => e.DataIv).HasColumnName("DataIV");

                entity.Property(e => e.DataIx).HasColumnName("DataIX");

                entity.Property(e => e.DataVi).HasColumnName("DataVI");

                entity.Property(e => e.DataVii).HasColumnName("DataVII");

                entity.Property(e => e.DataViii).HasColumnName("DataVIII");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(55);
            });

            modelBuilder.Entity<AchievementCategory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AchievementKind>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Action>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Icon).HasMaxLength(25);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.XaxisModifier).HasColumnName("XAxisModifier");
            });

            modelBuilder.Entity<ActionCategory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ActionComboRoute>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<ActionComboRouteTransient>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1500);
            });

            modelBuilder.Entity<FishingSpot>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BigFishOnEnd)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BigFishOnReach)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FishingSpotItem>(entity =>
            {
                entity.HasKey(e => new { e.FishingSpotId, e.Sequence });

                entity.HasOne(d => d.FishingSpot)
                    .WithMany(p => p.FishingSpotItem)
                    .HasForeignKey(d => d.FishingSpotId)
                    .HasConstraintName("FK_FishingSpot");
            });

            modelBuilder.Entity<FishParameter>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GatheringType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IconMain)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.IconOff)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.Property(e => e.Icon).HasMaxLength(25);

                entity.Property(e => e.ItemUicategory).HasColumnName("ItemUICategory");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Plural)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Singular)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JournalCategory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JournalGenre>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JournalSection>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Map>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.MapId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MediumMap)
                    .IsRequired()
                    .HasMaxLength(35);

                entity.Property(e => e.SmallMap)
                    .IsRequired()
                    .HasMaxLength(35);
            });

            modelBuilder.Entity<Orchestrion>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(205)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrchestrionCategory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrchestrionPath>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrchestrionUiparam>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<PlaceName>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameNoArticle)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Quest>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EnpcResidentEnd).HasColumnName("ENpcResidentEnd");

                entity.Property(e => e.EnpcResidentStart).HasColumnName("ENpcResidentStart");

                entity.Property(e => e.Icon)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.IconSpecial)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QuestId)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.QuestStatus).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<QuestDetail>(entity =>
            {
                entity.Property(e => e.DetailDescription).IsUnicode(false);

                entity.Property(e => e.DetailKey)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.QuestTextId)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SheetFullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpearfishingEcology>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IntensifyDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NearbyDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShadowsDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShapeDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpearfishingItem>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SpearfishingNotebook>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TerritoryType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Bg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TripleTriadCard>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TripleTriadCardRarity>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TripleTriadCardResident>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TripleTriadCardType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TripleTriadCompetition>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TripleTriadRule>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });
        }
    }
}