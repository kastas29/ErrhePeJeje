/*
RPG? GAME HAS TO BE SETTED WITH A NAME AND VERSION

PLACES I WANT THE GAME TO HAVE
 - Desert
 - Plains
 - Flower Forest
 - Forest
 - Dark Forest(?)
 - Beach
 - Mountains

THINGS TO BE FIXED/DEVELOPED:
 - GOOD MOVEMENT
    - Walk
    - Run (consumes stamina over time)
    - Roll (consumes a little bit of stamina)
    - Swim (Consumes Oxygen)
    - Climb (consumes stamina over time)
    - Teleport (through portals maybe?)

SKILLS:
    I would like to have passive skills, not combat ones. THis refers to abilities such as:
 - Agility (not affected by slowness of sand for example)
 - Dexterity (To pick up people pockets)
 - Construction: The player is able to create more effective buildings such as storages or tools.
 - LockPicking: They can access hidden areas, unlock doors, and disarm traps, granting access to valuable treasures or shortcuts.
 - Linguistics: The character is a polyglot, skilled in multiple languages. They can communicate with various NPCs and decipher ancient texts or cryptic messages, providing valuable insights and uncovering hidden secrets.
 - Stealth: The character is adept at moving silently and remaining undetected. They can sneak past guards, eavesdrop on conversations, and perform covert actions without alerting others.

 - Items
    - Simple items: These are basic items that do not have any special attributes or effects.
      Examples include things like keys, notes, or other quest-related items that the player needs to collect.
      These items might not have any gameplay-related attributes, but they can still be important for advancing
      the story or unlocking new areas.
    - Weapons: Weapons are items that the player can use to deal damage to enemies.
      Each weapon could have different attributes such as damage, attack speed, and range.
      Some weapons might also have special effects like poison or stun.
    - Armor: Armor items provide the player with protection from enemy attacks.
      Each piece of armor could have different attributes such as defense, resistance to specific types of damage,
      and weight (which could affect movement speed or other attributes).
    - Consumables: Consumable items are items that the player can use to gain temporary benefits.
      Examples include potions that restore health or mana, food that boosts the player's stats for a limited time,
      or other items that provide a temporary bonus.
    - Crafting materials: These items can be used to craft other items or equipment.
      Each crafting material could have different attributes such as rarity, difficulty to obtain,
      and the types of items that can be crafted using it.
    - Quest items: These items are specific to certain quests and may have unique attributes or effects.
      Quest items could be used to solve puzzles or unlock new areas of the game.
    - Miscellaneous items: These are items that don't fit into any other category but could still have
      their own unique attributes or effects. Examples might include things like keys that unlock specific doors or chests,
      or items that allow the player to interact with the environment in unique ways.

 - QUESTS -> Implementing simple quests that the player can complete to progress
             the story or earn rewards can add depth to your game without making it too complicated.
             You could start with straightforward quests like "collect 10 mushrooms" or
             "deliver a package to a specific NPC", and expand on them later.
    - NPC who gives quests
    - NPC Quests States
        Idle State: The default state for an NPC. In this state, the NPC is simply standing in place and can be interacted with by the player.
        Offer Quest State: When the player interacts with an NPC who has a quest available, the NPC will transition to this state. In this state, the NPC will present the player with the details of the quest and give them the option to accept or decline.
        Active Quest State: If the player accepts the quest, the NPC will transition to this state. In this state, the NPC will provide any additional information the player needs to complete the quest and will remain in this state until the quest is completed or abandoned.
        Complete Quest State: When the player completes the quest, the NPC will transition to this state. In this state, the NPC will congratulate the player and provide any rewards associated with completing the quest.
        Abandoned Quest State: If the player abandons the quest, the NPC will transition to this state. In this state, the NPC will express disappointment or frustration with the player and may refuse to offer additional quests until the player has completed the abandoned quest or taken some other action to make amends.
    - Rewards balanced to the difficulty level of the quest

 - NPCs TYPES
    - Quest-Giver
    - Vendors
    - Trainers
    - Guards
    - Friendly NPC

 - ENEMIES
    - Add critical chances both to the player and the enemy
    - Add combos? (bored or tiring to do tbh)
    - Particle effects on spawn or hit and death
    - Variety: First, you'll want to create a variety of different enemies that pose different challenges for the player.
      These might include enemies with different types of attacks, strengths and weaknesses, or behaviors.
    - Behaviors: Enemies should behave in a way that makes sense for their type. For example, some enemies might be more
      aggressive and charge the player, while others might be more cautious and try to stay at a distance.
      Some enemies might have special abilities, such as the ability to summon allies or launch ranged attacks.
    - Difficulty: The difficulty of enemies should be balanced to provide a challenge without being overwhelming.
      This can be achieved by adjusting their health, damage output, or other attributes based on the player's level or equipment.
    - Rewards: Finally, defeating enemies should provide the player with rewards that make the effort worthwhile.
      This could include experience points, in-game currency, or items that can be used for crafting or other purposes.

 - LOOTING
    - The player might need to use a specific item or ability to unlock it.
        Additionally, the player could find treasure maps or clues that lead them to specific locations
        where chests are hidden, adding an element of exploration to the game. Copy as many quest types as possible from sea of thieves or teso
    - Lootable enemies: One of the simplest ways to incorporate loot into your game is to allow players to collect items from defeated enemies. This can be done by having enemies drop items at random intervals or by having a chance to drop specific items based on their type or difficulty.
    - Chests: Chests can be used to provide players with more valuable loot or rare items that are not found on enemies. These could be placed in specific locations throughout the game world, such as hidden rooms, dungeons, or at the end of boss battles.
    - Interactable objects: Other objects in the game world can also be used as loot sources. For example, players might find valuable resources by mining rocks or chopping down trees, or they might discover hidden treasure by interacting with specific objects in the environment.
    - Treasure hunting: You could also create mini-quests or challenges that require players to search for hidden treasure or loot. For example, players might need to solve a puzzle or complete a platforming challenge in order to access a hidden area with valuable items.

 - FISHING:
    - Fishing Spots
    - Fishing Gear as rods and baits
    - Fishing Mingames

 - CHARACTER CUSTOMIZATION
    - Giving the player the ability to customize their character's appearance or equipment can make the game
      more engaging and provide a sense of ownership. You could start with a few simple customization options and add more later.





 - EMOTES
    Hide in a barrel
    Backflip
    Frontflip (?)
    I NEED MORE IDEAS PLEAASE


/////////////////////////////////////////////////////
/// MODDABLES MODS OVER MODIFICATIONS OF THE GAME ///
/////////////////////////////////////////////////////
Things that could be moddable:
 - Player Cosmetics
 - UI (Display dmg done / received, modify existent UI position or smth like this)
 - New Levels (?)
 - Override existing textures (modify tiles)
 - Override audio/sound/music


//////////////////
///   STORY    ///
//////////////////

Title: "The Enchanted Cafe Catastrophe"
In a half-fantasy, half-real world, there exists a bustling town named "Harmonyville,"
where mystical beings and ordinary humans coexist peacefully. Amidst the cobbled streets
and quaint shops, lies a hidden gem: "The Enchanted Cafe." This whimsical cafe is renowned
or serving the most extraordinary and magical drinks and dishes, delighting all who visit.
However, one fateful morning, an accidental collision of two ancient artifacts occurred
inside the cafe's kitchen – a magical hourglass and a mysterious jar of rare spices.
The resulting explosion of magical energy sent a shockwave throughout Harmonyville,
infusing the town's everyday items with enchantment and creating bizarre combinations.
Ordinary utensils sprouted wings, brooms gained the ability to teleport, and candles
developed the power to speak.
The townspeople are bewildered, and chaos ensues as the enchanted items create a series
of absurd problems. Customers at the cafe are being served floating teacups, sneezing
pastries, and color-changing ice creams. Moreover, the enchanted items have escaped the cafe,
spreading their antics throughout the town.
The main problem: The enchanted chaos must be resolved before it spreads beyond Harmonyville
and becomes irreversible. If left unchecked, the enchanted items could jeopardize the delicate
balance between fantasy and reality, leading to even stranger and potentially dangerous consequences.
The solution: A group of unlikely heroes, comprising a curious street urchin, a reclusive potion master,
a clumsy talking candlestick, and an adventurous baker with a magical rolling pin, set out on a quest
to retrieve the hourglass and the spice jar. Their mission is to reverse the accidental collision and
bring everything back to normal.
Throughout their journey, the heroes must face comical challenges and puzzles, utilizing the
enchanted items' peculiar powers to overcome obstacles. For instance, they might use the talking
candlestick to negotiate with enchanted brooms guarding the artifacts or concoct potions with the
help of the flying teacups.
The game unfolds as an RPG with humorous dialogue, quirky characters, and unexpected twists,
showcasing the players' ability to think creatively to solve problems. Instead of the typical
"save the world" scenario, the players' goal is to restore harmony to their whimsical town and
reverse the absurd enchantments while navigating through an amusing and unpredictable adventure.

///
/// NPCS AND LITTLE TOWN FEATURES
/// 
Quest NPCs:
Archibald Quibblepuff: An eccentric wizard who accidentally caused the artifact collision. He provides valuable clues and advice to the heroes, but his quirky nature often leads to more confusion.
Gertrude Whimsybrook: The head chef of the Enchanted Cafe. She feels guilty for the chaos caused and seeks help in gathering the ingredients needed to concoct a potion that can reverse the enchantments.
Mortimer Snickersnack: The mischievous talking candlestick who escaped the cafe. He holds vital information about the artifacts and their whereabouts but enjoys playing tricks on the heroes.
Gwendolyn Goldenfluff: A kind-hearted fairy who offers assistance with deciphering clues and navigating through the mystical forest where the artifacts are hidden.
Captain Blunderbeard: The valiant but somewhat clueless leader of the town guard. He assigns the heroes to various tasks but often confuses the severity of the enchanted situations.
Madame Esmeralda: A fortune-telling cat with a penchant for speaking in riddles. She aids the heroes by offering cryptic hints about the artifacts' locations.
Professor Ignatius Puddlefidget: A brilliant but absent-minded scholar who specializes in magical artifacts. He provides research materials to help the heroes understand the consequences of the collision.
Marigold Buttercup: The town's chief gardener who needs help rescuing her enchanted plants, which have started singing loudly at midnight and causing sleepless nights for the villagers.
Wilbur Wafflefoot: A shy young baker who accidentally enchanted his bakery's bread, resulting in loaves that have grown legs and run away. He seeks assistance in catching them.
Lady Penelope Whifflebottom: An elegant aristocrat who needs help recovering her prized collection of enchanted jewelry that has scattered across the town.
Vendor-type NPCs:
Fizzlepop Twigglespark: A goblin merchant selling an assortment of peculiar magical trinkets, like hats that turn into squirrels and self-dancing shoes.
Bumbleberry Bumblebee: A quirky beekeeper selling jars of enchanted honey that makes food levitate for a few seconds when drizzled on top.
Grizzletoe Ironforge: A grumpy dwarf blacksmith selling talking swords and flying hammers, albeit they argue with potential buyers over their worth.
Delilah Spellbinder: A mystical artist selling enchanted paintings that come to life, depicting humorous scenes of mythical creatures engaging in everyday tasks.
Tinker McSparkles: An enthusiastic tinkerer selling mechanical pet rocks that do nothing but wiggle their eyebrows and occasionally sneeze.
Wanda Wobblesprocket: A fortune-teller with a twist, selling magic eight balls that answer questions with puns and riddles instead of clear answers.
Percival Puddingbottom: A jovial confectioner selling enchanted sweets that change flavors with every bite, leaving customers guessing what they're eating.
Petunia Fluffernutter: A cuddly stuffed animal vendor who swears that her plushies have a secret society at night but can never provide proof.
Oliver Oglethorpe: A fisherman selling fish that sing sea shanties while being cooked.
Horace Hootenanny: A bard selling enchanted musical instruments that play random tunes, causing quite the cacophony.
Amusing Village Features:
The Talking Fountain: A majestic fountain in the town square that shares cheesy jokes and riddles with passersby.
The Everchanging Rainbow Bridge: A magical bridge that changes colors based on the mood of the last person who crossed it.
The Upside-Down House: A house where the rooms are upside down, and furniture is fixed to the ceiling, making for a hilarious navigation experience.
The Ticklish Tree: A tree that giggles uncontrollably when someone tries to climb it.
The Quacking Garden: A garden where all the plants make various animal noises, giving it a lively and amusing atmosphere.
The Peculiar Weather Vane: A weather vane on top of the town hall that spins wildly without any regard for the actual wind direction.
The Mirror Maze: A maze of mirrors that distorts reflections, leaving visitors hilariously bewildered.
The Endless Staircase: A seemingly normal staircase that never ends, leading to a humorous exercise in futility.
The Invisible Pet Park: A park where townspeople come to "walk" their invisible pets and engage in friendly imaginary pet competitions.
The Fortune Cookie Cart: A cart that sells fortune cookies with absurd and nonsensical fortunes that never seem to come true.


///
/// MAIN CITIES
///
Glimmerbrook: A mystical village hidden within an ancient forest, home to fairies, sprites,
and talking animals. Glimmerbrook is famous for its luminescent fireflies that illuminate the
village at night.
Misty Harbor: A coastal city with colorful houses built on stilts, known for its friendly
merfolk inhabitants. The locals love to host underwater music festivals, and visitors can
enjoy magical boat rides on floating water lilies.
Emberpeak: A mountainous town located at the foot of an active volcano. Emberpeak is home
to skilled blacksmiths who craft enchanted weaponry and armor.
Starfall Sanctuary: A serene village situated in the celestial valley, where the night sky
twinkles with an array of magical constellations. It's said that wishes made here have a
higher chance of coming true.
Whimsy Wallow: A peculiar village hidden inside a giant mushroom forest. The villagers are
known for their love of mushroom-themed festivities and whimsical hats.


*/