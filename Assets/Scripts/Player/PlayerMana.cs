using UnityEngine;

public class PlayerMana : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private PlayerStats stats;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            UseMana(5f);
        }
    }

    public void UseMana(float amount)
    {
        stats.mana = Mathf.Max(stats.mana -= amount, 0f);
    }
}