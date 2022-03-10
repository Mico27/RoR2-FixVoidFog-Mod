## FixVoidFog Mod for Risk of rain 2
- A mod that allows you to ride other members of your team.
- It is an extended version of the original mod https://thunderstore.io/package/xiaoxiao921/RideMe/ which allows more customization for other mods implementation.

## How it works
- Pressing interact will make the user mount.
- Pressing interact again while mounted will switch seat (if a mod implementad multiple seats. by default there's always one seat)
- Pressing Jump will make you unmount
- There is a config to ajust some parameters, such as jump height on unmount, disabling hurtboxes while mounted, etc.

## Configs
There are a bunch of additional config you can adjust:
- Specify a blacklist of which character cant ride or not be rideable
- You can specify the default offset of seats
- You can disable the rider's hitboxes while riding
- You can enable riding enemies
- etc.

## Example of implementation for other mods
- You can see an example of implementation here: https://github.com/Mico27/RoR2-TTGL-Mod/blob/main/src/ExternalHelper/FixVoidFogAddin.cs
- Here's a few properties/functions in FixVoidFog that allows implementation of other mods
- The property RiderBodyBlacklist is a list where you can add the Body's name you dont want to be able to ride other characters
- The property RideableBodyBlacklist is a list where you can add the Body's name you dont want to be able to ride on.
- The event OnGlobalSeatChange allows you to listen for when a rider entered/switched/exited a seat.
- The function RegisterRideSeats allows you to specify custom seats for a Body's name. If not specified, one default seat is created.
 - The RideSeat class that you instanciate for the RegisterRideSeats function have the following properties:
 - the Property Name is optional, mainly used for conveniance of identification
 - The property SeatTransform is the transform representing the seat, where the rider will be placed. This must be specified on instanciation.
 - The property SeatOwner is the owner of the seat, representing the rideable. Does not need to be initialized.
 - The property SeatUser is the current user of the seat, representing a rider. Does not need to be initialized.
 - The function callback PositionOffsetGetter which allows you to specify a position offset from the SeatTransform. Optional.
 - The property AlignToSeatRotation specifies if the rider will be forcefully aligned to the SeatTransform rotation.
 - The function callback RotationOffsetGetter which allows you to specify a rotation offset from the SeatTransform. Optional. AlignToSeatRotation must be set to true to be used.

- Other functions are also available to other mods that allows controls on the interactions, such as forcefully ejecting a rider with RiderController.CallCmdExitSeat().

## Some mods that have FixVoidFog implementation

- https://thunderstore.io/package/Mico27/TTGL_Mod/

[![](https://cdn.discordapp.com/attachments/194257452374425600/860789798372376576/unknown.png)]()

[![](https://cdn.discordapp.com/attachments/194257452374425600/860791583778668584/unknown.png)]()

feel free to ping/dm me with any questions / suggestion / complaints on the modding discord- @Mico27#0642

## Changelog

`1.1.0`
- Void update.

`1.0.2`
- Added the possiblity to add to the rider and rideable blacklist through config.
- Added the option to mount enemies through config.

`1.0.1`
- Engie's turrets and squid turrets are now rideable.

`1.0.0`
- Initial release