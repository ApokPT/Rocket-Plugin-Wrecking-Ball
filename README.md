# Wrecking Ball
### Destroy stuff in the server to clear lag

This addon allows you clear stuff in a defined radius using filters


## Available Commands
Command | Action
------- | -------
/wreck [filter] [radius]				| Creates new items destruction list
/wreck confirm							| Confirms list destruction
/wreck abort							| Aborts list destruction
/wreck scan [filter] [radius]			| Scan for [filter] in [radius] and list
/wreck teleport [b/s]					| Teleports caller to the next [b] (barricade) [s] (structure) +200m away


## Available Filters
Filter | Element
------- | -------
b				| Bed
t				| Trap
d				| Door
c				| Container
l				| Ladder
w				| Wall / Window
p				| Pillar
r				| Roof / Hole
s				| Stair / Ramp
g				| Guards (Barricades / Fortifications)
i				| Illumination / Generators / Fireplaces
a				| Agriculture (plantations / platers)
v				| Vehicles
*				| Everything except Zombies
z				| Zombies (killing too many zombies at once, crashes the server)


## Available Permissions
Permission | Action
------- | -------
wreck				| allow caller to wreck stuff


## Other Options
Option | Action
------- | -------
Enabled								| Enables and disables the addon (does not apply to admins)


## Todo List:
* I don't know what else to add