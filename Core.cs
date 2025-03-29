using HarmonyLib;
using Il2Cpp;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.UI;
using Il2CppSteamworks;
using MelonLoader;
using System.Globalization;
using UnityEngine;


[assembly: MelonInfo(typeof(DeepStateChat.Core), "DeepStateChat", "1.0.1", "Jumpman", null)]
[assembly: MelonGame("TVGS", "Schedule I")]
namespace DeepStateChat;

public class Core : MelonMod
{
    private HarmonyLib.Harmony JumpHarmony;
    public override void OnInitializeMelon()
    {
        LoggerInstance.Msg("DeepStateChat v1.0.1 by Jumpman. Loading...");
        JumpHarmony = new HarmonyLib.Harmony("com.SimpleIngameText");
        JumpHarmony.PatchAll();
        LoggerInstance.Msg("Mod Loaded - Use the 'say' command in the console to send messages!");
    }

    static long LastExecTime = Environment.TickCount64;
    [HarmonyPatch(typeof(ConsoleUI), "Submit")]
    public static class ConsoleSubmitPatch
    {
        public static bool Prefix(ConsoleUI __instance, ref string val)
        {

            if (string.IsNullOrEmpty(val.Trim()))
            {
                return true; //Empty command/someone hit enter, ignore and pass it on. 
            }

            if (Environment.TickCount64 - LastExecTime < 2000)
            {
                return true;
            }
            LastExecTime = Environment.TickCount64;

            if (val.ToLower().StartsWith("say", true, null))
            {
                if(val.Split(' ').Length > 1)
                {
                    //NotificationsManager.Instance.SendNotification(Player.Local.PlayerName, val.ToLower().Replace("echo", "").Replace("say", ""), new UnityEngine.Sprite());
                    string playername = Player.Local.PlayerName;
                    if (playername.Length > 10) playername = Player.Local.PlayerName.Substring(0, 10);
                    NPCManager.GetNPC("officerbailey").SendTextMessage(playername + ":" + val.ToLower().Replace("say", ""));
                    return false;
                }  
            }
            return true; 
        }
    }
    
}