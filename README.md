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

