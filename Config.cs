using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Rocket.API;

namespace coolpuppy24.rpevents
{
    public class RPEventsConfiguration : IRocketPluginConfiguration
    {
        public int MinutesUntilRaid;
        public string MessageColor;

        public void LoadDefaults()
        {
            MinutesUntilRaid = 600;
            MessageColor = "red";
        }
    }
}