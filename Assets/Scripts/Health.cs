using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    int maxHealth = 100;
    int currentHealth;
    public GameObject healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar = GameObject.Find("Canvas").transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
        healthBar.GetComponent<HealthBar>().SetHealthBarValue(currentHealth);
        if(currentHealth <=0)
        {
            Destroy(this.gameObject);
        }
    }

    public void Die()
    {
      
    }
}
