using System;
using System.Linq;
using System.Reflection;
using Rocket.API;
using Rocket.Unturned.Player;
using UnityEngine;
using SDG.Unturned;
using Rocket.Core.Plugins;
using Rocket.Core.Logging;
using Rocket.API.Collections;
using Rocket.Unturned.Chat;
using Rocket.Core;
using System.Collections.Generic;

namespace coolpuppy24.rpevents
{
    public class Main : RocketPlugin<RPEventsConfiguration>
    {
        public static string version = "1.0.2.0";

        public static Main Instance = null;
        
        protected override void Load()
        {
            Instance = this;
            Rocket.Core.Logging.Logger.LogWarning("[RPEvents] Made by: Coolpuppy24");
            Rocket.Core.Logging.Logger.LogWarning("-----------------------------");
            if (Configuration.Instance.RaidDelay) {
                Rocket.Core.Logging.Logger.LogWarning("[RPEvents] Raid Delay is Enabled.");
                Rocket.Core.Logging.Logger.LogWarning("[RPEvents] Minutes Until Raid: " + Configuration.Instance.MinutesUntilRaid);
            } else
            {
                Rocket.Core.Logging.Logger.LogWarning("[RPEvents] Raid Delay is Disabled.");
            }
            Rocket.Core.Logging.Logger.LogWarning("-----------------------------");
            Rocket.Core.Logging.Logger.LogWarning("[RPEvents] Arrest Message Color " + Configuration.Instance.ArrestMessageColor);
            Rocket.Core.Logging.Logger.LogWarning("[RPEvents] Arrest Finish Message Color " + Configuration.Instance.ArrestFinishMessageColor);
            Rocket.Core.Logging.Logger.LogWarning("[RPEvents] Rob Message Color " + Configuration.Instance.RobMessageColor);
            Rocket.Core.Logging.Logger.LogWarning("[RPEvents] Rob Finish Message Color " + Configuration.Instance.RobFinishMessageColor);
            Rocket.Core.Logging.Logger.LogWarning("[RPEvents] Raid Message Color " + Configuration.Instance.RaidMessageColor);
            Rocket.Core.Logging.Logger.LogWarning("[RPEvents] Raid Finish Message Color " + Configuration.Instance.RaidFinishMessageColor);
            Rocket.Core.Logging.Logger.Log("Successfully Loaded!");
        }

        protected override void Unload()
        {
            Rocket.Core.Logging.Logger.Log("Unload");
        }

        public override TranslationList DefaultTranslations
        {
            get
            {
                return new TranslationList(){
                    {"player_not_found","Player not found."},
                    {"command_rob_help","Please Specify a player to Rob!"},
                    {"command_raid_help","Please Specify an area to Raid!"},
                    {"command_arrest_help","Please Specify a player to Arrest!"},
                    {"command_rob","[RPEvents]: {0} Has Called a Rob on {1}!"},
                    {"command_robfinish","[RPEvents]: The Rob on {0} is Over."},
                    {"command_raid_delay","[RPEvents]: {0} Has Called a Raid on {1}, Starting in {2} Minutes!"},
                    {"command_raid","[RPEvents]: {0} Has Called a Raid on {1}!"},
                    {"command_raidfinish","[RPEvents]: The Raid on {0} is Over."},
                    {"command_arrest","[RPEvents]: {0} Has Called an Arrest on {1}!" },
                    {"command_arrestfinish","[RPEvents]: The Arrest on {0} is Over."},
                };
            }
        }
    }
}
