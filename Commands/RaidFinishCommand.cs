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
    public class RaidFinishCommand : IRocketCommand
    {
        public static Main Instance;

        public List<string> Aliases
        {
            get
            {
                return new List<string>() { };
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
                return "Finishes the raid on an area";
            }
        }

        public string Name
        {
            get
            {
                return "raidfinish";
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

            if (command.Length == null)
            {
                Rocket.Core.Logging.Logger.Log("This command cannot be called from the console!");
                return;
            }
            else
            {
                UnturnedChat.Say(Main.Instance.Translate("command_raidfinish", message), UnturnedChat.GetColorFromName(Main.Instance.Configuration.Instance.RaidFinishMessageColor, Color.red));
                return;
            }

        }
    }
}
