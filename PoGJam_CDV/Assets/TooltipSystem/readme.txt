Thank You for purchasing the Tooltip System.

---------
Includes:
---------

GUIController.cs
Icon.cs
ObjectHandler.cs
TooltipHandler.cs

---------------------------------------
Updates:
---------------------------------------
[12/2/2012] 1.05
- Fixed a bug when hovering over another GameObject with the same Object Name
- Added the Tooltip Mouse Follow functionality to the GUIController.cs script
    - This allows the active_tooltip to follow the mouse position when hovering over a GameObject

[3/13/2012] 1.04
Updated GUIController to give GUI Icons priority over GameObject Icons
 - If you're hovering over both a GUI Icon and a GameObject the GUI Icon Tooltip will be drawn

Updated GUIController to not draw GUI Icon tooltips that don't contain an Icon name
 - Useful for when you don't want the Icon to contain any object

Fixed a bug that would generate the data more than once

[3/10/2012] 1.031
Added customization of the Tooltip Font and Font Sizes within the Unity Inspector for the GUIHandler
---------------------------------------

------------
Description:
------------

The purpose of this Tooltip System is to display GUI information of various elements in your game from information read in from various text files. Such as: GUI Objects (Items, HUD objects, etc), Skills / Spells / etc, GameObjects (meaning objects with an in game transform). Within the GUIController script, this is where the Icons are created, and displayed for generating particular Tooltip Detail information. Within the Icon script, this is used particularly for displaying icons, but mainly for being able to generate Tooltip Detail information. The ObjectHandler script is a very small script, but its main purpose is for collecting information from the various GameObjects the mouse is hovering over. Finally, the TooltipHandler script, this is where the work is done. Where the particular files are loaded in, details are read in from those files, and Tooltips generated for displaying that information.

---------
Controls:
---------

The Tooltips are generated by hovering the mouse over the particular Icons.

---------------------------------------
To install within your own application:
---------------------------------------

1) The first thing you should do is attach the GUIController script to your Main Camera. From here you can set the initial data values, such as the Icon Base texture, which represents the icon being displayed in an empty state. The Tooltip BGTexture, which is the texture that is displayed behind the displayed tooltip. By default, if it is empty it'll display a black tooltip background. You can also change the Font the tooltip is displayed in, as well as the sizes of the various lines in the tooltip. Finally, and most importantly, if you want colors within your tooltips, set the size and ColorValues for the colors you desire.

-----------------------------------------------

2) The second thing you must do before anything else is create the actual data to represent the Tooltip Details. This can be done yourself programatically within the various included text files, or manually. Meaning, within the item_info.txt file create the information there for representing data for items. Or the skill_info.txt for representing data for skills / spells / etc, or the object_info.txt file for representing data for in world Game Objects. The determination of what file is being used is based off of the type of IconType you use for your particular icons.

 - The syntax for the text files is fairly straight forward.
    ex) Adding an item to the item_info.txt file:
        [it]New Item[ColorValue]
        [id]#
        [s]Various Statistical Data[ColorValue]
        [d]Various Detail Data[ColorValue]
        <new line>

        The [it] represents the initialization of a NewItem, this token is only used in the item_info.txt file.
        The [ColorValue] is an integer (Real Number) of the ColorValue index of the color data on the GUIController script. 
            By default, if no color value is inputed, that line is set to white.
        The [id] is an unseen variable, but can be useful if you ever need to find or use a specific item quickly
        The [s] represents statistical data. Such as: values that rely on numbers; health, mana, armor, strength, etc..
            You can have as many [s] values as you need. The [ColorValue] can also be used here.
        The [d] represents detail data. Such as: Explanations of items, or items that have specific effects.
            You can have as many [d] value as you need. The [ColorValue] can also be used here.

        IMPORTANT: Always make sure you have a New Line after a created item, skill, or gameobject if there is more than one.
                   See the item_info.txt file for a complete example.

 - The only differences between the files is the [it], [sk], and [ob] values for creating a new item, skill or game object

-----------------------------------------------

3) Finally to get a new displayable Tooltip, you will need to create an Icon object within the GUIController. The Icon is what is used to determine where to get the proper data from. This Icon system can also be used to create other systems like an inventory, a hotbar system for skills, anything that needs anything relating to icons.

 - Icon(IconType type, Texture2D icon, Rect dimens, string name)
   or
 - Icon(IconType type, Texture2D icon_base, Texture2D icon, Rect dimens, string name)

   ex) Creating a new Skill icon
       Icon new_skill_icon = new Icon(IconType.Skill, IconBase, 
                             (Texture2D)Resources.Load("ObjectDetails/Skills/new_skill_icon"), Dimensions, "Skill Name");

       IconType.Skill      : is the Icon type, this changes depending on the type of Icon you're creating.
       IconBase            : is the base icon texture to use from the GUIController Script values (see first step)
       Resources.Load(...) : is where you load in the image to be displayed ontop of the IconBase texture
       Dimensions          : is the Rect object to represent the x, y, width, and height values of the Icon
       "Skill Name"        : is the name of the skill for the TooltipHandler to find in the skill_info.txt file

       IMPORTANT: Make sure the "Skill Name", "Item Name", or "GameObject Name" exists within the proper file (see second step)

       IMPORTANT: As you can see within the GUIController script, I have to add my created icons to the icons List. 
                  If you're building off the provided GUIController make sure to add your created Icon to the list.
                  This list is used for easy Icon manipulation.

       IMPORTANT: Also notice that there is only one Icon that contains the IconType.GameObject. 
                  The system is designed such that you only need one Icon for displaying Tooltips on in world objects.

For Displaying Transform Tooltip information (IconType.GameObject) you will need to attach the ObjectHandler script to the objects you wish to have tooltip displayed information. Also and very importantly, make sure your object within the Hierarchy contains "Object" within it's name. Once it is attached, go to the Object Handler (Script) properties within the inspector and set the Name value to what you wish the Tooltip system to look for within the object_info.txt file.

-----------------------------------------------
Please Contact: m11hut@gmail.com if you have any suggestions, bug reports or input.
A Reference To Chase Hutchens would be much appreciated if used in your project(s)
Also, please take the time to rate this Asset and give feedback, if you can. It is very much appreciated. :)