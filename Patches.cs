using System;
using HarmonyLib;
using AimLab.Utility;
using AimLabUtilities;
using AimLab.Models.Economy;

namespace AimLabUnlocker
{
    /// <summary>
    /// EDITING GUIDE:
    /// To disable a specific patch, simply comment out the [HarmonyPatch] line above the class.
    /// To change a result, edit the '__result' variable inside the Prefix method.
    /// </summary>

    // --- SUBSCRIPTION PATCHES ---
    [HarmonyPatch(typeof(IdentityService), "IsUserSubscribed")]
    internal static class SubscriptionPatch
    {
        static bool Prefix(ref bool __result)
        {
            __result = true; // Set to true to bypass subscription checks
            return false;    // Skips original game logic
        }
    }

    // --- COSMETIC & SKIN PATCHES ---
    // This section forces the game to treat all skins and items as "Owned"
    
    [HarmonyPatch(typeof(CosmeticSettingsUtility), "HasSkin")]
    [HarmonyPatch(typeof(CosmeticSettingsUtility), "IsOwnedSkin")]
    [HarmonyPatch(typeof(CosmeticSettingsUtility), "OwnsArmSkin")]
    [HarmonyPatch(typeof(CosmeticSettingsUtility), "OwnsWeaponSkin")]
    internal static class GlobalSkinPatch
    {
        static bool Prefix(ref SkinOwnedResult __result)
        {
            __result = SkinOwnedResult.Owned; // Tells the game you own the skin
            return false;
        }
    }

    // --- ITEM OWNERSHIP PATCHES ---
    // Handles specific catalog items and strings
    
    [HarmonyPatch(typeof(CosmeticSettingsUtility), "IsOwnedItem", new Type[] { typeof(string) })]
    internal static class ItemOwnershipStringPatch
    {
        static bool Prefix(ref SkinOwnedResult __result)
        {
            __result = SkinOwnedResult.Owned;
            return false;
        }
    }

    [HarmonyPatch(typeof(CosmeticSettingsUtility), "IsOwnedItem", new Type[] { typeof(CatalogItem), typeof(bool) })]
    internal static class ItemOwnershipObjectPatch
    {
        static bool Prefix(ref SkinOwnedResult __result)
        {
            __result = SkinOwnedResult.Owned;
            return false;
        }
    }
}