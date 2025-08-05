using BepInEx;
using GorillaTagModTemplate.Patches;

namespace GorillaTagModTemplate
{
    [BepInPlugin(Constants.PluginGuid, Constants.PluginName, Constants.PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private void Start()
        {
            HarmonyPatches.ApplyHarmonyPatches();
            GorillaTagger.OnPlayerSpawned(OnGameInitialized);
        }

        private void OnGameInitialized()
        {
            
        }
    }
}