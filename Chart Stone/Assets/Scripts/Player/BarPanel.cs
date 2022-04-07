using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BarPanel : MonoBehaviour
{

    public Image electric;
    public Image healthBar;
    public Text txt;
    public float energy = 0;
    private float maxEnergy = 100;

    public float health;
    private float maxHealth = 100;

    public static BarPanel instance;
    //public GameObject introduction;
    void Start()
    {
        instance = this;
       // InvokeRepeating("updateFoodHealth", 1.0f, 2f);
       

    }
    void Update()
    {
        float radio = energy / maxEnergy;
        electric.rectTransform.localScale = new Vector3(radio, 1, 1);

        float radioHeath = health / maxHealth;
        healthBar.rectTransform.localScale = new Vector3(radioHeath, 1, 1);
        txt.text = (radioHeath * 100) + " % ";

    }
    void updateFoodHealth()
    {
        if (energy < 100)
        {
            energy += 1f;
        }
    }
    public void startGame()
    {
        // introduction.SetActive(false);

    }
    public void RecoverEnergy()
    {
        energy += 100;
        if (energy >= maxEnergy)
        {
            energy = maxEnergy;
        }
    }

    public void UpdateLives(int HP)
    {
        health = HP;
    }
}
