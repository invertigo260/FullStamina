using BepInEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStam
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string ModGUID = "Invertigo.FullStam";
        private const string ModName = "FullStam";
        private const string ModVersion = "1.0.0.0";

        private readonly HarmonyLib.Harmony harmony = new HarmonyLib.Harmony(ModGUID);
        private static Plugin Instance;


        private void Awake()
        {
            BepInEx.Logging.ManualLogSource
                        // Plugin startup logic

                        mylogging = BepInEx.Logging.Logger.CreateLogSource(ModGUID);
            mylogging.LogInfo($"Plugin {ModGUID} is loaded!");

            if ( Instance == null )
            {
                Instance = this;
            }

            harmony.PatchAll(typeof(Plugin));

        }
    }
}