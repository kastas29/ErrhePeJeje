using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterStats : ScriptableObject
{
    public Sprite sprite;
    public new string name;

    public int current_hp;// Vida del personaje
    public int hp_max;
    public int current_stamina;// Sirve para correr
    public int stamina_max;
    public float stamina_regenVelocity;
    public int current_mana;//Sirve para usar hechizos
    public int mana_max;
    public float mana_regenVelocity;
    public int dmg;// daño del personaje.
    public int speed;// Aumenta la velocidad de nuestro personaje. Esta estadistica se obtiene de equipables y consumibles temporales.
    public int criticalDmg;// Daño que se suma al dmg cuando se acesta un ataque critico
    public int criticalPercent;// Porcentaje de acesatar ataques critics
    public int criticalResistance;//reduce el daño recibido de ataques criticos
    public int armor;//reduce el daño general recibido funciona como el DamagePercent
    public int shield;// Si el personaje fuera a recibir daño a la vida, se consume el daño como escudo y si el escudo baja a 0 se inflinge a la vida.
    public int shield_max;
    public int damagePercent;// aumenta el daño final porcentualmente. Por ejemplo si el calculo de daño final es 100 y tines 20 de esta estadistica el daño final aumentara un 20% siendo 120 el daño causado
    public int peso;// define si te puedes equipar un item o no, si se llena el peso no podras equipar otro item y tendras que subir la estadistica a los dark souls
    public int peso_max;

    public float dashDistance = 500;
    public float dashDuration = 0.2f;
    public float dashCooldown = 1.5f;

    // Attack things
    public float AttackCooldownMultiplier = 1f;



    // Elementos: funcionan igual que el dmg y el CriticalDmg. Si un arma tiene una runa del elemento fuego el FireMaestry se sumata al dmg
    public int FireMaestry;
    public int WaterMaestry;
    public int EarthMaestry;
    public int AirMaestry;

    //xp y nivel. La xp se puede conseguir a travez de misiones o matar enemigos.
    public int xp;
    public int xp_nextLevel;
    public int level;



    public enum role
    {
        WIZARD,
        ASSASSIN,
        WARRIOR,
        ARCHER
    }
}
