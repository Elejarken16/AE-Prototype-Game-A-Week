using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth singleton;
    public float currentHealth;
    public float maxHealth = 100f;
    public Slider healthSlider;
    public Text healthCounter;
    public bool isDead = false;
    

    private void Awake()
    {
        singleton = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthSlider.value = maxHealth;
        UpdateHealthCounter();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth < 0)
        {
            currentHealth = 0;
        }
    }

    public void PlayerDamage(float damage)
    {
        if(currentHealth > 0)
        {
            if (damage >= currentHealth)
            {
                Dead();
            }
            else
            {
                currentHealth -= damage;
                healthSlider.value -= damage;
            }
            UpdateHealthCounter();
        }
    }

    void Dead()
    {
        currentHealth = 0;
        isDead = true;
        healthSlider.value = 0;
        UpdateHealthCounter();
        Debug.Log("player is dead");
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }

    

    void UpdateHealthCounter()
    {
        healthCounter.text = currentHealth.ToString();
    }
}
