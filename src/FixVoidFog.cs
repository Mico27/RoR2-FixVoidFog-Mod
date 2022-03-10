using BepInEx;
using RoR2;
using System;
using System.Security.Permissions;
using System.Security;
using MonoMod.Cil;

[module: UnverifiableCode]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]

namespace FixVoidFog
{
    [BepInPlugin(MODUID, MODNAME, MODVERSION)]
    public sealed class FixVoidFog : BaseUnityPlugin
    {
        public const string
            MODNAME = "FixVoidFog",
            MODAUTHOR = "Mico27",
            MODUID = "com." + MODAUTHOR + "." + MODNAME,
            MODVERSION = "1.0.0";
        // a prefix for name tokens to prevent conflicts
        public const string developerPrefix = MODAUTHOR;
        public void Awake()
        {
            try
            {
                IL.RoR2.FogDamageController.EvaluateTeam += (il) =>
                {
                    ILCursor c = new ILCursor(il);
                    c.GotoNext(
                        x => x.MatchDup(),
                        x => x.MatchLdcI4(0x42),
                        x => x.MatchStfld<DamageInfo>("damageType")
                        );
                    c.RemoveRange(3);
                };
            }
            catch (Exception e)
            {
                Logger.LogError(e.Message + " - " + e.StackTrace);
            }
        }
    }
}
