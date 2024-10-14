using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterBattle : MonoBehaviour
{

    public string name = "";
    public int currentHealth;
    public int maxHealth = 100;

    public Card[] deck;
    public bool isStunned = false;






    public void Start()
    {
        currentHealth = maxHealth;
        // state = State.waitingForPlayer;
    }

    public void takeDamage(int damage)
    {
        currentHealth -= damage;

    }





}
