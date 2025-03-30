This mod allows for a VERY VERY basic text chat ingame instead of having to rely on Discord/etc. This is done very sloppily as I assume the devs will actually implement text-chat properly soon. This is done by "adding" a console command called say. By using that followed by your input the mod will capture your input and send all lobby participants a text message from Officer Bailey.

This will also produce the short notification on the side for user messages and will work with the whole lobby. Why Officer Bailey? No reason or maybe they're paid off it's a deep state secret ;)

I hope this helps, I know its not great but for now it's a quick and dirty fix I made for my friends and I so we dont have to keep alt-tabbing or if we can't VC. That said, it's open source so if anyone wants to contribute to make it better feel free!

HOW TO INSTALL AND USE:
1. Make sure you have MelonLoader installed and you have ran the game at least one time!
2. Drag DeepStateChat.dll from here into the Mods folder in the root of your game folder. (steamapps\common\Schedule I\Mods\)
3. Launch the game and enable the console (host) then simply use the console command ingame. (say Your Message)

Other stuff:
1. If a person's username is longer than 10 characters only the first 10 characters (or less) will be used to add their name to the message.
2. There is a hardcoded 2 second time delay between messages, this was because for some reason this would fire twice, I think its related to IL2CPP delegates but I dun know.
3. Yeah I tried changing Officer Bailey's name not possible right now but if you think you can fix that please feel free to contribute to this project. 
4. After installing MelonLoader you must run the game once before using this mod because MelonLoader does some initial configuration.
5. There will probably be bugs, if you find any let me know.

Known Bugs:
1. The console window doesn't close like normal when using the say command -- will look into fixing in future.
Fixed in 1.0.2 -- All text becomes lowercase -- Oops I forgot about that will fix in the future.

Changelog:
1.0.2:
Built in release mode
Fixed case being lost in sent or received messages.
Some groundwork to hopefully replace Officer Bailey's name with the player's name in the notification at least.


I can be reached on here or on discord: @Jumpman

Special Thanks to my testers and friends.


![S1IngameChatSS1](https://github.com/user-attachments/assets/74e410fa-cef1-4246-94fb-b5ffb4514666)
![S1IngameChatSS2](https://github.com/user-attachments/assets/03408048-5379-4167-bf7b-59dfe7dc1e1b)

