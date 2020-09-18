﻿using Newtonsoft.Json;

namespace PnP.Framework.Pages
{
    /// <summary>
    /// Base class representing the json control data that will describe a control versus the zones and sections on a page
    /// </summary>
    public class ClientSideCanvasPosition
    {

        /// <summary>
        /// Gets or sets JsonProperty "zoneIndex"
        /// </summary>
        [JsonProperty(PropertyName = "zoneIndex")]
        public float ZoneIndex { get; set; }
        /// <summary>
        /// Gets or sets JsonProperty "sectionIndex"
        /// </summary>
        [JsonProperty(PropertyName = "sectionIndex")]
        public int SectionIndex { get; set; }
        /// <summary>
        /// Gets or sets JsonProperty "sectionFactor"
        /// </summary>
        [JsonProperty(PropertyName = "sectionFactor", NullValueHandling = NullValueHandling.Ignore)]
        public int? SectionFactor { get; set; }
        /// <summary>
        /// Gets or sets JsonProperty "layoutIndex"
        /// </summary>
        [JsonProperty(PropertyName = "layoutIndex", NullValueHandling = NullValueHandling.Ignore)]
        public int? LayoutIndex { get; set; }
    }
}
