## Fix Void Fog
The void fog had BypassArmor and BypassBlock damage type on it.
BypassArmor would also bypass HiddenInvincibility (used a lot for iframes on some survivors) as well as armor.
BypassBlock would bypass block procs.
I simply removed the damage type assigned to the damageInfo created by the fog (so by default its now Generic)

feel free to ping/dm me with any questions / suggestion / complaints on the modding discord- @Mico27#0642

## Changelog

`1.0.0`
- Initial release
