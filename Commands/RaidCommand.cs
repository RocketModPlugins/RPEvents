using Rocket.API;
using Rocket.Core.Logging;
using Rocket.Unturned.Chat;
using Rocket.Core.Plugins;
using Rocket.Unturned.Commands;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using SDG.Unturned;
using Rocket.API.Extensions;
using UnityEngine;

namespace coolpuppy24.rpevents
{
    public class RaidCommand : IRocketCommand
    {
        public static Main Instance;

        public List<string> Aliases
        {
            get
            {
                return new List<string>() {};
            }
        }

        public AllowedCaller AllowedCaller
        {
            get
            {
                return AllowedCaller.Player;
            }
        }

        public string Help
        {
            get
            {
                return "Show who's getting raided!";
            }
        }

        public string Name
        {
            get
            {
                return "raid";
            }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>() { "rpevents.raid" };
            }
        }

        public string Syntax
        {
            get
            {
                return "<playername>";
            }
        }

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;

            string message = command.GetParameterString(0);

            if (command.Length == 0)
            {
                UnturnedChat.Say(caller, Main.Instance.Translate("command_raid_help"));
                return;
            }
            if (command.Length == null)
            {
                Rocket.Core.Logging.Logger.Log("This command cannot be called from the console!");
                return;
            }
            else
            {
                UnturnedChat.Say(Main.Instance.Translate("command_raid", caller.DisplayName, message, Main.Instance.Configuration.Instance.MinutesUntilRaid), UnturnedChat.GetColorFromName(Main.Instance.Configuration.Instance.MessageColor, Color.red));
                return;
            }
        }
    }
}
