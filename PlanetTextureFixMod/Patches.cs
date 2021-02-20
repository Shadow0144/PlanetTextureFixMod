using Harmony;
using Database;
using System;

namespace PlanetTextureFixMod
{
    public class Patches
    {
        [HarmonyPatch(typeof(SpaceDestinationTypes), MethodType.Constructor, new Type[] {typeof(ResourceSet)})]
        public class SpaceDestinationTypes_Patch
        {
            public static void Postfix(SpaceDestinationTypes __instance)
            {
                Debug.Log("Fixing planet textures...");

                __instance.IcyDwarf.spriteName = "icyAsteroid";
                __instance.SaltDesertPlanet.spriteName = "new_13";

                Debug.Log("...Planet textures fixed.");
            }
        }
    }
}
