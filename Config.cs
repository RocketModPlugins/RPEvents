using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Rocket.API;

namespace coolpuppy24.rpevents
{
    public class RPEventsConfiguration : IRocketPluginConfiguration
    {
        public bool RaidDelay;
        public int MinutesUntilRaid;
        public string StartColor;
        public string FinishColor;

        public void LoadDefaults()
        {
            RaidDelay = true;
            MinutesUntilRaid = 10;
            StartColor = "red";
            FinishColor = "blue";
        }
    }
}