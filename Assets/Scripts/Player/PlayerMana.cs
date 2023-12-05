using UnityEngine;

public class PlayerMana : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private PlayerStats stats;

    public void UseMana(float amount)
    {
        /*
        if (stats.mana >= amount)
        {
            stats.mana -= amount;
            if (stats.mana <= 0f)
            {
                stats.mana = 0f;
            }
        }
        */

        // Shorter way:
        stats.mana = Mathf.Max(stats.mana -= amount, 0f); // 2 değer girdim, büyük olanı vericek
    }
}