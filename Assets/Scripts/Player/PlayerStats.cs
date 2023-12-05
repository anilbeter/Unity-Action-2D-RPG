using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "Player Stats")]
public class PlayerStats : ScriptableObject
{
    [Header("Config")]
    public int Level;

    [Header("Health")]
    public float health;
    public float maxHealth;

    [Header("Mana")]
    public float mana;
    public float maxMana;

    public void ResetPlayer()
    {
        health = maxHealth;
        mana = maxMana;
    }
}
