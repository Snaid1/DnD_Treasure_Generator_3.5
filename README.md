# DnD_Treasure_Generator_3.5
Treasure Generator for Dungeons and Dragons 3.5

I haven't worked on this in years and probably won't unless interest is expressed by others.

## TODO
-v 3.0 will have an additional source added to it.
- figure out how to have a multi-source item table while still keeping true to the tables presented in the source materials

## Changelog

v 2.2.1   27 April 2015 (2 hours later)
--------
-Fixed bug with Rod names not appearing correctly
-BUG1:Resolved? Due to the usage of different charts and different kinds of items, there is no way to truely make a multi-source treasure Generation at this time, however it now will choose the source every time items are generated (meaning 3 times for triple items) instead of all the same.


v 2.2.0   27 April 2015
--------
Streamlined, Consolidated, and updated code. All Magic Items now use charts to be generated.
Code now similar between Psionic and Magic Treasure, should allow for easier updating in the future. 
*BUG2:RESOLVED!
Fix for BUG1 planned for next version.


v 2.1.1   24 April 2015
--------
Added weapon damage type to charts so that weapons meet proper prerequisites for special abilities(ie. Slashing for Keen)
DMG Wonderous Items now use Charts similar to Psionic Items!

v 2.1.0   20 November 2014
--------
Added support for multiple source treasure generation
-can set percentage chance of using DMG or XPH as source for item generation
*BUG1: will select all items from only one source 
       in multi-source.
*BUG2: Discovered that on rare occasions, program ends up in infinite
       loop generating DMG armor & possibly DMG weapons.

v 2.0.0   19 November 2014
--------
Added Support for Psionic items!
-All Items and charts found in the Expanded Psionics Handbook
-Most Resources kept in Chart files found in Charts sub directory
New File Menu Added
-Export moved to be File Menu Item
-Exit menu item


v 1.0.3   15 June 2012
--------
Added Menu Items
-Export: same as the button from 1.0.2
-Options
--Keep: Doesn't clear list before adding next generation
--Freeze: no change to that list on generation
-Clear: clears lists

v 1.0.2
--------
Added Export Capabilities to export treasure list as text file

v 1.0.1
--------
Added support for "Triple Standard" treasure
Update to remove duplicate "No Coins"

V 1.0.0
--------
Initial Release
Includes Random Treasure from Dungeon Masters Guide