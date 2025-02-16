﻿using System;
using System.Collections.Generic;
using System.Text;


namespace GatheringTimer.Data.ThirdParty.XIVApi
{
    public class Pagination
    {
        public int? Page { get; set; }

        public int? PageNext { get; set; }

        public int? PagePrev { get; set; }

        public int? PageTotal { get; set; }

        public int? Results { get; set; }

        public int? ResultsPerPage { get; set; }

        public int? ResultsTotal { get; set; }
    }

    /// <summary>
    /// XIV Item Data
    /// </summary>
    public class Item
    {
        public int? ID { get; set; }
        public string Name { get; set; }
        public string Name_de { get; set; }
        public string Name_en { get; set; }
        public string Name_fr { get; set; }
        public string Name_ja { get; set; }
        public string Description { get; set; }
        public string Description_de { get; set; }
        public string Description_en { get; set; }
        public string Description_fr { get; set; }
        public string Description_ja { get; set; }

        public int? IsCollectable { get; set; }

    }

    /// <summary>
    /// XIV GatheringItem Data
    /// </summary>
    public class GatheringItem
    {
        public int? ID { get; set; }
        public int? IsHidden { get; set; }
        public string ItemTarget { get; set; }
        public int? ItemTargetID { get; set; }
        public string GatheringItemLevelTarget { get; set; }
        public int? GatheringItemLevelTargetID { get; set; }

    }

    public class SpearfishingItem
    {
        public string Description { get; set; }

        public string Description_de { get; set; }

        public string Description_en { get; set; }

        public string Description_fr { get; set; }

        public string Description_ja { get; set; }

        public string FishingRecordTypeTarget { get; set; }

        public int? FishingRecordTypeTargetID { get; set; }

        public string GatheringItemLevelTarget { get; set; }

        public int? GatheringItemLevelTargetID { get; set; }

        public int? ID { get; set; }

        public int? IsVisible { get; set; }

        public string ItemTarget { get; set; }

        public int? ItemTargetID { get; set; }

        public string TerritoryTypeTarget { get; set; }

        public int? TerritoryTypeTargetID { get; set; }
    }

    /// <summary>
    /// XIV GatheringPointBase Data
    /// </summary>
    public class GatheringPointBase
    {
        public int? GatheringLevel { get; set; }
        public string GatheringTypeTarget { get; set; }
        public int? GatheringTypeTargetID { get; set; }
        public int? ID { get; set; }
        public int? IsLimited { get; set; }
        public string Item0Target { get; set; }
        public int? Item0TargetID { get; set; }
        public string Item1Target { get; set; }
        public int? Item1TargetID { get; set; }
        public string Item2Target { get; set; }
        public int? Item2TargetID { get; set; }
        public string Item3Target { get; set; }
        public int? Item3TargetID { get; set; }
        public string Item4Target { get; set; }
        public int? Item4TargetID { get; set; }
        public string Item5Target { get; set; }
        public int? Item5TargetID { get; set; }
        public string Item6Target { get; set; }
        public int? Item6TargetID { get; set; }
        public string Item7Target { get; set; }
        public int? Item7TargetID { get; set; }
    }


    /// <summary>
    /// XIV GatheringPoint Data
    /// </summary>
    public class GatheringPoint
    {
        public int? Count { get; set; }

        public string GatheringPointBaseTarget { get; set; }

        public int? GatheringPointBaseTargetID { get; set; }

        public string GatheringPointBonus0Target { get; set; }

        public int? GatheringPointBonus0TargetID { get; set; }

        public string GatheringPointBonus1Target { get; set; }

        public int? GatheringPointBonus1TargetID { get; set; }

        public string GatheringSubCategoryTarget { get; set; }

        public int? GatheringSubCategoryTargetID { get; set; }

        public int? ID { get; set; }

        public int? Patch { get; set; }

        public string PlaceNameTarget { get; set; }

        public int? PlaceNameTargetID { get; set; }

        public string TerritoryTypeTarget { get; set; }

        public int? TerritoryTypeTargetID { get; set; }

        public int? Type { get; set; }
    }

    public class PlaceName
    {
        public int? ID { get; set; }

        public string Name { get; set; }

        public string Name_de { get; set; }

        public string Name_en { get; set; }

        public string Name_fr { get; set; }

        public string Name_ja { get; set; }
    }

    public class TerritoryType
    {

        public string AetheryteTarget { get; set; }

        public int? AetheryteTargetID { get; set; }

        public int? ID { get; set; }

        public string MapTarget { get; set; }

        public int? MapTargetID { get; set; }

        public string PlaceNameRegionTarget { get; set; }

        public int? PlaceNameRegionTargetID { get; set; }

        public string PlaceNameTarget { get; set; }

        public int? PlaceNameTargetID { get; set; }

        public string PlaceNameZoneTarget { get; set; }

        public int? PlaceNameZoneTargetID { get; set; }
    }

    /// <summary>
    /// XIV Map Data
    /// </summary>
    public class Map
    {

        public int? ID { get; set; }

        public int? OffsetX { get; set; }

        public int? OffsetY { get; set; }

        public string PlaceNameRegionTarget { get; set; }

        public int? PlaceNameRegionTargetID { get; set; }

        public string PlaceNameTarget { get; set; }

        public int? PlaceNameTargetID { get; set; }

        public int? SizeFactor { get; set; }

    }


}
