# WitchGameForSubmission

# WitchStoreGame

# Testing or Running app instructions:
On any android device (recommended)
{
Download and run the apk file named 'Witch_Storev0.2'
it will likely give multiple warnings and also possibly an error message however the app is still safe to install just isn't verified ignore these and run the app, press ok on the error messages and the app will be installed on the device.
There is much functionality not yet implemented but this will alow testing of the latest build version.
}
  
if using the unity editor
{
- Ensure that the 2022.3.12f1 version of the editor is installed with android packages.
- Clone the github repo
- Using unity hub press add project and select the parent folder
- Open the project
- Make sure that android packages are installed and that the emulator settings will allow touch screen emulation
- Press the play button.
}
Gameplay concept:

- The player buys stock.
- Customers come and buy this stock.
- Player can then afford to upgrade the store and buy more stock.
- Upgrades will then allow the player to create farms for certain items or craft specific potions.
- Customers may then come into the shop with problems that the player will have to craft a suitable potion to solve the problem.
- Customers will tip generously for custom items if it is suitable to solve their problem.
- Players can then buy expensive items to sell as well as more spell components, upgrades and cosmetic upgrades for their shop and character

---

Required features (mostly in order of priority){ - basic graphics (player needs to see the game)

    - view transitions (player needs to see the game)

    - player movement (Player needs to have a way of interacting without just buttons - use touch screen etc)

    - NPC basics{
        NPC Movement - will mostly be similar to player movement
        NPC randomization
        NPC spawning
        (Getting basic NPC functionality is essential to the playability of the game as well as allowing the player to have something to interact with)
        }

    - Coin handling/ saving (The main aim of the game is to gain coins making it important to get this working)

    - Inventory{
        Functionality
        User interface
        Items{
            Items within inventory
            Item UI
            Picking up Items/ packages of items
        }
    (Inventory is again one of the key features - though it might be complex is essential to implement)
    }

    - NPC checkout/ leaving feature (NPCs should leave the shop after a random amount of looking around or decide to buy something at stand at the checkout waiting to be served by the player then pay the player and leave)

    - Crafting potion/npc potion requesting (this is probably going to take a while to implement but is a feature that will be the most interesting aspect of the game - this is bordering on the nice to have list however as the game will work without this if I cannot implement it in time)

}

Additional features (That I most likely won’t have time to implement given the timeframe){

    - Crafting spells - spell book ( so that players don’t need to memorise how to craft potions)

    - Reputation system ( as an alternate form of progression bringing in more customers )

    - Upgrades ( to provide game progression)

    - Shop Upgrades ( to allow for farming and other additions)

    - An assistant that runs the shop when player is offline.

    - Minimum stock once where items will be kept in storage and new stock ordered to replace sold stock

    - Witch broom that will pick up any items dropped while the player is offline or packages that arrive.

    - Cosmetic Upgrades ( for players to customise their shop and character to their liking)

    - Achievements ( integrations with google play achievements )

    - Monetization? ( like a donation option? - usure will explore much later not a priority )

    - Anything else I come up with... ( just incase )

}

intial planning breakdown of tasks:{
using a 2d sprites and a grid layout I can use unity's inbuilt system to paint out the map using tile sprite instances

     using multiple camera objects I can easily change the priority of the different cameras to transition between views
     - this can be smoothed using unity's cinemachine plugin

     - Player movement: I can use Astar pathfinding paired with using Unity's new input system as well as touch inputs to move the pathfinding target to a screen position

     - NPCs: I need to create an object that will pathfind to random positions 'looking around the shop' then can easily add the ability to leave
     - for the NPC randomisation: if I create a few differnt outfit sprites that are white in colour I can easily recolour them randomly ussing an array of colours and sprites.
     - for spawning: using a parent game object I can then randomly instantiate a new NPC object at random intervals in the game scene

     - For coins: I can create an object that checks for collisions from the player and then access a separate coin counter script that is attched to the player object and accessed by a counter
     - as this variable is a single variable I can use unity's playerprefs to save it when its value is changed and laod it on the start of the game using only a few lines of code

     - For inventory I will use unity's scriptable objects to create a class for items as well as then create a scriptable object for the inventory that will hold and process these items. not sure how I will make the UI work for this yet I expect this is going to be really complicated
     - as for picking up items I can access a similar script to the coin however instead call an add item function and pass a corresponding item scriptable object

     - I will then modify the random relocation of the NPC destination object so that the NPCs hanve a random probability of going to a killzone that will remove them from the scene as well  
     - after this I'll repeat that process with a checkout area that will select a random item from stock to pick and buy so that when the player is standing at a desk area items will be removed and the player will recieve coins
}

the rest of the list I will deal with if I can get around to that as I don't think that I will get around to the rest
