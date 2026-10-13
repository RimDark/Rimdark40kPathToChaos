using HarmonyLib;
using Verse;

namespace PathToChaos40k;

public class PathToChaos40kMod : Mod
{
    public static string CurrentVersion;

    public static Harmony harmony;

    public PathToChaos40kMod(ModContentPack content) : base(content)
    {
        harmony = new Harmony("PathToChaos40k.Mod");
        CurrentVersion = content.ModMetaData.ModVersion;

        harmony.PatchAll();
    }

    public override string SettingsCategory()
    {
        return "BEWH.PathToChaos.ModSettings.ModName".Translate(CurrentVersion);
    }
}
