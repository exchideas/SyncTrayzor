﻿using Newtonsoft.Json;

namespace SyncTrayzor.SyncThing.ApiClient
{
    public class FolderSummaryEventData
    {
        [JsonProperty("folder")]
        public string Folder { get; set; }

        [JsonProperty("summary")]
        public FolderStatus Summary { get; set; }
    }

    public class FolderSummaryEvent : Event
    {
        [JsonProperty("data")]
        public FolderSummaryEventData Data { get; set; }

        public override void Visit(IEventVisitor visitor)
        {
            visitor.Accept(this);
        }

        public override string ToString()
        {
            return $"<FolderSummary ID={this.Id} Time={this.Time} Folder={this.Data.Folder} Summary={this.Data.Summary}>";
        }
    }
}
