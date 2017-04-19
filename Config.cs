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
        public string ArrestMessageColor;
        public string ArrestFinishMessageColor;
        public string RobMessageColor;
        public string RobFinishMessageColor;
        public string RaidMessageColor;
        public string RaidFinishMessageColor;

        public void LoadDefaults()
        {
            RaidDelay = true;
            MinutesUntilRaid = 10;
            ArrestMessageColor = "red";
            ArrestFinishMessageColor = "blue";
            RobMessageColor = "red";
            RobFinishMessageColor = "blue";
            RaidMessageColor = "red";
            RaidFinishMessageColor = "blue";
        }
    }
}