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
    [Header("EXP")]
    public float currentExp;
    public float nextLevelExp;
    public float initialNextLevelExp;
    [Range(1f, 100f)] public float expMultiplier;

    public void ResetPlayer()
    {
        health = maxHealth;
        mana = maxMana;
        Level = 1;
        currentExp = 0;
        nextLevelExp = initialNextLevelExp;
    }
}
