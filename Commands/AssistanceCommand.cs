﻿using Rocket.API;
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
    public class AssistanceCommand : IRocketCommand
    {
        public static Main Instance;

        public List<string> Aliases
        {
            get
            {
                return new List<string>() {"a"};
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
                return "Call for backup!";
            }
        }

        public string Name
        {
            get
            {
                return "assistance";
            }
        }

        public List<string> Permissions
        {
            get
            {
                return new List<string>() { "rpevents.assistance" };
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
                UnturnedChat.Say("[RPEvents]: " + Main.Instance.Translate("command_assistance", caller.DisplayName), UnturnedChat.GetColorFromName(Main.Instance.Configuration.Instance.StartColor, Color.red));
            }

            UnturnedChat.Say("[RPEvents]: " + Main.Instance.Translate("command_assistance_specified", caller.DisplayName, message), UnturnedChat.GetColorFromName(Main.Instance.Configuration.Instance.StartColor, Color.red));
        }
    }
}
