using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStam.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {

        [HarmonyPatch("LateUpdate")]
        [HarmonyPostfix]
        static void FullSprintPatch(ref float ___sprintMeter)
        {
        ___sprintMeter = 1f;
        }


    }
}
