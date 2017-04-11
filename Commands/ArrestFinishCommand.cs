using Rocket.API;
using Rocket.API.Extensions;
using Rocket.Core.Logging;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System;
using System.Collections.Generic;

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
            UnturnedPlayer player = (UnturnedPlayer)caller;

            string message = command.GetParameterString(0);

            if (command.Length == null)
            {
                Logger.Log("This command cannot be called from the console!");
                return;
            }
            else
            {
                UnturnedChat.Say(Main.Instance.Translate("command_arrestfinish", message));
                return;
            }

        }
    }
}
