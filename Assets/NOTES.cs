/*
RPG? GAME HAS TO BE SETTED WITH A NAME AND VERSION

THINGS TO BE FIXED/DEVELOPED:
 - GOOD MOVEMENT
    - Walk
    - Run (consumes stamina over time)
    - Roll (consumes a little bit of stamina)
    - Slide (to slide under obstacles)(consumes a little bit of stamina)
    - Swim (Consumes Oxygen)
    - Climb (consumes stamina over time)
    - Teleport (through portals maybe?)

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
        where chests are hidden, adding an element of exploration to the game.
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



*/