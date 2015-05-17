using Rocket.Unturned;
using Rocket.Unturned.Commands;
using Rocket.Unturned.Player;
using System;

namespace ApokPT.RocketPlugins
{
    class WreckingBallCommand : IRocketCommand
    {

        public void Execute(RocketPlayer caller, string[] cmd)
        {

            string command = String.Join(" ", cmd);

            if (!caller.IsAdmin && !WreckingBall.Instance.Configuration.Enabled) return;

            if (!caller.IsAdmin && !caller.Permissions.Contains("wreck")) return;

            if (String.IsNullOrEmpty(command.Trim()))
            {
                RocketChat.Say(caller, WreckingBall.Instance.Translate("wreckingball_help"));
                return;
            }
            else
            {
                string[] oper = command.Split(' ');

                if (oper.Length >= 1)
                {
                    switch (oper[0])
                    {
                        case "confirm":
                            WreckingBall.Instance.Confirm(caller);
                            break;
                        case "abort":
                            RocketChat.Say(caller, WreckingBall.Instance.Translate("wreckingball_aborted"));
                            WreckingBall.Instance.Abort();
                            break;
                        case "scan":
                            if (oper.Length == 3)
                            {
                                WreckingBall.Instance.Scan(caller, oper[1], Convert.ToUInt32(oper[2]));
                            }
                            else
                            {
                                RocketChat.Say(caller, WreckingBall.Instance.Translate("wreckingball_help_scan"));
                            }
                            break;
                        case "teleport":

                            if (oper.Length > 1)
                            {
                                switch (oper[1])
                                {
                                    case "b":
                                        WreckingBall.Instance.Teleport(caller, true);
                                        break;
                                    case "s":
                                        WreckingBall.Instance.Teleport(caller, false);
                                        break;
                                    default:
                                        RocketChat.Say(caller, WreckingBall.Instance.Translate("wreckingball_help_teleport"));
                                        break;
                                }
                            }
                            else
                            {
                                RocketChat.Say(caller, WreckingBall.Instance.Translate("wreckingball_help_teleport"));
                                break;
                            }
                            break;
                        default:
                            try { WreckingBall.Instance.Wreck(caller, oper[0], Convert.ToUInt32(oper[1])); }
                            catch { WreckingBall.Instance.Wreck(caller, oper[0], 20); }
                            break;
                    }
                    return;
                }
                else
                {
                    RocketChat.Say(caller, WreckingBall.Instance.Translate("wreckingball_help"));
                }
            }
        }

        public string Help
        {
            get { return "Destroy everything in a specific radius!"; }
        }

        public string Name
        {
            get { return "wreck"; }
        }

        public bool RunFromConsole
        {
            get { return false; }
        }
    }
}
