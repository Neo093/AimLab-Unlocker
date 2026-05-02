using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using System;
using System.Runtime.InteropServices;

namespace AimLabUnlocker;

[BepInPlugin("com.yourname.aimlabunlocker", "AimLab Unlocker", "1.0.0")]
public class Plugin : BasePlugin
{
    internal static new ManualLogSource Log;

    // Import Windows MessageBox for error reporting
    [DllImport("user32.dll")]
    public static extern int MessageBoxA(IntPtr hWnd, string text, string caption, uint type);

    public override void Load()
    {
        Log = base.Log;
        Harmony harmony = new("com.yourname.aimlabunlocker");

        try
        {
            // This line automatically finds and applies all [HarmonyPatch] classes in Patches.cs
            harmony.PatchAll();
            Log.LogInfo("AimLabUnlocker loaded successfully!");
        }
        catch (Exception e)
        {
            Log.LogError($"Patching failed: {e}");
            
            // Helpful popup if the game updates and breaks the mod
            MessageBoxA(IntPtr.Zero, 
                "AimLabUnlocker was unable to patch the game. The game version may have changed.", 
                "Mod Load Error", 0);
        }
    }
}