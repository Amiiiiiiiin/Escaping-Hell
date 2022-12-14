using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDrop : PowerUp
{
    [Range(0,100)]
    public int PercentHealth;

    private new void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Player player = collision.GetComponent<Player>();
            //if this is ever null, i will stab a bitch
            if (player != null)
            {
                player.Heal(Mathf.CeilToInt(player.MaxHealth/(PercentHealth * 1f)));
            }
            Destroy(gameObject);
        }
    }
}
