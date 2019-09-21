using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteDangerousRGBLightingIntegration.Applications
{
    class CheckLines
    {

        private static string music = "\"event\":\"Music\", \"MusicTrack\":\"NoTrack\"";
        private static string underAttack = "\"event\":\"UnderAttack\", \"Target\":\"You\"";
        private static string hullDamage = "\"event\":\"HullDamage\"";
        private static string heatDamage = "\"event\":\"HeatDamage\"";
        private static string heatWarning = "\"event\":\"HeatWarning\"";
        private static string shieldOff = "\"event\":\"ShieldState\", \"ShieldsUp\":false";
        private static string shieldOn = "\"event\":\"ShieldState\", \"ShieldsUp\":true";
        private static string docked = "\"event\":\"Docked\"";
        private static string dockedMusic2 = "\"event\":\"Music\", \"MusicTrack\":\"Exploration\"";
        private static string dockedMusic = "\"event\":\"Music\", \"MusicTrack\":\"Starport\"";
        private static string undocked = "\"event\":\"Undocked\"";
        private static string dockGranted = "\"event\":\"DockingGranted\"";
        private static string kill = "\"event\":\"PVPKill\"";
        private static string supercruiseEnter = "\"event\":\"SupercruiseEntry\"";
        private static string supercruiseExit = "\"event\":\"SupercruiseExit\"";
        private static string dockingMusic = "\"event\":\"Music\", \"MusicTrack\":\"DockingComputer\"";
        private static string shutdown = "\"event\":\"Shutdown\"";

        public static string CheckLineContents(string line)
        {

            if (line.Contains(music) != true)
            {
                if (line.Contains(underAttack))
                {
                    return "underAttack";
                }
                else if (line.Contains(hullDamage))
                {
                    return "hullDamage";
                }
                else if (line.Contains(heatDamage))
                {
                    return "heatDamage";
                }
                else if (line.Contains(heatWarning))
                {
                    return "heatWarning";
                }
                else if (line.Contains(shieldOff))
                {
                    return "shieldOff";
                }
                else if (line.Contains(shieldOn))
                {
                    return "shieldOn";
                }
                else if (line.Contains(docked))
                {
                    return "docked";
                }
                else if (line.Contains(dockedMusic))
                {
                    return "dockedMusic";
                }
                else if (line.Contains(dockedMusic2))
                {
                    return "dockedMusic2";
                }
                else if (line.Contains(undocked))
                {
                    return "undocked";
                }
                else if (line.Contains(dockGranted))
                {
                    return "dockGranted";
                }
                else if (line.Contains(kill))
                {
                    return "kill";
                }
                else if (line.Contains(supercruiseEnter))
                {
                    return "supercruiseEnter";
                }
                else if (line.Contains(supercruiseExit))
                {
                    return "supercruiseExit";
                }
                else if (line.Contains(dockingMusic))
                {
                    return "dockingMusic";
                }
                else if (line.Contains(shutdown))
                {
                    return "shutdown";
                }
                else
                {
                    return "noAction";
                }
            }
            else
            {
                return "noAction";
            }
        }
    }
}
