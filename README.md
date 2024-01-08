# WitchGameForSubmission

# Testing or Running app instructions:
On any android device (recommended)

    - Download and run the apk file named 'Witch_Storev0.2'
    - The APK will likely give multiple warnings and also possibly an error message however the app is still safe to install just isn't verified ignore these and run the app, press ok on the error messages and the app will be installed on the device.
    There is much functionality not yet implemented but this will alow testing of the latest build version.

  
if using the unity editor

    - Ensure that the 2022.3.12f1 version of the editor is installed with android packages.
    - Clone the github repo
    - Using unity hub press add project and select the parent folder
    - Open the project
    - Make sure that android packages are installed and that the emulator settings will allow touch screen emulation
    - Press the play button.


# Gameplay concept:

- The player buys stock.
- Customers come and buy this stock.
- Player can then afford to upgrade the store and buy more stock.
- Upgrades will then allow the player to create farms for certain items or craft specific potions.
- Customers may then come into the shop with problems that the player will have to craft a suitable potion to solve the problem.
- Customers will tip generously for custom items if it is suitable to solve their problem.
- Players can then buy expensive items to sell as well as more spell components, upgrades and cosmetic upgrades for their shop and character

## commit history
Due to some issues with github and unity I instead needed to use other means to doccument my progress so I had to use the unity remote which I unfortunatly don't have access to however I did use text files to doccument my progress.
1. **Adding sprites**
2. **Map Design and view transitions**
    - Inital design of shop
    - Importing Cinemachine extension
    - Movement of cameras around the map using Unity engine UI components and Cinemachine 
