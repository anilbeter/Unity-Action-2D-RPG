using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExperience : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private PlayerStats stats;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            AddExperience(300f);
        } 
    }
    public void AddExperience(float amount)
    {
        stats.currentExp += amount;
        while (stats.currentExp >= stats.nextLevelExp)
        {
            stats.currentExp -= stats.nextLevelExp;
            NextLevel();
        }
    }

    private void NextLevel()
    {
        stats.Level++;
        float currentExpRequired = stats.nextLevelExp;
        float newNextLevelExp = Mathf.Round(currentExpRequired + stats.nextLevelExp * (stats.expMultiplier / 100f));
        stats.nextLevelExp = newNextLevelExp;
    }
}
