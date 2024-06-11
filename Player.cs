using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //The variables

    private int coins = 0;
    public int health = 10;
    public AudioSource audioSource;
    public AudioClip collectSound;

    public GameObject fireballPrefab;
    public Transform attackPoint;

    public void CollectCoin()
    {
       //Increases the value of the variable that stores the number of coins

        coins++;

      //Playing the sound of collecting the coin

        audioSource.PlayOneShot(collectSound);

        //Print the number of coins collected

        print("Coins Collected: " + coins);
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
    /*public class Player : MonoBehaviour
{
    private int health = 10;

    private int coins = 0;

    public AudioSource audioSource;
    public AudioClip collectSound;

    //The Fireball prefab and the Transform parameter of the attack point
    public GameObject fireballPrefab;
    public Transform attackPoint;

    //A method that lowers the player's health
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Player's health: " + health);
    }


    public void CollectCoins()
    {
        // Increase our variable that counts the number of coins we've collected so far
        // (the "coins" variable at the top)
        coins++;

        // Playing the sound of collecting a coin
        audioSource.PlayOneShot(collectSound);

        // Display the number of collected coins in the console
        print("Coins collected:" + coins);
    }
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
} */

}