![image](https://github.com/Rainbow-Turtle1/WitchGameForSubmission/assets/72671611/2916ad11-a906-489a-9d38-9707c0409b7d)![image](https://github.com/Rainbow-Turtle1/WitchGameForSubmission/assets/72671611/0f854262-29f0-4f7f-a5e0-22bb094aa565)![image](https://github.com/Rainbow-Turtle1/WitchGameForSubmission/assets/72671611/6c43875e-9084-4c36-bb1d-07c49219b4ad)

4. **Updating sprites using new spritesheet**
    - The sprites looked bad and were imported poorly so the compression would occasionally mess it up so I created a sprite sheet that I subdevided and imported using consistent import settings.
    - I also modified the cameras further and created the graphics and GUI of the cauldron and computer - initailly tried to use an invisible button that would activate the cauldrons camera object and GUI object parent
  
5. **Importing and using aStar pathfinding**
    - Created the target sprite for the player, originally this was the child of the player object and then I realised that it would be more effective as a seperate object.
    - here created a click detection system that would allow the player to change the priority of the camera and set a array of objects as active or inactive (shown in presentaiton)

6. **Movement**
    - Created the movement script for the target sprite for the player.
    - Added animations to make the player waddle around (made deliberatly by changeing x and z rotations so it can be reused for the NPCs)
    - Created the animation management script for the player as well as animator controller.
    - Began importing assets for NPC sprite sections.

6. **NPCs**
    - Created the movement script for the target sprite for the NPCs.
    - Added animations to make the NPC waddle around (reused from player)
    - Created the randomisation scripts for the NPCs so that when they start on the scene the appearance is randomised.
    - Created prefab for NPC object and Spawner that spawns at random intervals unless there are X amount of NPCs allready present in the scene.

7. **Cleanup/bugfixing**
    - Changed some animations, added a camera animation that would play on start so that the game would fade in instead of appear after the made by unity screen.
    - Added more options to the colour randomiser for the NPCs so that they are less likely to spawn the same thing.
        - after implementing this there were 8 skintones, 4 hair options, 4 top options with 22 colour options and 4 bottom options with 14 colours - totaling to (8x4x22x4x14)/4 approximatlet 39,000 combinations.
    - Added more animations as well as the sprites for the vertical wall peices, because there were none befor players and NPCs would pathfind in and out the side of the shop. 

8. **NPC Leaving**
    - in order to further test the NPCs I made the numebr of NPCs able to be active in the scene at one time higher as well as creating a chance that they would leave the shop after some time so I could make sure the randomizer was working well.
    - I planned to implement this later but instead decided to implement it now.
  
9. **Coins**
    - Implemented hte coin object.
    - Implemented the coin counter.
    - Implemented the coin saving feature.

10. **Items and inventory**
    - Implemented the Items
    - began implementing the inventory however did not work

11. **Inventory UI**
    - Took ages to implement but eventually got it to show the items in the inventory correctly

12. **Inventory SO and Add Item**
    - finished the implementaion of AddItem and the inventory.

13. **Item GameObject for collecting**

15. **AddItem Bugfix**
    - AddItem did not work so I attempted to fix it.
    - this bugfgix was not yet enough though it did now work items were not stacking correctly

16. **AddItem Stacking Bugfix**
    - Stacking Items Bug fix started and created more bugs however I fixed all of these (it took a week)

17. **Add Item effect**
    - Created and object that would show when the user picked up an item using a prefab with an animation.

18. **Add Item effect for coins**
    - Expanded the AddItem to work with the coins too using the prefab.

19. **NPC checkout**
    - Unfortuantly while I started implementing this I didn't manage to finish it and it isn't included in the final commit due to it not yet being functional.

# For examination:
## Initial Planning Breakdown of Tasks
(Mostly in order of priority)
1. **Map Design**
   - Use Unity's built-in system for a 2D sprite grid layout.
   - Implement tile sprite instances to paint the map.

2. **View Transitions**
   - Utilize multiple camera objects with Unity's Cinemachine plugin for smooth transitions.

3. **Player Movement**
   - Implement A* pathfinding and Unity's new input system for player movement.

4. **NPCs**
   - Develop NPC object with pathfinding for random movement and leaving the shop.
   - Randomize NPC appearance using different outfit sprites and recoloring.

5. **Coins**
   - Create an object to check collisions with the player for coin collection.
   - Implement PlayerPrefs for saving and loading the coin count.

6. **Inventory**
   - Use Unity's scriptable objects for item and inventory classes.
   - Develop a scriptable object for the inventory to process items.

7. **NPC Checkout**
   - Implement a checkout area where NPCs buy random items from stock, generating coins.

**UML Style Diagram of task analysis:**
![image](https://github.com/Rainbow-Turtle1/WitchGameForSubmission/assets/72671611/45bc8dea-8d6c-47e5-b5a8-ddb4490df5f7)

## Additional Features
- Crafting Spells
- Spell Book
- Reputation System
- Upgrades (Game Progression)
- Shop Upgrades (Farming and Additions)
- Assistant for Offline Shop Management
- Minimum Stock System
- Witch Broom for Offline Item Pickup
- Cosmetic Upgrades for Shop and Character
- Achievements (Google Play Integration)
- Monetization Options (Donation, etc.)

the rest of the list I will deal with if I can get around to that as I don't think that I will get around to the rest

## Testing 

The majority of testing I did for this project was iterative testing where I would test features during or after implementing them. This is also in order that they were implemented. 


1. **Map Design**
   - Didn't really have any issues other than that I didnt create a vertical wall sprite so i needed to copy and paste the horizontal one and change its scale on the X axis. Testing didn't reveal much else.

2. **View Transitions**
   - Iterative testing revealed some bugs with the buttons so I created a gameobject for screens of buttons and set them as inactive whenever the active camera is changed

3. **Player Movement**
   - a* pathfinding had a bug after relocating the movement target for the player. Essentially as it was a child of the player object it would sometimes also move the entire player object so the solution was to have the target objecty as a seperate object. I used the unity input actions to create a raycast that would take the screen postition of whatever was pressed and move the object to this screen position. Then I also set up an animation that would not loop so the player can see where they had pressed on.

4. **NPCs**
   - Using a* pathfinding and a destination relocate script I easily implemented a script that would pick random destinations to relocate the destination within the coordinates of the shop.
   - Randomize sprites/recoloring. ~ for this I created multiple child objects using the same randomization script that would allow me to edit a array for outfit sprites to be chosen from randomlyy as well as an array of colours.
   - (this is discussed further in my presentation)
    ![image](https://github.com/Rainbow-Turtle1/WitchGameForSubmission/assets/72671611/4144aaec-c649-411b-9563-8fcd6f5b779d)
    ^the object and children
    ![image](https://github.com/Rainbow-Turtle1/WitchGameForSubmission/assets/72671611/259a18cf-5ed8-4757-a7cf-2b5402e29a17)
    ^the scripts showing the array on the bottoms of the outfit that was reused to create multiple skin tones, tops colours and hair colours for each NPC that spawns.

5. **Coins**
   - Testing revealed no bugs - I tested this iterativly on desktop and also two differnt android devices with differnt operating systems to make sure that it would save and load correctly

6. **Inventory**
   - Extensive testing showed that while testing through unity would allow the inventory to save this wouldnt work when built onto a device.
     
7. **NPC Checkout**
   - Didn't manage to finish implementing this enough to test.
     
# Use of Object Oreinted programming principles:

1. Code Refactoring:
Throughout the development process, there was continuous refactoring to improve the clarity, efficiency, and maintainability of the codebase. Notable instances of code refactoring include:

    - Animation Management:
      Initial animation scripts underwent refactoring to improve readability and modularity. By encapsulating animation-related logic into a dedicated manager, the code became more extensible for future additions or modifications. I wanted to make sure that it was able to support more animations later and be reused for both NPCs, players and future additions like potentially animals and upgrades.
      
    - Sprite Onclick events/Camera Transitions:
      Refactored camera transition logic to handle screen button interactions more robustly. This refactoring ensured a smoother transition between different views within the game.
      
2. Code Reuse:
Code reuse played a crucial role in achieving scalability and reducing redundancy. Key examples of code reuse include:

    - Randomization Scripts:
      A deliberatly versatile randomization script was created for NPCs, enabling the dynamic generation of randomized appearances. This script was reused for different NPC elements, fostering a flexible and efficient approach to character design.

    - Add Item System:
      The Add Item system, responsible for collecting items and triggering corresponding effects, was designed as a modular component. It allowed for easy integration with different types of items, promoting code reuse and extensibility.

    - Animation Management and animations:
      Animation scripts were reused for both the NPCs and the Player character.

    - Item Objects
      Item objects were reused for collection as well as use in the inventory UI scripts and the UI pickup prefab effect.

    - NPC Object Prefabs.
      The NPC object prefabs are how I created a multitude of different.

    - All other prefabs.
      Seen as there were over 30 differnt prefab assets it would waste time to list them all but all prefabs that were instanciated in the scence reused the same code and properties.

    - Buttons and Sprite on press script.
      The buttons to navigate use differnt but similar scripts that are created by unity for use in UI I used similar properties to make them all function in a similar way. In addition to this when I created sprite onpress scripts I made them function very similarly to the buttons in the scene by enabling and disabling lists of sprites and changing the priority of the cinemachine Virtual Camera as I am also doing with the buttons.

3. The inventory system was created with scriptable objects employing multiple OOP principles. InventoryItem and InventoryManager classes were created for the item-related functionality. Not only promoting code reuse but also encapsulation and abstraction, ensuring a modular and maintainable inventory system.

4. A* Pathfinding Implementation:
    - The implementation of A* pathfinding for player and NPC movement aligns with OOP principles of encapsulation as well as abstraction. The PathfindingManager encapsulates the A* algorithm, which provides a clean interface for navigation. Abstraction is achieved through the use of interfaces, ensuring a more maintainable and easily extendable system.
  
These are the main instances where the core OOP principles were employed however the use of prefab objects also is a good example of encasulation and abstraction as they all contain the code neccicarry and are reused in multiple instances (there are too many for me to list them all it would waste the time of both myself and examiner) in addition to thes object there are probably other instances I kept it as a high priority throughout the devleopment process.

# Further Expansion, future plans and Additional features implementation planning

Given more time on this project I would have liked to implement the NPC checkout as well as the additional features list, however due to the timeframe for the project as well as the amount of time I needed for the inventory implementation and UI for inventory I was unable to complete the full list of features that I originally planned. Having allready provided the list of feature that I intended to implement and knowing from my presentation what features I managed to implement successfully it is simple enough to know what my future plans are for this project however I will reiterate that here anyway. 

**Future plans**
- NPC checkout
      - Using the same method as the NPC leave feature combined with a randomly selected inventory item and some if conditions that require the player to be on the other side of the serving desk I can make the NPCs able to checkout.
- Inventory Saving
      - Originally I thought that as this was a scriptable object it would save on build in the same way that it does in the editor however this inst the case and I will need to save its state somehow, my thoughts are to create and save an array and load it on start.
- Ordering New stock
      - Using the computer I will allow the player to order new stock to sell to NPC customers.
- Crafting Spells
      - I will need to first make sure that the inventory is viewable and interactable from the cauldrons UI, as can be seen in the demo the UI component is allready there but not yet functional. Using more scriptable objects I think this will be possible.
- Advanced checkout/ potion buying
      - I will create a system where NPCs have a chance of spawning in with a problem that needs to be solved by the player with a potion. Depending on the potion given to the NPC they will give a larger or smaller amount of coins as a tip. I'll do this using a JSON with the problem and their responses to differnet solutions that will be imported by the NPC's request script. 
- Spell Book
      - Mostly this requires alot of graphic design and some GUI intergration - shouldn't be 
- Reputation System
      - Using the outcome from the potions and the problem they are solved I will add a star system that can be viewed on the computer (almost like a google review rating) 
- Upgrades (Game Progression)
      - Using some different variables to modify the game I can allow the player to upgrade.
- Shop Upgrades (Farming and Additions)
      - This will be a new system and may take some time but having objects that spawn in around a certain object after it is bought for the shop will be a good start.
- Assistant for Offline Shop Management
      - In order to make it seem like the shop has been managed by the assistant I will take into account the amount of time the player was offline for and remove X amount of items from the inventory and leave a coin for each one of those items at the desk when the player returns. When the player returns they will see a number of coins at the desk for them to collect as well as notice that the inventory has lost the items. I could also add a report clipboard for when the player returns to let them know about changes to the stock.  
- Witch Broom for Offline Item Pickup
      - If the player was expecting a delivery it will allready be in thier inventory when they return instead of in a package.
- Cosmetic Upgrades for Shop and Character
      - Will create an index for item components and colours so that they will be easy to save or add more.
- Minimum Stock System
- Achievements (Google Play Integration)
      - Requires further examination.
- Monetization Options (Donation, etc.)
      - Requires further examination.
  





