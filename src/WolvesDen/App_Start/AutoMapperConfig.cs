using AutoMapper;
using AutoMapper.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using WolvesDen.Profiles;

namespace WolvesDen
{
    /// <summary>
    /// Configuration class for AutoMapper
    /// </summary>
    public static class AutoMapperConfig
    {
        /// <summary>
        /// Register profiles for AutoMapper
        /// </summary>
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<AchievementProfile>();
                cfg.AddProfile<AchievementCategoryProfile>();
                cfg.AddProfile<AchievementKindProfile>();
                cfg.AddProfile<ActionProfile>();
                cfg.AddProfile<ActionCategoryProfile>();
                cfg.AddProfile<ActionComboRouteProfile>();
                cfg.AddProfile<ActionComboRouteTransientProfile>();
                cfg.AddProfile<FishingSpotProfile>();
                cfg.AddProfile<FishParameterProfile>();
                cfg.AddProfile<GatheringTypeProfile>();
                cfg.AddProfile<ItemProfile>();
                cfg.AddProfile<JournalCategoryProfile>();
                cfg.AddProfile<JournalGenreProfile>();
                cfg.AddProfile<JournalSectionProfile>();
                cfg.AddProfile<MapProfile>();
                cfg.AddProfile<OrchestrionProfile>();
                cfg.AddProfile<OrchestrionCategoryProfile>();
                cfg.AddProfile<OrchestrionPathProfile>();
                cfg.AddProfile<OrchestrionUiparamProfile>();
                cfg.AddProfile<PlaceNameProfile>();
                cfg.AddProfile<PhysicalWeaponProfile>();
                cfg.AddProfile<SpearfishingEcologyProfile>();
                cfg.AddProfile<SpearfishingItemProfile>();
                cfg.AddProfile<SpearfishingNotebookProfile>();
                cfg.AddProfile<TerritoryTypeProfile>();
                cfg.AddProfile<TripleTriadCardProfile>();
                cfg.AddProfile<TripleTriadCardRarityProfile>();
                cfg.AddProfile<TripleTriadCardResidentProfile>();
                cfg.AddProfile<TripleTriadCardTypeProfile>();
                cfg.AddProfile<TripleTriadCompetitionProfile>();
                cfg.AddProfile<TripleTriadRuleProfile>();
                cfg.AddProfile<QuestDetailProfile>();
                cfg.AddProfile<QuestProfile>();
            });
        }
    }
}