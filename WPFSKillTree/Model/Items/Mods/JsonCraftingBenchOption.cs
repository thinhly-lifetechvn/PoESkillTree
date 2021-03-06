﻿using Newtonsoft.Json;

namespace PoESkillTree.Model.Items.Mods
{
    // The class used to deserialize RePoE's crafting_bench_options
    public class JsonCraftingBenchOption
    {
        [JsonProperty("mod_id")]
        public string ModId { get; set; } = default!;

        [JsonProperty("item_classes")]
        public string[] ItemClasses { get; set; } = default!;
    }
}
