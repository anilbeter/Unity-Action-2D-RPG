using UnityEngine;

public class PlayerMana : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private PlayerStats stats;

    public void UseMana(float amount)
    {
        stats.mana = Mathf.Max(stats.mana -= amount, 0f);
    }
}