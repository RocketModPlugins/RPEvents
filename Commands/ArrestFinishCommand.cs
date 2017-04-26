using Rocket.API;
using Rocket.API.Extensions;
using Rocket.Core.Logging;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Commands;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace coolpuppy24.rpevents
{
    public class ArrestFinishCommand : IRocketCommand
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
                return "Finishes arrest on a player";
            }
        }

        public string Name
        {
            get
            {
                return "arrestfinish";
            }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>() { "rpevents.arrest" };
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

            if (caller is ConsolePlayer)
            {
                Rocket.Core.Logging.Logger.Log("This command cannot be called from the console!");
                return;
            }
            else
            {
                UnturnedChat.Say("[RPEvents]: " + Main.Instance.Translate("command_arrestfinish", caller.DisplayName), UnturnedChat.GetColorFromName(Main.Instance.Configuration.Instance.FinishColor, Color.red));
                return;
            }

        }
    }
}
