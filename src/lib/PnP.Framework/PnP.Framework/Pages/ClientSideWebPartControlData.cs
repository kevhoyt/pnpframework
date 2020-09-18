﻿using Newtonsoft.Json;

namespace PnP.Framework.Pages
{
    /// <summary>
    /// Control data for controls of type 3 (= client side web parts)
    /// </summary>
    public class ClientSideWebPartControlData : ClientSideCanvasControlData
    {
        /// <summary>
        /// Gets or sets JsonProperty "webPartId"
        /// </summary>
        [JsonProperty(PropertyName = "webPartId")]
        public string WebPartId { get; set; }
    }
}
