using Rocket.API;
using Rocket.Core.Logging;
using Rocket.Unturned.Chat;
using Rocket.Core.Plugins;
using Rocket.Unturned.Commands;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

namespace coolpuppy24.rpevents
{
    public class RobCommand : IRocketCommand
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
                return "Show who's getting robbed!";
            }
        }

        public string Name
        {
            get
            {
                return "rob";
            }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>() { "rpevents.rob" };
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
            UnturnedPlayer player = command.GetUnturnedPlayerParameter(0);
            if (player == null) UnturnedChat.Say(caller, Main.Instance.Translate("player_not_found"));

            if (command.Length == null)
            {
                Rocket.Core.Logging.Logger.LogError("This command cannot be called from the console!");
                return;
            }
            else
            {
                UnturnedChat.Say(Main.Instance.Translate("command_rob", caller.DisplayName, player.CharacterName), UnturnedChat.GetColorFromName(Main.Instance.Configuration.Instance.MessageColor, Color.red));
                return;
            }

        }
    }
}
