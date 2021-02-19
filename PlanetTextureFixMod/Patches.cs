using Harmony;

namespace PlanetTextureFixMod
{
    public class Patches
    {
        [HarmonyPatch(typeof(Db))]
        [HarmonyPatch("Initialize")]
        public class Db_Initialize_Patch
        {
            public static void Postfix()
            {
                Debug.Log("Fixing planet textures...");

                // Enter code here

                Debug.Log("...Planet textures fixed.");
            }
        }
    }
}
